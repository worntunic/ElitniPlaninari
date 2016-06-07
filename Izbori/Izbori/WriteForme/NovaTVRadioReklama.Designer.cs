namespace Izbori.WriteForme
{
    partial class NovaTVRadioReklama
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
            this.tbNazivStanice = new System.Windows.Forms.TextBox();
            this.tbBrojPonavljanja = new System.Windows.Forms.TextBox();
            this.tbCenaZakupa = new System.Windows.Forms.TextBox();
            this.dateTimeZakupa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTrajanjeZakupa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTrajanje = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Stanice:";
            // 
            // tbNazivStanice
            // 
            this.tbNazivStanice.Location = new System.Drawing.Point(114, 12);
            this.tbNazivStanice.Name = "tbNazivStanice";
            this.tbNazivStanice.Size = new System.Drawing.Size(200, 20);
            this.tbNazivStanice.TabIndex = 1;
            // 
            // tbBrojPonavljanja
            // 
            this.tbBrojPonavljanja.Location = new System.Drawing.Point(114, 38);
            this.tbBrojPonavljanja.Name = "tbBrojPonavljanja";
            this.tbBrojPonavljanja.Size = new System.Drawing.Size(200, 20);
            this.tbBrojPonavljanja.TabIndex = 2;
            this.tbBrojPonavljanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojPonavljanja_KeyPress);
            // 
            // tbCenaZakupa
            // 
            this.tbCenaZakupa.Location = new System.Drawing.Point(114, 90);
            this.tbCenaZakupa.Name = "tbCenaZakupa";
            this.tbCenaZakupa.Size = new System.Drawing.Size(200, 20);
            this.tbCenaZakupa.TabIndex = 3;
            this.tbCenaZakupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCenaZakupa_KeyPress);
            // 
            // dateTimeZakupa
            // 
            this.dateTimeZakupa.Location = new System.Drawing.Point(114, 116);
            this.dateTimeZakupa.Name = "dateTimeZakupa";
            this.dateTimeZakupa.Size = new System.Drawing.Size(200, 20);
            this.dateTimeZakupa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj Ponavljanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena Zakupa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum Zakupa:";
            // 
            // tbTrajanjeZakupa
            // 
            this.tbTrajanjeZakupa.Location = new System.Drawing.Point(114, 142);
            this.tbTrajanjeZakupa.Name = "tbTrajanjeZakupa";
            this.tbTrajanjeZakupa.Size = new System.Drawing.Size(200, 20);
            this.tbTrajanjeZakupa.TabIndex = 8;
            this.tbTrajanjeZakupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTrajanjeZakupa_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trajanje Zakupa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trajanje reklame:";
            // 
            // tbTrajanje
            // 
            this.tbTrajanje.Location = new System.Drawing.Point(114, 64);
            this.tbTrajanje.Name = "tbTrajanje";
            this.tbTrajanje.Size = new System.Drawing.Size(200, 20);
            this.tbTrajanje.TabIndex = 11;
            this.tbTrajanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTrajanje_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(114, 177);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NovaTVRadioReklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 212);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbTrajanje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTrajanjeZakupa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeZakupa);
            this.Controls.Add(this.tbCenaZakupa);
            this.Controls.Add(this.tbBrojPonavljanja);
            this.Controls.Add(this.tbNazivStanice);
            this.Controls.Add(this.label1);
            this.Name = "NovaTVRadioReklama";
            this.Text = "Nova TV/Radio Reklama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazivStanice;
        private System.Windows.Forms.TextBox tbBrojPonavljanja;
        private System.Windows.Forms.TextBox tbCenaZakupa;
        private System.Windows.Forms.DateTimePicker dateTimeZakupa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTrajanjeZakupa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTrajanje;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}