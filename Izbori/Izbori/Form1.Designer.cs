using System.Windows.Forms;

namespace Izbori
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Miting", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Deljenje letaka", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Susret kandidata", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.aktKoord = new System.Windows.Forms.TabPage();
            this.labKoord = new System.Windows.Forms.Label();
            this.lvAkt = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeRod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodajNAkt = new System.Windows.Forms.Button();
            this.koorOpstina = new System.Windows.Forms.TextBox();
            this.koorLab4 = new System.Windows.Forms.Label();
            this.koorGradKanc = new System.Windows.Forms.TextBox();
            this.koorLab3 = new System.Windows.Forms.Label();
            this.labZaGM = new System.Windows.Forms.Label();
            this.labAkcije = new System.Windows.Forms.Label();
            this.labZaAkc = new System.Windows.Forms.Label();
            this.jeKoord = new System.Windows.Forms.CheckBox();
            this.koordObrisiP = new System.Windows.Forms.Button();
            this.koordDodajP = new System.Windows.Forms.Button();
            this.koorPomoc = new System.Windows.Forms.ComboBox();
            this.koorLab5 = new System.Windows.Forms.Label();
            this.koorBrojKanc = new System.Windows.Forms.TextBox();
            this.koorUlicaKanc = new System.Windows.Forms.TextBox();
            this.koorLab2 = new System.Windows.Forms.Label();
            this.koorLab1 = new System.Windows.Forms.Label();
            this.aktObrisi = new System.Windows.Forms.Button();
            this.aktAzuriraj = new System.Windows.Forms.Button();
            this.btnRemoveTelefon = new System.Windows.Forms.Button();
            this.btnAddTelefon = new System.Windows.Forms.Button();
            this.aktTelefon = new System.Windows.Forms.ComboBox();
            this.btnRemoveEmail = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.aktMail = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aktGrad = new System.Windows.Forms.TextBox();
            this.aktBroj = new System.Windows.Forms.TextBox();
            this.aktUlica = new System.Windows.Forms.TextBox();
            this.aktPrezime = new System.Windows.Forms.TextBox();
            this.aktImeRod = new System.Windows.Forms.TextBox();
            this.aktIme = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.akcije = new System.Windows.Forms.TabPage();
            this.btnObrisiLok = new System.Windows.Forms.Button();
            this.btnDodajLok = new System.Windows.Forms.Button();
            this.mitZatvoreniP = new System.Windows.Forms.CheckBox();
            this.labOdabGost = new System.Windows.Forms.Label();
            this.labFunkcija = new System.Windows.Forms.Label();
            this.labPrezime = new System.Windows.Forms.Label();
            this.labIme = new System.Windows.Forms.Label();
            this.labTitula = new System.Windows.Forms.Label();
            this.tbFunkcija = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbTitula = new System.Windows.Forms.TextBox();
            this.lvGosti = new System.Windows.Forms.ListView();
            this.gosTitula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gosIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gosPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gosFunkcija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mitCena = new System.Windows.Forms.TextBox();
            this.susPlaniranoVreme = new System.Windows.Forms.DateTimePicker();
            this.labGosti = new System.Windows.Forms.Label();
            this.labCena = new System.Windows.Forms.Label();
            this.labIznajm = new System.Windows.Forms.Label();
            this.labVreme = new System.Windows.Forms.Label();
            this.labLok = new System.Windows.Forms.Label();
            this.labGrad = new System.Windows.Forms.Label();
            this.labNaziv = new System.Windows.Forms.Label();
            this.btnUpdGuest = new System.Windows.Forms.Button();
            this.btnDelGuest = new System.Windows.Forms.Button();
            this.btnAngazuj = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnUpdAkc = new System.Windows.Forms.Button();
            this.btnDelAkc = new System.Windows.Forms.Button();
            this.btnAddAkc = new System.Windows.Forms.Button();
            this.tbaLokacija = new System.Windows.Forms.TextBox();
            this.cbLokacija = new System.Windows.Forms.ComboBox();
            this.tbaGrad = new System.Windows.Forms.TextBox();
            this.tbaNaziv = new System.Windows.Forms.TextBox();
            this.mitIznajmljivac = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.lvAkcije = new System.Windows.Forms.ListView();
            this.akcNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.akcGrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gmesto = new System.Windows.Forms.TabPage();
            this.btnPrimedbe = new System.Windows.Forms.Button();
            this.btnDodajAktGM = new System.Windows.Forms.Button();
            this.btnObrGM = new System.Windows.Forms.Button();
            this.btnRezIzb = new System.Windows.Forms.Button();
            this.btnAzurGM = new System.Windows.Forms.Button();
            this.labDK = new System.Windows.Forms.Label();
            this.labPK = new System.Windows.Forms.Label();
            this.labAktGM = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.gmBrojRegBir = new System.Windows.Forms.TextBox();
            this.gmBrojGM = new System.Windows.Forms.TextBox();
            this.gmNaziv = new System.Windows.Forms.TextBox();
            this.novoGM = new System.Windows.Forms.Button();
            this.lvGM = new System.Windows.Forms.ListView();
            this.gmIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brGM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gmBB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label27 = new System.Windows.Forms.Label();
            this.mediji = new System.Windows.Forms.TabPage();
            this.lNazivEmisije = new System.Windows.Forms.Label();
            this.lNazivStanice = new System.Windows.Forms.Label();
            this.lProcenjenaGledanost = new System.Windows.Forms.Label();
            this.lImeVoditelja = new System.Windows.Forms.Label();
            this.btnUkloniPitanje = new System.Windows.Forms.Button();
            this.btnDodajPitanje = new System.Windows.Forms.Button();
            this.cbPitanje = new System.Windows.Forms.ComboBox();
            this.lPitanja = new System.Windows.Forms.Label();
            this.btnUkloniProtivkandidata = new System.Windows.Forms.Button();
            this.btnDodajProtivkandidata = new System.Windows.Forms.Button();
            this.cbProtivKandidati = new System.Windows.Forms.ComboBox();
            this.lImeProtivkand = new System.Windows.Forms.Label();
            this.tbProcenjenaGledanost = new System.Windows.Forms.TextBox();
            this.tbImeVoditelja = new System.Windows.Forms.TextBox();
            this.tbNazivEmisije = new System.Windows.Forms.TextBox();
            this.tbNazivStanice = new System.Windows.Forms.TextBox();
            this.chBoxTVDuel = new System.Windows.Forms.CheckBox();
            this.btnAddGostovanje = new System.Windows.Forms.Button();
            this.btnRemoveGostovanje = new System.Windows.Forms.Button();
            this.btnUpdateGostovanje = new System.Windows.Forms.Button();
            this.btnUkloniNovinara = new System.Windows.Forms.Button();
            this.btnDodajNovinara = new System.Windows.Forms.Button();
            this.cbNovinari = new System.Windows.Forms.ComboBox();
            this.lNovinari = new System.Windows.Forms.Label();
            this.tbNazivLista = new System.Windows.Forms.TextBox();
            this.lNazivLista = new System.Windows.Forms.Label();
            this.lDatumObjavljivanja = new System.Windows.Forms.Label();
            this.calObjavljivanja = new System.Windows.Forms.MonthCalendar();
            this.lDatumIntervjua = new System.Windows.Forms.Label();
            this.calIntervjua = new System.Windows.Forms.MonthCalendar();
            this.rBtnTVRadio = new System.Windows.Forms.RadioButton();
            this.rBtnNovine = new System.Windows.Forms.RadioButton();
            this.Naslov = new System.Windows.Forms.Label();
            this.listaPojavljivanja = new System.Windows.Forms.ListView();
            this.propaganda = new System.Windows.Forms.TabPage();
            this.propBtnDodaj = new System.Windows.Forms.Button();
            this.propBtnObrisi = new System.Windows.Forms.Button();
            this.propBtnAzur = new System.Windows.Forms.Button();
            this.propCBUBoji = new System.Windows.Forms.CheckBox();
            this.propTxtCenaZakupa = new System.Windows.Forms.TextBox();
            this.propTxtTrajanjeZakupa = new System.Windows.Forms.TextBox();
            this.propLblDatum = new System.Windows.Forms.Label();
            this.propLblTrajanje = new System.Windows.Forms.Label();
            this.propLblcena = new System.Windows.Forms.Label();
            this.propTxtMod2 = new System.Windows.Forms.TextBox();
            this.propClndDatumZakupa = new System.Windows.Forms.MonthCalendar();
            this.propTxtMod3 = new System.Windows.Forms.TextBox();
            this.propLblMod3 = new System.Windows.Forms.Label();
            this.propRBTVRad = new System.Windows.Forms.RadioButton();
            this.propRBPano = new System.Windows.Forms.RadioButton();
            this.propRBNovine = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.propTxtPanoVlasnik = new System.Windows.Forms.TextBox();
            this.propTxtMod0 = new System.Windows.Forms.TextBox();
            this.propTxtMod1 = new System.Windows.Forms.TextBox();
            this.propLblMod2 = new System.Windows.Forms.Label();
            this.propLblMod0 = new System.Windows.Forms.Label();
            this.propLblmod1 = new System.Windows.Forms.Label();
            this.propLblpropaganda = new System.Windows.Forms.Label();
            this.propagandaListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.aktKoord.SuspendLayout();
            this.akcije.SuspendLayout();
            this.gmesto.SuspendLayout();
            this.mediji.SuspendLayout();
            this.propaganda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.aktKoord);
            this.tabControl1.Controls.Add(this.akcije);
            this.tabControl1.Controls.Add(this.gmesto);
            this.tabControl1.Controls.Add(this.mediji);
            this.tabControl1.Controls.Add(this.propaganda);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 635);
            this.tabControl1.TabIndex = 42;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 609);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Početak";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(204, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "Do pobede! Samo jako!";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 97);
            this.label23.MaximumSize = new System.Drawing.Size(500, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(492, 39);
            this.label23.TabIndex = 2;
            this.label23.Text = resources.GetString("label23.Text");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 45);
            this.label22.MaximumSize = new System.Drawing.Size(500, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(493, 39);
            this.label22.TabIndex = 1;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Dobrodošli!";
            // 
            // aktKoord
            // 
            this.aktKoord.BackColor = System.Drawing.Color.SlateGray;
            this.aktKoord.Controls.Add(this.labKoord);
            this.aktKoord.Controls.Add(this.lvAkt);
            this.aktKoord.Controls.Add(this.dodajNAkt);
            this.aktKoord.Controls.Add(this.koorOpstina);
            this.aktKoord.Controls.Add(this.koorLab4);
            this.aktKoord.Controls.Add(this.koorGradKanc);
            this.aktKoord.Controls.Add(this.koorLab3);
            this.aktKoord.Controls.Add(this.labZaGM);
            this.aktKoord.Controls.Add(this.labAkcije);
            this.aktKoord.Controls.Add(this.labZaAkc);
            this.aktKoord.Controls.Add(this.jeKoord);
            this.aktKoord.Controls.Add(this.koordObrisiP);
            this.aktKoord.Controls.Add(this.koordDodajP);
            this.aktKoord.Controls.Add(this.koorPomoc);
            this.aktKoord.Controls.Add(this.koorLab5);
            this.aktKoord.Controls.Add(this.koorBrojKanc);
            this.aktKoord.Controls.Add(this.koorUlicaKanc);
            this.aktKoord.Controls.Add(this.koorLab2);
            this.aktKoord.Controls.Add(this.koorLab1);
            this.aktKoord.Controls.Add(this.aktObrisi);
            this.aktKoord.Controls.Add(this.aktAzuriraj);
            this.aktKoord.Controls.Add(this.btnRemoveTelefon);
            this.aktKoord.Controls.Add(this.btnAddTelefon);
            this.aktKoord.Controls.Add(this.aktTelefon);
            this.aktKoord.Controls.Add(this.btnRemoveEmail);
            this.aktKoord.Controls.Add(this.btnAddEmail);
            this.aktKoord.Controls.Add(this.aktMail);
            this.aktKoord.Controls.Add(this.label10);
            this.aktKoord.Controls.Add(this.label11);
            this.aktKoord.Controls.Add(this.aktGrad);
            this.aktKoord.Controls.Add(this.aktBroj);
            this.aktKoord.Controls.Add(this.aktUlica);
            this.aktKoord.Controls.Add(this.aktPrezime);
            this.aktKoord.Controls.Add(this.aktImeRod);
            this.aktKoord.Controls.Add(this.aktIme);
            this.aktKoord.Controls.Add(this.label12);
            this.aktKoord.Controls.Add(this.label13);
            this.aktKoord.Controls.Add(this.label14);
            this.aktKoord.Controls.Add(this.label15);
            this.aktKoord.Controls.Add(this.label16);
            this.aktKoord.Controls.Add(this.label17);
            this.aktKoord.Controls.Add(this.label8);
            this.aktKoord.ForeColor = System.Drawing.Color.Azure;
            this.aktKoord.Location = new System.Drawing.Point(4, 22);
            this.aktKoord.Name = "aktKoord";
            this.aktKoord.Padding = new System.Windows.Forms.Padding(3);
            this.aktKoord.Size = new System.Drawing.Size(998, 609);
            this.aktKoord.TabIndex = 1;
            this.aktKoord.Text = "Aktiviste i koordinatori";
            // 
            // labKoord
            // 
            this.labKoord.AutoSize = true;
            this.labKoord.Location = new System.Drawing.Point(706, 274);
            this.labKoord.Name = "labKoord";
            this.labKoord.Size = new System.Drawing.Size(0, 13);
            this.labKoord.TabIndex = 74;
            // 
            // lvAkt
            // 
            this.lvAkt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ime,
            this.imeRod,
            this.prezime});
            this.lvAkt.FullRowSelect = true;
            this.lvAkt.HideSelection = false;
            this.lvAkt.Location = new System.Drawing.Point(25, 64);
            this.lvAkt.MultiSelect = false;
            this.lvAkt.Name = "lvAkt";
            this.lvAkt.Size = new System.Drawing.Size(349, 368);
            this.lvAkt.TabIndex = 73;
            this.lvAkt.UseCompatibleStateImageBehavior = false;
            this.lvAkt.View = System.Windows.Forms.View.Details;
            this.lvAkt.SelectedIndexChanged += new System.EventHandler(this.listAkt_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            this.ime.Width = 80;
            // 
            // imeRod
            // 
            this.imeRod.Text = "Ime roditelja";
            this.imeRod.Width = 89;
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            this.prezime.Width = 115;
            // 
            // dodajNAkt
            // 
            this.dodajNAkt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dodajNAkt.Location = new System.Drawing.Point(264, 438);
            this.dodajNAkt.Name = "dodajNAkt";
            this.dodajNAkt.Size = new System.Drawing.Size(110, 53);
            this.dodajNAkt.TabIndex = 72;
            this.dodajNAkt.Text = "Dodaj novog aktivistu";
            this.dodajNAkt.UseVisualStyleBackColor = true;
            this.dodajNAkt.Click += new System.EventHandler(this.button10_Click);
            // 
            // koorOpstina
            // 
            this.koorOpstina.Enabled = false;
            this.koorOpstina.Location = new System.Drawing.Point(486, 375);
            this.koorOpstina.Name = "koorOpstina";
            this.koorOpstina.Size = new System.Drawing.Size(204, 20);
            this.koorOpstina.TabIndex = 71;
            // 
            // koorLab4
            // 
            this.koorLab4.AutoSize = true;
            this.koorLab4.Enabled = false;
            this.koorLab4.Location = new System.Drawing.Point(380, 378);
            this.koorLab4.Name = "koorLab4";
            this.koorLab4.Size = new System.Drawing.Size(100, 13);
            this.koorLab4.TabIndex = 70;
            this.koorLab4.Text = "Opština kancelarije:";
            // 
            // koorGradKanc
            // 
            this.koorGradKanc.Enabled = false;
            this.koorGradKanc.Location = new System.Drawing.Point(486, 349);
            this.koorGradKanc.Name = "koorGradKanc";
            this.koorGradKanc.Size = new System.Drawing.Size(204, 20);
            this.koorGradKanc.TabIndex = 69;
            // 
            // koorLab3
            // 
            this.koorLab3.AutoSize = true;
            this.koorLab3.Enabled = false;
            this.koorLab3.Location = new System.Drawing.Point(391, 352);
            this.koorLab3.Name = "koorLab3";
            this.koorLab3.Size = new System.Drawing.Size(87, 13);
            this.koorLab3.TabIndex = 68;
            this.koorLab3.Text = "Grad kancelarije:";
            // 
            // labZaGM
            // 
            this.labZaGM.AutoSize = true;
            this.labZaGM.Location = new System.Drawing.Point(715, 64);
            this.labZaGM.MaximumSize = new System.Drawing.Size(205, 0);
            this.labZaGM.Name = "labZaGM";
            this.labZaGM.Size = new System.Drawing.Size(0, 13);
            this.labZaGM.TabIndex = 67;
            this.labZaGM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labAkcije
            // 
            this.labAkcije.AutoSize = true;
            this.labAkcije.Location = new System.Drawing.Point(707, 346);
            this.labAkcije.MaximumSize = new System.Drawing.Size(205, 0);
            this.labAkcije.Name = "labAkcije";
            this.labAkcije.Size = new System.Drawing.Size(0, 13);
            this.labAkcije.TabIndex = 66;
            // 
            // labZaAkc
            // 
            this.labZaAkc.AutoSize = true;
            this.labZaAkc.Location = new System.Drawing.Point(706, 297);
            this.labZaAkc.MaximumSize = new System.Drawing.Size(205, 0);
            this.labZaAkc.Name = "labZaAkc";
            this.labZaAkc.Size = new System.Drawing.Size(0, 13);
            this.labZaAkc.TabIndex = 65;
            this.labZaAkc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jeKoord
            // 
            this.jeKoord.AutoSize = true;
            this.jeKoord.Enabled = false;
            this.jeKoord.Location = new System.Drawing.Point(486, 274);
            this.jeKoord.Name = "jeKoord";
            this.jeKoord.Size = new System.Drawing.Size(133, 17);
            this.jeKoord.TabIndex = 64;
            this.jeKoord.Text = "Aktivista je koordinator";
            this.jeKoord.UseVisualStyleBackColor = true;
            this.jeKoord.Click += new System.EventHandler(this.jeKoord_Click);
            // 
            // koordObrisiP
            // 
            this.koordObrisiP.Enabled = false;
            this.koordObrisiP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koordObrisiP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.koordObrisiP.Location = new System.Drawing.Point(668, 399);
            this.koordObrisiP.Name = "koordObrisiP";
            this.koordObrisiP.Size = new System.Drawing.Size(22, 23);
            this.koordObrisiP.TabIndex = 63;
            this.koordObrisiP.Text = "-";
            this.koordObrisiP.UseVisualStyleBackColor = true;
            this.koordObrisiP.Click += new System.EventHandler(this.koordObrisiP_Click);
            // 
            // koordDodajP
            // 
            this.koordDodajP.Enabled = false;
            this.koordDodajP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koordDodajP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.koordDodajP.Location = new System.Drawing.Point(640, 399);
            this.koordDodajP.Name = "koordDodajP";
            this.koordDodajP.Size = new System.Drawing.Size(22, 23);
            this.koordDodajP.TabIndex = 62;
            this.koordDodajP.Text = "+";
            this.koordDodajP.UseVisualStyleBackColor = true;
            this.koordDodajP.Click += new System.EventHandler(this.koordDodajP_Click);
            // 
            // koorPomoc
            // 
            this.koorPomoc.Enabled = false;
            this.koorPomoc.FormattingEnabled = true;
            this.koorPomoc.Location = new System.Drawing.Point(486, 401);
            this.koorPomoc.Name = "koorPomoc";
            this.koorPomoc.Size = new System.Drawing.Size(146, 21);
            this.koorPomoc.TabIndex = 61;
            // 
            // koorLab5
            // 
            this.koorLab5.AutoSize = true;
            this.koorLab5.Enabled = false;
            this.koorLab5.Location = new System.Drawing.Point(421, 404);
            this.koorLab5.Name = "koorLab5";
            this.koorLab5.Size = new System.Drawing.Size(59, 13);
            this.koorLab5.TabIndex = 60;
            this.koorLab5.Text = "Pomoćnici:";
            // 
            // koorBrojKanc
            // 
            this.koorBrojKanc.Enabled = false;
            this.koorBrojKanc.Location = new System.Drawing.Point(486, 323);
            this.koorBrojKanc.Name = "koorBrojKanc";
            this.koorBrojKanc.Size = new System.Drawing.Size(204, 20);
            this.koorBrojKanc.TabIndex = 57;
            // 
            // koorUlicaKanc
            // 
            this.koorUlicaKanc.Enabled = false;
            this.koorUlicaKanc.Location = new System.Drawing.Point(486, 297);
            this.koorUlicaKanc.Name = "koorUlicaKanc";
            this.koorUlicaKanc.Size = new System.Drawing.Size(204, 20);
            this.koorUlicaKanc.TabIndex = 56;
            // 
            // koorLab2
            // 
            this.koorLab2.AutoSize = true;
            this.koorLab2.Enabled = false;
            this.koorLab2.Location = new System.Drawing.Point(397, 326);
            this.koorLab2.Name = "koorLab2";
            this.koorLab2.Size = new System.Drawing.Size(82, 13);
            this.koorLab2.TabIndex = 55;
            this.koorLab2.Text = "Broj kancelarije:";
            // 
            // koorLab1
            // 
            this.koorLab1.AutoSize = true;
            this.koorLab1.Enabled = false;
            this.koorLab1.Location = new System.Drawing.Point(391, 300);
            this.koorLab1.Name = "koorLab1";
            this.koorLab1.Size = new System.Drawing.Size(88, 13);
            this.koorLab1.TabIndex = 54;
            this.koorLab1.Text = "Ulica kancelarije:";
            // 
            // aktObrisi
            // 
            this.aktObrisi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.aktObrisi.Location = new System.Drawing.Point(486, 438);
            this.aktObrisi.Name = "aktObrisi";
            this.aktObrisi.Size = new System.Drawing.Size(81, 53);
            this.aktObrisi.TabIndex = 51;
            this.aktObrisi.Text = "Obriši odabranog aktivistu";
            this.aktObrisi.UseVisualStyleBackColor = true;
            this.aktObrisi.Click += new System.EventHandler(this.aktObrisi_Click);
            // 
            // aktAzuriraj
            // 
            this.aktAzuriraj.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.aktAzuriraj.Location = new System.Drawing.Point(569, 438);
            this.aktAzuriraj.Name = "aktAzuriraj";
            this.aktAzuriraj.Size = new System.Drawing.Size(121, 53);
            this.aktAzuriraj.TabIndex = 50;
            this.aktAzuriraj.Text = "Ažuriraj odabranog aktivistu";
            this.aktAzuriraj.UseVisualStyleBackColor = true;
            this.aktAzuriraj.Click += new System.EventHandler(this.aktAzuriraj_Click);
            // 
            // btnRemoveTelefon
            // 
            this.btnRemoveTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTelefon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemoveTelefon.Location = new System.Drawing.Point(666, 245);
            this.btnRemoveTelefon.Name = "btnRemoveTelefon";
            this.btnRemoveTelefon.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveTelefon.TabIndex = 49;
            this.btnRemoveTelefon.Text = "-";
            this.btnRemoveTelefon.UseVisualStyleBackColor = true;
            this.btnRemoveTelefon.Click += new System.EventHandler(this.btnRemoveTelefon_Click);
            // 
            // btnAddTelefon
            // 
            this.btnAddTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTelefon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddTelefon.Location = new System.Drawing.Point(638, 245);
            this.btnAddTelefon.Name = "btnAddTelefon";
            this.btnAddTelefon.Size = new System.Drawing.Size(24, 23);
            this.btnAddTelefon.TabIndex = 48;
            this.btnAddTelefon.Text = "+";
            this.btnAddTelefon.UseVisualStyleBackColor = true;
            this.btnAddTelefon.Click += new System.EventHandler(this.btnAddTelefon_Click);
            // 
            // aktTelefon
            // 
            this.aktTelefon.FormattingEnabled = true;
            this.aktTelefon.Location = new System.Drawing.Point(486, 247);
            this.aktTelefon.Name = "aktTelefon";
            this.aktTelefon.Size = new System.Drawing.Size(146, 21);
            this.aktTelefon.TabIndex = 47;
            // 
            // btnRemoveEmail
            // 
            this.btnRemoveEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemoveEmail.Location = new System.Drawing.Point(666, 220);
            this.btnRemoveEmail.Name = "btnRemoveEmail";
            this.btnRemoveEmail.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveEmail.TabIndex = 46;
            this.btnRemoveEmail.Text = "-";
            this.btnRemoveEmail.UseVisualStyleBackColor = true;
            this.btnRemoveEmail.Click += new System.EventHandler(this.btnRemoveEmail_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddEmail.Location = new System.Drawing.Point(638, 220);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(24, 23);
            this.btnAddEmail.TabIndex = 45;
            this.btnAddEmail.Text = "+";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // aktMail
            // 
            this.aktMail.FormattingEnabled = true;
            this.aktMail.Location = new System.Drawing.Point(486, 220);
            this.aktMail.Name = "aktMail";
            this.aktMail.Size = new System.Drawing.Size(146, 21);
            this.aktMail.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Telefoni:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "E-Mailovi:";
            // 
            // aktGrad
            // 
            this.aktGrad.Location = new System.Drawing.Point(486, 194);
            this.aktGrad.Name = "aktGrad";
            this.aktGrad.Size = new System.Drawing.Size(204, 20);
            this.aktGrad.TabIndex = 41;
            // 
            // aktBroj
            // 
            this.aktBroj.Location = new System.Drawing.Point(486, 168);
            this.aktBroj.Name = "aktBroj";
            this.aktBroj.Size = new System.Drawing.Size(204, 20);
            this.aktBroj.TabIndex = 40;
            // 
            // aktUlica
            // 
            this.aktUlica.Location = new System.Drawing.Point(486, 142);
            this.aktUlica.Name = "aktUlica";
            this.aktUlica.Size = new System.Drawing.Size(204, 20);
            this.aktUlica.TabIndex = 39;
            // 
            // aktPrezime
            // 
            this.aktPrezime.Location = new System.Drawing.Point(486, 116);
            this.aktPrezime.Name = "aktPrezime";
            this.aktPrezime.Size = new System.Drawing.Size(204, 20);
            this.aktPrezime.TabIndex = 38;
            // 
            // aktImeRod
            // 
            this.aktImeRod.Location = new System.Drawing.Point(486, 90);
            this.aktImeRod.Name = "aktImeRod";
            this.aktImeRod.Size = new System.Drawing.Size(204, 20);
            this.aktImeRod.TabIndex = 37;
            // 
            // aktIme
            // 
            this.aktIme.Location = new System.Drawing.Point(486, 64);
            this.aktIme.Name = "aktIme";
            this.aktIme.Size = new System.Drawing.Size(204, 20);
            this.aktIme.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Grad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(452, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Broj:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(446, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Ulica:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(409, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Ime Roditelja:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(433, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Prezime:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(453, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Aktivisti stranke";
            // 
            // akcije
            // 
            this.akcije.BackColor = System.Drawing.Color.SlateGray;
            this.akcije.Controls.Add(this.btnObrisiLok);
            this.akcije.Controls.Add(this.btnDodajLok);
            this.akcije.Controls.Add(this.mitZatvoreniP);
            this.akcije.Controls.Add(this.labOdabGost);
            this.akcije.Controls.Add(this.labFunkcija);
            this.akcije.Controls.Add(this.labPrezime);
            this.akcije.Controls.Add(this.labIme);
            this.akcije.Controls.Add(this.labTitula);
            this.akcije.Controls.Add(this.tbFunkcija);
            this.akcije.Controls.Add(this.tbPrezime);
            this.akcije.Controls.Add(this.tbIme);
            this.akcije.Controls.Add(this.tbTitula);
            this.akcije.Controls.Add(this.lvGosti);
            this.akcije.Controls.Add(this.mitCena);
            this.akcije.Controls.Add(this.susPlaniranoVreme);
            this.akcije.Controls.Add(this.labGosti);
            this.akcije.Controls.Add(this.labCena);
            this.akcije.Controls.Add(this.labIznajm);
            this.akcije.Controls.Add(this.labVreme);
            this.akcije.Controls.Add(this.labLok);
            this.akcije.Controls.Add(this.labGrad);
            this.akcije.Controls.Add(this.labNaziv);
            this.akcije.Controls.Add(this.btnUpdGuest);
            this.akcije.Controls.Add(this.btnDelGuest);
            this.akcije.Controls.Add(this.btnAngazuj);
            this.akcije.Controls.Add(this.btnAddGuest);
            this.akcije.Controls.Add(this.btnUpdAkc);
            this.akcije.Controls.Add(this.btnDelAkc);
            this.akcije.Controls.Add(this.btnAddAkc);
            this.akcije.Controls.Add(this.tbaLokacija);
            this.akcije.Controls.Add(this.cbLokacija);
            this.akcije.Controls.Add(this.tbaGrad);
            this.akcije.Controls.Add(this.tbaNaziv);
            this.akcije.Controls.Add(this.mitIznajmljivac);
            this.akcije.Controls.Add(this.label31);
            this.akcije.Controls.Add(this.lvAkcije);
            this.akcije.ForeColor = System.Drawing.Color.AliceBlue;
            this.akcije.Location = new System.Drawing.Point(4, 22);
            this.akcije.Name = "akcije";
            this.akcije.Size = new System.Drawing.Size(998, 609);
            this.akcije.TabIndex = 4;
            this.akcije.Text = "Predizborne akcije";
            // 
            // btnObrisiLok
            // 
            this.btnObrisiLok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiLok.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnObrisiLok.Location = new System.Drawing.Point(650, 107);
            this.btnObrisiLok.Name = "btnObrisiLok";
            this.btnObrisiLok.Size = new System.Drawing.Size(24, 23);
            this.btnObrisiLok.TabIndex = 48;
            this.btnObrisiLok.Text = "-";
            this.btnObrisiLok.UseVisualStyleBackColor = true;
            this.btnObrisiLok.Click += new System.EventHandler(this.btnObrisiLok_Click);
            // 
            // btnDodajLok
            // 
            this.btnDodajLok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajLok.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDodajLok.Location = new System.Drawing.Point(622, 107);
            this.btnDodajLok.Name = "btnDodajLok";
            this.btnDodajLok.Size = new System.Drawing.Size(24, 23);
            this.btnDodajLok.TabIndex = 47;
            this.btnDodajLok.Text = "+";
            this.btnDodajLok.UseVisualStyleBackColor = true;
            this.btnDodajLok.Click += new System.EventHandler(this.btnDodajLok_Click);
            // 
            // mitZatvoreniP
            // 
            this.mitZatvoreniP.AutoSize = true;
            this.mitZatvoreniP.Location = new System.Drawing.Point(442, 159);
            this.mitZatvoreniP.Name = "mitZatvoreniP";
            this.mitZatvoreniP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mitZatvoreniP.Size = new System.Drawing.Size(173, 17);
            this.mitZatvoreniP.TabIndex = 36;
            this.mitZatvoreniP.Text = "Miting je u zatvorenom prostoru";
            this.mitZatvoreniP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mitZatvoreniP.UseVisualStyleBackColor = true;
            this.mitZatvoreniP.CheckedChanged += new System.EventHandler(this.mitZatvoreniP_CheckedChanged);
            this.mitZatvoreniP.Click += new System.EventHandler(this.mitZatvoreniP_Click);
            // 
            // labOdabGost
            // 
            this.labOdabGost.AutoSize = true;
            this.labOdabGost.Location = new System.Drawing.Point(480, 241);
            this.labOdabGost.Name = "labOdabGost";
            this.labOdabGost.Size = new System.Drawing.Size(73, 13);
            this.labOdabGost.TabIndex = 34;
            this.labOdabGost.Text = "Odabrani gost";
            // 
            // labFunkcija
            // 
            this.labFunkcija.AutoSize = true;
            this.labFunkcija.Location = new System.Drawing.Point(427, 347);
            this.labFunkcija.Name = "labFunkcija";
            this.labFunkcija.Size = new System.Drawing.Size(47, 13);
            this.labFunkcija.TabIndex = 33;
            this.labFunkcija.Text = "Funkcija";
            // 
            // labPrezime
            // 
            this.labPrezime.AutoSize = true;
            this.labPrezime.Location = new System.Drawing.Point(430, 321);
            this.labPrezime.Name = "labPrezime";
            this.labPrezime.Size = new System.Drawing.Size(44, 13);
            this.labPrezime.TabIndex = 32;
            this.labPrezime.Text = "Prezime";
            // 
            // labIme
            // 
            this.labIme.AutoSize = true;
            this.labIme.Location = new System.Drawing.Point(453, 295);
            this.labIme.Name = "labIme";
            this.labIme.Size = new System.Drawing.Size(24, 13);
            this.labIme.TabIndex = 31;
            this.labIme.Text = "Ime";
            // 
            // labTitula
            // 
            this.labTitula.AutoSize = true;
            this.labTitula.Location = new System.Drawing.Point(441, 269);
            this.labTitula.Name = "labTitula";
            this.labTitula.Size = new System.Drawing.Size(33, 13);
            this.labTitula.TabIndex = 30;
            this.labTitula.Text = "Titula";
            // 
            // tbFunkcija
            // 
            this.tbFunkcija.Location = new System.Drawing.Point(483, 344);
            this.tbFunkcija.Name = "tbFunkcija";
            this.tbFunkcija.Size = new System.Drawing.Size(191, 20);
            this.tbFunkcija.TabIndex = 29;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(483, 318);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(191, 20);
            this.tbPrezime.TabIndex = 28;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(483, 292);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(191, 20);
            this.tbIme.TabIndex = 27;
            // 
            // tbTitula
            // 
            this.tbTitula.Location = new System.Drawing.Point(483, 266);
            this.tbTitula.Name = "tbTitula";
            this.tbTitula.Size = new System.Drawing.Size(191, 20);
            this.tbTitula.TabIndex = 26;
            // 
            // lvGosti
            // 
            this.lvGosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gosTitula,
            this.gosIme,
            this.gosPrezime,
            this.gosFunkcija});
            this.lvGosti.FullRowSelect = true;
            this.lvGosti.Location = new System.Drawing.Point(697, 56);
            this.lvGosti.Name = "lvGosti";
            this.lvGosti.Size = new System.Drawing.Size(277, 308);
            this.lvGosti.TabIndex = 25;
            this.lvGosti.UseCompatibleStateImageBehavior = false;
            this.lvGosti.View = System.Windows.Forms.View.Details;
            this.lvGosti.SelectedIndexChanged += new System.EventHandler(this.lvGosti_SelectedIndexChanged);
            // 
            // gosTitula
            // 
            this.gosTitula.Text = "Titula";
            // 
            // gosIme
            // 
            this.gosIme.Text = "Ime";
            // 
            // gosPrezime
            // 
            this.gosPrezime.Text = "Prezime";
            // 
            // gosFunkcija
            // 
            this.gosFunkcija.Text = "Funkcija";
            // 
            // mitCena
            // 
            this.mitCena.Location = new System.Drawing.Point(483, 206);
            this.mitCena.Name = "mitCena";
            this.mitCena.Size = new System.Drawing.Size(132, 20);
            this.mitCena.TabIndex = 24;
            this.mitCena.Visible = false;
            // 
            // susPlaniranoVreme
            // 
            this.susPlaniranoVreme.CustomFormat = "dd.MM.yyyy.  HH:mm";
            this.susPlaniranoVreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.susPlaniranoVreme.Location = new System.Drawing.Point(483, 133);
            this.susPlaniranoVreme.Name = "susPlaniranoVreme";
            this.susPlaniranoVreme.Size = new System.Drawing.Size(132, 20);
            this.susPlaniranoVreme.TabIndex = 23;
            // 
            // labGosti
            // 
            this.labGosti.AutoSize = true;
            this.labGosti.Location = new System.Drawing.Point(694, 29);
            this.labGosti.Name = "labGosti";
            this.labGosti.Size = new System.Drawing.Size(82, 13);
            this.labGosti.TabIndex = 22;
            this.labGosti.Text = "Gosti na mitingu";
            // 
            // labCena
            // 
            this.labCena.AutoSize = true;
            this.labCena.Location = new System.Drawing.Point(341, 209);
            this.labCena.Name = "labCena";
            this.labCena.Size = new System.Drawing.Size(133, 13);
            this.labCena.TabIndex = 21;
            this.labCena.Text = "Cena iznajmljenog prostora";
            this.labCena.Visible = false;
            // 
            // labIznajm
            // 
            this.labIznajm.AutoSize = true;
            this.labIznajm.Location = new System.Drawing.Point(337, 183);
            this.labIznajm.Name = "labIznajm";
            this.labIznajm.Size = new System.Drawing.Size(137, 13);
            this.labIznajm.TabIndex = 20;
            this.labIznajm.Text = "Naziv iznajmljivača prostora";
            this.labIznajm.Visible = false;
            // 
            // labVreme
            // 
            this.labVreme.AutoSize = true;
            this.labVreme.Location = new System.Drawing.Point(346, 133);
            this.labVreme.Name = "labVreme";
            this.labVreme.Size = new System.Drawing.Size(128, 13);
            this.labVreme.TabIndex = 19;
            this.labVreme.Text = "Termin planiranog susreta";
            // 
            // labLok
            // 
            this.labLok.AutoSize = true;
            this.labLok.Location = new System.Drawing.Point(396, 110);
            this.labLok.Name = "labLok";
            this.labLok.Size = new System.Drawing.Size(78, 13);
            this.labLok.TabIndex = 18;
            this.labLok.Text = "Lokacija akcije";
            // 
            // labGrad
            // 
            this.labGrad.AutoSize = true;
            this.labGrad.Location = new System.Drawing.Point(413, 83);
            this.labGrad.Name = "labGrad";
            this.labGrad.Size = new System.Drawing.Size(61, 13);
            this.labGrad.TabIndex = 17;
            this.labGrad.Text = "Grad akcije";
            // 
            // labNaziv
            // 
            this.labNaziv.AutoSize = true;
            this.labNaziv.Location = new System.Drawing.Point(409, 59);
            this.labNaziv.Name = "labNaziv";
            this.labNaziv.Size = new System.Drawing.Size(65, 13);
            this.labNaziv.TabIndex = 16;
            this.labNaziv.Text = "Naziv akcije";
            // 
            // btnUpdGuest
            // 
            this.btnUpdGuest.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdGuest.Location = new System.Drawing.Point(798, 370);
            this.btnUpdGuest.Name = "btnUpdGuest";
            this.btnUpdGuest.Size = new System.Drawing.Size(75, 45);
            this.btnUpdGuest.TabIndex = 15;
            this.btnUpdGuest.Text = "Ažuriranje gosta";
            this.btnUpdGuest.UseVisualStyleBackColor = true;
            this.btnUpdGuest.Click += new System.EventHandler(this.btnUpdGuest_Click);
            // 
            // btnDelGuest
            // 
            this.btnDelGuest.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelGuest.Location = new System.Drawing.Point(899, 370);
            this.btnDelGuest.Name = "btnDelGuest";
            this.btnDelGuest.Size = new System.Drawing.Size(75, 45);
            this.btnDelGuest.TabIndex = 14;
            this.btnDelGuest.Text = "Brisanje gosta";
            this.btnDelGuest.UseVisualStyleBackColor = true;
            this.btnDelGuest.Click += new System.EventHandler(this.btnDelGuest_Click);
            // 
            // btnAngazuj
            // 
            this.btnAngazuj.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAngazuj.Location = new System.Drawing.Point(546, 370);
            this.btnAngazuj.Name = "btnAngazuj";
            this.btnAngazuj.Size = new System.Drawing.Size(58, 45);
            this.btnAngazuj.TabIndex = 13;
            this.btnAngazuj.Text = "Angažuj aktiviste";
            this.btnAngazuj.UseVisualStyleBackColor = true;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddGuest.Location = new System.Drawing.Point(697, 370);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(75, 45);
            this.btnAddGuest.TabIndex = 12;
            this.btnAddGuest.Text = "Dodavanje gosta";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnUpdAkc
            // 
            this.btnUpdAkc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdAkc.Location = new System.Drawing.Point(612, 370);
            this.btnUpdAkc.Name = "btnUpdAkc";
            this.btnUpdAkc.Size = new System.Drawing.Size(62, 45);
            this.btnUpdAkc.TabIndex = 11;
            this.btnUpdAkc.Text = "Ažuriranje akcije";
            this.btnUpdAkc.UseVisualStyleBackColor = true;
            this.btnUpdAkc.Click += new System.EventHandler(this.btnUpdAkc_Click);
            // 
            // btnDelAkc
            // 
            this.btnDelAkc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelAkc.Location = new System.Drawing.Point(483, 370);
            this.btnDelAkc.Name = "btnDelAkc";
            this.btnDelAkc.Size = new System.Drawing.Size(55, 45);
            this.btnDelAkc.TabIndex = 10;
            this.btnDelAkc.Text = "Brisanje akcije";
            this.btnDelAkc.UseVisualStyleBackColor = true;
            this.btnDelAkc.Click += new System.EventHandler(this.btnDelAkc_Click);
            // 
            // btnAddAkc
            // 
            this.btnAddAkc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddAkc.Location = new System.Drawing.Point(240, 421);
            this.btnAddAkc.Name = "btnAddAkc";
            this.btnAddAkc.Size = new System.Drawing.Size(75, 45);
            this.btnAddAkc.TabIndex = 9;
            this.btnAddAkc.Text = "Dodavanje akcije";
            this.btnAddAkc.UseVisualStyleBackColor = true;
            this.btnAddAkc.Click += new System.EventHandler(this.btnAddAkc_Click);
            // 
            // tbaLokacija
            // 
            this.tbaLokacija.Location = new System.Drawing.Point(483, 106);
            this.tbaLokacija.Name = "tbaLokacija";
            this.tbaLokacija.Size = new System.Drawing.Size(132, 20);
            this.tbaLokacija.TabIndex = 8;
            // 
            // cbLokacija
            // 
            this.cbLokacija.FormattingEnabled = true;
            this.cbLokacija.Location = new System.Drawing.Point(483, 106);
            this.cbLokacija.Name = "cbLokacija";
            this.cbLokacija.Size = new System.Drawing.Size(132, 21);
            this.cbLokacija.TabIndex = 7;
            // 
            // tbaGrad
            // 
            this.tbaGrad.Location = new System.Drawing.Point(483, 80);
            this.tbaGrad.Name = "tbaGrad";
            this.tbaGrad.Size = new System.Drawing.Size(191, 20);
            this.tbaGrad.TabIndex = 6;
            // 
            // tbaNaziv
            // 
            this.tbaNaziv.Location = new System.Drawing.Point(483, 56);
            this.tbaNaziv.Name = "tbaNaziv";
            this.tbaNaziv.Size = new System.Drawing.Size(191, 20);
            this.tbaNaziv.TabIndex = 5;
            // 
            // mitIznajmljivac
            // 
            this.mitIznajmljivac.Location = new System.Drawing.Point(483, 180);
            this.mitIznajmljivac.Name = "mitIznajmljivac";
            this.mitIznajmljivac.Size = new System.Drawing.Size(191, 20);
            this.mitIznajmljivac.TabIndex = 2;
            this.mitIznajmljivac.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(27, 29);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 13);
            this.label31.TabIndex = 1;
            this.label31.Text = "Predizborne akcije";
            // 
            // lvAkcije
            // 
            this.lvAkcije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.akcNaziv,
            this.akcGrad});
            this.lvAkcije.FullRowSelect = true;
            listViewGroup1.Header = "Miting";
            listViewGroup1.Name = "akcMiting";
            listViewGroup2.Header = "Deljenje letaka";
            listViewGroup2.Name = "akcDeljLet";
            listViewGroup3.Header = "Susret kandidata";
            listViewGroup3.Name = "akcSusKand";
            this.lvAkcije.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lvAkcije.Location = new System.Drawing.Point(30, 56);
            this.lvAkcije.Name = "lvAkcije";
            this.lvAkcije.Size = new System.Drawing.Size(285, 359);
            this.lvAkcije.TabIndex = 0;
            this.lvAkcije.UseCompatibleStateImageBehavior = false;
            this.lvAkcije.View = System.Windows.Forms.View.Details;
            this.lvAkcije.SelectedIndexChanged += new System.EventHandler(this.lvAkcije_SelectedIndexChanged);
            // 
            // akcNaziv
            // 
            this.akcNaziv.Text = "Naziv Akcije";
            this.akcNaziv.Width = 94;
            // 
            // akcGrad
            // 
            this.akcGrad.Text = "Grad";
            // 
            // gmesto
            // 
            this.gmesto.BackColor = System.Drawing.Color.SlateGray;
            this.gmesto.Controls.Add(this.btnPrimedbe);
            this.gmesto.Controls.Add(this.btnDodajAktGM);
            this.gmesto.Controls.Add(this.btnObrGM);
            this.gmesto.Controls.Add(this.btnRezIzb);
            this.gmesto.Controls.Add(this.btnAzurGM);
            this.gmesto.Controls.Add(this.labDK);
            this.gmesto.Controls.Add(this.labPK);
            this.gmesto.Controls.Add(this.labAktGM);
            this.gmesto.Controls.Add(this.label30);
            this.gmesto.Controls.Add(this.label29);
            this.gmesto.Controls.Add(this.label28);
            this.gmesto.Controls.Add(this.gmBrojRegBir);
            this.gmesto.Controls.Add(this.gmBrojGM);
            this.gmesto.Controls.Add(this.gmNaziv);
            this.gmesto.Controls.Add(this.novoGM);
            this.gmesto.Controls.Add(this.lvGM);
            this.gmesto.Controls.Add(this.label27);
            this.gmesto.ForeColor = System.Drawing.Color.AliceBlue;
            this.gmesto.Location = new System.Drawing.Point(4, 22);
            this.gmesto.Name = "gmesto";
            this.gmesto.Size = new System.Drawing.Size(998, 609);
            this.gmesto.TabIndex = 5;
            this.gmesto.Text = "Glasačka mesta";
            // 
            // btnPrimedbe
            // 
            this.btnPrimedbe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrimedbe.Location = new System.Drawing.Point(570, 497);
            this.btnPrimedbe.Name = "btnPrimedbe";
            this.btnPrimedbe.Size = new System.Drawing.Size(58, 49);
            this.btnPrimedbe.TabIndex = 94;
            this.btnPrimedbe.Text = "Pogledaj primedbe";
            this.btnPrimedbe.UseVisualStyleBackColor = true;
            this.btnPrimedbe.Click += new System.EventHandler(this.btnPrimedbe_Click);
            // 
            // btnDodajAktGM
            // 
            this.btnDodajAktGM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDodajAktGM.Location = new System.Drawing.Point(469, 497);
            this.btnDodajAktGM.Name = "btnDodajAktGM";
            this.btnDodajAktGM.Size = new System.Drawing.Size(95, 49);
            this.btnDodajAktGM.TabIndex = 93;
            this.btnDodajAktGM.Text = "Dodaj aktivistu na glasačko mesto";
            this.btnDodajAktGM.UseVisualStyleBackColor = true;
            this.btnDodajAktGM.Click += new System.EventHandler(this.dodajAktGM_Click);
            // 
            // btnObrGM
            // 
            this.btnObrGM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnObrGM.Location = new System.Drawing.Point(726, 497);
            this.btnObrGM.Name = "btnObrGM";
            this.btnObrGM.Size = new System.Drawing.Size(82, 49);
            this.btnObrGM.TabIndex = 92;
            this.btnObrGM.Text = "Obriši glasčko mesto";
            this.btnObrGM.UseVisualStyleBackColor = true;
            this.btnObrGM.Click += new System.EventHandler(this.btnObrGM_Click);
            // 
            // btnRezIzb
            // 
            this.btnRezIzb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRezIzb.Location = new System.Drawing.Point(391, 497);
            this.btnRezIzb.Name = "btnRezIzb";
            this.btnRezIzb.Size = new System.Drawing.Size(72, 49);
            this.btnRezIzb.TabIndex = 91;
            this.btnRezIzb.Text = "Dodaj rezultate izbora";
            this.btnRezIzb.UseVisualStyleBackColor = true;
            this.btnRezIzb.Click += new System.EventHandler(this.rezIzb_Click);
            // 
            // btnAzurGM
            // 
            this.btnAzurGM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAzurGM.Location = new System.Drawing.Point(634, 497);
            this.btnAzurGM.Name = "btnAzurGM";
            this.btnAzurGM.Size = new System.Drawing.Size(86, 49);
            this.btnAzurGM.TabIndex = 90;
            this.btnAzurGM.Text = "Ažuriraj glasčko mesto";
            this.btnAzurGM.UseVisualStyleBackColor = true;
            this.btnAzurGM.Click += new System.EventHandler(this.btnAzurGM_Click);
            // 
            // labDK
            // 
            this.labDK.AutoSize = true;
            this.labDK.Location = new System.Drawing.Point(691, 116);
            this.labDK.MaximumSize = new System.Drawing.Size(120, 0);
            this.labDK.Name = "labDK";
            this.labDK.Size = new System.Drawing.Size(0, 13);
            this.labDK.TabIndex = 88;
            // 
            // labPK
            // 
            this.labPK.AutoSize = true;
            this.labPK.Location = new System.Drawing.Point(564, 116);
            this.labPK.MaximumSize = new System.Drawing.Size(120, 0);
            this.labPK.Name = "labPK";
            this.labPK.Size = new System.Drawing.Size(0, 13);
            this.labPK.TabIndex = 87;
            // 
            // labAktGM
            // 
            this.labAktGM.AutoSize = true;
            this.labAktGM.Location = new System.Drawing.Point(388, 116);
            this.labAktGM.MaximumSize = new System.Drawing.Size(150, 0);
            this.labAktGM.Name = "labAktGM";
            this.labAktGM.Size = new System.Drawing.Size(0, 13);
            this.labAktGM.TabIndex = 86;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(579, 81);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(120, 13);
            this.label30.TabIndex = 85;
            this.label30.Text = "Broj registrovanih birača";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(397, 81);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 13);
            this.label29.TabIndex = 84;
            this.label29.Text = "Broj glasačkog mesta";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(388, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 13);
            this.label28.TabIndex = 83;
            this.label28.Text = "Nazvi glasačkog mesta";
            // 
            // gmBrojRegBir
            // 
            this.gmBrojRegBir.Location = new System.Drawing.Point(708, 78);
            this.gmBrojRegBir.Name = "gmBrojRegBir";
            this.gmBrojRegBir.Size = new System.Drawing.Size(100, 20);
            this.gmBrojRegBir.TabIndex = 78;
            // 
            // gmBrojGM
            // 
            this.gmBrojGM.Location = new System.Drawing.Point(511, 78);
            this.gmBrojGM.Name = "gmBrojGM";
            this.gmBrojGM.Size = new System.Drawing.Size(62, 20);
            this.gmBrojGM.TabIndex = 77;
            // 
            // gmNaziv
            // 
            this.gmNaziv.Location = new System.Drawing.Point(511, 48);
            this.gmNaziv.Name = "gmNaziv";
            this.gmNaziv.Size = new System.Drawing.Size(297, 20);
            this.gmNaziv.TabIndex = 76;
            // 
            // novoGM
            // 
            this.novoGM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.novoGM.Location = new System.Drawing.Point(248, 497);
            this.novoGM.Name = "novoGM";
            this.novoGM.Size = new System.Drawing.Size(100, 49);
            this.novoGM.TabIndex = 75;
            this.novoGM.Text = "Dodaj novo glasčko mesto";
            this.novoGM.UseVisualStyleBackColor = true;
            this.novoGM.Click += new System.EventHandler(this.novoGM_Click);
            // 
            // lvGM
            // 
            this.lvGM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gmIme,
            this.brGM,
            this.gmBB});
            this.lvGM.FullRowSelect = true;
            this.lvGM.HideSelection = false;
            this.lvGM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvGM.Location = new System.Drawing.Point(23, 55);
            this.lvGM.MultiSelect = false;
            this.lvGM.Name = "lvGM";
            this.lvGM.Size = new System.Drawing.Size(325, 436);
            this.lvGM.TabIndex = 74;
            this.lvGM.UseCompatibleStateImageBehavior = false;
            this.lvGM.View = System.Windows.Forms.View.Details;
            this.lvGM.SelectedIndexChanged += new System.EventHandler(this.lvGM_SelectedIndexChanged);
            // 
            // gmIme
            // 
            this.gmIme.Text = "Naziv";
            this.gmIme.Width = 200;
            // 
            // brGM
            // 
            this.brGM.Text = "Broj";
            this.brGM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.brGM.Width = 38;
            // 
            // gmBB
            // 
            this.gmBB.Text = "Broj birača";
            this.gmBB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gmBB.Width = 69;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Glasčka mesta";
            // 
            // mediji
            // 
            this.mediji.BackColor = System.Drawing.Color.SlateGray;
            this.mediji.Controls.Add(this.lNazivEmisije);
            this.mediji.Controls.Add(this.lNazivStanice);
            this.mediji.Controls.Add(this.lProcenjenaGledanost);
            this.mediji.Controls.Add(this.lImeVoditelja);
            this.mediji.Controls.Add(this.btnUkloniPitanje);
            this.mediji.Controls.Add(this.btnDodajPitanje);
            this.mediji.Controls.Add(this.cbPitanje);
            this.mediji.Controls.Add(this.lPitanja);
            this.mediji.Controls.Add(this.btnUkloniProtivkandidata);
            this.mediji.Controls.Add(this.btnDodajProtivkandidata);
            this.mediji.Controls.Add(this.cbProtivKandidati);
            this.mediji.Controls.Add(this.lImeProtivkand);
            this.mediji.Controls.Add(this.tbProcenjenaGledanost);
            this.mediji.Controls.Add(this.tbImeVoditelja);
            this.mediji.Controls.Add(this.tbNazivEmisije);
            this.mediji.Controls.Add(this.tbNazivStanice);
            this.mediji.Controls.Add(this.chBoxTVDuel);
            this.mediji.Controls.Add(this.btnAddGostovanje);
            this.mediji.Controls.Add(this.btnRemoveGostovanje);
            this.mediji.Controls.Add(this.btnUpdateGostovanje);
            this.mediji.Controls.Add(this.btnUkloniNovinara);
            this.mediji.Controls.Add(this.btnDodajNovinara);
            this.mediji.Controls.Add(this.cbNovinari);
            this.mediji.Controls.Add(this.lNovinari);
            this.mediji.Controls.Add(this.tbNazivLista);
            this.mediji.Controls.Add(this.lNazivLista);
            this.mediji.Controls.Add(this.lDatumObjavljivanja);
            this.mediji.Controls.Add(this.calObjavljivanja);
            this.mediji.Controls.Add(this.lDatumIntervjua);
            this.mediji.Controls.Add(this.calIntervjua);
            this.mediji.Controls.Add(this.rBtnTVRadio);
            this.mediji.Controls.Add(this.rBtnNovine);
            this.mediji.Controls.Add(this.Naslov);
            this.mediji.Controls.Add(this.listaPojavljivanja);
            this.mediji.ForeColor = System.Drawing.Color.Azure;
            this.mediji.Location = new System.Drawing.Point(4, 22);
            this.mediji.Name = "mediji";
            this.mediji.Size = new System.Drawing.Size(998, 609);
            this.mediji.TabIndex = 2;
            this.mediji.Text = "Kandidat u medijima";
            // 
            // lNazivEmisije
            // 
            this.lNazivEmisije.AutoSize = true;
            this.lNazivEmisije.Location = new System.Drawing.Point(470, 77);
            this.lNazivEmisije.Name = "lNazivEmisije";
            this.lNazivEmisije.Size = new System.Drawing.Size(72, 13);
            this.lNazivEmisije.TabIndex = 133;
            this.lNazivEmisije.Text = "Naziv Emisije:";
            this.lNazivEmisije.Visible = false;
            // 
            // lNazivStanice
            // 
            this.lNazivStanice.AutoSize = true;
            this.lNazivStanice.Location = new System.Drawing.Point(466, 45);
            this.lNazivStanice.Name = "lNazivStanice";
            this.lNazivStanice.Size = new System.Drawing.Size(76, 13);
            this.lNazivStanice.TabIndex = 132;
            this.lNazivStanice.Text = "Naziv Stanice:";
            this.lNazivStanice.Visible = false;
            // 
            // lProcenjenaGledanost
            // 
            this.lProcenjenaGledanost.AutoSize = true;
            this.lProcenjenaGledanost.ForeColor = System.Drawing.Color.Azure;
            this.lProcenjenaGledanost.Location = new System.Drawing.Point(427, 130);
            this.lProcenjenaGledanost.Name = "lProcenjenaGledanost";
            this.lProcenjenaGledanost.Size = new System.Drawing.Size(115, 13);
            this.lProcenjenaGledanost.TabIndex = 131;
            this.lProcenjenaGledanost.Text = "Procenjena Gledanost:";
            this.lProcenjenaGledanost.Visible = false;
            // 
            // lImeVoditelja
            // 
            this.lImeVoditelja.AutoSize = true;
            this.lImeVoditelja.ForeColor = System.Drawing.Color.Azure;
            this.lImeVoditelja.Location = new System.Drawing.Point(472, 104);
            this.lImeVoditelja.Name = "lImeVoditelja";
            this.lImeVoditelja.Size = new System.Drawing.Size(70, 13);
            this.lImeVoditelja.TabIndex = 130;
            this.lImeVoditelja.Text = "Ime Voditelja:";
            this.lImeVoditelja.Visible = false;
            // 
            // btnUkloniPitanje
            // 
            this.btnUkloniPitanje.Enabled = false;
            this.btnUkloniPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniPitanje.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUkloniPitanje.Location = new System.Drawing.Point(734, 177);
            this.btnUkloniPitanje.Name = "btnUkloniPitanje";
            this.btnUkloniPitanje.Size = new System.Drawing.Size(24, 23);
            this.btnUkloniPitanje.TabIndex = 129;
            this.btnUkloniPitanje.Text = "-";
            this.btnUkloniPitanje.UseVisualStyleBackColor = true;
            this.btnUkloniPitanje.Visible = false;
            this.btnUkloniPitanje.Click += new System.EventHandler(this.btnUkloniPitanje_Click);
            // 
            // btnDodajPitanje
            // 
            this.btnDodajPitanje.Enabled = false;
            this.btnDodajPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPitanje.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDodajPitanje.Location = new System.Drawing.Point(706, 177);
            this.btnDodajPitanje.Name = "btnDodajPitanje";
            this.btnDodajPitanje.Size = new System.Drawing.Size(24, 23);
            this.btnDodajPitanje.TabIndex = 128;
            this.btnDodajPitanje.Text = "+";
            this.btnDodajPitanje.UseVisualStyleBackColor = true;
            this.btnDodajPitanje.Visible = false;
            this.btnDodajPitanje.Click += new System.EventHandler(this.btnDodajPitanje_Click);
            // 
            // cbPitanje
            // 
            this.cbPitanje.Enabled = false;
            this.cbPitanje.FormattingEnabled = true;
            this.cbPitanje.Location = new System.Drawing.Point(554, 178);
            this.cbPitanje.Name = "cbPitanje";
            this.cbPitanje.Size = new System.Drawing.Size(146, 21);
            this.cbPitanje.TabIndex = 127;
            this.cbPitanje.Visible = false;
            // 
            // lPitanja
            // 
            this.lPitanja.AutoSize = true;
            this.lPitanja.ForeColor = System.Drawing.Color.Azure;
            this.lPitanja.Location = new System.Drawing.Point(500, 182);
            this.lPitanja.Name = "lPitanja";
            this.lPitanja.Size = new System.Drawing.Size(42, 13);
            this.lPitanja.TabIndex = 126;
            this.lPitanja.Text = "Pitanja:";
            this.lPitanja.Visible = false;
            // 
            // btnUkloniProtivkandidata
            // 
            this.btnUkloniProtivkandidata.Enabled = false;
            this.btnUkloniProtivkandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniProtivkandidata.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUkloniProtivkandidata.Location = new System.Drawing.Point(734, 150);
            this.btnUkloniProtivkandidata.Name = "btnUkloniProtivkandidata";
            this.btnUkloniProtivkandidata.Size = new System.Drawing.Size(24, 23);
            this.btnUkloniProtivkandidata.TabIndex = 125;
            this.btnUkloniProtivkandidata.Text = "-";
            this.btnUkloniProtivkandidata.UseVisualStyleBackColor = true;
            this.btnUkloniProtivkandidata.Visible = false;
            this.btnUkloniProtivkandidata.Click += new System.EventHandler(this.btnUkloniProtivkandidata_Click);
            // 
            // btnDodajProtivkandidata
            // 
            this.btnDodajProtivkandidata.Enabled = false;
            this.btnDodajProtivkandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProtivkandidata.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDodajProtivkandidata.Location = new System.Drawing.Point(706, 150);
            this.btnDodajProtivkandidata.Name = "btnDodajProtivkandidata";
            this.btnDodajProtivkandidata.Size = new System.Drawing.Size(24, 23);
            this.btnDodajProtivkandidata.TabIndex = 124;
            this.btnDodajProtivkandidata.Text = "+";
            this.btnDodajProtivkandidata.UseVisualStyleBackColor = true;
            this.btnDodajProtivkandidata.Visible = false;
            this.btnDodajProtivkandidata.Click += new System.EventHandler(this.btnDodajProtivkandidata_Click);
            // 
            // cbProtivKandidati
            // 
            this.cbProtivKandidati.Enabled = false;
            this.cbProtivKandidati.FormattingEnabled = true;
            this.cbProtivKandidati.Location = new System.Drawing.Point(554, 151);
            this.cbProtivKandidati.Name = "cbProtivKandidati";
            this.cbProtivKandidati.Size = new System.Drawing.Size(146, 21);
            this.cbProtivKandidati.TabIndex = 123;
            this.cbProtivKandidati.Visible = false;
            // 
            // lImeProtivkand
            // 
            this.lImeProtivkand.AutoSize = true;
            this.lImeProtivkand.ForeColor = System.Drawing.Color.Azure;
            this.lImeProtivkand.Location = new System.Drawing.Point(438, 155);
            this.lImeProtivkand.Name = "lImeProtivkand";
            this.lImeProtivkand.Size = new System.Drawing.Size(104, 13);
            this.lImeProtivkand.TabIndex = 122;
            this.lImeProtivkand.Text = "Ime Protivkandidata:";
            this.lImeProtivkand.Visible = false;
            // 
            // tbProcenjenaGledanost
            // 
            this.tbProcenjenaGledanost.Location = new System.Drawing.Point(554, 126);
            this.tbProcenjenaGledanost.Name = "tbProcenjenaGledanost";
            this.tbProcenjenaGledanost.Size = new System.Drawing.Size(199, 20);
            this.tbProcenjenaGledanost.TabIndex = 121;
            this.tbProcenjenaGledanost.Visible = false;
            this.tbProcenjenaGledanost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProcenjenaGledanost_KeyPress);
            // 
            // tbImeVoditelja
            // 
            this.tbImeVoditelja.Location = new System.Drawing.Point(554, 100);
            this.tbImeVoditelja.Name = "tbImeVoditelja";
            this.tbImeVoditelja.Size = new System.Drawing.Size(199, 20);
            this.tbImeVoditelja.TabIndex = 120;
            this.tbImeVoditelja.Visible = false;
            // 
            // tbNazivEmisije
            // 
            this.tbNazivEmisije.Location = new System.Drawing.Point(554, 74);
            this.tbNazivEmisije.Name = "tbNazivEmisije";
            this.tbNazivEmisije.Size = new System.Drawing.Size(199, 20);
            this.tbNazivEmisije.TabIndex = 119;
            this.tbNazivEmisije.Visible = false;
            // 
            // tbNazivStanice
            // 
            this.tbNazivStanice.Location = new System.Drawing.Point(554, 42);
            this.tbNazivStanice.Name = "tbNazivStanice";
            this.tbNazivStanice.Size = new System.Drawing.Size(199, 20);
            this.tbNazivStanice.TabIndex = 118;
            this.tbNazivStanice.Visible = false;
            // 
            // chBoxTVDuel
            // 
            this.chBoxTVDuel.AutoSize = true;
            this.chBoxTVDuel.ForeColor = System.Drawing.Color.Azure;
            this.chBoxTVDuel.Location = new System.Drawing.Point(43, 449);
            this.chBoxTVDuel.Name = "chBoxTVDuel";
            this.chBoxTVDuel.Size = new System.Drawing.Size(112, 17);
            this.chBoxTVDuel.TabIndex = 117;
            this.chBoxTVDuel.Text = "Selektuj TV Duele";
            this.chBoxTVDuel.UseVisualStyleBackColor = true;
            this.chBoxTVDuel.Visible = false;
            this.chBoxTVDuel.CheckedChanged += new System.EventHandler(this.cbTVDuel_CheckedChanged);
            // 
            // btnAddGostovanje
            // 
            this.btnAddGostovanje.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddGostovanje.Location = new System.Drawing.Point(315, 470);
            this.btnAddGostovanje.Name = "btnAddGostovanje";
            this.btnAddGostovanje.Size = new System.Drawing.Size(110, 53);
            this.btnAddGostovanje.TabIndex = 116;
            this.btnAddGostovanje.Text = "Dodaj Novo Pojavljivanje";
            this.btnAddGostovanje.UseVisualStyleBackColor = true;
            this.btnAddGostovanje.Visible = false;
            this.btnAddGostovanje.Click += new System.EventHandler(this.btnAddGostovanje_Click);
            // 
            // btnRemoveGostovanje
            // 
            this.btnRemoveGostovanje.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemoveGostovanje.Location = new System.Drawing.Point(554, 470);
            this.btnRemoveGostovanje.Name = "btnRemoveGostovanje";
            this.btnRemoveGostovanje.Size = new System.Drawing.Size(81, 53);
            this.btnRemoveGostovanje.TabIndex = 115;
            this.btnRemoveGostovanje.Text = "Obriši Odabrano Pojavljivanje";
            this.btnRemoveGostovanje.UseVisualStyleBackColor = true;
            this.btnRemoveGostovanje.Visible = false;
            this.btnRemoveGostovanje.Click += new System.EventHandler(this.btnRemoveGostovanje_Click);
            // 
            // btnUpdateGostovanje
            // 
            this.btnUpdateGostovanje.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateGostovanje.Location = new System.Drawing.Point(637, 470);
            this.btnUpdateGostovanje.Name = "btnUpdateGostovanje";
            this.btnUpdateGostovanje.Size = new System.Drawing.Size(121, 53);
            this.btnUpdateGostovanje.TabIndex = 114;
            this.btnUpdateGostovanje.Text = "Ažuriraj Odabrano Pojavljivanje";
            this.btnUpdateGostovanje.UseVisualStyleBackColor = true;
            this.btnUpdateGostovanje.Visible = false;
            this.btnUpdateGostovanje.Click += new System.EventHandler(this.btnUpdateGostovanje_Click);
            // 
            // btnUkloniNovinara
            // 
            this.btnUkloniNovinara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniNovinara.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUkloniNovinara.Location = new System.Drawing.Point(734, 428);
            this.btnUkloniNovinara.Name = "btnUkloniNovinara";
            this.btnUkloniNovinara.Size = new System.Drawing.Size(24, 23);
            this.btnUkloniNovinara.TabIndex = 113;
            this.btnUkloniNovinara.Text = "-";
            this.btnUkloniNovinara.UseVisualStyleBackColor = true;
            this.btnUkloniNovinara.Visible = false;
            this.btnUkloniNovinara.Click += new System.EventHandler(this.btnUkloniNovinara_Click);
            // 
            // btnDodajNovinara
            // 
            this.btnDodajNovinara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovinara.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDodajNovinara.Location = new System.Drawing.Point(706, 428);
            this.btnDodajNovinara.Name = "btnDodajNovinara";
            this.btnDodajNovinara.Size = new System.Drawing.Size(24, 23);
            this.btnDodajNovinara.TabIndex = 112;
            this.btnDodajNovinara.Text = "+";
            this.btnDodajNovinara.UseVisualStyleBackColor = true;
            this.btnDodajNovinara.Visible = false;
            this.btnDodajNovinara.Click += new System.EventHandler(this.btnDodajNovinara_Click);
            // 
            // cbNovinari
            // 
            this.cbNovinari.FormattingEnabled = true;
            this.cbNovinari.Location = new System.Drawing.Point(554, 428);
            this.cbNovinari.Name = "cbNovinari";
            this.cbNovinari.Size = new System.Drawing.Size(146, 21);
            this.cbNovinari.TabIndex = 111;
            this.cbNovinari.Visible = false;
            // 
            // lNovinari
            // 
            this.lNovinari.AutoSize = true;
            this.lNovinari.ForeColor = System.Drawing.Color.Azure;
            this.lNovinari.Location = new System.Drawing.Point(493, 431);
            this.lNovinari.Name = "lNovinari";
            this.lNovinari.Size = new System.Drawing.Size(49, 13);
            this.lNovinari.TabIndex = 110;
            this.lNovinari.Text = "Novinari:";
            this.lNovinari.Visible = false;
            // 
            // tbNazivLista
            // 
            this.tbNazivLista.Location = new System.Drawing.Point(554, 42);
            this.tbNazivLista.Name = "tbNazivLista";
            this.tbNazivLista.Size = new System.Drawing.Size(199, 20);
            this.tbNazivLista.TabIndex = 109;
            this.tbNazivLista.Visible = false;
            // 
            // lNazivLista
            // 
            this.lNazivLista.AutoSize = true;
            this.lNazivLista.ForeColor = System.Drawing.Color.Azure;
            this.lNazivLista.Location = new System.Drawing.Point(480, 45);
            this.lNazivLista.Name = "lNazivLista";
            this.lNazivLista.Size = new System.Drawing.Size(62, 13);
            this.lNazivLista.TabIndex = 108;
            this.lNazivLista.Text = "Naziv Lista:";
            this.lNazivLista.Visible = false;
            // 
            // lDatumObjavljivanja
            // 
            this.lDatumObjavljivanja.AutoSize = true;
            this.lDatumObjavljivanja.ForeColor = System.Drawing.Color.Azure;
            this.lDatumObjavljivanja.Location = new System.Drawing.Point(438, 254);
            this.lDatumObjavljivanja.Name = "lDatumObjavljivanja";
            this.lDatumObjavljivanja.Size = new System.Drawing.Size(104, 13);
            this.lDatumObjavljivanja.TabIndex = 107;
            this.lDatumObjavljivanja.Text = "Datum Objavljivanja:";
            this.lDatumObjavljivanja.Visible = false;
            // 
            // calObjavljivanja
            // 
            this.calObjavljivanja.Location = new System.Drawing.Point(554, 254);
            this.calObjavljivanja.MaxSelectionCount = 1;
            this.calObjavljivanja.Name = "calObjavljivanja";
            this.calObjavljivanja.ShowToday = false;
            this.calObjavljivanja.TabIndex = 106;
            this.calObjavljivanja.Visible = false;
            // 
            // lDatumIntervjua
            // 
            this.lDatumIntervjua.AutoSize = true;
            this.lDatumIntervjua.ForeColor = System.Drawing.Color.Azure;
            this.lDatumIntervjua.Location = new System.Drawing.Point(457, 74);
            this.lDatumIntervjua.Name = "lDatumIntervjua";
            this.lDatumIntervjua.Size = new System.Drawing.Size(85, 13);
            this.lDatumIntervjua.TabIndex = 105;
            this.lDatumIntervjua.Text = "Datum Intervjua:";
            this.lDatumIntervjua.Visible = false;
            // 
            // calIntervjua
            // 
            this.calIntervjua.Location = new System.Drawing.Point(554, 74);
            this.calIntervjua.MaxSelectionCount = 1;
            this.calIntervjua.Name = "calIntervjua";
            this.calIntervjua.ShowToday = false;
            this.calIntervjua.TabIndex = 104;
            this.calIntervjua.Visible = false;
            // 
            // rBtnTVRadio
            // 
            this.rBtnTVRadio.AutoSize = true;
            this.rBtnTVRadio.ForeColor = System.Drawing.Color.Azure;
            this.rBtnTVRadio.Location = new System.Drawing.Point(169, 51);
            this.rBtnTVRadio.Name = "rBtnTVRadio";
            this.rBtnTVRadio.Size = new System.Drawing.Size(129, 17);
            this.rBtnTVRadio.TabIndex = 92;
            this.rBtnTVRadio.TabStop = true;
            this.rBtnTVRadio.Text = "TV/Radio Gostovanje";
            this.rBtnTVRadio.UseVisualStyleBackColor = true;
            this.rBtnTVRadio.CheckedChanged += new System.EventHandler(this.rBtnTVRadio_CheckedChanged);
            // 
            // rBtnNovine
            // 
            this.rBtnNovine.AutoSize = true;
            this.rBtnNovine.ForeColor = System.Drawing.Color.Azure;
            this.rBtnNovine.Location = new System.Drawing.Point(43, 51);
            this.rBtnNovine.Name = "rBtnNovine";
            this.rBtnNovine.Size = new System.Drawing.Size(120, 17);
            this.rBtnNovine.TabIndex = 91;
            this.rBtnNovine.TabStop = true;
            this.rBtnNovine.Text = "Intervju u Novinama";
            this.rBtnNovine.UseVisualStyleBackColor = true;
            this.rBtnNovine.CheckedChanged += new System.EventHandler(this.rBtnNovine_CheckedChanged);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.ForeColor = System.Drawing.Color.AliceBlue;
            this.Naslov.Location = new System.Drawing.Point(40, 19);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(244, 13);
            this.Naslov.TabIndex = 90;
            this.Naslov.Text = "Pojavljivanje Predsedničkog Kandidata u Medijima";
            // 
            // listaPojavljivanja
            // 
            this.listaPojavljivanja.FullRowSelect = true;
            this.listaPojavljivanja.HideSelection = false;
            this.listaPojavljivanja.Location = new System.Drawing.Point(43, 74);
            this.listaPojavljivanja.MultiSelect = false;
            this.listaPojavljivanja.Name = "listaPojavljivanja";
            this.listaPojavljivanja.Size = new System.Drawing.Size(382, 368);
            this.listaPojavljivanja.TabIndex = 89;
            this.listaPojavljivanja.UseCompatibleStateImageBehavior = false;
            this.listaPojavljivanja.View = System.Windows.Forms.View.Details;
            this.listaPojavljivanja.SelectedIndexChanged += new System.EventHandler(this.listaPojavljivanja_SelectedIndexChanged);
            // 
            // propaganda
            // 
            this.propaganda.BackColor = System.Drawing.Color.SlateGray;
            this.propaganda.Controls.Add(this.propBtnDodaj);
            this.propaganda.Controls.Add(this.propBtnObrisi);
            this.propaganda.Controls.Add(this.propBtnAzur);
            this.propaganda.Controls.Add(this.propCBUBoji);
            this.propaganda.Controls.Add(this.propTxtCenaZakupa);
            this.propaganda.Controls.Add(this.propTxtTrajanjeZakupa);
            this.propaganda.Controls.Add(this.propLblDatum);
            this.propaganda.Controls.Add(this.propLblTrajanje);
            this.propaganda.Controls.Add(this.propLblcena);
            this.propaganda.Controls.Add(this.propTxtMod2);
            this.propaganda.Controls.Add(this.propClndDatumZakupa);
            this.propaganda.Controls.Add(this.propTxtMod3);
            this.propaganda.Controls.Add(this.propLblMod3);
            this.propaganda.Controls.Add(this.propRBTVRad);
            this.propaganda.Controls.Add(this.propRBPano);
            this.propaganda.Controls.Add(this.propRBNovine);
            this.propaganda.Controls.Add(this.label19);
            this.propaganda.Controls.Add(this.propTxtPanoVlasnik);
            this.propaganda.Controls.Add(this.propTxtMod0);
            this.propaganda.Controls.Add(this.propTxtMod1);
            this.propaganda.Controls.Add(this.propLblMod2);
            this.propaganda.Controls.Add(this.propLblMod0);
            this.propaganda.Controls.Add(this.propLblmod1);
            this.propaganda.Controls.Add(this.propLblpropaganda);
            this.propaganda.Controls.Add(this.propagandaListView);
            this.propaganda.ForeColor = System.Drawing.Color.Azure;
            this.propaganda.Location = new System.Drawing.Point(4, 22);
            this.propaganda.Name = "propaganda";
            this.propaganda.Size = new System.Drawing.Size(998, 609);
            this.propaganda.TabIndex = 3;
            this.propaganda.Text = "Propaganda";
            // 
            // propBtnDodaj
            // 
            this.propBtnDodaj.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.propBtnDodaj.Location = new System.Drawing.Point(486, 517);
            this.propBtnDodaj.Name = "propBtnDodaj";
            this.propBtnDodaj.Size = new System.Drawing.Size(110, 53);
            this.propBtnDodaj.TabIndex = 11;
            this.propBtnDodaj.Text = "Dodaj novu propagandu";
            this.propBtnDodaj.UseVisualStyleBackColor = true;
            this.propBtnDodaj.Click += new System.EventHandler(this.button11_Click);
            // 
            // propBtnObrisi
            // 
            this.propBtnObrisi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.propBtnObrisi.Location = new System.Drawing.Point(694, 517);
            this.propBtnObrisi.Name = "propBtnObrisi";
            this.propBtnObrisi.Size = new System.Drawing.Size(81, 53);
            this.propBtnObrisi.TabIndex = 16;
            this.propBtnObrisi.Text = "Obriši odabranu propagandu";
            this.propBtnObrisi.UseVisualStyleBackColor = true;
            this.propBtnObrisi.Click += new System.EventHandler(this.button12_Click);
            // 
            // propBtnAzur
            // 
            this.propBtnAzur.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.propBtnAzur.Location = new System.Drawing.Point(800, 517);
            this.propBtnAzur.Name = "propBtnAzur";
            this.propBtnAzur.Size = new System.Drawing.Size(121, 53);
            this.propBtnAzur.TabIndex = 15;
            this.propBtnAzur.Text = "Ažuriraj odabranu propagandu";
            this.propBtnAzur.UseVisualStyleBackColor = true;
            this.propBtnAzur.Click += new System.EventHandler(this.button13_Click);
            // 
            // propCBUBoji
            // 
            this.propCBUBoji.AutoSize = true;
            this.propCBUBoji.Location = new System.Drawing.Point(695, 431);
            this.propCBUBoji.Name = "propCBUBoji";
            this.propCBUBoji.Size = new System.Drawing.Size(15, 14);
            this.propCBUBoji.TabIndex = 8;
            this.propCBUBoji.UseVisualStyleBackColor = true;
            // 
            // propTxtCenaZakupa
            // 
            this.propTxtCenaZakupa.Location = new System.Drawing.Point(692, 67);
            this.propTxtCenaZakupa.Name = "propTxtCenaZakupa";
            this.propTxtCenaZakupa.Size = new System.Drawing.Size(204, 20);
            this.propTxtCenaZakupa.TabIndex = 4;
            // 
            // propTxtTrajanjeZakupa
            // 
            this.propTxtTrajanjeZakupa.Location = new System.Drawing.Point(694, 273);
            this.propTxtTrajanjeZakupa.Name = "propTxtTrajanjeZakupa";
            this.propTxtTrajanjeZakupa.Size = new System.Drawing.Size(204, 20);
            this.propTxtTrajanjeZakupa.TabIndex = 6;
            this.propTxtTrajanjeZakupa.TextChanged += new System.EventHandler(this.propTxtTrajanjeZakupa_TextChanged);
            // 
            // propLblDatum
            // 
            this.propLblDatum.AutoSize = true;
            this.propLblDatum.ForeColor = System.Drawing.Color.Azure;
            this.propLblDatum.Location = new System.Drawing.Point(607, 99);
            this.propLblDatum.Name = "propLblDatum";
            this.propLblDatum.Size = new System.Drawing.Size(81, 13);
            this.propLblDatum.TabIndex = 103;
            this.propLblDatum.Text = "Datum Zakupa:";
            // 
            // propLblTrajanje
            // 
            this.propLblTrajanje.AutoSize = true;
            this.propLblTrajanje.ForeColor = System.Drawing.Color.Azure;
            this.propLblTrajanje.Location = new System.Drawing.Point(602, 276);
            this.propLblTrajanje.Name = "propLblTrajanje";
            this.propLblTrajanje.Size = new System.Drawing.Size(88, 13);
            this.propLblTrajanje.TabIndex = 102;
            this.propLblTrajanje.Text = "Trajanje Zakupa:";
            // 
            // propLblcena
            // 
            this.propLblcena.AutoSize = true;
            this.propLblcena.ForeColor = System.Drawing.Color.Azure;
            this.propLblcena.Location = new System.Drawing.Point(613, 70);
            this.propLblcena.Name = "propLblcena";
            this.propLblcena.Size = new System.Drawing.Size(75, 13);
            this.propLblcena.TabIndex = 101;
            this.propLblcena.Text = "Cena Zakupa:";
            // 
            // propTxtMod2
            // 
            this.propTxtMod2.Location = new System.Drawing.Point(694, 454);
            this.propTxtMod2.Name = "propTxtMod2";
            this.propTxtMod2.Size = new System.Drawing.Size(204, 20);
            this.propTxtMod2.TabIndex = 9;
            this.propTxtMod2.Visible = false;
            // 
            // propClndDatumZakupa
            // 
            this.propClndDatumZakupa.Location = new System.Drawing.Point(694, 99);
            this.propClndDatumZakupa.MaxSelectionCount = 100;
            this.propClndDatumZakupa.Name = "propClndDatumZakupa";
            this.propClndDatumZakupa.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2016, 6, 18, 0, 0, 0, 0), new System.DateTime(2016, 6, 20, 0, 0, 0, 0));
            this.propClndDatumZakupa.ShowToday = false;
            this.propClndDatumZakupa.TabIndex = 5;
            this.propClndDatumZakupa.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.propClndDatumZakupa_DateChanged);
            // 
            // propTxtMod3
            // 
            this.propTxtMod3.Location = new System.Drawing.Point(694, 480);
            this.propTxtMod3.Name = "propTxtMod3";
            this.propTxtMod3.Size = new System.Drawing.Size(204, 20);
            this.propTxtMod3.TabIndex = 10;
            this.propTxtMod3.Visible = false;
            // 
            // propLblMod3
            // 
            this.propLblMod3.ForeColor = System.Drawing.Color.Azure;
            this.propLblMod3.Location = new System.Drawing.Point(611, 483);
            this.propLblMod3.Name = "propLblMod3";
            this.propLblMod3.Size = new System.Drawing.Size(77, 13);
            this.propLblMod3.TabIndex = 92;
            this.propLblMod3.Text = "Površina:";
            this.propLblMod3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propRBTVRad
            // 
            this.propRBTVRad.AutoSize = true;
            this.propRBTVRad.ForeColor = System.Drawing.Color.Azure;
            this.propRBTVRad.Location = new System.Drawing.Point(146, 70);
            this.propRBTVRad.Name = "propRBTVRad";
            this.propRBTVRad.Size = new System.Drawing.Size(72, 17);
            this.propRBTVRad.TabIndex = 2;
            this.propRBTVRad.TabStop = true;
            this.propRBTVRad.Text = "TV/Radio";
            this.propRBTVRad.UseVisualStyleBackColor = true;
            this.propRBTVRad.CheckedChanged += new System.EventHandler(this.propRBTVRad_CheckedChanged);
            // 
            // propRBPano
            // 
            this.propRBPano.AutoSize = true;
            this.propRBPano.ForeColor = System.Drawing.Color.Azure;
            this.propRBPano.Location = new System.Drawing.Point(90, 70);
            this.propRBPano.Name = "propRBPano";
            this.propRBPano.Size = new System.Drawing.Size(50, 17);
            this.propRBPano.TabIndex = 1;
            this.propRBPano.TabStop = true;
            this.propRBPano.Text = "Pano";
            this.propRBPano.UseVisualStyleBackColor = true;
            this.propRBPano.CheckedChanged += new System.EventHandler(this.propRBPano_CheckedChanged);
            // 
            // propRBNovine
            // 
            this.propRBNovine.AutoSize = true;
            this.propRBNovine.ForeColor = System.Drawing.Color.Azure;
            this.propRBNovine.Location = new System.Drawing.Point(25, 70);
            this.propRBNovine.Name = "propRBNovine";
            this.propRBNovine.Size = new System.Drawing.Size(59, 17);
            this.propRBNovine.TabIndex = 0;
            this.propRBNovine.TabStop = true;
            this.propRBNovine.Text = "Novine";
            this.propRBNovine.UseVisualStyleBackColor = true;
            this.propRBNovine.CheckedChanged += new System.EventHandler(this.propRBNovine_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(923, 428);
            this.label19.MaximumSize = new System.Drawing.Size(205, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 86;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propTxtPanoVlasnik
            // 
            this.propTxtPanoVlasnik.Location = new System.Drawing.Point(694, 454);
            this.propTxtPanoVlasnik.Name = "propTxtPanoVlasnik";
            this.propTxtPanoVlasnik.Size = new System.Drawing.Size(204, 20);
            this.propTxtPanoVlasnik.TabIndex = 85;
            this.propTxtPanoVlasnik.Visible = false;
            // 
            // propTxtMod0
            // 
            this.propTxtMod0.Location = new System.Drawing.Point(694, 402);
            this.propTxtMod0.Name = "propTxtMod0";
            this.propTxtMod0.Size = new System.Drawing.Size(204, 20);
            this.propTxtMod0.TabIndex = 7;
            // 
            // propTxtMod1
            // 
            this.propTxtMod1.Location = new System.Drawing.Point(694, 428);
            this.propTxtMod1.Name = "propTxtMod1";
            this.propTxtMod1.Size = new System.Drawing.Size(204, 20);
            this.propTxtMod1.TabIndex = 82;
            this.propTxtMod1.Visible = false;
            // 
            // propLblMod2
            // 
            this.propLblMod2.ForeColor = System.Drawing.Color.Azure;
            this.propLblMod2.Location = new System.Drawing.Point(602, 457);
            this.propLblMod2.Name = "propLblMod2";
            this.propLblMod2.Size = new System.Drawing.Size(86, 13);
            this.propLblMod2.TabIndex = 80;
            this.propLblMod2.Text = "Vlasnik:";
            this.propLblMod2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propLblMod0
            // 
            this.propLblMod0.ForeColor = System.Drawing.Color.Azure;
            this.propLblMod0.Location = new System.Drawing.Point(611, 405);
            this.propLblMod0.Name = "propLblMod0";
            this.propLblMod0.Size = new System.Drawing.Size(77, 13);
            this.propLblMod0.TabIndex = 77;
            this.propLblMod0.Text = "Grad:";
            this.propLblMod0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propLblmod1
            // 
            this.propLblmod1.ForeColor = System.Drawing.Color.Azure;
            this.propLblmod1.Location = new System.Drawing.Point(608, 431);
            this.propLblmod1.Name = "propLblmod1";
            this.propLblmod1.Size = new System.Drawing.Size(80, 13);
            this.propLblmod1.TabIndex = 76;
            this.propLblmod1.Text = "Reklama je u boji:";
            this.propLblmod1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propLblpropaganda
            // 
            this.propLblpropaganda.AutoSize = true;
            this.propLblpropaganda.ForeColor = System.Drawing.Color.AliceBlue;
            this.propLblpropaganda.Location = new System.Drawing.Point(22, 38);
            this.propLblpropaganda.Name = "propLblpropaganda";
            this.propLblpropaganda.Size = new System.Drawing.Size(65, 13);
            this.propLblpropaganda.TabIndex = 75;
            this.propLblpropaganda.Text = "Propaganda";
            // 
            // propagandaListView
            // 
            this.propagandaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.propagandaListView.FullRowSelect = true;
            this.propagandaListView.HideSelection = false;
            this.propagandaListView.Location = new System.Drawing.Point(25, 93);
            this.propagandaListView.MultiSelect = false;
            this.propagandaListView.Name = "propagandaListView";
            this.propagandaListView.Size = new System.Drawing.Size(571, 418);
            this.propagandaListView.TabIndex = 3;
            this.propagandaListView.UseCompatibleStateImageBehavior = false;
            this.propagandaListView.View = System.Windows.Forms.View.Details;
            this.propagandaListView.SelectedIndexChanged += new System.EventHandler(this.propagandaListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cena zakupa";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum zakupa";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trajanje zakupa";
            this.columnHeader5.Width = 96;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "(S)elect*";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.aktKoord.ResumeLayout(false);
            this.aktKoord.PerformLayout();
            this.akcije.ResumeLayout(false);
            this.akcije.PerformLayout();
            this.gmesto.ResumeLayout(false);
            this.gmesto.PerformLayout();
            this.mediji.ResumeLayout(false);
            this.mediji.PerformLayout();
            this.propaganda.ResumeLayout(false);
            this.propaganda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aktKoord;
        private System.Windows.Forms.TabPage mediji;
        private System.Windows.Forms.TabPage propaganda;
        private System.Windows.Forms.TabPage akcije;
        private System.Windows.Forms.TabPage gmesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button aktObrisi;
        private System.Windows.Forms.Button aktAzuriraj;
        private System.Windows.Forms.Button btnRemoveTelefon;
        private System.Windows.Forms.Button btnAddTelefon;
        private System.Windows.Forms.ComboBox aktTelefon;
        private System.Windows.Forms.Button btnRemoveEmail;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.ComboBox aktMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aktGrad;
        private System.Windows.Forms.TextBox aktBroj;
        private System.Windows.Forms.TextBox aktUlica;
        private System.Windows.Forms.TextBox aktPrezime;
        private System.Windows.Forms.TextBox aktImeRod;
        private System.Windows.Forms.TextBox aktIme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labZaGM;
        private System.Windows.Forms.Label labAkcije;
        private System.Windows.Forms.Label labZaAkc;
        private System.Windows.Forms.CheckBox jeKoord;
        private System.Windows.Forms.Button koordObrisiP;
        private System.Windows.Forms.Button koordDodajP;
        private System.Windows.Forms.ComboBox koorPomoc;
        private System.Windows.Forms.Label koorLab5;
        private System.Windows.Forms.TextBox koorBrojKanc;
        private System.Windows.Forms.TextBox koorUlicaKanc;
        private System.Windows.Forms.Label koorLab2;
        private System.Windows.Forms.Label koorLab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox koorOpstina;
        private System.Windows.Forms.Label koorLab4;
        private System.Windows.Forms.TextBox koorGradKanc;
        private System.Windows.Forms.Label koorLab3;
        private System.Windows.Forms.Button dodajNAkt;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader imeRod;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ListView lvAkt;
        private System.Windows.Forms.ListView lvGM;
        private System.Windows.Forms.TextBox gmNaziv;
        private System.Windows.Forms.TextBox gmBrojGM;
        private System.Windows.Forms.TextBox gmBrojRegBir;
        private System.Windows.Forms.Label labAktGM;
        private System.Windows.Forms.Label labPK;
        private System.Windows.Forms.Label labDK;
        private System.Windows.Forms.Button btnPrimedbe;
        private System.Windows.Forms.Button btnDodajAktGM;
        private System.Windows.Forms.Button btnObrGM;
        private System.Windows.Forms.Button btnRezIzb;
        private System.Windows.Forms.Button btnAzurGM;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button novoGM;
        private System.Windows.Forms.Label labKoord;
        private System.Windows.Forms.Label propLblpropaganda;
        private System.Windows.Forms.ListView propagandaListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox propTxtPanoVlasnik;
        private System.Windows.Forms.Label propLblMod0;
        private System.Windows.Forms.Label propLblmod1;
        private System.Windows.Forms.RadioButton propRBTVRad;
        private System.Windows.Forms.RadioButton propRBPano;
        private System.Windows.Forms.RadioButton propRBNovine;
        private System.Windows.Forms.MonthCalendar propClndDatumZakupa;
        private System.Windows.Forms.TextBox propTxtCenaZakupa;
        private System.Windows.Forms.TextBox propTxtTrajanjeZakupa;
        private System.Windows.Forms.Label propLblDatum;
        private System.Windows.Forms.Label propLblTrajanje;
        private System.Windows.Forms.Label propLblcena;
        private System.Windows.Forms.TextBox propTxtMod2;
        private System.Windows.Forms.TextBox propTxtMod3;
        private System.Windows.Forms.Label propLblMod3;
        private System.Windows.Forms.TextBox propTxtMod0;
        private System.Windows.Forms.TextBox propTxtMod1;
        private System.Windows.Forms.Label propLblMod2;
        private System.Windows.Forms.CheckBox propCBUBoji;
        private System.Windows.Forms.CheckBox chBoxTVDuel;
        private System.Windows.Forms.Button btnAddGostovanje;
        private System.Windows.Forms.Button btnRemoveGostovanje;
        private System.Windows.Forms.Button btnUpdateGostovanje;
        private System.Windows.Forms.Button btnUkloniNovinara;
        private System.Windows.Forms.Button btnDodajNovinara;
        private System.Windows.Forms.ComboBox cbNovinari;
        private System.Windows.Forms.Label lNovinari;
        private System.Windows.Forms.TextBox tbNazivLista;
        private System.Windows.Forms.Label lNazivLista;
        private System.Windows.Forms.Label lDatumObjavljivanja;
        private System.Windows.Forms.MonthCalendar calObjavljivanja;
        private System.Windows.Forms.Label lDatumIntervjua;
        private System.Windows.Forms.MonthCalendar calIntervjua;
        private System.Windows.Forms.RadioButton rBtnTVRadio;
        private System.Windows.Forms.RadioButton rBtnNovine;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.ListView listaPojavljivanja;
        private System.Windows.Forms.Label lNazivEmisije;
        private System.Windows.Forms.Label lNazivStanice;
        private System.Windows.Forms.Label lProcenjenaGledanost;
        private System.Windows.Forms.Label lImeVoditelja;
        private System.Windows.Forms.Button btnUkloniPitanje;
        private System.Windows.Forms.Button btnDodajPitanje;
        private System.Windows.Forms.ComboBox cbPitanje;
        private System.Windows.Forms.Label lPitanja;
        private System.Windows.Forms.Button btnUkloniProtivkandidata;
        private System.Windows.Forms.Button btnDodajProtivkandidata;
        private System.Windows.Forms.ComboBox cbProtivKandidati;
        private System.Windows.Forms.Label lImeProtivkand;
        private System.Windows.Forms.TextBox tbProcenjenaGledanost;
        private System.Windows.Forms.TextBox tbImeVoditelja;
        private System.Windows.Forms.TextBox tbNazivEmisije;
        private System.Windows.Forms.TextBox tbNazivStanice;
        private ColumnHeader gmIme;
        private ColumnHeader brGM;
        private ColumnHeader gmBB;
        private Label label27;
        private TextBox tbaLokacija;
        private ComboBox cbLokacija;
        private TextBox tbaGrad;
        private TextBox tbaNaziv;
        private TextBox mitIznajmljivac;
        private Label label31;
        private ListView lvAkcije;
        private ColumnHeader akcNaziv;
        private ColumnHeader akcGrad;
        private Button btnUpdGuest;
        private Button btnDelGuest;
        private Button btnAngazuj;
        private Button btnAddGuest;
        private Button btnUpdAkc;
        private Button btnDelAkc;
        private Button btnAddAkc;
        private Label labGosti;
        private Label labCena;
        private Label labIznajm;
        private Label labVreme;
        private Label labLok;
        private Label labGrad;
        private Label labNaziv;
        private DateTimePicker susPlaniranoVreme;
        private TextBox mitCena;
        private ListView lvGosti;
        private CheckBox mitZatvoreniP;
        private Label labOdabGost;
        private Label labFunkcija;
        private Label labPrezime;
        private Label labIme;
        private Label labTitula;
        private TextBox tbFunkcija;
        private TextBox tbPrezime;
        private TextBox tbIme;
        private TextBox tbTitula;
        private ColumnHeader gosTitula;
        private ColumnHeader gosIme;
        private ColumnHeader gosPrezime;
        private ColumnHeader gosFunkcija;
        private Button btnObrisiLok;
        private Button btnDodajLok;
        private System.Windows.Forms.Button propBtnDodaj;
        private System.Windows.Forms.Button propBtnObrisi;
        private System.Windows.Forms.Button propBtnAzur;
    }
}

