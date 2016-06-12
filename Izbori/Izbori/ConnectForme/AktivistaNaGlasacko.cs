using Izbori.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izbori.ConnectForme
{
    public partial class AktivistaNaGlasacko : Form
    {
        private IList<GlasackoMesto> listaGlasackihMesta;
        private IList<Aktivista> listaAktivista; //slobodnih

        public AktivistaNaGlasacko()
        {
            InitializeComponent();
            listaGlasackihMesta = new List<GlasackoMesto>();
            listaAktivista = new List<Aktivista>();

            ISession ses = DataLayer.GetSession();

            try
            {
                listaAktivista = ses.QueryOver<Aktivista>().Where(x => x.gm == null).List();//nisam 100% siguran
                listaGlasackihMesta = ses.QueryOver<GlasackoMesto>().List();
                foreach (GlasackoMesto x in listaGlasackihMesta)
                {
                    cbGlasackoMesto.Items.Add(x.Naziv);
                }

                foreach (Aktivista x in listaAktivista)
                {
                    cbAktivista.Items.Add(x.Ime + ' ' + x.ImeRod + ' ' + x.Prezime);
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
                var akt = new Aktivista();
                akt = getAkt(cbAktivista.SelectedItem.ToString());

                akt.gm = getGm(cbGlasackoMesto.SelectedItem.ToString());

                ses.SaveOrUpdate(akt);

                ses.Transaction.Commit();

                MessageBox.Show("Aktivista je uspešno angažovan na ovo glasačko mesto!", "Uspeh!");
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
            var returner = new GlasackoMesto();
            IList<GlasackoMesto> temp = new List<GlasackoMesto>();

            ISession ses = DataLayer.GetSession();
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

        private Aktivista getAkt(string src)
        {
            string[] strArray = src.Split(' ');

            string aktIme = strArray[0];
            string aktImeRod = strArray[1];
            string aktPrezime = strArray[2];

            var returner = new Aktivista();
            IList<Aktivista> temp = new List<Aktivista>();

            ISession ses = DataLayer.GetSession();
            try
            {
                temp = ses.QueryOver<Aktivista>().Where(x => x.Ime == aktIme && x.ImeRod == aktImeRod && x.Prezime == aktPrezime).List();
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
