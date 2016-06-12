using Izbori.Entiteti;
using Izbori.WriteForme.PomocneForme;
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
    public partial class NovaPrimedbaAktiviste : Form
    {
        private IList<Aktivista> listaAktivista; //koji su angazovani

        public NovaPrimedbaAktiviste()
        {
            InitializeComponent();
            
            listaAktivista = new List<Aktivista>();

            ISession ses = DataLayer.GetSession();
            try
            {
                listaAktivista = ses.QueryOver<Aktivista>().Where(x => x.gm != null).List();                
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
                
        private void btnAddPrimedba_Click(object sender, EventArgs e)
        {
            var form = new DodajTekstPrimedbe();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cbTextPrimedbe.Items.Add(form.RetValString);                
            }
        }

        private void btnRemovePrimedba_Click(object sender, EventArgs e)
        {
            cbTextPrimedbe.Items.Remove(cbTextPrimedbe.SelectedItem);
            cbTextPrimedbe.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();
            try
            {
                ses.Transaction.Begin();

                var akt = getAkt(cbAktivista.SelectedItem.ToString());

                foreach (string x in cbTextPrimedbe.Items)
                {
                    var pr = new Primedbe()
                    {
                        Aktivista = akt,
                        GlasackoMesto = akt.gm,
                        TekstPrim = x
                    };
                    ses.Update(pr);
                }                

                ses.Transaction.Commit();

                MessageBox.Show("Primedba/e uspešno dodata/e!", "Uspeh!");
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
