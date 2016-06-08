namespace Izbori.WriteForme
{
    partial class NovaAkcMitinga
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
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazivAkcije = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.cbGosti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbJelZatvoren = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCenaZakupa = new System.Windows.Forms.TextBox();
            this.tbNazivIznajmljivaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveLokacija = new System.Windows.Forms.Button();
            this.btnAddLokacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(113, 38);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(200, 20);
            this.tbGrad.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Naziv Akcije:";
            // 
            // tbNazivAkcije
            // 
            this.tbNazivAkcije.Location = new System.Drawing.Point(113, 12);
            this.tbNazivAkcije.Name = "tbNazivAkcije";
            this.tbNazivAkcije.Size = new System.Drawing.Size(200, 20);
            this.tbNazivAkcije.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Lokacija:";
            // 
            // tbLokacija
            // 
            this.tbLokacija.Location = new System.Drawing.Point(113, 64);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(200, 20);
            this.tbLokacija.TabIndex = 28;
            // 
            // cbGosti
            // 
            this.cbGosti.FormattingEnabled = true;
            this.cbGosti.Location = new System.Drawing.Point(113, 196);
            this.cbGosti.Name = "cbGosti";
            this.cbGosti.Size = new System.Drawing.Size(146, 21);
            this.cbGosti.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Gosti:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(113, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbJelZatvoren
            // 
            this.cbJelZatvoren.AutoSize = true;
            this.cbJelZatvoren.Location = new System.Drawing.Point(113, 95);
            this.cbJelZatvoren.Name = "cbJelZatvoren";
            this.cbJelZatvoren.Size = new System.Drawing.Size(113, 17);
            this.cbJelZatvoren.TabIndex = 34;
            this.cbJelZatvoren.Text = "Zatvoreni Prostor?";
            this.cbJelZatvoren.UseVisualStyleBackColor = true;
            this.cbJelZatvoren.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cena Zakupa:";
            this.label4.Visible = false;
            // 
            // tbCenaZakupa
            // 
            this.tbCenaZakupa.Location = new System.Drawing.Point(113, 144);
            this.tbCenaZakupa.Name = "tbCenaZakupa";
            this.tbCenaZakupa.Size = new System.Drawing.Size(200, 20);
            this.tbCenaZakupa.TabIndex = 37;
            this.tbCenaZakupa.Visible = false;
            this.tbCenaZakupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCenaZakupa_KeyPress);
            // 
            // tbNazivIznajmljivaca
            // 
            this.tbNazivIznajmljivaca.Location = new System.Drawing.Point(113, 118);
            this.tbNazivIznajmljivaca.Name = "tbNazivIznajmljivaca";
            this.tbNazivIznajmljivaca.Size = new System.Drawing.Size(200, 20);
            this.tbNazivIznajmljivaca.TabIndex = 36;
            this.tbNazivIznajmljivaca.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Naziv Iznajmljivača:";
            this.label5.Visible = false;
            // 
            // btnRemoveLokacija
            // 
            this.btnRemoveLokacija.Location = new System.Drawing.Point(289, 194);
            this.btnRemoveLokacija.Name = "btnRemoveLokacija";
            this.btnRemoveLokacija.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveLokacija.TabIndex = 40;
            this.btnRemoveLokacija.Text = "-";
            this.btnRemoveLokacija.UseVisualStyleBackColor = true;
            this.btnRemoveLokacija.Click += new System.EventHandler(this.btnRemoveLokacija_Click);
            // 
            // btnAddLokacija
            // 
            this.btnAddLokacija.Location = new System.Drawing.Point(265, 194);
            this.btnAddLokacija.Name = "btnAddLokacija";
            this.btnAddLokacija.Size = new System.Drawing.Size(24, 23);
            this.btnAddLokacija.TabIndex = 39;
            this.btnAddLokacija.Text = "+";
            this.btnAddLokacija.UseVisualStyleBackColor = true;
            this.btnAddLokacija.Click += new System.EventHandler(this.btnAddLokacija_Click);
            // 
            // NovaAkcMitinga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 258);
            this.Controls.Add(this.btnRemoveLokacija);
            this.Controls.Add(this.btnAddLokacija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCenaZakupa);
            this.Controls.Add(this.tbNazivIznajmljivaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJelZatvoren);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNazivAkcije);
            this.Name = "NovaAkcMitinga";
            this.Text = "Dodaj Akciju Mitinga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivAkcije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.ComboBox cbGosti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbJelZatvoren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCenaZakupa;
        private System.Windows.Forms.TextBox tbNazivIznajmljivaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveLokacija;
        private System.Windows.Forms.Button btnAddLokacija;
    }
}