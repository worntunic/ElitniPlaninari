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
        public TVDuel RetValPoj { get; set; }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                s.Transaction.Begin();

                RetValPoj = new TVDuel
                {
                    NazivStanice = tbNazivStanice.Text,
                    NazivEmisije = tbNazivEmisije.Text,
                    ImeVoditelja = tbImeVoditelja.Text,
                    Gledanost = int.Parse(tbGledanost.Text)
                };

                s.SaveOrUpdate(RetValPoj);

                s.Transaction.Commit();

                DialogResult = DialogResult.OK;

                MessageBox.Show("Pojavljivanje predsedničkog kandidata na TV-duelu je uspešno sačuvano!", "Uspeh!");
            }
            catch (Exception ex)
            {
                s.Transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }
    }
}
