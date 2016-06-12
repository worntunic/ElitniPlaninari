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
    public partial class NoviGostNaMitingu : Form
    {
        private IList<Miting> listaMitinga;

        private List<Gost> listaGostiju;

        public NoviGostNaMitingu()
        {
            InitializeComponent();

            listaMitinga = new List<Miting>();
            listaGostiju = new List<Gost>();

            ISession ses = DataLayer.GetSession();
            try
            {
                listaMitinga = ses.QueryOver<Miting>().List();
                foreach (Miting x in listaMitinga)
                {
                    cbMitinzi.Items.Add(x.NazivAkcije);
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

        private void btnAddGost_Click(object sender, EventArgs e)
        {
            var form = new DodajGosta();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                listaGostiju.Add(form.RetValGost);
                cbGosti.Items.Add(form.RetValGost.Ime + " " + form.RetValGost.Prezime);

                MessageBox.Show("Gost uspešno dodat!", "Uspeh!");
            }
        }

        private void btnRemoveGost_Click(object sender, EventArgs e)
        {
            //najverovatnije moze mnogo bolje
            string x = cbGosti.SelectedItem.ToString();
            int counter = 0;
            foreach (Gost temp in listaGostiju)
            {
                if (temp.Ime == x)
                    listaGostiju.RemoveAt(counter);
                ++counter;
            }
            cbGosti.Items.Remove(cbGosti.SelectedItem);
            cbGosti.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();
            try
            {
                ses.Transaction.Begin();

                var mit = getMiting(cbMitinzi.SelectedItem.ToString());

                foreach (Gost x in listaGostiju)
                {
                    x.Miting = mit;
                    ses.Save(x);
                }

                ses.Transaction.Commit();
                MessageBox.Show("Gosti su uspešno sačuvana!", "Uspeh");
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

        protected Miting getMiting(string nazAkc)
        {
            var returner = new Miting();
            IList<Miting> temp = new List<Miting>();

            ISession ses = DataLayer.GetSession();
            try
            {
                temp = ses.QueryOver<Miting>().Where(x => x.NazivAkcije == nazAkc).List();
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
