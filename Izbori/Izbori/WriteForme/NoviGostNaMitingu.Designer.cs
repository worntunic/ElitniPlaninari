namespace Izbori.WriteForme
{
    partial class NoviGostNaMitingu
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
            this.btnRemoveGost = new System.Windows.Forms.Button();
            this.btnAddGost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGosti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMitinzi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRemoveGost
            // 
            this.btnRemoveGost.Location = new System.Drawing.Point(259, 36);
            this.btnRemoveGost.Name = "btnRemoveGost";
            this.btnRemoveGost.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveGost.TabIndex = 46;
            this.btnRemoveGost.Text = "-";
            this.btnRemoveGost.UseVisualStyleBackColor = true;
            this.btnRemoveGost.Click += new System.EventHandler(this.btnRemoveGost_Click);
            // 
            // btnAddGost
            // 
            this.btnAddGost.Location = new System.Drawing.Point(235, 36);
            this.btnAddGost.Name = "btnAddGost";
            this.btnAddGost.Size = new System.Drawing.Size(24, 23);
            this.btnAddGost.TabIndex = 45;
            this.btnAddGost.Text = "+";
            this.btnAddGost.UseVisualStyleBackColor = true;
            this.btnAddGost.Click += new System.EventHandler(this.btnAddGost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Zatvori";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(83, 75);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "Dodaj";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gosti:";
            // 
            // cbGosti
            // 
            this.cbGosti.FormattingEnabled = true;
            this.cbGosti.Location = new System.Drawing.Point(83, 38);
            this.cbGosti.Name = "cbGosti";
            this.cbGosti.Size = new System.Drawing.Size(146, 21);
            this.cbGosti.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Naziv Mitinga:";
            // 
            // cbMitinzi
            // 
            this.cbMitinzi.FormattingEnabled = true;
            this.cbMitinzi.Location = new System.Drawing.Point(83, 12);
            this.cbMitinzi.Name = "cbMitinzi";
            this.cbMitinzi.Size = new System.Drawing.Size(200, 21);
            this.cbMitinzi.TabIndex = 49;
            // 
            // NoviGostNaMitingu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 112);
            this.Controls.Add(this.cbMitinzi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveGost);
            this.Controls.Add(this.btnAddGost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGosti);
            this.Name = "NoviGostNaMitingu";
            this.Text = "Dodaj Goste Na Miting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveGost;
        private System.Windows.Forms.Button btnAddGost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMitinzi;
    }
}