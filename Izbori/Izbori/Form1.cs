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

                Aktivista akt = s.Load<Aktivista>(1);

                string info =
                    "Licni podaci: " + akt.Ime + " " + akt.ImeRod + " " + akt.Prezime +
                    "\nAdresa: " + akt.Ulica + " " + akt.Broj + " " + akt.Grad +
                    "\nEmail: ";
                for(int i = 0; i < akt.email.Count; i++)
                {
                    info += akt.email[i].eMail + "\n";
                }
                info += "\nBrojevi telefona: ";
                for(int i = 0; i < akt.brTel.Count; i++)
                {
                    info += akt.brTel[i].BrojTel + "\n";
                }

                if (akt.koord != null)
                {
                    info += "\nNadredjeni aktivisti: " + akt.koord.Ime + " " + akt.koord.Prezime;
                }

                MessageBox.Show(info, "Aktivista sa ID " + akt.ID);
                s.Close();
            }
            catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowCoord_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Koordinator koord = s.Load<Koordinator>(7);

                string info =
                    "Licni podaci: " + koord.Ime + " " + koord.ImeRod + " " + koord.Prezime +
                    "\nOpstina koordinisanje: " + koord.Opstina +
                    "\nAdresa kancelarije: " + koord.UlicaKanc + " " + koord.BrojKanc + " " + koord.GradKanc +
                    "\nPodredjeni: ";
                for(int i = 0; i < koord.Saradnici.Count; i++)
                {
                    info += koord.Saradnici[i].Ime + " " + koord.Saradnici[i].Prezime + "\n";
                }
                
                MessageBox.Show(info, "Koordinator sa ID " + koord.ID);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajAktivistuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Aktivista akt = new Aktivista();

                akt.Ime = "Petar";
                akt.ImeRod = "Dragan";
                akt.Prezime = "Petrović";
                akt.Ulica = "Draže Petrovića";
                akt.Broj = 42;
                akt.Grad = "Beograd";

                s.Save(akt);

                EMailAktiviste email = new EMailAktiviste();
                email.Akt = akt;
                email.eMail = "pera@petrovic.com";
                s.Save(email);

                email = new EMailAktiviste();
                email.Akt = akt;
                email.eMail = "pera2@petrovicdrugi.com";
                s.Save(email);

                BrTel brTel = new BrTel();
                brTel.Aktivista = akt;
                brTel.BrojTel = "011/232-23-21";
                s.Save(brTel);

                s.Close();

                MessageBox.Show("Uspesno sacuvan");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajKoordinatoraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                int id = 2;
                //kako izvrsiti proveru da li je lepo ucitan ili ne???

                Aktivista akt = s.Load<Aktivista>(id);
                Koordinator koord = s.Load<Koordinator>(id);
                
                //provera ne valja bas
                if(akt != null && akt.koord == null && koord == null)
                {
                    IQuery q = s.CreateSQLQuery("insert into koordinator values (?, ?, ?, ?, ?)");
                    q.SetParameter(0, akt.ID);
                    q.SetParameter(1, "Stari grad");
                    q.SetParameter(2, "Strahinića Bana");
                    q.SetParameter(3, 21);
                    q.SetParameter(4, "Beograd");
                    q.ExecuteUpdate();
                    
                    MessageBox.Show("Uspesno dodat koordinator.");

                    s.Close();
                }
                else if (akt.koord == null)
                {
                    MessageBox.Show("Ovaj aktivista je vec koordinator.");
                }
                else
                {
                    MessageBox.Show("Ovaj aktivista je vec podredjen nekom.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodeliPomocnikeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Koordinator koord = s.Load<Koordinator>(23);

                int brAktivista = s.QueryOver<Aktivista>().Where(x => x.koord == koord).RowCount();

                //samo test! dodaje prva 4 na koja naidje da moze
                for(int i = 1, j = 0; j < 4 - brAktivista; i++)
                {
                    Aktivista akt = s.Load<Aktivista>(i);
                    bool jeKoord = s.QueryOver<Koordinator>().Where(x => x.ID == i).RowCount() > 0;
                    
                    if(!jeKoord && akt.koord == null)
                    {
                        akt.koord = koord;
                        s.Save(akt);
                        j++;
                    }
                }
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
