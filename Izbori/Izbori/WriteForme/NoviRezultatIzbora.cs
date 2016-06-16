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
    public partial class NoviRezultatIzbora : Form
    {
        public NoviRezultatIzbora()
        {
            InitializeComponent();            
        }

        private void tbProcenatZaKandidata_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void tbBrojKruga_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch != '1' && ch != '2' && ch != 8 && ch != 46)//ako je maximum dva kruga
                e.Handled = true;
        }

        private void tbBrojBiraca_KeyPress(object sender, KeyPressEventArgs e)
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
            if(tbBrojBiraca.Text != "" 
                && tbBrojKruga.Text != "" 
                && tbProcenatZaKandidata.Text != "")
            {
                ISession ses = DataLayer.GetSession();
                try
                {
                    var ri = new RezultatiIzbora()
                    {
                        ProcenatZaKandidata = int.Parse(tbProcenatZaKandidata.Text),
                        BrBiraca = int.Parse(tbBrojBiraca.Text),
                        BrKruga = int.Parse(tbBrojKruga.Text),
                        GlasackoMesto = ((Form1)Owner).oGM
                    };
                    ses.SaveOrUpdate(ri);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ses.Close();
                }
            }
            else
            {
                MessageBox.Show("Morate uneti sve potrebne informacije za rezultate izbora.", "Greška!");
            }
        }
    }
}