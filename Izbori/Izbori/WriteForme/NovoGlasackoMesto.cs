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

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();

            if(tbNaziv.Text == "")
            {
                MessageBox.Show("Morate uneti barem naziv glasačkog mesta!", "Greška");
            } else
            {
                try
                {
                    var glm = new GlasackoMesto();
                    glm.Naziv = tbNaziv.Text;
                    if (tbBrojRegBir.Text != "")
                    {
                        glm.BrojRegBir = int.Parse(tbBrojRegBir.Text);
                    }
                    else
                    {
                        glm.BrojRegBir = 0;
                    }
                    if (tbBrojGM.Text != "")
                    {
                        glm.BrojGM = int.Parse(tbBrojGM.Text);
                    }
                    else
                    {
                        glm.BrojGM = 0;
                    }

                    ses.SaveOrUpdate(glm);
                    ses.Flush();

                    ((Form1)Owner).oGM = glm;
                    ((Form1)Owner).gmesta.Add(glm);                                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ses.Close();
                    this.Close();
                }

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
