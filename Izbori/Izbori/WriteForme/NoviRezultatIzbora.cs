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
        private IList<GlasackoMesto> listaGlasackihMesta;

        public NoviRezultatIzbora()
        {
            InitializeComponent();
            listaGlasackihMesta = new List<GlasackoMesto>();
            ISession ses = DataLayer.GetSession();
            try
            {
                listaGlasackihMesta = ses.QueryOver<GlasackoMesto>().List();
                foreach (GlasackoMesto x in listaGlasackihMesta)
                {
                    cbGlasackaMesta.Items.Add(x.Naziv);
                }
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
            ISession ses = DataLayer.GetSession();
            try
            {
                ses.Transaction.Begin();

                var ri = new RezultatiIzbora()
                {
                    ProcenatZaKandidata = int.Parse(tbProcenatZaKandidata.Text),
                    BrBiraca = int.Parse(tbBrojBiraca.Text),
                    BrKruga = int.Parse(tbBrojKruga.Text),
                    GlasackoMesto = getGm(cbGlasackaMesta.SelectedItem.ToString())
                };

                ses.SaveOrUpdate(ri);

                ses.Transaction.Commit();

                MessageBox.Show("Rezulati izbora uspešno sačuvani!","Uspeh!");
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

        private GlasackoMesto getGm(string gm)
        {
            listaGlasackihMesta = new List<GlasackoMesto>();
            ISession ses = DataLayer.GetSession();
            var returner = new GlasackoMesto();
            IList<GlasackoMesto> temp = new List<GlasackoMesto>();
            try
            {
                temp = ses.QueryOver<GlasackoMesto>().Where(x => x.Naziv == gm).List();
                returner = temp[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ses.Close();
            }
            return returner;
        }
    }
}