using Izbori.Entiteti;
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

namespace Izbori.WriteForme
{
    public partial class NovaPanoReklama : Form
    {
        public NovaPanoReklama()
        {
            InitializeComponent();
        }

        private void tbTrajanjeZakupa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbPovrsina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.')
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
                var reklama = new PanoReklama()
                {
                    Grad = tbGrad.Text,
                    Povrsina = double.Parse(tbPovrsina.Text),
                    Ulica = tbUlica.Text,
                    Vlasnik = tbVlasnik.Text,
                    CenaZakupa = int.Parse(tbCenaZakupa.Text),
                    TrajanjeZakupa = int.Parse(tbTrajanjeZakupa.Text),
                    DatumZakupa = dateTimeZakupa.Value.Date
                };
                ses.SaveOrUpdate(reklama);
                ses.Flush();

                ses.Transaction.Commit();
                MessageBox.Show("Uspesno sačuvana reklama na panou!", "Uspeh!");
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
