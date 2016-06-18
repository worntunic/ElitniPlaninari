namespace Izbori
{
    partial class DodajAkciju
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rBtnDeljLet = new System.Windows.Forms.RadioButton();
            this.rBtnSusKand = new System.Windows.Forms.RadioButton();
            this.rBtnMiting = new System.Windows.Forms.RadioButton();
            this.tbNazivAkcije = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.lLokacija = new System.Windows.Forms.Label();
            this.cbZatProst = new System.Windows.Forms.CheckBox();
            this.tbCenaZakupa = new System.Windows.Forms.TextBox();
            this.tbNazivIznajmljivaca = new System.Windows.Forms.TextBox();
            this.lCenaZakupa = new System.Windows.Forms.Label();
            this.lNazivIznajmljivaca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(122, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rBtnDeljLet
            // 
            this.rBtnDeljLet.AutoSize = true;
            this.rBtnDeljLet.Location = new System.Drawing.Point(13, 13);
            this.rBtnDeljLet.Name = "rBtnDeljLet";
            this.rBtnDeljLet.Size = new System.Drawing.Size(99, 17);
            this.rBtnDeljLet.TabIndex = 2;
            this.rBtnDeljLet.TabStop = true;
            this.rBtnDeljLet.Text = "Deljenje Letaka";
            this.rBtnDeljLet.UseVisualStyleBackColor = true;
            this.rBtnDeljLet.CheckedChanged += new System.EventHandler(this.rBtnDeljLet_CheckedChanged);
            // 
            // rBtnSusKand
            // 
            this.rBtnSusKand.AutoSize = true;
            this.rBtnSusKand.Location = new System.Drawing.Point(118, 13);
            this.rBtnSusKand.Name = "rBtnSusKand";
            this.rBtnSusKand.Size = new System.Drawing.Size(112, 17);
            this.rBtnSusKand.TabIndex = 3;
            this.rBtnSusKand.TabStop = true;
            this.rBtnSusKand.Text = "Susreta Kandidata";
            this.rBtnSusKand.UseVisualStyleBackColor = true;
            this.rBtnSusKand.CheckedChanged += new System.EventHandler(this.rBtnSusKand_CheckedChanged);
            // 
            // rBtnMiting
            // 
            this.rBtnMiting.AutoSize = true;
            this.rBtnMiting.Location = new System.Drawing.Point(236, 13);
            this.rBtnMiting.Name = "rBtnMiting";
            this.rBtnMiting.Size = new System.Drawing.Size(53, 17);
            this.rBtnMiting.TabIndex = 4;
            this.rBtnMiting.TabStop = true;
            this.rBtnMiting.Text = "Miting";
            this.rBtnMiting.UseVisualStyleBackColor = true;
            this.rBtnMiting.CheckedChanged += new System.EventHandler(this.rBtnMiting_CheckedChanged);
            // 
            // tbNazivAkcije
            // 
            this.tbNazivAkcije.Location = new System.Drawing.Point(118, 69);
            this.tbNazivAkcije.Name = "tbNazivAkcije";
            this.tbNazivAkcije.Size = new System.Drawing.Size(181, 20);
            this.tbNazivAkcije.TabIndex = 5;
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(118, 95);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(181, 20);
            this.tbGrad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv Akcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grad";
            // 
            // tbLokacija
            // 
            this.tbLokacija.Location = new System.Drawing.Point(118, 121);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(181, 20);
            this.tbLokacija.TabIndex = 9;
            this.tbLokacija.Visible = false;
            // 
            // lLokacija
            // 
            this.lLokacija.AutoSize = true;
            this.lLokacija.Location = new System.Drawing.Point(65, 124);
            this.lLokacija.Name = "lLokacija";
            this.lLokacija.Size = new System.Drawing.Size(47, 13);
            this.lLokacija.TabIndex = 10;
            this.lLokacija.Text = "Lokacija";
            this.lLokacija.Visible = false;
            // 
            // cbZatProst
            // 
            this.cbZatProst.AutoSize = true;
            this.cbZatProst.Location = new System.Drawing.Point(192, 36);
            this.cbZatProst.Name = "cbZatProst";
            this.cbZatProst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbZatProst.Size = new System.Drawing.Size(107, 17);
            this.cbZatProst.TabIndex = 11;
            this.cbZatProst.Text = "Zatvoreni Prostor";
            this.cbZatProst.UseVisualStyleBackColor = true;
            this.cbZatProst.Visible = false;
            this.cbZatProst.CheckedChanged += new System.EventHandler(this.cbZatProst_CheckedChanged);
            // 
            // tbCenaZakupa
            // 
            this.tbCenaZakupa.Location = new System.Drawing.Point(118, 147);
            this.tbCenaZakupa.Name = "tbCenaZakupa";
            this.tbCenaZakupa.Size = new System.Drawing.Size(181, 20);
            this.tbCenaZakupa.TabIndex = 12;
            this.tbCenaZakupa.Visible = false;
            // 
            // tbNazivIznajmljivaca
            // 
            this.tbNazivIznajmljivaca.Location = new System.Drawing.Point(118, 173);
            this.tbNazivIznajmljivaca.Name = "tbNazivIznajmljivaca";
            this.tbNazivIznajmljivaca.Size = new System.Drawing.Size(181, 20);
            this.tbNazivIznajmljivaca.TabIndex = 13;
            this.tbNazivIznajmljivaca.Visible = false;
            // 
            // lCenaZakupa
            // 
            this.lCenaZakupa.AutoSize = true;
            this.lCenaZakupa.Location = new System.Drawing.Point(40, 150);
            this.lCenaZakupa.Name = "lCenaZakupa";
            this.lCenaZakupa.Size = new System.Drawing.Size(72, 13);
            this.lCenaZakupa.TabIndex = 14;
            this.lCenaZakupa.Text = "Cena Zakupa";
            this.lCenaZakupa.Visible = false;
            // 
            // lNazivIznajmljivaca
            // 
            this.lNazivIznajmljivaca.AutoSize = true;
            this.lNazivIznajmljivaca.Location = new System.Drawing.Point(15, 176);
            this.lNazivIznajmljivaca.Name = "lNazivIznajmljivaca";
            this.lNazivIznajmljivaca.Size = new System.Drawing.Size(97, 13);
            this.lNazivIznajmljivaca.TabIndex = 15;
            this.lNazivIznajmljivaca.Text = "Naziv Iznajmljivača";
            this.lNazivIznajmljivaca.Visible = false;
            // 
            // DodajAkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 248);
            this.Controls.Add(this.lNazivIznajmljivaca);
            this.Controls.Add(this.lCenaZakupa);
            this.Controls.Add(this.tbNazivIznajmljivaca);
            this.Controls.Add(this.tbCenaZakupa);
            this.Controls.Add(this.cbZatProst);
            this.Controls.Add(this.lLokacija);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.tbNazivAkcije);
            this.Controls.Add(this.rBtnMiting);
            this.Controls.Add(this.rBtnSusKand);
            this.Controls.Add(this.rBtnDeljLet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "DodajAkciju";
            this.Text = "Dodaj Akciju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rBtnDeljLet;
        private System.Windows.Forms.RadioButton rBtnSusKand;
        private System.Windows.Forms.RadioButton rBtnMiting;
        private System.Windows.Forms.TextBox tbNazivAkcije;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.Label lLokacija;
        private System.Windows.Forms.CheckBox cbZatProst;
        private System.Windows.Forms.TextBox tbCenaZakupa;
        private System.Windows.Forms.TextBox tbNazivIznajmljivaca;
        private System.Windows.Forms.Label lCenaZakupa;
        private System.Windows.Forms.Label lNazivIznajmljivaca;
    }
}