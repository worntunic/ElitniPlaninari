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
using NHibernate;
using System.Media;

namespace Izbori.WriteForme
{
    public partial class NoviAktivista : Form
    {
        public NoviAktivista()
        {
            InitializeComponent();
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

                var akt = new Aktivista
                {
                    Ime = tbIme.Text,
                    ImeRod = tbImeRoditelja.Text,
                    Prezime = tbPrezime.Text,
                    Ulica = tbUlica.Text,
                    Broj = int.Parse(tbBroj.Text),
                    Grad = tbGrad.Text
                };

                ses.Save(akt);
                foreach (string x in cbEmail.Items)
                {
                    var email = new EMailAktiviste()
                    {
                        eMail = x,
                        Akt = akt
                    };
                    ses.Save(email);
                }

                foreach (string x in cbTelefon.Items)
                {
                    var telefon = new BrTel()
                    {
                        Aktivista = akt,
                        BrojTel = x
                    };
                    ses.Save(telefon);
                }

                ses.Transaction.Commit();

                MessageBox.Show("Aktivista uspešno sačuvan!", "Uspeh!");
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

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            if (!cbEmail.Text.Length.Equals(0))
            {
                cbEmail.Items.Add(cbEmail.Text);
                cbEmail.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemoveEmail_Click(object sender, EventArgs e)
        {
            cbEmail.Items.Remove(cbEmail.SelectedItem);
        }

        private void btnAddTelefon_Click(object sender, EventArgs e)
        {
            if (!cbTelefon.Text.Length.Equals(0))
            {
                cbTelefon.Items.Add(cbTelefon.Text);
                cbTelefon.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemoveTelefon_Click(object sender, EventArgs e)
        {
            cbTelefon.Items.Remove(cbTelefon.SelectedItem);
        }

        private void tbBroj_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }
    }
}
