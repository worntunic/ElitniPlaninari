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
    public partial class NovoPojPKTVDuel : Form
    {
        public NovoPojPKTVDuel()
        {
            InitializeComponent();
        }

        private void tbGledanost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void btnAddProtivKandidat_Click(object sender, EventArgs e)
        {
            if (!cbProtivKandidati.Text.Length.Equals(0))
            {
                cbProtivKandidati.Items.Add(cbProtivKandidati.Text);
                cbProtivKandidati.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemoveProtivKandidat_Click(object sender, EventArgs e)
        {
            cbProtivKandidati.Items.Remove(cbProtivKandidati.SelectedItem);
        }

        private void btnAddPitanje_Click(object sender, EventArgs e)
        {
            if (!cbPitanja.Text.Length.Equals(0))
            {
                cbPitanja.Items.Add(cbPitanja.Text);
                cbPitanja.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemovePitanje_Click(object sender, EventArgs e)
        {
            cbPitanja.Items.Remove(cbPitanja.SelectedItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();

            try
            {
                ses.Transaction.Begin();

                var poj = new TVDuel
                {
                    NazivStanice = tbNazivStanice.Text,
                    NazivEmisije = tbNazivEmisije.Text,
                    ImeVoditelja = tbImeVoditelja.Text,
                    Gledanost = int.Parse(tbGledanost.Text)
                };

                ses.Save(poj);

                foreach (string x in cbPitanja.Items)
                {
                    var pitanje = new PitanjaTVDuel()
                    {
                        IDDuela = poj,
                        Tekst = x
                    };
                    ses.Save(pitanje);
                }

                foreach (string x in cbProtivKandidati.Items)
                {
                    var protivKandidat = new ProtivKandidatiTVDuel()
                    {
                        ImePK = x,
                        IDDuela = poj
                    };
                    ses.Save(protivKandidat);
                }

                ses.Flush();//Nisam siguran mozda i ne treba flush!

                ses.Transaction.Commit();

                MessageBox.Show("Pojavljivanje predsedničkog kandidata na TV-duelu je uspešno sačuvano!", "Uspeh!");
            }
            catch (Exception ex)
            {
                ses.Transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ses.Close();
            }
        }
    }
}
