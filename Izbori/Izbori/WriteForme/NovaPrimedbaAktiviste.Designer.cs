namespace Izbori.WriteForme
{
    partial class NovaPrimedbaAktiviste
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
            this.cbTextPrimedbe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAktivista = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRemovePrimedba = new System.Windows.Forms.Button();
            this.btnAddPrimedba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTextPrimedbe
            // 
            this.cbTextPrimedbe.FormattingEnabled = true;
            this.cbTextPrimedbe.Location = new System.Drawing.Point(86, 39);
            this.cbTextPrimedbe.Name = "cbTextPrimedbe";
            this.cbTextPrimedbe.Size = new System.Drawing.Size(145, 21);
            this.cbTextPrimedbe.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tekst:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Aktivista:";
            // 
            // cbAktivista
            // 
            this.cbAktivista.FormattingEnabled = true;
            this.cbAktivista.Location = new System.Drawing.Point(86, 12);
            this.cbAktivista.Name = "cbAktivista";
            this.cbAktivista.Size = new System.Drawing.Size(203, 21);
            this.cbAktivista.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(85, 75);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRemovePrimedba
            // 
            this.btnRemovePrimedba.Location = new System.Drawing.Point(265, 37);
            this.btnRemovePrimedba.Name = "btnRemovePrimedba";
            this.btnRemovePrimedba.Size = new System.Drawing.Size(24, 23);
            this.btnRemovePrimedba.TabIndex = 45;
            this.btnRemovePrimedba.Text = "-";
            this.btnRemovePrimedba.UseVisualStyleBackColor = true;
            this.btnRemovePrimedba.Click += new System.EventHandler(this.btnRemovePrimedba_Click);
            // 
            // btnAddPrimedba
            // 
            this.btnAddPrimedba.Location = new System.Drawing.Point(237, 37);
            this.btnAddPrimedba.Name = "btnAddPrimedba";
            this.btnAddPrimedba.Size = new System.Drawing.Size(24, 23);
            this.btnAddPrimedba.TabIndex = 44;
            this.btnAddPrimedba.Text = "+";
            this.btnAddPrimedba.UseVisualStyleBackColor = true;
            this.btnAddPrimedba.Click += new System.EventHandler(this.btnAddPrimedba_Click);
            // 
            // NovaPrimedbaAktiviste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 110);
            this.Controls.Add(this.btnRemovePrimedba);
            this.Controls.Add(this.btnAddPrimedba);
            this.Controls.Add(this.cbTextPrimedbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAktivista);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "NovaPrimedbaAktiviste";
            this.Text = "Dodaj Primedbu Aktivisti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTextPrimedbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAktivista;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemovePrimedba;
        private System.Windows.Forms.Button btnAddPrimedba;
    }
}