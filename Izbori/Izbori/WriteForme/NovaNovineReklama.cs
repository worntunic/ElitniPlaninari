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
    public partial class NovaNovineReklama : Form
    {
        public NovaNovineReklama()
        {
            InitializeComponent();
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
                NovineReklama reklama = new NovineReklama()
                {
                    NazivLista = tbNazivLista.Text,
                    CenaZakupa = int.Parse(tbCenaZakupa.Text),
                    TrajanjeZakupa = int.Parse(tbTrajanjeZakupa.Text),
                    DatumZakupa = dateTimeZakupa.Value.Date,
                    Uboji = (cbUBoji.Enabled) ? 1 : 0
                };
                ses.SaveOrUpdate(reklama);
                ses.Flush();

                ses.Transaction.Commit();
                MessageBox.Show("Uspesno Sačuvana Reklama u Novinama!");
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
