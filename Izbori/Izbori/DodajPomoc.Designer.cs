namespace Izbori
{
    partial class DodajPomoc
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
            this.lvPomoc = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeRod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPomoc
            // 
            this.lvPomoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ime,
            this.imeRod,
            this.prezime});
            this.lvPomoc.FullRowSelect = true;
            this.lvPomoc.HideSelection = false;
            this.lvPomoc.Location = new System.Drawing.Point(14, 47);
            this.lvPomoc.MultiSelect = false;
            this.lvPomoc.Name = "lvPomoc";
            this.lvPomoc.Size = new System.Drawing.Size(349, 368);
            this.lvPomoc.TabIndex = 74;
            this.lvPomoc.UseCompatibleStateImageBehavior = false;
            this.lvPomoc.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            this.ime.Width = 85;
            // 
            // imeRod
            // 
            this.imeRod.Text = "Ime roditelja";
            this.imeRod.Width = 98;
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            this.prezime.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Aktivisti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 34);
            this.button1.TabIndex = 76;
            this.button1.Text = "Dodeli aktivistu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajPomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPomoc);
            this.Name = "DodajPomoc";
            this.Text = "Dodaj pomoćnika";
            this.Load += new System.EventHandler(this.DodajPomoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPomoc;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader imeRod;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}