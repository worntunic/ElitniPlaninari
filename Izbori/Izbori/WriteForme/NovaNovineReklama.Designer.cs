namespace Izbori.WriteForme
{
    partial class NovaNovineReklama
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTrajanjeZakupa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeZakupa = new System.Windows.Forms.DateTimePicker();
            this.tbCenaZakupa = new System.Windows.Forms.TextBox();
            this.tbNazivLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUBoji = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(109, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Trajanje Zakupa:";
            // 
            // tbTrajanjeZakupa
            // 
            this.tbTrajanjeZakupa.Location = new System.Drawing.Point(109, 114);
            this.tbTrajanjeZakupa.Name = "tbTrajanjeZakupa";
            this.tbTrajanjeZakupa.Size = new System.Drawing.Size(200, 20);
            this.tbTrajanjeZakupa.TabIndex = 22;
            this.tbTrajanjeZakupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTrajanjeZakupa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Datum Zakupa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cena Zakupa:";
            // 
            // dateTimeZakupa
            // 
            this.dateTimeZakupa.Location = new System.Drawing.Point(109, 88);
            this.dateTimeZakupa.Name = "dateTimeZakupa";
            this.dateTimeZakupa.Size = new System.Drawing.Size(200, 20);
            this.dateTimeZakupa.TabIndex = 18;
            // 
            // tbCenaZakupa
            // 
            this.tbCenaZakupa.Location = new System.Drawing.Point(109, 62);
            this.tbCenaZakupa.Name = "tbCenaZakupa";
            this.tbCenaZakupa.Size = new System.Drawing.Size(200, 20);
            this.tbCenaZakupa.TabIndex = 17;
            this.tbCenaZakupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCenaZakupa_KeyPress);
            // 
            // tbNazivLista
            // 
            this.tbNazivLista.Location = new System.Drawing.Point(109, 12);
            this.tbNazivLista.Name = "tbNazivLista";
            this.tbNazivLista.Size = new System.Drawing.Size(200, 20);
            this.tbNazivLista.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Naziv Lista:";
            // 
            // cbUBoji
            // 
            this.cbUBoji.AutoSize = true;
            this.cbUBoji.Location = new System.Drawing.Point(109, 38);
            this.cbUBoji.Name = "cbUBoji";
            this.cbUBoji.Size = new System.Drawing.Size(60, 17);
            this.cbUBoji.TabIndex = 28;
            this.cbUBoji.Text = "U Boji?";
            this.cbUBoji.UseVisualStyleBackColor = true;
            // 
            // NovaNovineReklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 196);
            this.Controls.Add(this.cbUBoji);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTrajanjeZakupa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeZakupa);
            this.Controls.Add(this.tbCenaZakupa);
            this.Controls.Add(this.tbNazivLista);
            this.Controls.Add(this.label1);
            this.Name = "NovaNovineReklama";
            this.Text = "Dodaj Reklamu u Novinama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTrajanjeZakupa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeZakupa;
        private System.Windows.Forms.TextBox tbCenaZakupa;
        private System.Windows.Forms.TextBox tbNazivLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUBoji;
    }
}