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
    public partial class NovaAkcSusretaKandidata : Form
    {
        public NovaAkcSusretaKandidata()
        {
            InitializeComponent();
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

                var akc = new SusretKandidata
                {
                    Grad = tbGrad.Text,
                    Lokacija = tbLokacija.Text,
                    NazivAkcije = tbNazivAkcije.Text,
                    PlaniranoVreme = new DateTime(dateTimePlaniranoVreme.Value.Ticks)
                };

                ses.SaveOrUpdate(akc);

                ses.Transaction.Commit();

                MessageBox.Show("Akcija dodavanja susreta kandidata je sačuvana!","Uspeh!");
            }
            catch (Exception ec)
            {
                ses.Transaction.Rollback();
                MessageBox.Show(ec.Message);
            }
            finally
            {
                ses.Close();
            }
        }
    }
}
