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

namespace Izbori.WriteForme
{
    public partial class NovaTVRadioReklama : Form
    {
        public NovaTVRadioReklama()
        {
            InitializeComponent();
        }

        private void tbBrojPonavljanja_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void tbTrajanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void tbCenaZakupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void tbTrajanjeZakupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
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
                var reklama = new TVRadioReklama()
                {
                    NazivStanice = tbNazivStanice.Text,
                    BrojPonavljanja = int.Parse(tbBrojPonavljanja.Text),
                    CenaZakupa = int.Parse(tbCenaZakupa.Text), //zasto cenu cuvamo kao int? xD
                    Trajanje = int.Parse(tbTrajanje.Text),
                    TrajanjeZakupa = int.Parse(tbTrajanjeZakupa.Text),
                    DatumZakupa = dateTimeZakupa.Value.Date
                };

                ses.SaveOrUpdate(reklama);

                ses.Flush();

                ses.Transaction.Commit();
                MessageBox.Show("TV/Radio reklama uspešno sačuvana!", "Uspeh!");
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
