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
    public partial class NovoGlasackoMesto : Form
    {
        public NovoGlasackoMesto()
        {
            InitializeComponent();
        }       

        private void tbBrojGM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var r = new Random();
            tbBrojGM.Text = r.Next(22222, 1222222).ToString();
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

                var glm = new GlasackoMesto
                {
                    Naziv = tbNaziv.Text,
                    BrojRegBir = int.Parse(tbBrojRegBir.Text),
                    BrojGM = int.Parse(tbBrojGM.Text)
                };

                ses.SaveOrUpdate(glm);

                ses.Flush();

                ses.Transaction.Commit();

                MessageBox.Show("Glasačko mesto uspešno sačuvano!", "Uspeh!");
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

        private void tbBrojRegBir_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }
    }
}
