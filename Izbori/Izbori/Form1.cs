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
using Izbori.Entiteti;

namespace Izbori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //komentar
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AkcDeljLetBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                DeljenjeLetaka dl = new DeljenjeLetaka();


                dl.NazivAkcije = "Posejimo ulice";
                dl.Grad = "Kruševac";
                s.Save(dl);

                s.Close();

            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }

        private void AkcSusKand_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();


                SusretKandidata sk = new SusretKandidata();


                sk.NazivAkcije = "U susret budućnosti";
                sk.Grad = "Jagodina";
                sk.Lokacija = "Boks Klub Jagodinski Tigrovi";
                sk.PlaniranoVreme = new DateTime(2016, 5, 1, 18, 30, 0);

                s.Save(sk);

                s.Close();

            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }

        private void AkcMitBtn_Click(object sender, EventArgs e) {

        }

        private void RezIzbBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShowActv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Aktivista akt = s.Load<Aktivista>(2);

                string info =
                    "Licni podaci: " + akt.Ime + " " + akt.ImeRod + " " + akt.Prezime +
                    "\nAdresa: " + akt.Ulica + " " + akt.Broj + " " + akt.Grad +
                    "\nEmail: ";
                for(int i = 0; i < akt.email.Count; i++)
                {
                    info += akt.email[i].eMail + " ";
                }
                info += "\nBrojevi telefona: ";
                for(int i = 0; i < akt.brTel.Count; i++)
                {
                    info += akt.brTel[i].BrojTel + " ";
                }
                info += "\nNadredjeni aktivisti: " + akt.koord.Ime + " " + akt.koord.Prezime;

                MessageBox.Show(info, "Aktivista sa ID " + akt.ID);
                s.Close();
            }
            catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
