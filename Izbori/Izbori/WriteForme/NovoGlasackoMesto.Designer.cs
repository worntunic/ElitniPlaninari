namespace Izbori.WriteForme
{
    partial class NovoGlasackoMesto
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
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBrojRegBir = new System.Windows.Forms.TextBox();
            this.tbBrojGM = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(55, 6);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(249, 20);
            this.tbNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj registrovanih birača";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj glasačkog mesta";
            // 
            // tbBrojRegBir
            // 
            this.tbBrojRegBir.Location = new System.Drawing.Point(213, 29);
            this.tbBrojRegBir.Name = "tbBrojRegBir";
            this.tbBrojRegBir.Size = new System.Drawing.Size(91, 20);
            this.tbBrojRegBir.TabIndex = 4;
            this.tbBrojRegBir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojRegBir_KeyPress);
            // 
            // tbBrojGM
            // 
            this.tbBrojGM.Location = new System.Drawing.Point(213, 55);
            this.tbBrojGM.Name = "tbBrojGM";
            this.tbBrojGM.Size = new System.Drawing.Size(91, 20);
            this.tbBrojGM.TabIndex = 5;
            this.tbBrojGM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojGM_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(213, 87);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NovoGlasackoMesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 128);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbBrojGM);
            this.Controls.Add(this.tbBrojRegBir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label1);
            this.Name = "NovoGlasackoMesto";
            this.Text = "Dodaj Glasačko Mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBrojRegBir;
        private System.Windows.Forms.TextBox tbBrojGM;
        private System.Windows.Forms.Button btnOK;
    }
}