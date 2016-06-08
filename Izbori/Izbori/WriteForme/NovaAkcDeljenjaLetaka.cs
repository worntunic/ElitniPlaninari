using Izbori.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izbori.WriteForme
{
    public partial class NovaAkcDeljenjaLetaka : Form
    {
        public NovaAkcDeljenjaLetaka()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddLokacija_Click(object sender, EventArgs e)
        {
            if (!cbLokacija.Text.Length.Equals(0))
            {
                cbLokacija.Items.Add(cbLokacija.Text);
                cbLokacija.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemoveLokacija_Click(object sender, EventArgs e)
        {
            cbLokacija.Items.Remove(cbLokacija.SelectedItem);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();

            try
            {
                ses.Transaction.Begin();

                var akc = new DeljenjeLetaka()
                {
                    Grad = tbGrad.Text,
                    NazivAkcije = tbNazivAkcije.Text
                };
                ses.Save(akc);

                foreach (string x in cbLokacija.Items)
                {
                    var lok = new LokacijaDeljenjaLetaka()
                    {
                        DeljenjeLetaka = akc,
                        Lokacija = x
                    };
                    ses.Save(lok);
                }

                ses.Transaction.Commit();

                MessageBox.Show("Akcija deljenja letaka je uspešno sačuvana!", "Uspeh");
            }
            catch (Exception ec)
            {
                ses.Transaction.Rollback();
                MessageBox.Show(ec.Message);
            }
            finally
            {
                ses.Close();
            }
        }
    }
}
