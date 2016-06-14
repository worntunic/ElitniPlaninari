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
using Izbori.WriteForme;
using Izbori.ConnectForme;
using System.Collections;
using System.Media;

namespace Izbori
{
    public partial class Form1 : Form
    {
        Aktivista odabrani;
        public Form1()
        {
            InitializeComponent();
            odabrani = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AkcDeljLetBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovaAkcDeljenjaLetaka();
            forma.Show();
        }

        private void AkcSusKand_Click(object sender, EventArgs e)
        {
            var forma = new NovaAkcSusretaKandidata();
            forma.Show();
        }

        private void AkcMitBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovaAkcMitinga();
            forma.Show();
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
            var forma = new NoviAktivista();
            forma.Show();            
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
                    ++id;
                    akt = s.Load<Aktivista>(id);
                    notHelper = akt.koord == null;
                    notKoord = s.QueryOver<Koordinator>().Where(x => x.ID == akt.ID).RowCount() == 0;
                }
                while (!notHelper || !notKoord);

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
                        ++j;
                    }
                }
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno sacuvani");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GostMitBtn_Click(object sender, EventArgs e)
        {
            var forma = new NoviGostNaMitingu();
            forma.Show();
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

        private void GlasackoMestoBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovoGlasackoMesto();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma = new NoviRezultatIzbora();
            forma.Show();
        }

        private void AngAktnaGMBtn_Click(object sender, EventArgs e)
        {
            var forma = new AktivistaNaGlasacko();
            forma.Show();
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            var forma = new NovaPrimedbaAktiviste();
            forma.Show();
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

        private void ReklTVRadioBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovaTVRadioReklama();
            forma.Show();
        }

        private void ShowReklTVRadioBtn_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                var reklama = s.Load<TVRadioReklama>(1);

                string info = "";
                info += "Na stanici: \"" + reklama.NazivStanice + "\""
                    + "\nBroj ponavljanja: " + reklama.BrojPonavljanja
                    + "\nTrajanje reklame: " + reklama.Trajanje + " sekundi"
                    + "\nCena Zakupa: " + reklama.CenaZakupa
                    + "\nDatum Zakupa" + reklama.DatumZakupa
                    + "\nTrajanje Zakupa" + reklama.TrajanjeZakupa + " dana.";

                MessageBox.Show(info, "TV/Radio Reklama: " + reklama.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void ReklNovineBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovaNovineReklama();
            forma.Show();
        }

        private void ShowReklNovineBtn_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                var reklama = s.Load<NovineReklama>(7);

                string info = "";
                info += "Na listu: \"" + reklama.NazivLista + "\"";
                if (reklama.Uboji == 1)
                    info += " koji je u boji";
                else
                    info += " koji nije u boji";
                info += "\nCena Zakupa: " + reklama.CenaZakupa
                + "\nDatum Zakupa" + reklama.DatumZakupa
                + "\nTrajanje Zakupa" + reklama.TrajanjeZakupa + " dana.";

                MessageBox.Show(info, "Reklama u novinama: " + reklama.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void PojPKTVDuelBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovoPojPKTVDuel();
            forma.Show();
        }

        private void PojPKTVRadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var tvradg = new TVRadioGost();
                tvradg.Gledanost = 1000;
                tvradg.ImeVoditelja = "Crni Gruja";
                tvradg.NazivEmisije = "Antiantidepresiv";
                tvradg.NazivStanice = "Stodva zapeta dva gigaherca";
                s.Save(tvradg);
                s.Flush();

                MessageBox.Show("Uspesno sacuvan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PojPKNovineBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovoPojPKNovine();
            forma.Show();
        }

        private void ReklPanoBtn_Click(object sender, EventArgs e)
        {
            var forma = new NovaPanoReklama();
            forma.Show();
        }

        private void ShowReklPanoBtn_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                var reklama = s.Load<PanoReklama>(11);

                string info = "";
                info += "Naziv Grada: " + reklama.Grad
                + "\nNaziv Ulice: " + reklama.Ulica
                + "\nVlasnik panoa: " + reklama.Vlasnik
                + "\nVelicina panoa: " + reklama.Povrsina + "m^2"
                + "\nCena Zakupa: " + reklama.CenaZakupa
                + "\nDatum Zakupa" + reklama.DatumZakupa
                + "\nTrajanje Zakupa" + reklama.TrajanjeZakupa + " dana.";

                MessageBox.Show(info, "Pano Reklama: " + reklama.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                IntervjuNovine intNov = s.Load<IntervjuNovine>(13);

                string info =
                    "Pojavljivanje Predsednickog kandidata u novinama " + intNov.NazivLista 
                    + ", dana " + intNov.DatumObjavljivanja.ToShortDateString() +
                    ", obavili su novinari ";
                for (int i = 0; i < intNov.NovinariIzNovina.Count; i++) {
                    info += intNov.NovinariIzNovina[i].ImeNovinara;
                    if (intNov.NovinariIzNovina.Count != 1) {
                        if (i < intNov.NovinariIzNovina.Count - 2) {
                            info += ", ";
                        } else if (i == intNov.NovinariIzNovina.Count - 2) {
                            info += " i ";
                        }
                    }
                }
                info += " dana " + intNov.DatumIntervjua.ToShortDateString();
                MessageBox.Show(info, "IntervjuNovine sa ID " + intNov.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                TVRadioGost tvradg = s.Load<TVRadioGost>(5);

                string info = "Gostovanje na TV ili Radio emisiji pod nazivom " + tvradg.NazivEmisije
                    + " koju vodi " + tvradg.ImeVoditelja + " na stanici " + tvradg.NazivStanice +
                    ", pratilo je " + tvradg.Gledanost + " ljudi.";
                MessageBox.Show(info, "TV/Radio sa ID " + tvradg.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                TVDuel tvd = s.Load<TVDuel>(6);

                string info = "Gostovanje na TV duelu " + tvd.NazivEmisije
                    + " koju vodi " + tvd.ImeVoditelja + " na stanici " + tvd.NazivStanice +
                    ", pratilo je " + tvd.Gledanost + " ljudi.";
                info += "\n Protivkandidati u duelu bili su: \n";
                for(int i = 0; i < tvd.ProtivKandidati.Count; i++) {
                    info += tvd.ProtivKandidati[i].ImePK + "\n";
                }
                info += "\nZajedno sa njima, Naš Predsednički Kandidat odgovarao je na sledeća pitanja:\n";
                for (int i = 0; i < tvd.Pitanja.Count; i++) {
                    info += tvd.Pitanja[i].Tekst + "\n";
                }
                MessageBox.Show(info, "TVDuel sa ID " + tvd.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucitajAkt(ListBox lista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<object[]> imena = s.QueryOver<Aktivista>()
                                            .SelectList(list => list
                                                    .Select(p => p.ID)
                                                    .Select(p => p.Ime)
                                                    .Select(p => p.ImeRod)
                                                    .Select(p => p.Prezime))
                                                    .OrderBy(p => p.ID).Asc
                                                    .List<object[]>();

                
                foreach(var i in imena)
                {
                    // prikazujemo samo imena, ID cuvamo za posle
                    string id = i[0].ToString().PadLeft(4);
                    string ime = i[1].ToString().PadRight(15);
                    string prezime = i[3].ToString().PadRight(15);
                    string roditelj = i[2].ToString().PadRight(15);
                    lista.Items.Add(id + " " + ime + " " + roditelj + " " + prezime);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indeks = ((TabControl)sender).SelectedIndex;

            switch (indeks)
            {
                case 1:
                    ucitajAkt(listAkt);
                    break;
                default:
                    MessageBox.Show("Da se uradi");
                    break;
            }
        }

        private void osveziPolja(Aktivista akt, Boolean koord)
        {
            if (koord)
            {
                koordUl.Text = ((Koordinator)odabrani).UlicaKanc;
                koordBr.Text = ((Koordinator)odabrani).BrojKanc.ToString();
                koordGrad.Text = ((Koordinator)odabrani).GradKanc;
                koordOpst.Text = ((Koordinator)odabrani).Opstina;

                koordPomoc.Items.Clear();
                foreach(var pomoc in ((Koordinator)odabrani).Saradnici)
                {
                    koordPomoc.Items.Add(pomoc.Ime + " " + pomoc.Prezime + " ");
                }
            }
            else
            {
                koordUl.Text = "";
                koordBr.Text = "";
                koordGrad.Text = "";
                koordOpst.Text = "";
                jeKoord.Enabled = odabrani.koord == null;
            }
            jeKoord.Checked = koord;
            jeKoord.Enabled = koord;
            koordUl.Enabled = koord;
            koordBr.Enabled = koord;
            koordGrad.Enabled = koord;
            koordOpst.Enabled = koord;
            koordDodajP.Enabled = koord;
            koordObrisiP.Enabled = koord;
            koordPomoc.Enabled = koord;
            labUl.Enabled = koord;
            labGradKanc.Enabled = koord;
            labOps.Enabled = koord;
            labBrKanc.Enabled = koord;
            labPomoc.Enabled = koord;

            aktIme.Text = odabrani.Ime;
            aktPrezime.Text = odabrani.Prezime;
            aktRoditelj.Text = odabrani.ImeRod;
            aktUlica.Text = odabrani.Ulica;
            aktGrad.Text = odabrani.Grad;
            aktBroj.Text = odabrani.Broj.ToString();

            aktMail.Items.Clear();
            foreach(var mail in odabrani.email)
            {
                aktMail.Items.Add(mail.eMail);
            }

            aktTelefon.Items.Clear();
            foreach (var tel in odabrani.brTel)
            {
                aktTelefon.Items.Add(tel.BrojTel);
            }

            if(odabrani.Akcije.Count == 0)
            {
                labZaAkc.Text = "Odabrani aktivista nije angažovan ni na jednoj akciji.";
            } else
            {
                labZaAkc.Text = "Broj akcija na kojima je kandidat učestvovao je " + odabrani.Akcije.Count
                                + " i to:";
                labAkcije.Text = "";
                foreach (var akc in odabrani.Akcije)
                {
                    labAkcije.Text += akc.NazivAkcije + "\n";
                }
            }

            if(odabrani.gm == null)
            {
                labZaGM.Text = "Aktivista nije zadužen ni za jedno glasačko mesto.";
            } else if (odabrani.Primedbe.Count == 0)
            {
                labZaGM.Text = "Aktivista je zadužen za glasaško mesto broj " + odabrani.gm.BrojGM
                                + " i nema primedbi.";
            } else
            {
                labZaGM.Text = "Aktivista je zadužen za glasaško mesto broj " + odabrani.gm.BrojGM
                                + " i ima žali se na sledeće stvari:\n";
                foreach (var prim in odabrani.Primedbe)
                {
                    labZaGM.Text += prim.TekstPrim + "\n";
                }
            }
        }

        private void listAkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                string[] odabranLista = ((ListBox)sender).SelectedItem.ToString().Split(' ')
                                        .Where(val => val != "").ToArray(); // parsiranje preko LINQa
                int id = Int32.Parse(odabranLista[0]);
                
                if(s.QueryOver<Koordinator>().Where(p => p.ID == id).RowCount() == 1)
                {
                    odabrani = s.Load<Koordinator>(id);
                    osveziPolja(odabrani, true);
                } else
                {
                    odabrani = s.Load<Aktivista>(id);
                    osveziPolja(odabrani, false);                    
                }

                s.Close();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // TODO: dodavanje ne radi dobro i znam zasto (uvek povuce novog iz baze)
        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            if (!aktMail.Text.Length.Equals(0))
            {
                aktMail.Items.Add(aktMail.Text);

                EMailAktiviste email = new EMailAktiviste();
                email.Akt = odabrani;
                email.eMail = aktMail.Text;

                aktMail.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemoveEmail_Click(object sender, EventArgs e)
        {
            if (!aktMail.Text.Length.Equals(0))
            {
                var poruka = MessageBox.Show("Da li ste sigurni da želite da obrišete mejl "
                                 + aktMail.Text + "?", "Brisanje e-mail adrese", MessageBoxButtons.YesNo);
                
                if(poruka == DialogResult.Yes)
                {
                    odabrani.email = odabrani.email.Where(mail => mail.eMail != aktMail.Text).ToArray();
                    aktMail.Items.Remove(aktMail.Text);
                    aktMail.Text = "";
                } else
                {
                    //nista
                }
            }
        }
    }
}
