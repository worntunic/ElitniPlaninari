namespace Izbori
{
    partial class PrimedbeGM
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
            this.cbAkt = new System.Windows.Forms.ComboBox();
            this.lbPrimedbe = new System.Windows.Forms.ListBox();
            this.dodajPrim = new System.Windows.Forms.Button();
            this.obrPrim = new System.Windows.Forms.Button();
            this.azurPrimedbu = new System.Windows.Forms.Button();
            this.primAkt = new System.Windows.Forms.Label();
            this.lblPrimedbe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAkt
            // 
            this.cbAkt.FormattingEnabled = true;
            this.cbAkt.Location = new System.Drawing.Point(12, 21);
            this.cbAkt.Name = "cbAkt";
            this.cbAkt.Size = new System.Drawing.Size(224, 21);
            this.cbAkt.TabIndex = 0;
            this.cbAkt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbPrimedbe
            // 
            this.lbPrimedbe.FormattingEnabled = true;
            this.lbPrimedbe.Location = new System.Drawing.Point(12, 63);
            this.lbPrimedbe.Name = "lbPrimedbe";
            this.lbPrimedbe.Size = new System.Drawing.Size(224, 160);
            this.lbPrimedbe.TabIndex = 1;
            this.lbPrimedbe.SelectedIndexChanged += new System.EventHandler(this.lbPrimedbe_SelectedIndexChanged);
            // 
            // dodajPrim
            // 
            this.dodajPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPrim.Location = new System.Drawing.Point(89, 230);
            this.dodajPrim.Name = "dodajPrim";
            this.dodajPrim.Size = new System.Drawing.Size(70, 23);
            this.dodajPrim.TabIndex = 3;
            this.dodajPrim.Text = "+";
            this.dodajPrim.UseVisualStyleBackColor = true;
            this.dodajPrim.Click += new System.EventHandler(this.dodajPrim_Click);
            // 
            // obrPrim
            // 
            this.obrPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrPrim.Location = new System.Drawing.Point(166, 230);
            this.obrPrim.Name = "obrPrim";
            this.obrPrim.Size = new System.Drawing.Size(70, 23);
            this.obrPrim.TabIndex = 4;
            this.obrPrim.Text = "-";
            this.obrPrim.UseVisualStyleBackColor = true;
            this.obrPrim.Click += new System.EventHandler(this.button2_Click);
            // 
            // azurPrimedbu
            // 
            this.azurPrimedbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azurPrimedbu.Location = new System.Drawing.Point(12, 230);
            this.azurPrimedbu.Name = "azurPrimedbu";
            this.azurPrimedbu.Size = new System.Drawing.Size(70, 23);
            this.azurPrimedbu.TabIndex = 5;
            this.azurPrimedbu.Text = "*";
            this.azurPrimedbu.UseVisualStyleBackColor = true;
            this.azurPrimedbu.Click += new System.EventHandler(this.azurPrimedbu_Click);
            // 
            // primAkt
            // 
            this.primAkt.AutoSize = true;
            this.primAkt.Location = new System.Drawing.Point(12, 4);
            this.primAkt.Name = "primAkt";
            this.primAkt.Size = new System.Drawing.Size(47, 13);
            this.primAkt.TabIndex = 6;
            this.primAkt.Text = "Aktivista";
            // 
            // lblPrimedbe
            // 
            this.lblPrimedbe.AutoSize = true;
            this.lblPrimedbe.Location = new System.Drawing.Point(12, 46);
            this.lblPrimedbe.Name = "lblPrimedbe";
            this.lblPrimedbe.Size = new System.Drawing.Size(51, 13);
            this.lblPrimedbe.TabIndex = 8;
            this.lblPrimedbe.Text = "Primedbe";
            // 
            // PrimedbeGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(253, 271);
            this.Controls.Add(this.lblPrimedbe);
            this.Controls.Add(this.primAkt);
            this.Controls.Add(this.azurPrimedbu);
            this.Controls.Add(this.obrPrim);
            this.Controls.Add(this.dodajPrim);
            this.Controls.Add(this.lbPrimedbe);
            this.Controls.Add(this.cbAkt);
            this.Name = "PrimedbeGM";
            this.Text = "PrimedbeGM";
            this.Load += new System.EventHandler(this.PrimedbeGM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAkt;
        private System.Windows.Forms.ListBox lbPrimedbe;
        private System.Windows.Forms.Button dodajPrim;
        private System.Windows.Forms.Button obrPrim;
        private System.Windows.Forms.Button azurPrimedbu;
        private System.Windows.Forms.Label primAkt;
        private System.Windows.Forms.Label lblPrimedbe;
    }
}