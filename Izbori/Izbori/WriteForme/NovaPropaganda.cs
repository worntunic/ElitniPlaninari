using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Izbori.Entiteti;

namespace Izbori.WriteForme {
    public partial class NovaPropaganda : Form {
        public NovaPropaganda() {
            InitializeComponent();
        }
        public int loadedID;
        public Type rekType;
        private void button1_Click(object sender, EventArgs e) {
            ISession ses = DataLayer.GetSession();
            Reklama rek = null;
            try {
                ses.Transaction.Begin();

                if (propRBNovine.Checked) {
                    rek = new NovineReklama();
                    rekType = typeof(NovineReklama); 
                } else if (propRBPano.Checked) {
                    rek = new PanoReklama();
                    rekType = typeof(PanoReklama);
                } else if (propRBTVRad.Checked) {
                    rek = new TVRadioReklama();
                    rekType = typeof(TVRadioReklama);
                }
                rek.CenaZakupa = Convert.ToInt32(propTxtCenaZakupa.Text);
                rek.DatumZakupa = propClndDatumZakupa.SelectionStart;
                rek.TrajanjeZakupa = Convert.ToInt32(propTxtTrajanjeZakupa.Text);
                ses.Save(rek);
                ses.Transaction.Commit();
                MessageBox.Show("Propaganda uspešno sačuvana!", "Uspeh!");
            } catch (Exception ex) {
                ses.Transaction.Rollback();
                MessageBox.Show(ex.Message);
            } finally {
                ses.Close();
                loadedID = rek.ID;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void propRBNovine_CheckedChanged(object sender, EventArgs e) {
            allowCreationOfPropaganda();
        }

        private void propRBPano_CheckedChanged(object sender, EventArgs e) {
            allowCreationOfPropaganda();
        }

        private void propRBTVRad_CheckedChanged(object sender, EventArgs e) {
            allowCreationOfPropaganda();
        }

        private void propTxtCenaZakupa_TextChanged(object sender, EventArgs e) {
            allowCreationOfPropaganda();
        }

        private void propClndDatumZakupa_DateChanged(object sender, DateRangeEventArgs e) {
            allowCreationOfPropaganda();
            propTxtTrajanjeZakupa.Text = (propClndDatumZakupa.SelectionEnd - propClndDatumZakupa.SelectionStart).Days.ToString();
        }

        private void propTxtTrajanjeZakupa_TextChanged(object sender, EventArgs e) {
            allowCreationOfPropaganda();
            int broj;
            if (int.TryParse(((TextBox)sender).Text, out broj)) {
                propClndDatumZakupa.SelectionRange = new SelectionRange(
                                                        propClndDatumZakupa.SelectionStart,
                                                        propClndDatumZakupa.SelectionStart.AddDays(broj));
            }
        }
        public void allowCreationOfPropaganda() {
            int tmp;
            button1.Enabled = ((propRBNovine.Checked || propRBPano.Checked || propRBTVRad.Checked)
                && int.TryParse(propTxtCenaZakupa.Text, out tmp) && int.TryParse(propTxtTrajanjeZakupa.Text, out tmp)
                && propClndDatumZakupa.SelectionStart != null);
        }
    }
}
