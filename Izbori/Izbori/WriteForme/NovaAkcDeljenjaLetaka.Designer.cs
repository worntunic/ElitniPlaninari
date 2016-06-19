namespace Izbori.WriteForme
{
    partial class NovaAkcDeljenjaLetaka
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
            this.btnRemoveLokacija = new System.Windows.Forms.Button();
            this.btnAddLokacija = new System.Windows.Forms.Button();
            this.cbLokacija = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(107, 38);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(200, 20);
            this.tbGrad.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Naziv Akcije:";
            // 
            // tbNazivAkcije
            // 
            this.tbNazivAkcije.Location = new System.Drawing.Point(107, 12);
            this.tbNazivAkcije.Name = "tbNazivAkcije";
            this.tbNazivAkcije.Size = new System.Drawing.Size(200, 20);
            this.tbNazivAkcije.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lokacija:";
            // 
            // btnRemoveLokacija
            // 
            this.btnRemoveLokacija.Location = new System.Drawing.Point(283, 62);
            this.btnRemoveLokacija.Name = "btnRemoveLokacija";
            this.btnRemoveLokacija.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveLokacija.TabIndex = 27;
            this.btnRemoveLokacija.Text = "-";
            this.btnRemoveLokacija.UseVisualStyleBackColor = true;
            this.btnRemoveLokacija.Click += new System.EventHandler(this.btnRemoveLokacija_Click);
            // 
            // btnAddLokacija
            // 
            this.btnAddLokacija.Location = new System.Drawing.Point(259, 62);
            this.btnAddLokacija.Name = "btnAddLokacija";
            this.btnAddLokacija.Size = new System.Drawing.Size(24, 23);
            this.btnAddLokacija.TabIndex = 26;
            this.btnAddLokacija.Text = "+";
            this.btnAddLokacija.UseVisualStyleBackColor = true;
            this.btnAddLokacija.Click += new System.EventHandler(this.btnAddLokacija_Click);
            // 
            // cbLokacija
            // 
            this.cbLokacija.FormattingEnabled = true;
            this.cbLokacija.Location = new System.Drawing.Point(107, 64);
            this.cbLokacija.Name = "cbLokacija";
            this.cbLokacija.Size = new System.Drawing.Size(146, 21);
            this.cbLokacija.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(107, 97);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NovaAkcDeljenjaLetaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 132);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRemoveLokacija);
            this.Controls.Add(this.btnAddLokacija);
            this.Controls.Add(this.cbLokacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNazivAkcije);
            this.Name = "NovaAkcDeljenjaLetaka";
            this.Text = "Dodaj Akciju Deljenja Letaka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivAkcije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveLokacija;
        private System.Windows.Forms.Button btnAddLokacija;
        private System.Windows.Forms.ComboBox cbLokacija;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}