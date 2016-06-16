namespace Izbori
{
    partial class ImePrezime
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
            this.aktIme = new System.Windows.Forms.TextBox();
            this.aktImeRod = new System.Windows.Forms.TextBox();
            this.aktPrez = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aktIme
            // 
            this.aktIme.Location = new System.Drawing.Point(13, 25);
            this.aktIme.Name = "aktIme";
            this.aktIme.Size = new System.Drawing.Size(264, 20);
            this.aktIme.TabIndex = 0;
            // 
            // aktImeRod
            // 
            this.aktImeRod.Location = new System.Drawing.Point(12, 64);
            this.aktImeRod.Name = "aktImeRod";
            this.aktImeRod.Size = new System.Drawing.Size(265, 20);
            this.aktImeRod.TabIndex = 1;
            // 
            // aktPrez
            // 
            this.aktPrez.Location = new System.Drawing.Point(12, 104);
            this.aktPrez.Name = "aktPrez";
            this.aktPrez.Size = new System.Drawing.Size(265, 20);
            this.aktPrez.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj aktivistu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime jednog roditelja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime";
            // 
            // ImePrezime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aktPrez);
            this.Controls.Add(this.aktImeRod);
            this.Controls.Add(this.aktIme);
            this.Name = "ImePrezime";
            this.Text = "ImePrezime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aktIme;
        private System.Windows.Forms.TextBox aktImeRod;
        private System.Windows.Forms.TextBox aktPrez;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}