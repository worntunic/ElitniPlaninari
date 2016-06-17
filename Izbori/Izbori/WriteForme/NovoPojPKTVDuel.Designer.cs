namespace Izbori.WriteForme
{
    partial class NovoPojPKTVDuel
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
            this.tbGledanost = new System.Windows.Forms.TextBox();
            this.tbImeVoditelja = new System.Windows.Forms.TextBox();
            this.tbNazivEmisije = new System.Windows.Forms.TextBox();
            this.tbNazivStanice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGledanost
            // 
            this.tbGledanost.Location = new System.Drawing.Point(99, 90);
            this.tbGledanost.Name = "tbGledanost";
            this.tbGledanost.Size = new System.Drawing.Size(200, 20);
            this.tbGledanost.TabIndex = 55;
            this.tbGledanost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGledanost_KeyPress);
            // 
            // tbImeVoditelja
            // 
            this.tbImeVoditelja.Location = new System.Drawing.Point(99, 64);
            this.tbImeVoditelja.Name = "tbImeVoditelja";
            this.tbImeVoditelja.Size = new System.Drawing.Size(200, 20);
            this.tbImeVoditelja.TabIndex = 54;
            // 
            // tbNazivEmisije
            // 
            this.tbNazivEmisije.Location = new System.Drawing.Point(99, 38);
            this.tbNazivEmisije.Name = "tbNazivEmisije";
            this.tbNazivEmisije.Size = new System.Drawing.Size(200, 20);
            this.tbNazivEmisije.TabIndex = 53;
            // 
            // tbNazivStanice
            // 
            this.tbNazivStanice.Location = new System.Drawing.Point(99, 12);
            this.tbNazivStanice.Name = "tbNazivStanice";
            this.tbNazivStanice.Size = new System.Drawing.Size(200, 20);
            this.tbNazivStanice.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(99, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 50;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Ime Voditelja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Naziv Emisije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Naziv Stanice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Gledanost:";
            // 
            // NovoPojPKTVDuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 160);
            this.Controls.Add(this.tbGledanost);
            this.Controls.Add(this.tbImeVoditelja);
            this.Controls.Add(this.tbNazivEmisije);
            this.Controls.Add(this.tbNazivStanice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "NovoPojPKTVDuel";
            this.Text = "Dodaj Pojavljivanje Predsedničkog Kandidata na TV Duel-u";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGledanost;
        private System.Windows.Forms.TextBox tbImeVoditelja;
        private System.Windows.Forms.TextBox tbNazivEmisije;
        private System.Windows.Forms.TextBox tbNazivStanice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}