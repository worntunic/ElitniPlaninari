namespace Izbori.WriteForme
{
    partial class UnaprediUKoordinatora
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
            this.cbAktiviste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUlicaKanc = new System.Windows.Forms.TextBox();
            this.tbBrojKanc = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPomocnici = new System.Windows.Forms.ComboBox();
            this.btnRemoveTelefon = new System.Windows.Forms.Button();
            this.btnAddTelefon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAktiviste
            // 
            this.cbAktiviste.FormattingEnabled = true;
            this.cbAktiviste.Location = new System.Drawing.Point(151, 12);
            this.cbAktiviste.Name = "cbAktiviste";
            this.cbAktiviste.Size = new System.Drawing.Size(206, 21);
            this.cbAktiviste.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktivista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ulica Kancelarije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj Kancelarije:";
            // 
            // tbUlicaKanc
            // 
            this.tbUlicaKanc.Location = new System.Drawing.Point(151, 40);
            this.tbUlicaKanc.Name = "tbUlicaKanc";
            this.tbUlicaKanc.Size = new System.Drawing.Size(206, 20);
            this.tbUlicaKanc.TabIndex = 4;
            // 
            // tbBrojKanc
            // 
            this.tbBrojKanc.Location = new System.Drawing.Point(151, 66);
            this.tbBrojKanc.Name = "tbBrojKanc";
            this.tbBrojKanc.Size = new System.Drawing.Size(206, 20);
            this.tbBrojKanc.TabIndex = 5;
            this.tbBrojKanc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(153, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Pomoćnici:";
            // 
            // cbPomocnici
            // 
            this.cbPomocnici.FormattingEnabled = true;
            this.cbPomocnici.Location = new System.Drawing.Point(151, 92);
            this.cbPomocnici.Name = "cbPomocnici";
            this.cbPomocnici.Size = new System.Drawing.Size(148, 21);
            this.cbPomocnici.TabIndex = 34;
            // 
            // btnRemoveTelefon
            // 
            this.btnRemoveTelefon.Location = new System.Drawing.Point(333, 90);
            this.btnRemoveTelefon.Name = "btnRemoveTelefon";
            this.btnRemoveTelefon.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveTelefon.TabIndex = 38;
            this.btnRemoveTelefon.Text = "-";
            this.btnRemoveTelefon.UseVisualStyleBackColor = true;
            // 
            // btnAddTelefon
            // 
            this.btnAddTelefon.Location = new System.Drawing.Point(305, 90);
            this.btnAddTelefon.Name = "btnAddTelefon";
            this.btnAddTelefon.Size = new System.Drawing.Size(24, 23);
            this.btnAddTelefon.TabIndex = 37;
            this.btnAddTelefon.Text = "+";
            this.btnAddTelefon.UseVisualStyleBackColor = true;
            // 
            // UnaprediUKoordinatora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 161);
            this.Controls.Add(this.btnRemoveTelefon);
            this.Controls.Add(this.btnAddTelefon);
            this.Controls.Add(this.cbPomocnici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbBrojKanc);
            this.Controls.Add(this.tbUlicaKanc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAktiviste);
            this.Name = "UnaprediUKoordinatora";
            this.Text = "Unapredi u Koordinatora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAktiviste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUlicaKanc;
        private System.Windows.Forms.TextBox tbBrojKanc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPomocnici;
        private System.Windows.Forms.Button btnRemoveTelefon;
        private System.Windows.Forms.Button btnAddTelefon;
    }
}