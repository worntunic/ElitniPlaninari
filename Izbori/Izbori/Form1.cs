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

namespace Izbori {
    public partial class Form1 : Form {
        public Aktivista odabrani { get; set; } // konrektan odabrani aktivista
        public List<Aktivista> aktivisti { get; set; } //svi aktivisti

        public Reklama odabranaReklama { get; set; } //konkretna odabrana reklama
        public IList<Reklama> reklame { get; set; } //sve reklame/propaganda

        public IntervjuNovine odabraniIntervjuUNovinama { get; set; } //konkretan odabrani intervju
        public IList<IntervjuNovine> intervjui { get; set; } //Svi intervjui

        public TVRadioGost odabranoGostovanje { get; set; } //konkretno odabrano gostovanje
        public IList<TVRadioGost> gostovanja { get; set; } //sva gostovanja

        public TVDuel odabraniDuel { get; set; } //konkretni odabrani duel
        public IList<TVDuel> dueli { get; set; } //svi dueli

        public Form1() {
            InitializeComponent();
            odabrani = null;
            aktivisti = null;
            reklame = null;
            intervjui = null;
            gostovanja = null;
            dueli = null;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void AkcDeljLetBtn_Click(object sender, EventArgs e) {
            var forma = new NovaAkcDeljenjaLetaka();
            forma.Show();
        }

        private void AkcSusKand_Click(object sender, EventArgs e) {
            var forma = new NovaAkcSusretaKandidata();
            forma.Show();
        }

        private void AkcMitBtn_Click(object sender, EventArgs e) {
            var forma = new NovaAkcMitinga();
            forma.Show();
        }

        private void RezIzbBtn_Click(object sender, EventArgs e) {
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

        private void ShowActv_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                Aktivista akt = s.Load<Aktivista>(18);

                string info =
                    "Licni podaci: " + akt.Ime + " " + akt.ImeRod + " " + akt.Prezime +
                    "\nAdresa: " + akt.Ulica + " " + akt.Broj + " " + akt.Grad +
                    "\nEmail: ";
                for (int i = 0; i < akt.email.Count; i++) {
                    info += akt.email[i].eMail + "\n";
                }
                info += "\nBrojevi telefona: ";
                for (int i = 0; i < akt.brTel.Count; i++) {
                    info += akt.brTel[i].BrojTel + "\n";
                }

                if (akt.koord != null) {
                    info += "\nNadredjeni aktivisti: " + akt.koord.Ime + " " + akt.koord.Prezime;
                }

                info += "\nAkcije: ";
                for (int i = 0; i < akt.Akcije.Count; i++) {
                    info += akt.Akcije[i].NazivAkcije + "\n";
                }
                info += "\nPrimedbe: ";
                for (int i = 0; i < akt.Primedbe.Count; i++) {
                    info += "Aktivista je angazovan na " + akt.gm.Naziv;
                    if (akt.Primedbe[i].TekstPrim != null) {
                        info += "\nImao je sledece primedbe: " + akt.Primedbe[i].TekstPrim;
                    } else {
                        info += "\nNije imao primedbe.";
                    }
                }

                MessageBox.Show(info, "Aktivista sa ID " + akt.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowCoord_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                Koordinator koord = s.Load<Koordinator>(7);

                string info =
                    "Licni podaci: " + koord.Ime + " " + koord.ImeRod + " " + koord.Prezime +
                    "\nOpstina koordinisanje: " + koord.Opstina +
                    "\nAdresa kancelarije: " + koord.UlicaKanc + " " + koord.BrojKanc + " " + koord.GradKanc +
                    "\nPodredjeni: ";
                for (int i = 0; i < koord.Saradnici.Count; i++) {
                    info += koord.Saradnici[i].Ime + " " + koord.Saradnici[i].Prezime + "\n";
                }
                
                MessageBox.Show(info, "Koordinator sa ID " + koord.ID);
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajAktivistuBtn_Click(object sender, EventArgs e) {
            var forma = new NoviAktivista();
            forma.Show();            
        }

        private void DodajKoordinatoraBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                int id = 0;
                bool notHelper = false;
                bool notKoord = false;
                Aktivista akt = null;
                do {
                    ++id;
                    akt = s.Load<Aktivista>(id);
                    notHelper = akt.koord == null;
                    notKoord = s.QueryOver<Koordinator>().Where(x => x.ID == akt.ID).RowCount() == 0;
                }
                while (!notHelper || !notKoord);

                if (notKoord && notHelper) {
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
                } else if (notHelper) {
                    MessageBox.Show("Ovaj aktivista je vec koordinator.");
                } else {
                    MessageBox.Show("Ovaj aktivista je vec podredjen nekom.");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodeliPomocnikeBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                Koordinator koord = s.Load<Koordinator>(23);

                int brAktivista = s.QueryOver<Aktivista>().Where(x => x.koord == koord).RowCount();

                //samo test! dodaje prva 4 na koja naidje da moze
                for (int i = 1, j = 0; j < 4 - brAktivista; i++) {
                    Aktivista akt = s.Load<Aktivista>(i);
                    bool jeKoord = s.QueryOver<Koordinator>().Where(x => x.ID == i).RowCount() > 0;
                    
                    if (!jeKoord && akt.koord == null) {
                        akt.koord = koord;
                        s.Save(akt);
                        ++j;
                    }
                }
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno sacuvani");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void GostMitBtn_Click(object sender, EventArgs e) {
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

        private void GlasackoMestoBtn_Click(object sender, EventArgs e) {
            var forma = new NovoGlasackoMesto();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            var forma = new NoviRezultatIzbora();
            forma.Show();
        }

        private void AngAktnaGMBtn_Click(object sender, EventArgs e) {
            var forma = new AktivistaNaGlasacko();
            forma.Show();
        }

        private void AddNote_Click(object sender, EventArgs e) {
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

        private void ReklTVRadioBtn_Click(object sender, EventArgs e) {
            var forma = new NovaTVRadioReklama();
            forma.Show();
        }

        private void ShowReklTVRadioBtn_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();
            try {
                var reklama = s.Load<TVRadioReklama>(1);

                string info = "";
                info += "Na stanici: \"" + reklama.NazivStanice + "\""
                    + "\nBroj ponavljanja: " + reklama.BrojPonavljanja
                    + "\nTrajanje reklame: " + reklama.Trajanje + " sekundi"
                    + "\nCena Zakupa: " + reklama.CenaZakupa
                    + "\nDatum Zakupa" + reklama.DatumZakupa
                    + "\nTrajanje Zakupa" + reklama.TrajanjeZakupa + " dana.";

                MessageBox.Show(info, "TV/Radio Reklama: " + reklama.ID);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                s.Close();
            }
        }

        private void ReklNovineBtn_Click(object sender, EventArgs e) {
            var forma = new NovaNovineReklama();
            forma.Show();
        }

        private void ShowReklNovineBtn_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();
            try {
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
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                s.Close();
            }
        }

        private void PojPKTVDuelBtn_Click(object sender, EventArgs e) {
            var forma = new NovoPojPKTVDuel();
            forma.Show();
        }

        private void PojPKTVRadBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                var tvradg = new TVRadioGost();
                tvradg.Gledanost = 1000;
                tvradg.ImeVoditelja = "Crni Gruja";
                tvradg.NazivEmisije = "Antiantidepresiv";
                tvradg.NazivStanice = "Stodva zapeta dva gigaherca";
                s.Save(tvradg);
                s.Flush();

                MessageBox.Show("Uspesno sacuvan");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void PojPKNovineBtn_Click(object sender, EventArgs e) {
            var forma = new NovoPojPKNovine();
            forma.Show();
        }

        private void ReklPanoBtn_Click(object sender, EventArgs e) {
            var forma = new NovaPanoReklama();
            forma.Show();
        }

        private void ShowReklPanoBtn_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();
            try {
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
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
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
                for (int i = 0; i < tvd.ProtivKandidati.Count; i++) {
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

        public void ucitajAkt(ListView lista, IList<Aktivista> akt)
        {
            if(lista.Items.Count != 0)
            {
                lista.Items.Clear();
            }
            foreach(var i in akt)
            {
                ListViewItem item = new ListViewItem(i.ID.ToString());
                item.SubItems.Add(i.Ime);
                item.SubItems.Add(i.ImeRod);
                item.SubItems.Add(i.Prezime);
                lista.Items.Add(item);
            }
        }
        public void ucitajRek(ListView lista, IList<Reklama> rek) {
            /*ListViewItem item = new ListViewItem("22");
            item.SubItems.Add("vrsta");
            item.SubItems.Add("cena");
            item.SubItems.Add("datum");
            item.SubItems.Add("Trajanje");
            lista.Items.Add(item);
            lista.Items[0].Group = lista.Groups[0];*/
            //int j = 0;
            foreach (var i in rek) {
                ListViewItem item = new ListViewItem(i.ID.ToString());
                item.SubItems.Add(i.CenaZakupa.ToString());
                item.SubItems.Add(String.Format("{0:d/M/yyyy}", i.DatumZakupa));
                item.SubItems.Add(i.TrajanjeZakupa.ToString());
                if (i is NovineReklama) {
                    item.Group = lista.Groups[0];
                } else if (i is PanoReklama) {
                    item.Group = lista.Groups[1];
                } else if (i is TVRadioReklama) {
                    item.Group = lista.Groups[2];
                }
                lista.Items.Add(item);
                //j++;
            }
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            var indeks = ((TabControl)sender).SelectedIndex;
            ISession s = DataLayer.GetSession();
            s.Flush();

            //if (s.Transaction.IsActive)
            //{
            //    s.Transaction.Commit(); //pri promeni taba, ako postoji transakcija, komituj je i nastavi dalje
            //}

            switch (indeks) {
                case 1:
                    aktivisti = (List<Aktivista>)s.QueryOver<Aktivista>().OrderBy(p => p.ID).Asc.List();
                    ucitajAkt(lvAkt, aktivisti);
                    break;
                case 4:
                    intervjui = (List<IntervjuNovine>)s.QueryOver<IntervjuNovine>().OrderBy(p => p.ID).Asc.List();
                    gostovanja = (List<TVRadioGost>)s.QueryOver<TVRadioGost>().OrderBy(p => p.ID).Asc.List();
                    dueli = (List<TVDuel>)s.QueryOver<TVDuel>().OrderBy(p => p.ID).Asc.List();
                    break;
                case 5:
                    reklame = s.QueryOver<Reklama>().OrderBy(p => p.ID).Asc.List();
                    ucitajRek(propagandaListView, reklame);
                    break;
                default:
                    MessageBox.Show("Da se uradi");
                    break;
            }
            s.Close();
        }

        public void osveziPolja(int id) {
            try {
                ISession s = DataLayer.GetSession();

                bool koord = s.QueryOver<Koordinator>().Where(p => p.ID == id).RowCount() == 1;

                if (koord) {
                    odabrani = s.Load<Koordinator>(id);
                    koorUlicaKanc.Text = ((Koordinator)odabrani).UlicaKanc;
                    koorBrojKanc.Text = ((Koordinator)odabrani).BrojKanc.ToString();
                    koorGradKanc.Text = ((Koordinator)odabrani).GradKanc;
                    koorOpstina.Text = ((Koordinator)odabrani).Opstina;

                    koordPomoc.Items.Clear();
                    foreach (var pomoc in ((Koordinator)odabrani).Saradnici) {
                        koordPomoc.Items.Add(pomoc.Ime + " " + pomoc.Prezime);
                    }
                    labKoord.Text = "";
                    jeKoord.Enabled = true;
                } else {
                    odabrani = s.Load<Aktivista>(id);
                    koorUlicaKanc.Text = "";
                    koorBrojKanc.Text = "";
                    koorGradKanc.Text = "";
                    koorOpstina.Text = "";
                    jeKoord.Enabled = odabrani.koord == null;

                    if (odabrani.koord == null) {
                        labKoord.Text = "Aktivista nije ničiji saradnik.";
                        jeKoord.Enabled = true;
                    } else {
                        labKoord.Text = String.Format("Aktivista sarađuje sa {0} {1}.",
                                                      odabrani.koord.Ime,
                                                      odabrani.koord.Prezime);
                        jeKoord.Enabled = false;
                    }
                }

                jeKoord.Checked = koord;
                koorUlicaKanc.Enabled = koord;
                koorBrojKanc.Enabled = koord;
                koorGradKanc.Enabled = koord;
                koorOpstina.Enabled = koord;
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
                aktImeRod.Text = odabrani.ImeRod;
                aktUlica.Text = odabrani.Ulica;
                aktGrad.Text = odabrani.Grad;
                aktBroj.Text = odabrani.Broj.ToString();

                aktMail.Items.Clear();
                foreach (var mail in odabrani.email) {
                    aktMail.Items.Add(mail.eMail);
                }

                aktTelefon.Items.Clear();
                foreach (var tel in odabrani.brTel) {
                    aktTelefon.Items.Add(tel.BrojTel);
                }

                if (odabrani.Akcije.Count == 0) {
                    labZaAkc.Text = "Odabrani aktivista nije angažovan ni na jednoj akciji.";
                } else {
                    labZaAkc.Text = "Broj akcija na kojima je kandidat učestvovao je " + odabrani.Akcije.Count
                                    + " i to:";
                    labAkcije.Text = "";
                    foreach (var akc in odabrani.Akcije) {
                        labAkcije.Text += akc.NazivAkcije + "\n";
                    }
                }

                if (odabrani.gm == null) {
                    labZaGM.Text = "Aktivista nije zadužen ni za jedno glasačko mesto.";
                } else if (odabrani.Primedbe.Count == 0) {
                    labZaGM.Text = "Aktivista je zadužen za glasaško mesto broj " + odabrani.gm.BrojGM
                                    + " i nema primedbi.";
                } else {
                    labZaGM.Text = "Aktivista je zadužen za glasaško mesto broj " + odabrani.gm.BrojGM
                                    + " i ima žali se na sledeće stvari:\n";
                    foreach (var prim in odabrani.Primedbe) {
                        labZaGM.Text += prim.TekstPrim + "\n";
                    }
                }
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void listAkt_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
            //u petlji je iako samo jedan moze da se odabere
            foreach (ListViewItem akt in odabr) {
                int id = Int32.Parse(akt.SubItems[0].Text);
                osveziPolja(id);
            }
        }

        private void obrisi(int id, string tip) {
            try {
                ISession s = DataLayer.GetSession();
                var q = String.Format("delete {0} where id = :id", tip);
                s.CreateQuery(q).SetParameter("id", id).ExecuteUpdate();
                s.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddEmail_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();

            if (!aktMail.Text.Length.Equals(0)) {
                aktMail.Items.Add(aktMail.Text);

                EMailAktiviste email = new EMailAktiviste();
                email.Akt = odabrani;
                email.eMail = aktMail.Text;

                aktMail.Text = "";

                s.Save(email);
            }

            s.Close();
        }


        private void btnRemoveEmail_Click(object sender, EventArgs e) {
            if (!aktMail.Text.Length.Equals(0)) {
                var poruka = MessageBox.Show("Da li ste sigurni da želite da obrišete mejl "
                                 + aktMail.Text + "?", "Brisanje e-mail adrese", MessageBoxButtons.YesNo);
                
                if (poruka == DialogResult.Yes) {
                    EMailAktiviste mail = odabrani.email.Single(m => m.eMail == aktMail.Text);
                    obrisi(mail.IDEmail, mail.GetType().ToString());

                    aktMail.Items.Remove(aktMail.Text);
                    aktMail.Text = "";
                }
            }
        }

        private void btnAddTelefon_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();

            if (!aktTelefon.Text.Length.Equals(0)) {
                aktTelefon.Items.Add(aktTelefon.Text);

                BrTel tel = new BrTel();
                tel.Aktivista = odabrani;
                tel.BrojTel = aktTelefon.Text;

                aktTelefon.Text = "";

                s.Save(tel);
            }
            s.Close();
        }

        private void btnRemoveTelefon_Click(object sender, EventArgs e) {
            if (!aktTelefon.Text.Length.Equals(0)) {
                var poruka = MessageBox.Show("Da li ste sigurni da želite da obrišete telefon "
                                 + aktTelefon.Text + "?", "Brisanje telefona", MessageBoxButtons.YesNo);

                if (poruka == DialogResult.Yes) {
                    BrTel tel = odabrani.brTel.Single(t => t.BrojTel == aktTelefon.Text);
                    obrisi(tel.IDBr, tel.GetType().ToString());

                    aktTelefon.Items.Remove(aktTelefon.Text);
                    aktTelefon.Text = "";
                }
            }
        }

        private void koordDodajP_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();
                int brPomoc = s.QueryOver<Aktivista>().Where(k => k.koord == odabrani).RowCount();
                s.Close();
                if (brPomoc == 4)
                {
                    MessageBox.Show("Koordinator već ima 4 saradnika. Obrišite nekog kako biste dodali novog.", "Puno saradnika");
                } else {
                    DodajPomoc f = new DodajPomoc();
                    f.ShowDialog(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void koordObrisiP_Click(object sender, EventArgs e) {
            if (!koordPomoc.Text.Length.Equals(0)) {
                Aktivista akt = ((Koordinator)odabrani).Saradnici
                                .Single(p => (p.Ime + " " + p.Prezime) == koordPomoc.Text);
                var poruka = MessageBox.Show(
                            String.Format("Da li ste sigurni da Da li ste sigurni da želite da obrišete " +
                            "{0} {1} iz liste saradnika?",
                            akt.Ime, akt.Prezime), "Brisanje saradnika", MessageBoxButtons.YesNo);

                if (poruka == DialogResult.Yes) {
                    try {
                        ISession s = DataLayer.GetSession();

                        akt.koord = null;
                        s.SaveOrUpdate(akt);
                        s.Flush();
                        s.Close();

                        koordPomoc.Items.Remove(koordPomoc.Text);
                        koordPomoc.Text = "";
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void jeKoord_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();

                if (jeKoord.Checked) {
                        Koordinator koord = new Koordinator();

                        string q = "insert into Koordinator (idakt) values (:id)";
                        s.CreateSQLQuery(q).SetParameter("id", odabrani.ID).ExecuteUpdate();
                        osveziPolja(odabrani.ID);
                } else {
                    foreach (var a in ((Koordinator)odabrani).Saradnici) {
                        a.koord = null;
                        s.SaveOrUpdate(a);
                    }
                    s.Flush();
                    string q = "delete from Koordinator where idakt=:id";
                    s.CreateSQLQuery(q).SetParameter("id", odabrani.ID).ExecuteUpdate();
                    ///TODO Zasto ne radi sa obrisi(odabrani.ID)?
                    osveziPolja(odabrani.ID);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aktAzuriraj_Click(object sender, EventArgs e)
        {
            var tekstBs = GetAll(this, typeof(TextBox));
            foreach(var t in tekstBs)
            {
                string tIme = t.Name;
                string propIme;
                if (tIme.Contains("akt"))
                {
                    propIme = t.Name.Substring(3);
                } else if (tIme.Contains("koor") && jeKoord.Checked)
                {
                    propIme = t.Name.Substring(4);
                } else
                {
                    continue;
                }
                try {
                    odabrani.GetType().GetProperty(propIme).SetValue(odabrani, t.Text);
                } catch (ArgumentException ex)
                {
                    odabrani.GetType().GetProperty(propIme).SetValue(odabrani, Int32.Parse(t.Text));
                }
            }
            ISession s = DataLayer.GetSession();
            s.SaveOrUpdate(odabrani);
            s.Flush();
            s.Close();

            aktivisti.Single(a => a.ID == odabrani.ID).Ime = odabrani.Ime;
            aktivisti.Single(a => a.ID == odabrani.ID).Prezime = odabrani.Prezime;
            aktivisti.Single(a => a.ID == odabrani.ID).ImeRod = odabrani.ImeRod;

            azurElListe(lvAkt, aktivisti, odabrani.ID);
        }
        ///TODO Kako napisati genericki metod? Interfejs mozda?
        //private void azurElListe<T>(ListView lista, List<T> inL, int id)
        private void azurElListe(ListView lista, List<Aktivista> inL, int id)
            //funkcija za azuriranje jednog aktiviste
        {
            lista.Select();
            int indOdab = inL.FindIndex(ak => ak.ID == id);
            lista.Items[indOdab].Selected = true;
            lista.Items[indOdab].SubItems[1].Text = inL[indOdab].Ime;
            lista.Items[indOdab].SubItems[2].Text = inL[indOdab].Prezime;
            lista.Items[indOdab].SubItems[3].Text = inL[indOdab].ImeRod;
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        //http://stackoverflow.com/questions/3419159/how-to-get-all-child-controls-of-a-windows-forms-form-of-a-specific-type-button
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void setEnable(IEnumerable<Control> cList, bool flag)
        {
            foreach(var c in cList)
            {
                c.Enabled = flag;
            }
        }

        private void clearCtrl(IEnumerable<Control> cList)
        {
            foreach(var c in cList)
            {
                c.Text = "";
                if(c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)c).Items.Clear();
                }
            }
        }

        ///TODO On delete cascade...
        private void aktObrisi_Click(object sender, EventArgs e) {
            if (odabrani != null) {
                try {
                    ISession s = DataLayer.GetSession();
                    string q = "delete from AKTIVISTASTRANKE where id=:id";
                    s.CreateSQLQuery(q).SetParameter("id", odabrani.ID).ExecuteUpdate();
                    s.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void label20_Click(object sender, EventArgs e) {

        }


        public void postaviKolonePropListe(Type tip) {
            propagandaListView.Columns.Clear();
            propagandaListView.Columns.Add("ID");
            if(tip == typeof(NovineReklama)) {
                propagandaListView.Columns.Add("NazivLista");
                propagandaListView.Columns.Add("U boji");
            } else if (tip == typeof(PanoReklama)) {
                propagandaListView.Columns.Add("Grad");
                propagandaListView.Columns.Add("Ulica");
                propagandaListView.Columns.Add("Vlasnik");
                propagandaListView.Columns.Add("Površina");
            } else if (tip == typeof(TVRadioReklama)) {
                propagandaListView.Columns.Add("Naziv Stanice");
                propagandaListView.Columns.Add("Trajanje");
                propagandaListView.Columns.Add("Broj Ponavljanja");
            }
            propagandaListView.Columns.Add("Cena Zakupa");
            propagandaListView.Columns.Add("Datum Zakupa");
            propagandaListView.Columns.Add("Trajanje Zakupa");
        }
        public void postaviSirinuSvihKolona(ListView lv) {
            int width = 0;
            int widthTotal = 0;
            foreach (ColumnHeader col in lv.Columns) {
                width = col.Width;
                widthTotal += width;
                // column items greatest width
                col.Width = -1;
                if (width > col.Width)
                    col.Width = width;

                // column header width
                col.Width = -2;
                if (width > col.Width)
                    col.Width = width;
            }
        }
        public void clearAllPropTxt() {
            propTxtCenaZakupa.Clear();
            propTxtTrajanjeZakupa.Clear();
            propTxtMod0.Clear();
            propTxtMod1.Clear();
            propTxtMod2.Clear();
            propTxtMod3.Clear();
            propClndDatumZakupa.Refresh();
        }
        public void osveziTipPropKontrola(Type tip) {
            if (tip == typeof(NovineReklama)) {
                propLblMod0.Text = "Naziv lista:";
                propLblmod1.Text = "U boji:";
                propLblMod2.Text = "";
                propLblMod3.Text = "";
                clearAllPropTxt();
                propCBUBoji.Visible = true;
                propTxtMod1.Visible = false;
                propTxtMod2.Visible = false;
                propTxtMod3.Visible = false;

            } else if (tip == typeof(PanoReklama)) {
                propLblMod0.Text = "Grad:";
                propLblmod1.Text = "Ulica:";
                propLblMod2.Text = "Vlasnik:";
                propLblMod3.Text = "Površina:";
                clearAllPropTxt();
                propCBUBoji.Visible = false;
                propTxtMod1.Visible = true;
                propTxtMod2.Visible = true;
                propTxtMod3.Visible = true;
            } else if (tip == typeof(TVRadioReklama)) {
                propLblMod0.Text = "Naziv stanice:";
                propLblmod1.Text = "Trajanje:";
                propLblMod2.Text = "Broj Ponavljanja";
                propLblMod3.Text = "";
                clearAllPropTxt();
                propCBUBoji.Visible = false;
                propTxtMod1.Visible = true;
                propTxtMod2.Visible = true;
                propTxtMod3.Visible = false;
            }
        }
        public void osveziPropListu(Type tip, IList<Reklama> rek) {
            propagandaListView.BeginUpdate();
            propagandaListView.Items.Clear();
            postaviKolonePropListe(tip);
            foreach (var i in rek) {
                if (i.GetType() == tip) {
                    ListViewItem item = new ListViewItem(i.ID.ToString());
                    if (i.GetType() == typeof(NovineReklama)) {
                        item.SubItems.Add(((NovineReklama)i).NazivLista);
                        item.SubItems.Add((((NovineReklama)i).Uboji == 1) ? "da" : "ne");
                    }
                    if (i.GetType() == typeof(PanoReklama)) {
                        item.SubItems.Add(((PanoReklama)i).Grad);
                        item.SubItems.Add(((PanoReklama)i).Ulica);
                        item.SubItems.Add(((PanoReklama)i).Vlasnik);
                        item.SubItems.Add(((PanoReklama)i).Povrsina.ToString());
                    }
                    if (i.GetType() == typeof(TVRadioReklama)) {
                        item.SubItems.Add(((TVRadioReklama)i).NazivStanice);
                        item.SubItems.Add(((TVRadioReklama)i).Trajanje.ToString());
                        item.SubItems.Add(((TVRadioReklama)i).BrojPonavljanja.ToString());
                    }
                    item.SubItems.Add(i.CenaZakupa.ToString());
                    item.SubItems.Add(String.Format("{0:d/M/yyyy}", i.DatumZakupa));
                    item.SubItems.Add(i.TrajanjeZakupa.ToString());
                    propagandaListView.Items.Add(item);
                }
            }
            postaviSirinuSvihKolona(propagandaListView);
            propagandaListView.EndUpdate();
        }
        private void propRBNovine_CheckedChanged(object sender, EventArgs e) {
            osveziPropListu(typeof(NovineReklama), reklame);
            osveziTipPropKontrola(typeof(NovineReklama));
        }
        private void propRBPano_CheckedChanged(object sender, EventArgs e) {
            osveziPropListu(typeof(PanoReklama), reklame);
            osveziTipPropKontrola(typeof(PanoReklama));
        }

        private void propRBTVRad_CheckedChanged(object sender, EventArgs e) {
            osveziPropListu(typeof(TVRadioReklama), reklame);
            osveziTipPropKontrola(typeof(TVRadioReklama));
        }
        private void propagandaListView_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (propRBNovine.Checked) {
                ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in odabr) {
                    propTxtMod0.Text = item.SubItems[1].Text;
                    propCBUBoji.Checked = (item.SubItems[2].Text == "da");
                    propTxtCenaZakupa.Text = item.SubItems[3].Text;
                    propClndDatumZakupa.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[4].Text), Convert.ToDateTime(item.SubItems[4].Text).AddDays(Convert.ToDouble(item.SubItems[5].Text)));
                    propTxtTrajanjeZakupa.Text = item.SubItems[5].Text;
                }
            }
            if (propRBPano.Checked) {
                ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in odabr) {
                    propTxtMod0.Text = item.SubItems[1].Text;
                    propTxtMod1.Text = item.SubItems[2].Text;
                    propTxtMod2.Text = item.SubItems[3].Text;
                    propTxtMod3.Text = item.SubItems[4].Text;
                    propTxtCenaZakupa.Text = item.SubItems[5].Text;
                    propClndDatumZakupa.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[6].Text), Convert.ToDateTime(item.SubItems[6].Text).AddDays(Convert.ToDouble(item.SubItems[7].Text)));
                    propTxtTrajanjeZakupa.Text = item.SubItems[7].Text;
                }
            }
            if (propRBTVRad.Checked) {
                ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in odabr) {
                    propTxtMod0.Text = item.SubItems[1].Text;
                    propTxtMod1.Text = item.SubItems[2].Text;
                    propTxtMod2.Text = item.SubItems[3].Text;
                    propTxtCenaZakupa.Text = item.SubItems[4].Text;
                    propClndDatumZakupa.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[5].Text), Convert.ToDateTime(item.SubItems[5].Text).AddDays(Convert.ToDouble(item.SubItems[6].Text)));
                    propTxtTrajanjeZakupa.Text = item.SubItems[6].Text;
            }
            }
        }

        private void rBtnNovine_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnNovine.Checked)
            {
                LoadData("Intervju Novine");
                hidePojControls();
                rBtnTVRadio.Checked = false;
                chBoxTVDuel.Checked = false;

                lNazivLista.Visible = true;
                tbNazivLista.Visible = true;

                lDatumIntervjua.Visible = true;
                calIntervjua.Visible = true;

                lDatumObjavljivanja.Visible = true;
                calObjavljivanja.Visible = true;

                lNovinari.Visible = true;
                cbNovinari.Visible = true;
                btnDodajNovinara.Visible = true;
                btnUkloniNovinara.Visible = true;
                btnAddGostovanje.Visible = true;
                btnRemoveGostovanje.Visible = true;
                btnUpdateGostovanje.Visible = true;
            }
        }

        private void rBtnTVRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTVRadio.Checked)
            {
                LoadData("TV/Radio Gostovanje");
                hidePojControls();
                lImeVoditelja.Visible = true;
                tbImeVoditelja.Visible = true;

                lProcenjenaGledanost.Visible = true;
                tbProcenjenaGledanost.Visible = true;

                lNazivEmisije.Visible = true;
                tbNazivEmisije.Visible = true;

                lNazivStanice.Visible = true;
                tbNazivStanice.Visible = true;
                chBoxTVDuel.Visible = true;

                lPitanja.Visible = true;
                cbPitanje.Visible = true;
                btnDodajPitanje.Visible = true;
                btnUkloniPitanje.Visible = true;

                lImeProtivkand.Visible = true;
                cbProtivkandidati.Visible = true;
                btnDodajProtivkandidata.Visible = true;
                btnUkloniProtivkandidata.Visible = true;

                btnAddGostovanje.Visible = true;
                btnRemoveGostovanje.Visible = true;
                btnUpdateGostovanje.Visible = true;
            }
        }

        private void cbTVDuel_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxTVDuel.CheckState == CheckState.Checked)
            {
                LoadData("TV Duel");
                lPitanja.Enabled = true;
                cbPitanje.Enabled = true;
                btnDodajPitanje.Enabled = true;
                btnUkloniPitanje.Enabled = true;

                lImeProtivkand.Enabled = true;
                cbProtivkandidati.Enabled = true;
                btnDodajProtivkandidata.Enabled = true;
                btnUkloniProtivkandidata.Enabled = true;
            }
            else
            {
                LoadData("TV/Radio Gostovanje");
                lPitanja.Enabled = false;
                cbPitanje.Enabled = false;
                btnDodajPitanje.Enabled = false;
                btnUkloniPitanje.Enabled = false;

                lImeProtivkand.Enabled = false;
                cbProtivkandidati.Enabled = false;
                btnDodajProtivkandidata.Enabled = false;
                btnUkloniProtivkandidata.Enabled = false;
            }
        }

        private void hidePojControls()
        {
            lNazivLista.Visible = false;
            tbNazivLista.Visible = false;

            lDatumIntervjua.Visible = false;
            calIntervjua.Visible = false;

            lDatumObjavljivanja.Visible = false;
            calObjavljivanja.Visible = false;

            lImeVoditelja.Visible = false;
            tbImeVoditelja.Visible = false;

            lProcenjenaGledanost.Visible = false;
            tbProcenjenaGledanost.Visible = false;

            lNazivEmisije.Visible = false;
            tbNazivEmisije.Visible = false;

            lNazivStanice.Visible = false;
            tbNazivStanice.Visible = false;

            lImeProtivkand.Visible = false;
            cbProtivkandidati.Visible = false;
            btnDodajProtivkandidata.Visible = false;
            btnUkloniProtivkandidata.Visible = false;

            lPitanja.Visible = false;
            cbPitanje.Visible = false;
            btnDodajPitanje.Visible = false;
            btnUkloniPitanje.Visible = false;

            lNovinari.Visible = false;
            cbNovinari.Visible = false;
            btnDodajNovinara.Visible = false;
            btnUkloniNovinara.Visible = false;

            btnAddGostovanje.Visible = false;
            btnRemoveGostovanje.Visible = false;
            btnUpdateGostovanje.Visible = false;
            chBoxTVDuel.Visible = false;
        }

        private void LoadData(string x)
        {
            listaPojavljivanja.Items.Clear();
            listaPojavljivanja.Columns.Clear();
            listaPojavljivanja.Columns.Add("ID");
            if (x == "Intervju Novine")
            {
                listaPojavljivanja.Columns.Add("Naziv Lista");
                listaPojavljivanja.Columns.Add("Datum Objavljivanja");
            }
            else if (x == "TV/Radio Gostovanje")
            {
                listaPojavljivanja.Columns.Add("Naziv Stanice");
                listaPojavljivanja.Columns.Add("Naziv Emisije");
            }
            else if (x == "TV Duel")
            {
                listaPojavljivanja.Columns.Add("Naziv Stanice");
                listaPojavljivanja.Columns.Add("Naziv Emisije");
            }
            LoadValues(x);
        }

        private void LoadValues(string tabela)
        {
            listaPojavljivanja.BeginUpdate();

            if (tabela == "Intervju Novine")
            {
                foreach (IntervjuNovine x in intervjui)
                {
                    string[] row = { x.ID.ToString(), x.NazivLista, String.Format("{0:d/M/yyyy}", x.DatumObjavljivanja), String.Format("{0:d/M/yyyy}", x.DatumIntervjua)};

                    var item = new ListViewItem(row);

                    listaPojavljivanja.Items.Add(item);
                }
            }
            else if (tabela == "TV/Radio Gostovanje")
            {
                foreach (TVRadioGost x in gostovanja)
                {
                    string[] row = { x.ID.ToString(), x.NazivStanice, x.NazivEmisije, x.ImeVoditelja, x.Gledanost.ToString()};

                    var item = new ListViewItem(row);

                    listaPojavljivanja.Items.Add(item);
                }
            }
            else if (tabela == "TV Duel")
            {
                foreach (TVDuel x in dueli)
                {
                    string[] row = { x.ID.ToString(), x.NazivStanice, x.NazivEmisije, x.ImeVoditelja, x.Gledanost.ToString() };

                    var item = new ListViewItem(row);

                    listaPojavljivanja.Items.Add(item);
                }
            }
            
            postaviSirinuSvihKolona(listaPojavljivanja);
            listaPojavljivanja.EndUpdate();
        }

        private void listaPojavljivanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Checked)
            {
                ListView.SelectedListViewItemCollection izabrani = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in izabrani)
                {
                    tbNazivStanice.Text = item.SubItems[1].Text;
                    tbNazivEmisije.Text = item.SubItems[2].Text;
                    tbImeVoditelja.Text = item.SubItems[3].Text;
                    tbProcenjenaGledanost.Text = item.SubItems[4].Text;
                    ISession s = DataLayer.GetSession();
                    try
                    {
                        odabraniDuel = s.Load<TVDuel>(int.Parse(item.SubItems[0].Text));
                        cbProtivkandidati.Items.Clear();
                        cbPitanje.Items.Clear();
                        foreach (ProtivKandidatiTVDuel x in odabraniDuel.ProtivKandidati)
                        {
                            cbProtivkandidati.Items.Add(x.ImePK);
                        }
                        foreach (var x in odabraniDuel.Pitanja)
                        {
                            cbPitanje.Items.Add(x.Tekst);
                        }
                    }
                    finally
                    {
                        s.Close();
                    }
                }
            }
            else if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Unchecked)
            {
                ListView.SelectedListViewItemCollection izabrani = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in izabrani)
                {
                    tbNazivStanice.Text = item.SubItems[1].Text;
                    tbNazivEmisije.Text = item.SubItems[2].Text;
                    tbImeVoditelja.Text = item.SubItems[3].Text;
                    tbProcenjenaGledanost.Text = item.SubItems[4].Text;                    
                }
            }
            else if (rBtnNovine.Checked)
            {
                ListView.SelectedListViewItemCollection izabrani = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in izabrani)
                {
                    tbNazivLista.Text = item.SubItems[1].Text;
                    calObjavljivanja.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[2].Text), Convert.ToDateTime(item.SubItems[2].Text));
                    calIntervjua.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[3].Text), Convert.ToDateTime(item.SubItems[3].Text));

                    ISession s = DataLayer.GetSession();
                    try
                    {
                        odabraniIntervjuUNovinama = s.Load<IntervjuNovine>(int.Parse(item.SubItems[0].Text));
                        cbNovinari.Items.Clear();
                        
                        foreach (NovinariIzNovina x in odabraniIntervjuUNovinama.NovinariIzNovina)
                        {
                            cbProtivkandidati.Items.Add(x.ImeNovinara);
                        }
                    }
                    finally
                    {
                        s.Close();
                    }
                }
            }
        }
    }
}