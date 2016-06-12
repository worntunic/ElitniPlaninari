namespace Izbori.WriteForme
{
    partial class NoviRezultatIzbora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBrojBiraca = new System.Windows.Forms.TextBox();
            this.tbBrojKruga = new System.Windows.Forms.TextBox();
            this.tbProcenatZaKandidata = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGlasackaMesta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj Birača:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj Kruga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Procenat za Kandidata:";
            // 
            // tbBrojBiraca
            // 
            this.tbBrojBiraca.Location = new System.Drawing.Point(145, 12);
            this.tbBrojBiraca.Name = "tbBrojBiraca";
            this.tbBrojBiraca.Size = new System.Drawing.Size(198, 20);
            this.tbBrojBiraca.TabIndex = 3;
            this.tbBrojBiraca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojBiraca_KeyPress);
            // 
            // tbBrojKruga
            // 
            this.tbBrojKruga.Location = new System.Drawing.Point(145, 38);
            this.tbBrojKruga.MaxLength = 1;
            this.tbBrojKruga.Name = "tbBrojKruga";
            this.tbBrojKruga.Size = new System.Drawing.Size(198, 20);
            this.tbBrojKruga.TabIndex = 4;
            this.tbBrojKruga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojKruga_KeyPress);
            // 
            // tbProcenatZaKandidata
            // 
            this.tbProcenatZaKandidata.Location = new System.Drawing.Point(145, 64);
            this.tbProcenatZaKandidata.Name = "tbProcenatZaKandidata";
            this.tbProcenatZaKandidata.Size = new System.Drawing.Size(198, 20);
            this.tbProcenatZaKandidata.TabIndex = 5;
            this.tbProcenatZaKandidata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProcenatZaKandidata_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(143, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Naziv Glasačkog Mesta:";
            // 
            // cbGlasackaMesta
            // 
            this.cbGlasackaMesta.FormattingEnabled = true;
            this.cbGlasackaMesta.Location = new System.Drawing.Point(145, 91);
            this.cbGlasackaMesta.Name = "cbGlasackaMesta";
            this.cbGlasackaMesta.Size = new System.Drawing.Size(198, 21);
            this.cbGlasackaMesta.TabIndex = 25;
            // 
            // NoviRezultatIzbora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 156);
            this.Controls.Add(this.cbGlasackaMesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbProcenatZaKandidata);
            this.Controls.Add(this.tbBrojKruga);
            this.Controls.Add(this.tbBrojBiraca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NoviRezultatIzbora";
            this.Text = "Dodaj Rezultate Izbora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBrojBiraca;
        private System.Windows.Forms.TextBox tbBrojKruga;
        private System.Windows.Forms.TextBox tbProcenatZaKandidata;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGlasackaMesta;
    }
}