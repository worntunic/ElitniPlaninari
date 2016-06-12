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
using Izbori.WriteForme.PomocneForme;
using NHibernate;

namespace Izbori.WriteForme
{
    public partial class NovaAkcMitinga : Form
    {
        private List<Gost> listaGostiju;

        public NovaAkcMitinga()
        {
            InitializeComponent();
            listaGostiju = new List<Gost>();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            if (cbJelZatvoren.CheckState == CheckState.Checked)
            {
                label4.Visible = true;
                label5.Visible = true;
                tbCenaZakupa.Visible = true;
                tbNazivIznajmljivaca.Visible = true;
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
                tbCenaZakupa.Visible = false;
                tbNazivIznajmljivaca.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCenaZakupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void btnAddLokacija_Click(object sender, EventArgs e)
        {
            var form = new DodajGosta();            
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                listaGostiju.Add(form.RetValGost);
                cbGosti.Items.Add(form.RetValGost.Ime + " " + form.RetValGost.Prezime);

                MessageBox.Show("Gost uspešno dodat!", "Uspeh!");
            }
        }

        private void btnRemoveLokacija_Click(object sender, EventArgs e)
        {//najverovatnije moze mnogo lakse
            string x = cbGosti.SelectedItem.ToString();
            int counter = 0;
            foreach (Gost temp in listaGostiju)
            {
                if (temp.Ime == x)
                    listaGostiju.RemoveAt(counter);
                ++counter;
            }
            cbGosti.Items.Remove(cbGosti.SelectedItem);
            cbGosti.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();
            try
            {
                ses.Transaction.Begin();
                Miting akc;
                if (cbJelZatvoren.Enabled)
                {
                    akc = new Miting()
                    {
                        NazivAkcije = tbNazivAkcije.Text,
                        Lokacija = tbLokacija.Text,
                        Grad = tbGrad.Text
                    };
                    ses.Save(akc);
                }
                else
                {
                    akc = new MitingZatvoreniP()
                    {
                        NazivAkcije = tbNazivAkcije.Text,
                        Lokacija = tbLokacija.Text,
                        Grad = tbGrad.Text,
                        Cena = int.Parse(tbCenaZakupa.Text),
                        NazivIznajmljivaca = tbNazivIznajmljivaca.Text
                    };
                    ses.Save(akc);
                }

                foreach (Gost x in listaGostiju)
                {
                    x.Miting = akc;
                    ses.Save(x);
                }

                ses.Transaction.Commit();
                MessageBox.Show("Akcija mitinga je uspešno sačuvana!", "Uspeh");
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
