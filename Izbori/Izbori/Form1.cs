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

                LokacijaDeljenjaLetaka ldl1 = new LokacijaDeljenjaLetaka();
                ldl1.DeljenjeLetaka = dl;
                ldl1.Lokacija = "Pašnjačka";
                s.Save(ldl1);

                LokacijaDeljenjaLetaka ldl2 = new LokacijaDeljenjaLetaka();
                ldl2.DeljenjeLetaka = dl;
                ldl2.Lokacija = "Tamnog Vilajeta";
                s.Save(ldl2);
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
            try {
                ISession s = DataLayer.GetSession();

                Miting mit = new Miting();

                mit.NazivAkcije = "Karma policija";
                mit.Grad = "Vavilon";
                mit.Lokacija = "Baš kod kule";
                s.Save(mit);

                Gost gost1 = new Gost();
                gost1.Ime = "Deus";
                gost1.Prezime = "Ex Machina";
                gost1.Titula = "Lord";
                gost1.Funkcija = "Izvršitelj";
                gost1.Miting = mit;
                s.Save(gost1);

                Gost gost2 = new Gost();
                gost2.Ime = "Plameni";
                gost2.Prezime = "Jezik";
                gost2.Titula = "Grešnik";
                gost2.Funkcija = "Ponizni";
                gost2.Miting = mit;
                s.Save(gost2);

                s.Close();

            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }

        private void RezIzbBtn_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();
                RezultatiIzbora ri = s.Load<RezultatiIzbora>(4);
                string info = "";
                info += "Na izbore odrzane na glasackom mestu " + ri.GlasackoMesto.Naziv
                    + ", u " + ri.BrKruga + ". krugu, izaslo je " + ri.BrBiraca + 
                    " biraca od ukupno " + ri.GlasackoMesto.BrojRegBir + " registrovanih, od cega je " 
                    + ri.ProcenatZaKandidata + "% glasalo za naseg kandidata.";
                MessageBox.Show(info, "Glasacko mesto " + ri.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowActv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Aktivista akt = s.Load<Aktivista>(18);

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

                info += "\nAkcije: ";
                for(int i = 0; i< akt.Akcije.Count; i++)
                {
                    info += akt.Akcije[i].NazivAkcije + "\n";
                }
                info += "\nPrimedbe: ";
                for(int i = 0; i < akt.Primedbe.Count; i++)
                {
                    info += "Aktivista je angazovan na " + akt.gm.Naziv;
                    if(akt.Primedbe[i].TekstPrim != null)
                    {
                        info += "\nImao je sledece primedbe: " + akt.Primedbe[i].TekstPrim;
                    }else
                    {
                        info += "\nNije imao primedbe.";
                    }
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
                int id = 0;
                bool notHelper = false;
                bool notKoord = false;
                Aktivista akt = null;
                do
                {
                    id++;
                    akt = s.Load<Aktivista>(id);
                    notHelper = akt.koord == null;
                    notKoord = s.QueryOver<Koordinator>().Where(x => x.ID == akt.ID).RowCount() == 0;
                } while (!notHelper || !notKoord);

                if (notKoord && notHelper)
                {
                    Koordinator koord = new Koordinator();

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
                else if (notHelper)
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

        private void GostMitBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                Miting mit = s.Load<Miting>(26);

                string info = "";
                info += "Miting je održan na lokaciji : \" " + mit.Grad + "\". \n";
                if(mit.Gosti.Count > 0) {
                    info += "\n Od gostiju prisustvovali su:\n";
                }
                else {
                    info += "Nije zabelezen nijedan gost :(.\n";
                }
                for (int i = 0; i < mit.Gosti.Count; i++) {
                    info += mit.Gosti[i].Funkcija + " " + mit.Gosti[i].Titula + " "
                        + mit.Gosti[i].Ime + " " + mit.Gosti[i].Prezime + "\n";
                }

                MessageBox.Show(info, "Miting sa ID " + mit.ID.ToString());

                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                Miting mit = s.Load<Miting>(26);

                string info = "";
                info += "Miting je održan na lokaciji : \" " + mit.Grad + "\". \n";
                /*if(mit.Gosti.Count > 0) {
                    info += "\n Od gostiju prisustvovali su:\n";
                }
                else {
                    info += "Nije zabelezen nijedan gost :(.\n";
                }
                for (int i = 0; i < mit.Gosti.Count; i++) {
                    info += mit.Gosti[i].Funkcija + " " + mit.Gosti[i].Titula + " "
                        + mit.Gosti[i].Ime + " " + mit.Gosti[i].Prezime + "\n";
                }*/

                MessageBox.Show(info, "Miting sa ID " + mit.ID.ToString());

                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                Miting mit = s.Load<Miting>(26);
                string info = "";
                if (mit.Gosti.Count <= 0) {
                    info += "Nije zabelezen nijedan gost :(.\n";
                } else {
                    for (int i = 0; i < mit.Gosti.Count; i++) {
                        info += mit.Gosti[i].Funkcija + " " + mit.Gosti[i].Titula + " "
                            + mit.Gosti[i].Ime + " " + mit.Gosti[i].Prezime + "\n";
                    }
                }
                
                MessageBox.Show(info, "Miting sa ID " + mit.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                DeljenjeLetaka dl = s.Load<DeljenjeLetaka>(17);
                string info = "";
                info += "Deljenje Letaka " + dl.NazivAkcije + " u gradu " + dl.Grad;
                MessageBox.Show(info, "Deljenje letaka " + dl.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                SusretKandidata sk = s.Load<SusretKandidata>(20);
                string info = "";
                info += "Susret Kandidata " + sk.NazivAkcije + " u gradu " + sk.Grad;
                info += "\n Pocinje u " + sk.PlaniranoVreme + " na lokaciji " + sk.Lokacija;
                MessageBox.Show(info, "Deljenje letaka " + sk.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                GlasackoMesto gm = s.Load<GlasackoMesto>(3);
                string info = "";
                info += "Glasacko Mesto: " + gm.Naziv + "\n sa rednim brojem " + gm.BrojGM
                    + "\n obuhvata " + gm.BrojRegBir + " registrovanih glasaca.";
                MessageBox.Show(info, "Glasacko mesto " + gm.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void GlasackoMestoBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                GlasackoMesto gm = new GlasackoMesto();

                gm.Naziv = "Osnovna Škola Ivan Goran Kovačić Niška Banja";
                gm.BrojRegBir = 4800;
                gm.BrojGM = 152;
                s.Save(gm);

                /*RezultatiIzbora ri = new RezultatiIzbora();
                ri.BrBiraca = 2200;
                ri.BrKruga = 1;
                ri.GlasackoMesto = gm;
                ri.ProcenatZaKandidata = 12;
                s.Save(ri);*/
                              

                s.Close();

                MessageBox.Show("Uspesno sacuvan");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                GlasackoMesto gm = s.Load<GlasackoMesto>(151);

                RezultatiIzbora ri = new RezultatiIzbora();
                ri.BrBiraca = 2200;
                ri.BrKruga = 1;
                ri.GlasackoMesto = gm;
                ri.ProcenatZaKandidata = 12;
                s.Save(ri);


                s.Close();

                MessageBox.Show("Uspesno sacuvan");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void AngAktnaGMBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                GlasackoMesto gm = s.Load<GlasackoMesto>(151);
                Aktivista akt = s.Load<Aktivista>(62);
                Primedbe pr = new Primedbe();
                pr.Aktivista = akt;
                pr.GlasackoMesto = gm;
                pr.TekstPrim = " ";
                s.Save(pr);


                s.Close();

                MessageBox.Show("Uspesno sacuvan");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNote_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                GlasackoMesto gm = s.Load<GlasackoMesto>(2);
                Aktivista akt = s.Load<Aktivista>(20);
                Primedbe pr = new Primedbe();
                pr.Aktivista = akt;
                pr.GlasackoMesto = gm;
                pr.TekstPrim = "Posluženje je bilo skromno";
                s.Save(pr);


                s.Close();

                MessageBox.Show("Uspesno sacuvan");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void AkcijaAktivistiBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                Aktivista akt = s.Load<Aktivista>(2);

                DeljenjeLetaka dl = new DeljenjeLetaka();
                dl.Aktiviste.Add(akt);
                akt.Akcije.Add(dl);
                dl.Grad = "Prosek";
                dl.NazivAkcije = "Natprosečno prosečni";
                s.Save(dl);

                LokacijaDeljenjaLetaka ldl1 = new LokacijaDeljenjaLetaka();
                ldl1.DeljenjeLetaka = dl;
                ldl1.Lokacija = "Kod reke";
                s.Save(ldl1);

                LokacijaDeljenjaLetaka ldl2 = new LokacijaDeljenjaLetaka();
                ldl2.DeljenjeLetaka = dl;
                ldl2.Lokacija = "Na mostu";
                s.Save(ldl2);

                s.SaveOrUpdate(akt);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno sacuvan");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
