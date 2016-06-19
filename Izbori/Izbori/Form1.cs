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
using System.Collections;

namespace Izbori
{
    public partial class Form1 : Form
    {
        public Aktivista odabrani { get; set; } // konrektan odabrani aktivista
        public List<Aktivista> aktivisti { get; set; } //svi aktivisti

        public GlasackoMesto oGM { get; set; } //konkretno glasacko mesto
        public List<GlasackoMesto> gmesta { get; set; } //sva glasacka mesta

        public Reklama odabranaReklama { get; set; } //konkretna odabrana reklama
        public List<Reklama> reklame { get; set; } //sve reklame/propaganda

        public IntervjuNovine odabraniIntervju { get; set; } //konkretan odabrani intervju
        public List<IntervjuNovine> intervjui { get; set; } //Svi intervjui

        public TVRadioGost odabranoGostovanje { get; set; } //konkretno odabrano gostovanje
        public List<TVRadioGost> gostovanja { get; set; } //sva gostovanja

        public TVDuel odabraniDuel { get; set; } //konkretni odabrani duel
        public List<TVDuel> dueli { get; set; } //svi dueli

        public Akcija odabranaAkcija { get; set; } //konkretna odabrana akcija
        public List<Akcija> sveAkcije { get; set; } //sve akcije

        public Gost odabraniGost { get; set; } //konkretni odabrani gost
        public List<Gost> gosti { get; set; } //svi gosti

        public Form1() {
            InitializeComponent();
            odabrani = null;
            aktivisti = new List<Aktivista>();
            reklame = new List<Reklama>();
            oGM = null;
            gmesta = new List<GlasackoMesto>();
            intervjui = new List<IntervjuNovine>();
            gostovanja = new List<TVRadioGost>();
            dueli = new List<TVDuel>();
            sveAkcije = new List<Akcija>();
            gosti = new List<Gost>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //blanko ucitavanje sesije, kako bi glatko tekao prolazak kroz tabove
            ISession s = DataLayer.GetSession();
            try {
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                s.Close();
            }
        }

        public void ucitajAkt(ListView lista, IList<Aktivista> akt)
        {
            if (lista.Items.Count != 0)
            {
                lista.Items.Clear();
            }
            foreach (var i in akt)
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
                lista.Items.Add(item);
            }
        }
        public void ucitajAkc(ListView lista, IList<Akcija> akc)
        {
            if (lista.Items.Count != 0)
            {
                lista.Items.Clear();
            }
            foreach (var x in akc)
            {
                ListViewItem item = new ListViewItem(x.NazivAkcije);                
                item.SubItems.Add(x.Grad);

                if (x.GetType() == typeof(Miting) || x.GetType() == typeof(MitingZatvoreniP))
                    item.Group = lista.Groups["akcMiting"];
                else if (x.GetType() == typeof(DeljenjeLetaka))
                    item.Group = lista.Groups["akcDeljLet"];
                else if (x.GetType() == typeof(SusretKandidata))
                    item.Group = lista.Groups["akcSusKand"];
                
                lista.Items.Add(item);
            }
            postaviSirinuSvihKolona(lista);
        }
        public void ucitajGoste(ListView lista, IList<Gost> gost)
        {
            if (lista.Items.Count != 0)
            {
                lista.Items.Clear();
            }
            foreach (var g in gost)
            {
                ListViewItem item = new ListViewItem(g.Titula);

                item.SubItems.Add(g.Ime);
                item.SubItems.Add(g.Prezime);
                item.SubItems.Add(g.Funkcija);

                lista.Items.Add(item);
            }
        }
        private void ucitajGM(ListView lista, List<GlasackoMesto> lg)
        {
            lista.Items.Clear();
            foreach (var g in lg)
            {
                ListViewItem item = new ListViewItem(g.Naziv);
                item.SubItems.Add(g.BrojGM.ToString());
                item.SubItems.Add(g.BrojRegBir.ToString());
                lista.Items.Add(item);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            var indeks = ((TabControl)sender).SelectedIndex;
            ISession s = DataLayer.GetSession();
            try
            {
                s.Flush(); //ako je nesto zaostalo

                switch (indeks)
                {
                    case 1:
                        aktivisti = (List<Aktivista>)s.QueryOver<Aktivista>().OrderBy(p => p.ID).Asc.List();
                        ucitajAkt(lvAkt, aktivisti);
                        break;
                    case 2:
                        sveAkcije = (List<Akcija>)s.QueryOver<Akcija>().OrderBy(p => p.ID).Asc.List();
                        ucitajAkc(lvAkcije, sveAkcije);
                        break;
                    case 3:
                        gmesta = (List<GlasackoMesto>)s.QueryOver<GlasackoMesto>().OrderBy(p => p.BrojGM).Asc.List();
                        ucitajGM(lvGM, gmesta);
                        break;
                    case 4:
                        intervjui = (List<IntervjuNovine>)s.QueryOver<IntervjuNovine>().OrderBy(p => p.ID).Asc.List();
                        gostovanja = (List<TVRadioGost>)s.QueryOver<TVRadioGost>().OrderBy(p => p.ID).Asc.List();
                        dueli = (List<TVDuel>)s.QueryOver<TVDuel>().OrderBy(p => p.ID).Asc.List();
                        break;
                    case 5:
                        reklame = (List<Reklama>)s.QueryOver<Reklama>().OrderBy(p => p.ID).Asc.List();
                        propRBNovine.Checked = true;
                        propRBNovine_CheckedChanged(new object(), new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                s.Close();
            }
        }
        public void osveziPolja(int id)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                bool koord = s.QueryOver<Koordinator>().Where(p => p.ID == id).RowCount() == 1;

                if (koord) {
                    odabrani = s.Load<Koordinator>(id);
                    koorUlicaKanc.Text = ((Koordinator)odabrani).UlicaKanc;
                    koorBrojKanc.Text = ((Koordinator)odabrani).BrojKanc.ToString();
                    koorGradKanc.Text = ((Koordinator)odabrani).GradKanc;
                    koorOpstina.Text = ((Koordinator)odabrani).Opstina;

                    koorPomoc.Items.Clear();
                    foreach (var pomoc in ((Koordinator)odabrani).Saradnici) {
                        koorPomoc.Items.Add(pomoc.Ime + " " + pomoc.Prezime);
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
                koorPomoc.Enabled = koord;
                koorLab1.Enabled = koord;
                koorLab3.Enabled = koord;
                koorLab4.Enabled = koord;
                koorLab2.Enabled = koord;
                koorLab5.Enabled = koord;

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
                    labAkcije.Text = "";
                } else {
                    labZaAkc.Text = "Broj akcija na kojima je kandidat učestvovao je " + odabrani.Akcije.Count
                                    + " i to:";
                    labAkcije.Text = "";
                    foreach (var akc in odabrani.Akcije) {
                        labAkcije.Text += "- " + akc.NazivAkcije + "\n";
                    }
                }

                if (odabrani.gm == null) {
                    labZaGM.Text = "Aktivista nije zadužen ni za jedno glasačko mesto.";
                } else if (odabrani.Primedbe.Count == 0) {
                    labZaGM.Text = "Aktivista je zadužen za glasaško mesto broj " + odabrani.gm.BrojGM
                                    + " i nema primedbi.";
                } else {
                    labZaGM.Text = "Aktivista je zadužen za glasaško mesto broj " + odabrani.gm.BrojGM
                                    + " i žali se na sledeće stvari:\n";
                    foreach (var prim in odabrani.Primedbe) {
                        labZaGM.Text += "\n- " + prim.TekstPrim + "\n";
                    }
                }
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
        public void osveziGM(int id)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                oGM = s.Load<GlasackoMesto>(id);
                gmNaziv.Text = oGM.Naziv;
                gmBrojGM.Text = oGM.BrojGM.ToString();
                gmBrojRegBir.Text = oGM.BrojRegBir.ToString();

                List<Aktivista> angazovani = (List<Aktivista>)s.QueryOver<Aktivista>()
                    .Where(a => a.gm == oGM).List();

                if (angazovani.Count == 0)
                {
                    labAktGM.Text = "Stranka nema nijednog aktivistu angažovanog na ovom glasačkom mestu.";
                }
                else
                {
                    labAktGM.Text = "Broj aktivista na ovom glasačkom mestu je " + angazovani.Count;
                    labAktGM.Text += " i to:\n\n";
                    foreach (var ang in angazovani)
                    {
                        labAktGM.Text += ang.Ime + " " + ang.Prezime + "\n";
                    }
                }

                var rezIzbora = s.QueryOver<RezultatiIzbora>().Where(r => r.GlasackoMesto == oGM).List();
                if (rezIzbora.Count == 0)
                {
                    labPK.Text = labDK.Text = "Ne postoje podaci o rezultatima izbora za ovo glasačko mesto.";
                }
                else
                {
                    foreach (var rez in rezIzbora)
                    {
                        string str = "U {0} krugu je na izbore izašlo {1} "
                               + "glasača, od čega je {2}% glasalo za našeg kandidata.";
                        if (rez.BrKruga == 1)
                        {
                            labPK.Text = String.Format(str, "prvom", rez.BrBiraca, rez.ProcenatZaKandidata);
                            if (rezIzbora.Count == 1)
                            {
                                labDK.Text = "Na ovom glasačkom mestu se nije održao drugi krug izbora.";
                            }
                        }
                        else if (rez.BrKruga == 2)
                        {
                            labDK.Text = String.Format(str, "drugom", rez.BrBiraca, rez.ProcenatZaKandidata);
                        }
                    }
                }
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
        public void listAkt_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
            //u petlji je iako samo jedan moze da se odabere
            foreach (ListViewItem akt in odabr) {
                int id = Int32.Parse(akt.SubItems[0].Text);
                osveziPolja(id);
            }
        }
        private void lvGM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var o = ((ListView)sender).SelectedItems;
            foreach (ListViewItem gm in o)
            {
                int id = gmesta.Single(g => g.Naziv == gm.SubItems[0].Text
                                            && g.BrojGM.ToString() == gm.SubItems[1].Text)
                                .ID;
                osveziGM(id);
            }
        }
        public void obrisi<T>(int id)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                s.Delete(s.Load<T>(id));
                s.Flush();
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
        private void btnAddEmail_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();
            try
            {
                if (!aktMail.Text.Length.Equals(0))
                {
                    aktMail.Items.Add(aktMail.Text);

                    EMailAktiviste email = new EMailAktiviste();
                    email.Akt = odabrani;
                    email.eMail = aktMail.Text;

                    aktMail.Text = "";

                    s.Save(email);
                }
            }
            finally
            {
                s.Close();
            }
        }
        private void btnRemoveEmail_Click(object sender, EventArgs e) {
            if (!aktMail.Text.Length.Equals(0)) {
                var poruka = MessageBox.Show("Da li ste sigurni da želite da obrišete mejl "
                                 + aktMail.Text + "?", "Brisanje e-mail adrese", MessageBoxButtons.YesNo);
                
                if (poruka == DialogResult.Yes) {
                    EMailAktiviste mail = odabrani.email.Single(m => m.eMail == aktMail.Text);
                    obrisi<EMailAktiviste>(mail.IDEmail);

                    aktMail.Items.Remove(aktMail.Text);
                    aktMail.Text = "";
                }
            }
        }
        private void btnAddTelefon_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();
            try
            {
                if (!aktTelefon.Text.Length.Equals(0))
                {
                    aktTelefon.Items.Add(aktTelefon.Text);

                    BrTel tel = new BrTel();
                    tel.Aktivista = odabrani;
                    tel.BrojTel = aktTelefon.Text;

                    aktTelefon.Text = "";

                    s.Save(tel);
                }
            }
            finally
            {
                s.Close();
            }
        }
        private void btnRemoveTelefon_Click(object sender, EventArgs e) {
            if (!aktTelefon.Text.Length.Equals(0)) {
                var poruka = MessageBox.Show("Da li ste sigurni da želite da obrišete telefon "
                                 + aktTelefon.Text + "?", "Brisanje telefona", MessageBoxButtons.YesNo);

                if (poruka == DialogResult.Yes) {
                    BrTel tel = odabrani.brTel.Single(t => t.BrojTel == aktTelefon.Text);
                    obrisi<BrTel>(tel.IDBr);

                    aktTelefon.Items.Remove(aktTelefon.Text);
                    aktTelefon.Text = "";
                }
            }
        }
        private void koordDodajP_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();

            try
            {
                int brPomoc = s.QueryOver<Aktivista>().Where(k => k.koord == odabrani).RowCount();
                
                if (brPomoc == 4)
                {
                    MessageBox.Show("Koordinator već ima 4 saradnika. Obrišite nekog kako biste dodali novog.", "Puno saradnika");
                }
                else
                {
                    DodajPomoc f = new DodajPomoc(typeof(Aktivista));
                    f.ShowDialog(this);
                }
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
        private void koordObrisiP_Click(object sender, EventArgs e) {
            if (!koorPomoc.Text.Length.Equals(0)) {
                Aktivista akt = ((Koordinator)odabrani).Saradnici
                                .Single(p => (p.Ime + " " + p.Prezime) == koorPomoc.Text);
                var poruka = MessageBox.Show(
                            string.Format("Da li ste sigurni da Da li ste sigurni da želite da obrišete " +
                            "{0} {1} iz liste saradnika?",
                            akt.Ime, akt.Prezime), "Brisanje saradnika", MessageBoxButtons.YesNo);

                if (poruka == DialogResult.Yes) {
                    ISession s = DataLayer.GetSession();
                    try {
                        akt.koord = null;
                        s.SaveOrUpdate(akt);
                        s.Flush();
                        s.Close();

                        koorPomoc.Items.Remove(koorPomoc.Text);
                        koorPomoc.Text = "";
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally
                    {
                        s.Close();
                    }
                }
            }
        }
        private void jeKoord_Click(object sender, EventArgs e) {
            ISession s = DataLayer.GetSession();
            try
            {
                if (jeKoord.Checked)
                {
                    Koordinator koord = new Koordinator();

                    string q = "insert into Koordinator (idakt) values (:id)";
                    s.CreateSQLQuery(q).SetParameter("id", odabrani.ID).ExecuteUpdate();
                    osveziPolja(odabrani.ID);
                }
                else
                {
                    foreach (var a in ((Koordinator)odabrani).Saradnici)
                    {
                        a.koord = null;
                        s.SaveOrUpdate(a);
                    }
                    s.Flush();
                    string q = "delete from Koordinator where idakt=:id";
                    s.CreateSQLQuery(q).SetParameter("id", odabrani.ID).ExecuteUpdate();
                    osveziPolja(odabrani.ID);
                }
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
        private void aktAzuriraj_Click(object sender, EventArgs e)
        {
            var tekstBs = GetAll(this.tabControl1.SelectedTab, typeof(TextBox));
            foreach (var t in tekstBs)
            {
                string tIme = t.Name;
                string propIme;
                if (tIme.Contains("akt"))
                {
                    propIme = t.Name.Substring(3);
                }
                else if (tIme.Contains("koor") && jeKoord.Checked)
                {
                    propIme = t.Name.Substring(4);
                }
                else
                {
                    continue;
                }
                try
                {
                    odabrani.GetType().GetProperty(propIme).SetValue(odabrani, t.Text);
                }
                catch (ArgumentException ex)
                {
                    odabrani.GetType().GetProperty(propIme).SetValue(odabrani, Int32.Parse(t.Text));
                }
            }
            ISession s = DataLayer.GetSession();
            try
            {
                s.SaveOrUpdate(odabrani);
                s.Flush();
            }
            finally
            {
                s.Close();
            }
            aktivisti.Single(a => a.ID == odabrani.ID).Ime = odabrani.Ime;
            aktivisti.Single(a => a.ID == odabrani.ID).Prezime = odabrani.Prezime;
            aktivisti.Single(a => a.ID == odabrani.ID).ImeRod = odabrani.ImeRod;

            azurElListe(lvAkt, aktivisti, odabrani.ID);
        }
        private void azurElListe(ListView lista, List<Aktivista> inL, int id)
            //funkcija za azuriranje jednog aktiviste
        {
            lista.Select();
            int indOdab = inL.FindIndex(ak => ak.ID == id);
            try
            {
            lista.Items[indOdab].Selected = true;
            lista.Items[indOdab].SubItems[1].Text = inL[indOdab].Ime;
            lista.Items[indOdab].SubItems[2].Text = inL[indOdab].Prezime;
            lista.Items[indOdab].SubItems[3].Text = inL[indOdab].ImeRod;
        }
            catch (Exception e)
            {
                ListViewItem item = new ListViewItem(inL[indOdab].ID.ToString());
                item.SubItems.Add(inL[indOdab].Ime);
                item.SubItems.Add(inL[indOdab].ImeRod);
                item.SubItems.Add(inL[indOdab].Prezime);
                lista.Items.Add(item);
                lista.Items[indOdab].Selected = true;
            }

        }
        private void azurElListe(ListView lista, List<GlasackoMesto> inL, int id)
        {
            lista.Select();
            int indOdab = inL.FindIndex(ak => ak.ID == id);
            try
            {
                lista.Items[indOdab].Selected = true;
                lista.Items[indOdab].SubItems[0].Text = inL[indOdab].Naziv;
                lista.Items[indOdab].SubItems[1].Text = inL[indOdab].BrojGM.ToString();
                lista.Items[indOdab].SubItems[2].Text = inL[indOdab].BrojRegBir.ToString();
            }
            catch (Exception e)
            {
                ListViewItem item = new ListViewItem(inL[indOdab].Naziv);
                item.SubItems.Add(inL[indOdab].BrojGM.ToString());
                item.SubItems.Add(inL[indOdab].BrojRegBir.ToString());
                lista.Items.Add(item);
                lista.Items[indOdab].Selected = true;
            }

        }
        private void obrisiElListe(ListView lista, List<Aktivista> inL, int id)
        {
            int indOdab = inL.FindIndex(ak => ak.ID == id);
            lista.Items[indOdab].Remove();
        }
        public IEnumerable<Control> GetAll(Control control, Type type) //http://stackoverflow.com/questions/3419159/how-to-get-all-child-controls-of-a-windows-forms-form-of-a-specific-type-button
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void setEnable(IEnumerable<Control> cList, bool flag)
        {
            foreach (var c in cList)
            {
                c.Enabled = flag;
            }
        }
        private void clearCtrl(IEnumerable<Control> cList)
        {
            foreach (var c in cList)
            {
                c.Text = "";
                if (c.GetType() == typeof(ComboBox)) //666!
                {
                    ((ComboBox)c).Items.Clear();
                }
            }
        }
        private void resetujPolja(Control ctrl)
        {
            var tb = GetAll(this.tabControl1.SelectedTab, typeof(TextBox));
            var cb = GetAll(this.tabControl1.SelectedTab, typeof(ComboBox));
            clearCtrl(tb);
            clearCtrl(cb);
            jeKoord.Enabled = true;
            jeKoord.Checked = false;
            tb = tb.Where(t => t.Name.Contains("koor"));
            setEnable(tb, false);
            cb = cb.Where(c => c.Name.Contains("koor"));
            setEnable(cb, false);
            var lab = GetAll(this.tabControl1.SelectedTab, typeof(Label)).Where(l => l.Name.Contains("koor"));
            setEnable(lab, false);
        }        
        private void aktObrisi_Click(object sender, EventArgs e) {
            if (odabrani != null) {
                var odg = MessageBox.Show(String.Format("Da li ste sigurni da želite da obrišete aktivistu {0} {1}",
                                            odabrani.Ime, odabrani.Prezime), "Brisanje aktiviste", MessageBoxButtons.YesNo);
                if (odg == DialogResult.Yes)
                {
                    ISession s = DataLayer.GetSession();
                    try
                    {
                        if (jeKoord.Checked)
                        {
                            foreach (var a in aktivisti.Where(a => a.koord == odabrani))
                            {
                                a.koord = null;
                                s.SaveOrUpdate(a);
                            }
                            s.Flush();
                        }
                        obrisi<Aktivista>(odabrani.ID);
                        s.Flush();
                        resetujPolja(this);
                        obrisiElListe(lvAkt, aktivisti, odabrani.ID);
                        aktivisti = aktivisti.Where(a => a.ID != odabrani.ID).ToList();
                        odabrani = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { s.Close(); }
                }   
            }
        }
        public void postaviKolonePropListe(Type tip) {
            propagandaListView.Columns.Clear();
            propagandaListView.Columns.Add("ID");
            if (tip == typeof(NovineReklama)) {
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
                propLblMod2.Text = "Broj Ponavljanja:";
                propLblMod3.Text = "";
                clearAllPropTxt();
                propCBUBoji.Visible = false;
                propTxtMod1.Visible = true;
                propTxtMod2.Visible = true;
                propTxtMod3.Visible = false;
            }
        }
        public void propDodajJedanItem(Type tip, Reklama rek) {
            if (rek.GetType() == tip) {
                ListViewItem item = new ListViewItem(rek.ID.ToString());
            if (rek.GetType() == typeof(NovineReklama)) {
                item.SubItems.Add(((NovineReklama)rek).NazivLista);
                item.SubItems.Add((((NovineReklama)rek).Uboji == 1) ? "da" : "ne");
                    }
            if (rek.GetType() == typeof(PanoReklama)) {
                item.SubItems.Add(((PanoReklama)rek).Grad);
                item.SubItems.Add(((PanoReklama)rek).Ulica);
                item.SubItems.Add(((PanoReklama)rek).Vlasnik);
                item.SubItems.Add(((PanoReklama)rek).Povrsina.ToString());
                    }
            if (rek.GetType() == typeof(TVRadioReklama)) {
                item.SubItems.Add(((TVRadioReklama)rek).NazivStanice);
                item.SubItems.Add(((TVRadioReklama)rek).Trajanje.ToString());
                item.SubItems.Add(((TVRadioReklama)rek).BrojPonavljanja.ToString());
                    }
            item.SubItems.Add(rek.CenaZakupa.ToString());
            item.SubItems.Add(String.Format("{0:d/M/yyyy}", rek.DatumZakupa));
            item.SubItems.Add(rek.TrajanjeZakupa.ToString());
                    propagandaListView.Items.Add(item);
                }
            }
        public void osveziPropListu(Type tip, IList<Reklama> rek) {
            propagandaListView.BeginUpdate();
            propagandaListView.Items.Clear();
            postaviKolonePropListe(tip);
            foreach (var i in rek) {
                propDodajJedanItem(tip, i);
            }
            postaviSirinuSvihKolona(propagandaListView);
            propagandaListView.EndUpdate();
        }
        private void propRBNovine_CheckedChanged(object sender, EventArgs e) {
            osveziPropListu(typeof(NovineReklama), reklame);
            osveziTipPropKontrola(typeof(NovineReklama));
            clearOdabranaReklamaAndOptions();
        }
        private void propRBPano_CheckedChanged(object sender, EventArgs e) {
            osveziPropListu(typeof(PanoReklama), reklame);
            osveziTipPropKontrola(typeof(PanoReklama));
            clearOdabranaReklamaAndOptions();
        }
        private void propRBTVRad_CheckedChanged(object sender, EventArgs e) {
            osveziPropListu(typeof(TVRadioReklama), reklame);
            osveziTipPropKontrola(typeof(TVRadioReklama));
            clearOdabranaReklamaAndOptions();
        }
        public void clearOdabranaReklamaAndOptions() {
            odabranaReklama = null;
            propBtnAzur.Enabled = false;
            propBtnObrisi.Enabled = false;
            propTxtCenaZakupa.Text = propTxtTrajanjeZakupa.Text = propTxtMod0.Text = propTxtMod1.Text = propTxtMod2.Text = propTxtMod3.Text = "";
            propCBUBoji.Checked = false;
            propClndDatumZakupa.Refresh();
        }
        private void propagandaListView_SelectedIndexChanged(object sender, System.EventArgs e) {
            DateTime tmpDT;
            int tmpInt;
            if(propagandaListView.SelectedItems.Count == 0) {
                clearOdabranaReklamaAndOptions();
            }
            else {
                propBtnAzur.Enabled = true;
                propBtnObrisi.Enabled = true;
            }
            if (propRBNovine.Checked) {
                ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in odabr) {

                    propTxtMod0.Text = item.SubItems[1].Text;
                    propCBUBoji.Checked = (item.SubItems[2].Text == "da");                   
                    propTxtCenaZakupa.Text = item.SubItems[3].Text;               
                    if (DateTime.TryParse(item.SubItems[4].Text, out tmpDT) && int.TryParse(item.SubItems[5].Text, out tmpInt)) {
                        propClndDatumZakupa.SelectionRange = new SelectionRange(tmpDT, tmpDT.AddDays(tmpInt));
                    }
                    propTxtTrajanjeZakupa.Text = item.SubItems[5].Text;

                    odabranaReklama = new NovineReklama();
                    odabranaReklama.ID = Convert.ToInt32(item.SubItems[0].Text);
                    ((NovineReklama)odabranaReklama).NazivLista = item.SubItems[1].Text;
                    ((NovineReklama)odabranaReklama).Uboji = (item.SubItems[2].Text == "da") ? 1 : 0;
                    odabranaReklama.CenaZakupa = Convert.ToInt32(item.SubItems[3].Text);
                    odabranaReklama.DatumZakupa = Convert.ToDateTime(item.SubItems[4].Text);
                    odabranaReklama.TrajanjeZakupa = Convert.ToInt32(item.SubItems[5].Text);
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
                    if (DateTime.TryParse(item.SubItems[6].Text, out tmpDT) && int.TryParse(item.SubItems[7].Text, out tmpInt)) {
                        propClndDatumZakupa.SelectionRange = new SelectionRange(tmpDT, tmpDT.AddDays(tmpInt));
                    }
                    propTxtTrajanjeZakupa.Text = item.SubItems[7].Text;

                    odabranaReklama = new PanoReklama();
                    odabranaReklama.ID = Convert.ToInt32(item.SubItems[0].Text);
                    ((PanoReklama)odabranaReklama).Grad = item.SubItems[1].Text;
                    ((PanoReklama)odabranaReklama).Ulica = item.SubItems[2].Text;
                    ((PanoReklama)odabranaReklama).Vlasnik = item.SubItems[3].Text;
                    double tmpValPov;
                    if (double.TryParse(item.SubItems[4].Text, out tmpValPov)) {
                        ((PanoReklama)odabranaReklama).Povrsina = Convert.ToDouble(item.SubItems[4].Text);
                    }
                    odabranaReklama.CenaZakupa = Convert.ToInt32(item.SubItems[5].Text);
                    odabranaReklama.DatumZakupa = Convert.ToDateTime(item.SubItems[6].Text);
                    odabranaReklama.TrajanjeZakupa = Convert.ToInt32(item.SubItems[7].Text);
                }
            }
            if (propRBTVRad.Checked) {
                ListView.SelectedListViewItemCollection odabr = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in odabr) {
                    propTxtMod0.Text = item.SubItems[1].Text;
                    propTxtMod1.Text = item.SubItems[2].Text;
                    propTxtMod2.Text = item.SubItems[3].Text;
                    propTxtCenaZakupa.Text = item.SubItems[4].Text;
                    if (DateTime.TryParse(item.SubItems[5].Text, out tmpDT) && int.TryParse(item.SubItems[6].Text, out tmpInt)) {
                        propClndDatumZakupa.SelectionRange = new SelectionRange(tmpDT, tmpDT.AddDays(tmpInt));
                    }
                    propTxtTrajanjeZakupa.Text = item.SubItems[6].Text;

                    odabranaReklama = new TVRadioReklama();
                    odabranaReklama.ID = Convert.ToInt32(item.SubItems[0].Text);
                    ((TVRadioReklama)odabranaReklama).NazivStanice = item.SubItems[1].Text;
                    int tmpVal;
                    if (int.TryParse(item.SubItems[2].Text, out tmpVal)) {
                        ((TVRadioReklama)odabranaReklama).BrojPonavljanja = Convert.ToInt32(item.SubItems[2].Text);
                    }
                    if (int.TryParse(item.SubItems[3].Text, out tmpVal)) {
                        ((TVRadioReklama)odabranaReklama).Trajanje = Convert.ToInt32(item.SubItems[3].Text);
                    }
                    odabranaReklama.CenaZakupa = Convert.ToInt32(item.SubItems[4].Text);
                    odabranaReklama.DatumZakupa = Convert.ToDateTime(item.SubItems[5].Text);
                    odabranaReklama.TrajanjeZakupa = Convert.ToInt32(item.SubItems[6].Text);
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
                cbProtivKandidati.Visible = true;
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
                cbProtivKandidati.Enabled = true;
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
                cbProtivKandidati.Enabled = false;
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
            cbProtivKandidati.Visible = false;
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

                odabraniDuel = new TVDuel();
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
                        cbPitanje.Items.Clear();
                        cbProtivKandidati.Items.Clear();

                        foreach (PitanjaTVDuel x in odabraniDuel.Pitanja)
                        {
                            cbPitanje.Items.Add(x.Tekst);
                        }

                        foreach (ProtivKandidatiTVDuel x in odabraniDuel.ProtivKandidati)
                        {
                            cbProtivKandidati.Items.Add(x.ImePK);
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
                    ISession s = DataLayer.GetSession();
                    try
                    {
                        odabranoGostovanje = s.Load<TVRadioGost>(int.Parse(item.SubItems[0].Text));
                    }
                    finally
                    {
                        s.Close();
            }
                }
            }
            else if (rBtnNovine.Checked)
            {
                ListView.SelectedListViewItemCollection izabrani = ((ListView)sender).SelectedItems;
                foreach (ListViewItem item in izabrani)
                {
                    tbNazivLista.Text = item.SubItems[1].Text;
                    calObjavljivanja.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[2].Text), Convert.ToDateTime(item.SubItems[2].Text));//TODOR
                    calIntervjua.SelectionRange = new SelectionRange(Convert.ToDateTime(item.SubItems[3].Text), Convert.ToDateTime(item.SubItems[3].Text));

                    ISession s = DataLayer.GetSession();
                    try
                    {
                        odabraniIntervju = s.Load<IntervjuNovine>(int.Parse(item.SubItems[0].Text));
                        cbNovinari.Items.Clear();
                        
                        foreach (NovinariIzNovina x in odabraniIntervju.NovinariIzNovina)
                        {
                            cbNovinari.Items.Add(x.ImeNovinara);
                        }
                    }
                    finally
                    {
                        s.Close();
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e) {
            if (odabranaReklama != null) {
                ISession s = DataLayer.GetSession();
                try {
                    int tmpID = odabranaReklama.ID;
                    string q = "delete from Reklama where id=:id";
                    s.CreateSQLQuery(q).SetParameter("id", odabranaReklama.ID).ExecuteUpdate();
                    
                    propagandaListView.Items.RemoveAt(findRekIndexWithID(tmpID));
                    reklame.RemoveAt(findRekIndexWithID(tmpID));
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally{
                    s.Close();
                }
            }
        }
        public int findRekIndexWithID(int id) {
            int index = 0;
            for (int i = 0; i < propagandaListView.Items.Count; i++) {
                if((Convert.ToInt32(propagandaListView.Items[i].SubItems[0].Text)) == id) {
                    index = propagandaListView.Items[i].Index;
                    break;
                }
                
            }
            return index;
        }
        public void azurElPropListe() {
            propagandaListView.Select();
            int indOdab = findRekIndexWithID(odabranaReklama.ID);
            if (propRBNovine.Checked) {
                propagandaListView.Items[indOdab].SubItems[1].Text = ((NovineReklama)odabranaReklama).NazivLista;
                propagandaListView.Items[indOdab].SubItems[2].Text = (((NovineReklama)odabranaReklama).Uboji == 1) ? "da" : "ne";
                propagandaListView.Items[indOdab].SubItems[3].Text = odabranaReklama.CenaZakupa.ToString();
                propagandaListView.Items[indOdab].SubItems[4].Text = String.Format("{0:d/M/yyyy}", odabranaReklama.DatumZakupa);
                propagandaListView.Items[indOdab].SubItems[5].Text = odabranaReklama.TrajanjeZakupa.ToString();
            }
            if (propRBPano.Checked) {
                ((PanoReklama)odabranaReklama).Grad = propTxtMod0.Text;
                ((PanoReklama)odabranaReklama).Ulica = propTxtMod1.Text;
                ((PanoReklama)odabranaReklama).Vlasnik = propTxtMod2.Text;
                ((PanoReklama)odabranaReklama).Povrsina = Convert.ToDouble(propTxtMod3.Text);
                propagandaListView.Items[indOdab].SubItems[1].Text = ((PanoReklama)odabranaReklama).Grad;
                propagandaListView.Items[indOdab].SubItems[2].Text = ((PanoReklama)odabranaReklama).Ulica;
                propagandaListView.Items[indOdab].SubItems[3].Text = ((PanoReklama)odabranaReklama).Vlasnik;
                propagandaListView.Items[indOdab].SubItems[4].Text = ((PanoReklama)odabranaReklama).Povrsina.ToString();
                propagandaListView.Items[indOdab].SubItems[5].Text = odabranaReklama.CenaZakupa.ToString();
                propagandaListView.Items[indOdab].SubItems[6].Text = String.Format("{0:d/M/yyyy}", odabranaReklama.DatumZakupa);
                propagandaListView.Items[indOdab].SubItems[7].Text = odabranaReklama.TrajanjeZakupa.ToString();
            }
            if (propRBTVRad.Checked) {
                ((TVRadioReklama)odabranaReklama).NazivStanice = propTxtMod0.Text;
                ((TVRadioReklama)odabranaReklama).BrojPonavljanja = Convert.ToInt32(propTxtMod1.Text);
                ((TVRadioReklama)odabranaReklama).Trajanje = Convert.ToInt32(propTxtMod2.Text);
                propagandaListView.Items[indOdab].SubItems[1].Text = ((TVRadioReklama)odabranaReklama).NazivStanice;
                propagandaListView.Items[indOdab].SubItems[2].Text = ((TVRadioReklama)odabranaReklama).Trajanje.ToString();
                propagandaListView.Items[indOdab].SubItems[3].Text = ((TVRadioReklama)odabranaReklama).BrojPonavljanja.ToString();
                propagandaListView.Items[indOdab].SubItems[4].Text = odabranaReklama.CenaZakupa.ToString();
                propagandaListView.Items[indOdab].SubItems[5].Text = String.Format("{0:d/M/yyyy}", odabranaReklama.DatumZakupa);
                propagandaListView.Items[indOdab].SubItems[6].Text = odabranaReklama.TrajanjeZakupa.ToString();
            }
        }
        private void button13_Click(object sender, EventArgs e) {
            if(propagandaListView.SelectedItems != null) { 
            if (propRBNovine.Checked) {
                ((NovineReklama)odabranaReklama).NazivLista = propTxtMod0.Text;
                ((NovineReklama)odabranaReklama).Uboji = propCBUBoji.Checked ? 1 : 0;
                odabranaReklama.CenaZakupa = Convert.ToInt32(propTxtCenaZakupa.Text);
                odabranaReklama.DatumZakupa = propClndDatumZakupa.SelectionStart;
                odabranaReklama.TrajanjeZakupa = Convert.ToInt32(propTxtTrajanjeZakupa.Text);
            }
            if (propRBPano.Checked) {
                ((PanoReklama)odabranaReklama).Grad = propTxtMod0.Text;
                ((PanoReklama)odabranaReklama).Ulica = propTxtMod1.Text;
                ((PanoReklama)odabranaReklama).Vlasnik = propTxtMod2.Text;
                ((PanoReklama)odabranaReklama).Povrsina = Convert.ToDouble(propTxtMod3.Text);
                odabranaReklama.CenaZakupa = Convert.ToInt32(propTxtCenaZakupa.Text);
                odabranaReklama.DatumZakupa = propClndDatumZakupa.SelectionStart;
                odabranaReklama.TrajanjeZakupa = Convert.ToInt32(propTxtTrajanjeZakupa.Text);
            }
            if (propRBTVRad.Checked) {
                ((TVRadioReklama)odabranaReklama).NazivStanice = propTxtMod0.Text;
                ((TVRadioReklama)odabranaReklama).Trajanje = Convert.ToInt32(propTxtMod1.Text);
                ((TVRadioReklama)odabranaReklama).BrojPonavljanja = Convert.ToInt32(propTxtMod2.Text);
                odabranaReklama.CenaZakupa = Convert.ToInt32(propTxtCenaZakupa.Text);
                odabranaReklama.DatumZakupa = propClndDatumZakupa.SelectionStart;
                odabranaReklama.TrajanjeZakupa = Convert.ToInt32(propTxtTrajanjeZakupa.Text);
                }
            ISession s = DataLayer.GetSession();
            try
            {
                s.SaveOrUpdate(odabranaReklama);
                s.Flush();
            }
            finally
            {
                s.Close();
            }           
            
            azurElPropListe();
            }
        }
        private bool proveriAzur(Control c)
        {
            var tBs = GetAll(this.tabControl1.SelectedTab, typeof(TextBox));

            foreach (var tb in tBs)
            {
                string name = tb.Name;
                string prop;

                if (name.Contains("koor") && jeKoord.Checked)
                {
                    prop = name.Substring(4);
                }
                else if (name.Contains("akt"))
                {
                    prop = name.Substring(3);
                }
                else
                {
                    continue;
                }
                var odVal = odabrani.GetType().GetProperty(prop).GetValue(odabrani);
                if (odVal.ToString() != tb.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private bool proveriAzurGM(Control C)
        {
            var tbS = GetAll(tabControl1.SelectedTab, typeof(TextBox));

            foreach (var tb in tbS)
            {
                string name = tb.Name.Substring(2);
                var oGMVal = oGM.GetType().GetProperty(name).GetValue(oGM);
                if (oGMVal.ToString() != tb.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (odabrani != null)
            {
                if (proveriAzur(this))
                {
                    var btn = MessageBox.Show("Da li prvo želite da sačuvate aktivistu?",
                        "Rad u toku", MessageBoxButtons.YesNo);
                    if (btn == DialogResult.Yes)
                    {
                        aktAzuriraj_Click(sender, e);
                    }
                }
                resetujPolja(this);
            }

            ImePrezime f = new ImePrezime();
            f.ShowDialog(this);
            if (odabrani != null)
            {
                azurElListe(lvAkt, aktivisti, odabrani.ID);
                osveziPolja(odabrani.ID);
            }
        }
        private void novoGM_Click(object sender, EventArgs e)
        {
            NovoGlasackoMesto f = new NovoGlasackoMesto();
            f.ShowDialog(this);
            osveziGM(oGM.ID);
            azurElListe(lvGM, gmesta, oGM.ID);
        }
        private void btnAzurGM_Click(object sender, EventArgs e)
        {
            if (oGM != null && proveriAzurGM(this))
            {
                var tBs = GetAll(this.tabControl1.SelectedTab, typeof(TextBox));
                foreach (var t in tBs)
                {
                    string name = t.Name.Substring(2);
                    try
                    {
                        oGM.GetType().GetProperty(name).SetValue(oGM, t.Text);
                    }
                    catch (Exception ex)
                    {
                        oGM.GetType().GetProperty(name).SetValue(oGM, Int32.Parse(t.Text));
                    }
                }
                ISession s = DataLayer.GetSession();
                try
                {
                    s.SaveOrUpdate(oGM);
                    s.Flush();                    

                    gmesta.Single(g => g.ID == oGM.ID).Naziv = oGM.Naziv;
                    gmesta.Single(g => g.ID == oGM.ID).BrojGM = oGM.BrojGM;
                    gmesta.Single(g => g.ID == oGM.ID).BrojRegBir = oGM.BrojRegBir;
                    azurElListe(lvGM, gmesta, oGM.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    s.Close();
                }
            } else if (oGM == null)
            {
                MessageBox.Show("Morade odabrati barem jedno glasačko mesto.", "Greška");
            }
        }
        private void rezIzb_Click(object sender, EventArgs e)
        {
            if (oGM != null)
            {
                NoviRezultatIzbora f = new NoviRezultatIzbora();
                f.ShowDialog(this);
                osveziGM(oGM.ID); 
            } else
            {
                MessageBox.Show("Morate odabrati barem jedno glasačko mesto.", "Greška");
            }
        }
        private void dodajAktGM_Click(object sender, EventArgs e)
        {
            if (oGM != null)
            {
                DodajPomoc f = new DodajPomoc(typeof(GlasackoMesto));
                f.ShowDialog(this);
            } else
            {
                MessageBox.Show("Morate odabrati barem jedno glasačko mesto.", "Greška");
            }
        }

        private void btnAddGostovanje_Click(object sender, EventArgs e)
        {
            if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Checked)//za TVDuel
            {
                var form = new NovoPojPKTVDuel();
                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dueli.Add(form.RetValPoj);
                    RefreshMladensTables();
                    int indeks = 0;
                    foreach (ListViewItem item in listaPojavljivanja.Items)
                    {
                        if (item.SubItems[0].Text == form.RetValPoj.ID.ToString())
                            listaPojavljivanja.Items[indeks].Selected = true;
                        else
                            ++indeks;
                    }

                    listaPojavljivanja.Select();
                }
            }
            else if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Unchecked)//za TVRadioGost
            {
                var form = new NovoPojPKTVRadio();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    gostovanja.Add(form.RetValPoj);
                    RefreshMladensTables();
                    int indeks = 0;
                    foreach (ListViewItem item in listaPojavljivanja.Items)
                    {
                        if (item.SubItems[0].Text == form.RetValPoj.ID.ToString())
                            listaPojavljivanja.Items[indeks].Selected = true;
                        else
                            ++indeks;
                    }

                    listaPojavljivanja.Select();
                }
            }
            else if (rBtnNovine.Checked) //za IntervjuNovine
            {
                var form = new NovoPojPKNovine();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    intervjui.Add(form.RetValPoj);
                    RefreshMladensTables();
                    int indeks = 0;
                    foreach (ListViewItem item in listaPojavljivanja.Items)
                    {
                        if (item.SubItems[0].Text == form.RetValPoj.ID.ToString())
                            listaPojavljivanja.Items[indeks].Selected = true;
                        else
                            ++indeks;
                    }

                    listaPojavljivanja.Select();
                }
            }
        }
        private void btnDodajNovinara_Click(object sender, EventArgs e)
        {
            if (!cbNovinari.Text.Length.Equals(0))
            {
                cbNovinari.Items.Add(cbNovinari.Text);
                ISession s = DataLayer.GetSession();
                try
                {
                    var novinar = new NovinariIzNovina
                    {
                        IDIntervjua = odabraniIntervju,
                        ImeNovinara = cbNovinari.Text
                    };
                    s.SaveOrUpdate(novinar);
                    s.Flush();
                }
                finally
                {
                    s.Close();
                    cbNovinari.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }
        private void btnUkloniNovinara_Click(object sender, EventArgs e)
        {
            if (!cbPitanje.Text.Length.Equals(0))
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete novinara: \"" + cbNovinari.Text + "\"?",
                                "Brisanje novinara", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NovinariIzNovina novinar = odabraniIntervju.NovinariIzNovina.Single(t => t.ImeNovinara == cbNovinari.Text);
                    obrisi<NovinariIzNovina>(novinar.IDNovinara);

                    cbNovinari.Items.Remove(cbNovinari.Text);
                    cbNovinari.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }        
        private void btnDodajProtivkandidata_Click(object sender, EventArgs e)
        {
            if (!cbProtivKandidati.Text.Length.Equals(0))
            {
                cbProtivKandidati.Items.Add(cbProtivKandidati.Text);
                ISession s = DataLayer.GetSession();
                try
                {
                    var pk = new ProtivKandidatiTVDuel
                    {
                        IDDuela = odabraniDuel,
                        ImePK = cbProtivKandidati.Text
                    };
                    s.SaveOrUpdate(pk);
                    s.Flush();
                }
                finally
                {
                    s.Close();
                    cbProtivKandidati.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }
        private void tbProcenjenaGledanost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }
        private void btnUkloniProtivkandidata_Click(object sender, EventArgs e)
        {
            if (!cbProtivKandidati.Text.Length.Equals(0))
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete protivkandidata: \"" + cbProtivKandidati.Text + "\"?",
                                 "Brisanje protivkandidata", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ProtivKandidatiTVDuel pk = odabraniDuel.ProtivKandidati.Single(t => t.ImePK == cbProtivKandidati.Text);
                    obrisi<ProtivKandidatiTVDuel>(pk.ID);

                    cbProtivKandidati.Items.Remove(cbProtivKandidati.Text);
                    cbProtivKandidati.Text = "";                    
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }        
        private void btnUkloniPitanje_Click(object sender, EventArgs e)
        {
            if (!cbPitanje.Text.Length.Equals(0))
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrano pitanje?",
                                 "Brisanje pitanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PitanjaTVDuel pitanje = odabraniDuel.Pitanja.Single(t => t.Tekst == cbPitanje.Text);
                    obrisi<PitanjaTVDuel>(pitanje.ID);

                    cbPitanje.Items.Remove(cbPitanje.Text);
                    cbPitanje.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }
        private void btnDodajPitanje_Click(object sender, EventArgs e)
        {
            if (!cbPitanje.Text.Length.Equals(0))
            {
                cbPitanje.Items.Add(cbPitanje.Text);
                ISession s = DataLayer.GetSession();
                try
                {
                    var pitanje = new PitanjaTVDuel
                    {
                        IDDuela = odabraniDuel,
                        Tekst = cbPitanje.Text
                    };
                    s.SaveOrUpdate(pitanje);
                    s.Flush();
                }
                finally
                {
                    s.Close();
                    cbPitanje.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }        
        private void btnUpdateGostovanje_Click(object sender, EventArgs e)
        {
            if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Checked)//za TVDuel
            {
                UpdatePojTVDuel();
            }
            else if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Unchecked)//za TVRadioGost
            {
                UpdatePojTVRadio();
            }
            else if (rBtnNovine.Checked) //za IntervjuNovine
            {
                UpdatePojNovine();
            }
        }
        private void UpdatePojTVDuel()
        {
            if (MessageBox.Show("Da li ste sigurni da želite da izmenite izabrani TV Duel?",
                "Ažuriranje TV Duela", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                
                ISession s = DataLayer.GetSession();
                try
                {
                    odabraniDuel.Gledanost = int.Parse(tbProcenjenaGledanost.Text);
                    odabraniDuel.ImeVoditelja = tbImeVoditelja.Text;
                    odabraniDuel.NazivEmisije = tbNazivEmisije.Text;
                    odabraniDuel.NazivStanice = tbNazivStanice.Text;

                    s.SaveOrUpdate(odabraniDuel);
                    s.Flush();
                }
                finally
                {
                    s.Close();                    
                    RefreshMladensTables();
                }
            }
        }
        private void UpdatePojTVRadio()
        {
            if (MessageBox.Show("Da li ste sigurni da želite da izmenite izabrano gostovanje?",
                "Ažuriranje gostovanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ISession s = DataLayer.GetSession();
                try
                {
                    odabranoGostovanje.Gledanost = int.Parse(tbProcenjenaGledanost.Text);
                    odabranoGostovanje.ImeVoditelja = tbImeVoditelja.Text;
                    odabranoGostovanje.NazivEmisije = tbNazivEmisije.Text;
                    odabranoGostovanje.NazivStanice = tbNazivStanice.Text;

                    s.SaveOrUpdate(odabranoGostovanje);

                    s.Flush();
                }
                finally
                {
                    s.Close();
                    RefreshMladensTables();///TODOR
                }
            }
        }
        private void UpdatePojNovine()
        {
            if (MessageBox.Show("Da li ste sigurni da želite da izmenite izabrani TV Duel?",
                "Ažuriranje TV Duela", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (calIntervjua.SelectionRange.Start > calObjavljivanja.SelectionRange.Start)
                {
                    MessageBox.Show("Datum intervjua ne sme biti posle datuma objavljivanja!", "Greška!");
                    return;
                }
                ISession s = DataLayer.GetSession();
                try
                {
                    odabraniIntervju.NazivLista = tbNazivLista.Text;
                    odabraniIntervju.DatumIntervjua = calIntervjua.SelectionRange.Start.Date;
                    odabraniIntervju.DatumObjavljivanja = calObjavljivanja.SelectionRange.Start.Date;
                    
                    s.SaveOrUpdate(odabraniIntervju);

                    s.Flush();
                }
                finally
                {
                    s.Close();
                    RefreshMladensTables();
                }
            }
        }
        private void btnRemoveGostovanje_Click(object sender, EventArgs e)
        {
            if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Checked)//za TVDuel
            {
                RemovePojTVDuel();
            }
            else if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Unchecked)//za TVRadioGost
            {
                RemovePojTVRadio();
            }
            else if (rBtnNovine.Checked) //za IntervjuNovine
            {
                RemovePojNovine();
            }
        }
        private void RemovePojTVDuel()
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrani TV Duel?",
                "Brisanje TV Duela", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obrisi<TVDuel>(odabraniDuel.ID);

                listaPojavljivanja.Items.RemoveAt(dueli.FindIndex(x => x.ID == odabraniDuel.ID));
                dueli.Remove(dueli.Find(x => x.ID == odabraniDuel.ID));

                RefreshMladensTables();
                odabraniDuel = null;
            }
        }
        private void RemovePojNovine()
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrani intervju u novinama?",
                "Brisanje intervjua", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obrisi<IntervjuNovine>(odabraniIntervju.ID);

                listaPojavljivanja.Items.RemoveAt(intervjui.FindIndex(x => x.ID == odabraniIntervju.ID));
                intervjui.Remove(intervjui.Find(x => x.ID == odabraniIntervju.ID));

                RefreshMladensTables();
                odabraniIntervju = null;
            }
        }
        private void RemovePojTVRadio()
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrano gostovanje?",
                "Brisanje Gostovanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obrisi<TVRadioGost>(odabranoGostovanje.ID);

                listaPojavljivanja.Items.RemoveAt(gostovanja.FindIndex(x => x.ID == odabranoGostovanje.ID));
                gostovanja.Remove(gostovanja.Find(x => x.ID == odabranoGostovanje.ID));

                RefreshMladensTables();
                odabranoGostovanje = null;
            }
        }
        private void RefreshMladensTables()
        {
            if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Checked)//za TVDuel
            {
                listaPojavljivanja.Items.Clear();
                LoadValues("TV Duel");
            }
            else if (rBtnTVRadio.Checked && chBoxTVDuel.CheckState == CheckState.Unchecked)//za TVRadioGost
            {
                listaPojavljivanja.Items.Clear();
                LoadValues("TV / Radio Gostovanje");
            }
            else if (rBtnNovine.Checked) //za IntervjuNovine
            {
                listaPojavljivanja.Items.Clear();
                LoadValues("Intervju Novine");
            }
        }

        private void propTxtTrajanjeZakupa_TextChanged(object sender, EventArgs e) {
            int broj;
            if (int.TryParse(((TextBox)sender).Text, out broj)) {
                propClndDatumZakupa.SelectionRange = new SelectionRange(
                                                        propClndDatumZakupa.SelectionStart,
                                                        propClndDatumZakupa.SelectionStart.AddDays(broj));
            }
        }
        private void propClndDatumZakupa_DateChanged(object sender, DateRangeEventArgs e) {
            propTxtTrajanjeZakupa.Text = (propClndDatumZakupa.SelectionEnd - propClndDatumZakupa.SelectionStart).Days.ToString();
        }
        private void button11_Click(object sender, EventArgs e) {
            NovaPropaganda nvprop = new NovaPropaganda();
            nvprop.ShowDialog(this);
            if(nvprop.DialogResult == DialogResult.OK) {
                ISession s = DataLayer.GetSession();
                try
                {
                    Reklama rek = s.Load<Reklama>(nvprop.loadedID);
                    ListViewItem item = new ListViewItem(rek.ID.ToString());
                    if (nvprop.rekType == typeof(NovineReklama))
                    {
                        propRBNovine.Checked = true;
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }
                    else if (nvprop.rekType == typeof(PanoReklama))
                    {
                        propRBPano.Checked = true;
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }
                    else if (nvprop.rekType == typeof(TVRadioReklama))
                    {
                        propRBTVRad.Checked = true;
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }

                    osveziPropListu(nvprop.rekType, reklame);
                    reklame.Add(rek);
                    item.SubItems.Add(rek.CenaZakupa.ToString());
                    item.SubItems.Add(String.Format("{0:d/M/yyyy}", rek.DatumZakupa));
                    item.SubItems.Add(rek.TrajanjeZakupa.ToString());
                    propagandaListView.Items.Add(item);

                    osveziTipPropKontrola(nvprop.rekType);
                    clearOdabranaReklamaAndOptions();
                    propagandaListView.Items[findRekIndexWithID(rek.ID)].Selected = true;
                    propagandaListView.Select();
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
        }
        private void mitZatvoreniP_CheckedChanged(object sender, EventArgs e)
        {
            if (mitZatvoreniP.CheckState == CheckState.Checked)
            {
                labCena.Visible = true;
                labIznajm.Visible = true;
                mitIznajmljivac.Visible = true;
                mitCena.Visible = true;
            }
            else if (mitZatvoreniP.CheckState == CheckState.Unchecked)
            {
                labCena.Visible = false;
                labIznajm.Visible = false;
                mitIznajmljivac.Visible = false;
                mitCena.Visible = false;
            }
        }
        private void btnObrGM_Click(object sender, EventArgs e)
        {
            if (oGM != null)
            {
                if(DialogResult.Yes == MessageBox.Show("Da li ste sigurni da želite da obrišete glasačko mesto?",
                                                        "Brisanje glasačko mesta", MessageBoxButtons.YesNo))
                {
                    ISession s = DataLayer.GetSession();
                    try
                    {
                        foreach (var a in s.QueryOver<Aktivista>().Where(a => a.gm == oGM).List())
                        {
                            a.gm = null;
                            s.Flush();
                        }
                        s.Flush();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        s.Close();
                    }
                    obrisi<GlasackoMesto>(oGM.ID);
                    gmesta.Remove(oGM);
                    oGM = null;
                    clearCtrl(GetAll(this.tabControl1.SelectedTab, typeof(TextBox)));
                    clearCtrl(GetAll(this.tabControl1.SelectedTab, typeof(ComboBox)));
                    labAktGM.Text = "";
                    labPK.Text = "";
                    labDK.Text = "";
                    ucitajGM(lvGM, gmesta);
                }
            } else
            {
                MessageBox.Show("Morate odabrati barem jedno glasačko mesto.", "Greška");
            }
        }
        private void btnPrimedbe_Click(object sender, EventArgs e)
        {
            if(oGM != null)
            {
                PrimedbeGM f = new PrimedbeGM();
                f.ShowDialog(this);
            } else
            {
                MessageBox.Show("Morate odabrati barem jedno glasačko mesto.", "Greška");
            }
        }
        private void btnAddAkc_Click(object sender, EventArgs e)
        {
            var form = new DodajAkciju();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                sveAkcije.Add(form.RetValAkc);
                lvAkcije.Items.Clear();
                ucitajAkc(lvAkcije, sveAkcije);
            }
        }

        public Akcija findAkcWith(string naziv, string grad)
        {            
            foreach (Akcija x in sveAkcije)
            {
                if (x.NazivAkcije == naziv && x.Grad == grad)
                    return x;
            }
            return null;
        }
        private void lvAkcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ((ListView)sender).SelectedItems)
            {
                odabranaAkcija = findAkcWith(item.SubItems[0].Text, item.SubItems[1].Text);
            }

            if (odabranaAkcija.GetType() == typeof(DeljenjeLetaka))
            {
                showAkcControls("DeljenjeLetaka");
                loadAkcijaData(odabranaAkcija);
            }
            else if (odabranaAkcija.GetType() == typeof(SusretKandidata))
            {
                showAkcControls("SusretKandidata");
                loadAkcijaData(odabranaAkcija);
            }
            else if (odabranaAkcija.GetType() == typeof(Miting))
            {
                showAkcControls("Miting");
                loadAkcijaData(odabranaAkcija);

                ISession s = DataLayer.GetSession();
                try
                {
                    gosti = (List<Gost>)s.QueryOver<Gost>().Where(x => x.Miting == odabranaAkcija).OrderBy(p => p.ID_GOST).Asc.List();
                    ucitajGoste(lvGosti, gosti);
                }
                finally
                {
                    s.Close();
                }                
            }
            else if (odabranaAkcija.GetType() == typeof(MitingZatvoreniP))
            {
                showAkcControls("MitingZatvoreniP");
                loadAkcijaData(odabranaAkcija);

                ISession s = DataLayer.GetSession();
                try
                {
                    gosti = (List<Gost>)s.QueryOver<Gost>().Where(x => x.Miting == odabranaAkcija).OrderBy(p => p.ID_GOST).Asc.List();
                    ucitajGoste(lvGosti, gosti);
                }
                finally
                {
                    s.Close();
                }
            }
        }
        public void showAkcControls(string tip)
        {
            labNaziv.Visible = true;
            tbaNaziv.Visible = true;
            labGrad.Visible = true;
            tbaGrad.Visible = true;

            labLok.Visible = true;

            labVreme.Visible = false;
            susPlaniranoVreme.Visible = false;

            labIznajm.Visible = false;
            mitIznajmljivac.Visible = false;
            mitIznajmljivac.Text = "";

            labCena.Visible = false;///JOOOOOOOOOOOOOOOOOOHN CEEEEEEEEENAAAAAAAAAA
            mitCena.Visible = false;
            mitCena.Text = "";            

            labOdabGost.Visible = false;
            labTitula.Visible = false;
            labIme.Visible = false;
            labPrezime.Visible = false;
            labFunkcija.Visible = false;
            tbTitula.Visible = false;
            tbIme.Visible = false;
            tbPrezime.Visible = false;
            tbFunkcija.Visible = false;

            lvGosti.Enabled = false;
            btnAddGuest.Enabled = false;
            btnUpdGuest.Enabled = false;
            btnDelGuest.Enabled = false;

            if (tip == "DeljenjeLetaka")
            {
                cbLokacija.Visible = true;
                btnDodajLok.Visible = true;
                btnObrisiLok.Visible = true;
                tbaLokacija.Visible = false;                
                mitZatvoreniP.Visible = false;
            }
            else if (tip == "SusretKandidata")
            {
                cbLokacija.Visible = false;
                btnDodajLok.Visible = false;
                btnObrisiLok.Visible = false;
                tbaLokacija.Visible = true;
                labVreme.Visible = true;
                susPlaniranoVreme.Visible = true;
                mitZatvoreniP.Visible = false;
            }
            else if (tip == "Miting")
            {
                cbLokacija.Visible = false;
                btnDodajLok.Visible = false;
                btnObrisiLok.Visible = false;
                tbaLokacija.Visible = true;                
                mitZatvoreniP.Visible = true;
                mitZatvoreniP.CheckState = CheckState.Unchecked;

                labOdabGost.Visible = true;
                labTitula.Visible = true;
                labIme.Visible = true;
                labPrezime.Visible = true;
                labFunkcija.Visible = true;
                tbTitula.Visible = true;
                tbIme.Visible = true;
                tbPrezime.Visible = true;
                tbFunkcija.Visible = true;

                lvGosti.Enabled = true;
                btnAddGuest.Enabled = true;
                btnUpdGuest.Enabled = true;
                btnDelGuest.Enabled = true;
            }
            else if (tip == "MitingZatvoreniP")
            {
                cbLokacija.Visible = false;
                btnDodajLok.Visible = false;
                btnObrisiLok.Visible = false;
                tbaLokacija.Visible = true;
                mitZatvoreniP.Visible = true;
                mitZatvoreniP.CheckState = CheckState.Checked;

                labIznajm.Visible = true;
                mitIznajmljivac.Visible = true;
                labCena.Visible = true;
                mitCena.Visible = true;

                labOdabGost.Visible = true;
                labTitula.Visible = true;
                labIme.Visible = true;
                labPrezime.Visible = true;
                labFunkcija.Visible = true;
                tbTitula.Visible = true;
                tbIme.Visible = true;
                tbPrezime.Visible = true;
                tbFunkcija.Visible = true;

                lvGosti.Enabled = true;
                btnAddGuest.Enabled = true;
                btnUpdGuest.Enabled = true;
                btnDelGuest.Enabled = true;
            }
        }
        public void loadAkcijaData(Akcija akc)
        {
            tbaNaziv.Text = akc.NazivAkcije;
            tbaGrad.Text = akc.Grad;

            if (odabranaAkcija.GetType() == typeof(DeljenjeLetaka))
            {
                ISession s = DataLayer.GetSession();///TODOR ovo ne umem!
                cbLokacija.Items.Clear();
                DeljenjeLetaka akcDL = s.Load<DeljenjeLetaka>(findAkcWith(akc.NazivAkcije, akc.Grad).ID);
                List<LokacijaDeljenjaLetaka> listLDL = (List<LokacijaDeljenjaLetaka>)s.QueryOver<LokacijaDeljenjaLetaka>().Where(p => p.DeljenjeLetaka == akcDL).List();
                foreach (LokacijaDeljenjaLetaka lok in listLDL)
                {
                    cbLokacija.Items.Add(lok.Lokacija);
                }
                s.Close();
            }
            else if (odabranaAkcija.GetType() == typeof(SusretKandidata))
            {
                tbaLokacija.Text = ((SusretKandidata)akc).Lokacija;
                susPlaniranoVreme.Value = ((SusretKandidata)akc).PlaniranoVreme;
            }
            else if (odabranaAkcija.GetType() == typeof(Miting))
            {
                tbaLokacija.Text = ((Miting)akc).Lokacija;
            }
            else if (odabranaAkcija.GetType() == typeof(MitingZatvoreniP))
            {
                tbaLokacija.Text = ((MitingZatvoreniP)akc).Lokacija;
                mitIznajmljivac.Text = ((MitingZatvoreniP)akc).NazivIznajmljivaca;
                mitCena.Text = ((MitingZatvoreniP)akc).Cena.ToString();
            }

        }
        private void lvGosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ((ListView)sender).SelectedItems)
            {
                odabraniGost = findGostWith(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
            }
            if (odabraniGost != null) {
                tbTitula.Text = odabraniGost.Titula;
                tbIme.Text = odabraniGost.Ime;
                tbPrezime.Text = odabraniGost.Prezime;
                tbFunkcija.Text = odabraniGost.Funkcija;
            }
        }

        private Gost findGostWith(string x1, string x2, string x3, string x4)
        {
            foreach (Gost g in gosti)
            {
                if ((g.Titula == x1 || (x1 == "" && g.Titula == null)) &&
                    g.Ime == x2 && g.Prezime == x3 &&
                    (g.Funkcija == x4 || (x4 == "" && g.Funkcija == null)))
                    return g;
            }
            return null;
        }
        private void btnDelAkc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu akciju?",
                "Brisanje akcije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obrisi<Akcija>(odabranaAkcija.ID);

                lvAkcije.Items.RemoveAt(sveAkcije.FindIndex(x => x.ID == odabranaAkcija.ID));
                sveAkcije.Remove(sveAkcije.Find(x => x.ID == odabranaAkcija.ID));

                ucitajAkc(lvAkcije, sveAkcije);
                odabranaAkcija = null;
                var visTB = GetAll(this.tabControl1.SelectedTab, typeof(TextBox)).Where(t => t.Visible == true);
                clearCtrl(visTB);
                var visCB = GetAll(this.tabControl1.SelectedTab, typeof(ComboBox)).Where(cb => cb.Visible == true);
                clearCtrl(visCB);
                if (mitZatvoreniP.Visible)
                {
                    mitZatvoreniP.Checked = false;
                }
            }
        }
        private void btnUpdAkc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da izmenite izabranu akciju?",
                "Ažuriranje akcije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ISession s = DataLayer.GetSession();
                try
                {
                    odabranaAkcija.NazivAkcije = tbaNaziv.Text;
                    odabranaAkcija.Grad = tbaGrad.Text;                    
                    if (odabranaAkcija.GetType() == typeof(SusretKandidata))
                    {
                        ((SusretKandidata)odabranaAkcija).Lokacija = tbaLokacija.Text;
                        ((SusretKandidata)odabranaAkcija).PlaniranoVreme = susPlaniranoVreme.Value;
                    }
                    else if (odabranaAkcija.GetType() == typeof(Miting))
                    {
                        ((Miting)odabranaAkcija).Lokacija = tbaLokacija.Text;
                    }
                    else if (odabranaAkcija.GetType() == typeof(MitingZatvoreniP))
                    {
                        ((MitingZatvoreniP)odabranaAkcija).Lokacija = tbaLokacija.Text;
                        ((MitingZatvoreniP)odabranaAkcija).NazivIznajmljivaca = mitIznajmljivac.Text;
                        ((MitingZatvoreniP)odabranaAkcija).Cena = int.Parse(mitCena.Text);
                    }
                    s.SaveOrUpdate(odabranaAkcija);

                    s.Flush();
                }
                finally
                {
                    s.Close();
                    ucitajAkc(lvAkcije, sveAkcije);
                }
            }
        }
        private void btnDodajLok_Click(object sender, EventArgs e)
        {
            if (!cbLokacija.Text.Length.Equals(0))
            {
                cbLokacija.Items.Add(cbLokacija.Text);
                ISession s = DataLayer.GetSession();
                try
                {
                    var lok = new LokacijaDeljenjaLetaka
                    {
                        DeljenjeLetaka = (DeljenjeLetaka)odabranaAkcija,
                        Lokacija = cbLokacija.Text
                    };
                    s.SaveOrUpdate(lok);
                    s.Flush();
                }
                finally
                {
                    s.Close();
                    cbLokacija.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }
        private void btnObrisiLok_Click(object sender, EventArgs e)
        {
            if (!cbLokacija.Text.Length.Equals(0))
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete sledecu lokaciju: \"" + cbLokacija.Text + "\"?",
                                 "Brisanje lokacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LokacijaDeljenjaLetaka pk = ((DeljenjeLetaka)odabranaAkcija).LokacijaDeljenjaLetaka.Single(t => t.Lokacija == cbLokacija.Text);
                    obrisi<LokacijaDeljenjaLetaka>(pk.ID);

                    cbLokacija.Items.Remove(cbLokacija.Text);
                    cbLokacija.Text = "";
                }
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }
        private void btnDelGuest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete gosta: \"" + odabraniGost.Ime + " " + odabraniGost.Prezime + "\" sa ovog mitinga?",
               "Brisanje gosta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obrisi<Gost>(odabraniGost.ID_GOST);

                lvGosti.Items.RemoveAt(gosti.FindIndex(x => x.ID_GOST == odabraniGost.ID_GOST));
                gosti.Remove(gosti.Find(x => x.ID_GOST == odabraniGost.ID_GOST));

                ucitajGoste(lvGosti, gosti);
                odabraniGost = null;
            }
        }

        private void btnUpdGuest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da ažurirate gosta: \"" + odabraniGost.Ime + " " + odabraniGost.Prezime + "\" sa ovog mitinga?",
               "Brisanje gosta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ISession s = DataLayer.GetSession();
                try
                {
                    odabraniGost.Titula = tbTitula.Text;
                    odabraniGost.Ime = tbIme.Text;
                    odabraniGost.Prezime = tbPrezime.Text;
                    odabraniGost.Funkcija = tbFunkcija.Text;

                    s.SaveOrUpdate(odabraniGost);

                    s.Flush();
                }
                finally
                {
                    s.Close();
                    ucitajGoste(lvGosti, gosti);
                }
            }
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            var form = new WriteForme.PomocneForme.DodajGosta();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.RetValGost.Miting = (Miting)odabranaAkcija;
                gosti.Add(form.RetValGost);
                ucitajGoste(lvGosti, gosti);
                MessageBox.Show("Gost uspešno dodat!", "Uspeh!");
            }
        }

        private void mitZatvoreniP_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                if (mitZatvoreniP.Checked)
                {
                    MitingZatvoreniP koord = new MitingZatvoreniP();

                    string q = "insert into Mitingzatvorenip (idmiting) values (:idm)";
                    s.CreateSQLQuery(q).SetParameter("idm", odabranaAkcija.ID).ExecuteUpdate();
                } else
                {
                    string q = "delete from Mitingzatvorenip where idmiting=:idm";
                    s.CreateSQLQuery(q).SetParameter("idm", odabranaAkcija.ID).ExecuteUpdate();
                }
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
    }
}