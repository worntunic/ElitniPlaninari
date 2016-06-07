namespace Izbori.WriteForme
{
    partial class NovoPojPKNovine
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
            this.tbNazivLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateObjavljivanja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateIntervjua = new System.Windows.Forms.DateTimePicker();
            this.cbNovinari = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRemoveNovinar = new System.Windows.Forms.Button();
            this.btnAddNovinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNazivLista
            // 
            this.tbNazivLista.Location = new System.Drawing.Point(126, 12);
            this.tbNazivLista.Name = "tbNazivLista";
            this.tbNazivLista.Size = new System.Drawing.Size(200, 20);
            this.tbNazivLista.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Naziv Lista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Datum Objavljivanja:";
            // 
            // dateObjavljivanja
            // 
            this.dateObjavljivanja.Location = new System.Drawing.Point(126, 38);
            this.dateObjavljivanja.Name = "dateObjavljivanja";
            this.dateObjavljivanja.Size = new System.Drawing.Size(200, 20);
            this.dateObjavljivanja.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Datum Intervjua:";
            // 
            // dateIntervjua
            // 
            this.dateIntervjua.Location = new System.Drawing.Point(126, 64);
            this.dateIntervjua.Name = "dateIntervjua";
            this.dateIntervjua.Size = new System.Drawing.Size(200, 20);
            this.dateIntervjua.TabIndex = 20;
            // 
            // cbNovinari
            // 
            this.cbNovinari.FormattingEnabled = true;
            this.cbNovinari.Location = new System.Drawing.Point(126, 90);
            this.cbNovinari.Name = "cbNovinari";
            this.cbNovinari.Size = new System.Drawing.Size(146, 21);
            this.cbNovinari.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Novinari:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 117);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRemoveNovinar
            // 
            this.btnRemoveNovinar.Location = new System.Drawing.Point(302, 88);
            this.btnRemoveNovinar.Name = "btnRemoveNovinar";
            this.btnRemoveNovinar.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveNovinar.TabIndex = 31;
            this.btnRemoveNovinar.Text = "-";
            this.btnRemoveNovinar.UseVisualStyleBackColor = true;
            this.btnRemoveNovinar.Click += new System.EventHandler(this.btnRemoveNovinar_Click);
            // 
            // btnAddNovinar
            // 
            this.btnAddNovinar.Location = new System.Drawing.Point(278, 88);
            this.btnAddNovinar.Name = "btnAddNovinar";
            this.btnAddNovinar.Size = new System.Drawing.Size(24, 23);
            this.btnAddNovinar.TabIndex = 30;
            this.btnAddNovinar.Text = "+";
            this.btnAddNovinar.UseVisualStyleBackColor = true;
            this.btnAddNovinar.Click += new System.EventHandler(this.btnAddNovinar_Click);
            // 
            // NovoPojPKNovine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 156);
            this.Controls.Add(this.btnRemoveNovinar);
            this.Controls.Add(this.btnAddNovinar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbNovinari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateIntervjua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateObjavljivanja);
            this.Controls.Add(this.tbNazivLista);
            this.Controls.Add(this.label1);
            this.Name = "NovoPojPKNovine";
            this.Text = "Dodaj Pojavljivanje Predsedničkog Kandidata u Novinama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazivLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateObjavljivanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIntervjua;
        private System.Windows.Forms.ComboBox cbNovinari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemoveNovinar;
        private System.Windows.Forms.Button btnAddNovinar;
    }
}