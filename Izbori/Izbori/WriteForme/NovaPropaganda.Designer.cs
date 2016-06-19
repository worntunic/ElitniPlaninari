namespace Izbori.WriteForme {
    partial class NovaPropaganda {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.propRBTVRad = new System.Windows.Forms.RadioButton();
            this.propRBPano = new System.Windows.Forms.RadioButton();
            this.propRBNovine = new System.Windows.Forms.RadioButton();
            this.propTxtCenaZakupa = new System.Windows.Forms.TextBox();
            this.propTxtTrajanjeZakupa = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.propClndDatumZakupa = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propRBTVRad
            // 
            this.propRBTVRad.AutoSize = true;
            this.propRBTVRad.Location = new System.Drawing.Point(221, 60);
            this.propRBTVRad.Name = "propRBTVRad";
            this.propRBTVRad.Size = new System.Drawing.Size(72, 17);
            this.propRBTVRad.TabIndex = 92;
            this.propRBTVRad.TabStop = true;
            this.propRBTVRad.Text = "TV/Radio";
            this.propRBTVRad.UseVisualStyleBackColor = true;
            this.propRBTVRad.CheckedChanged += new System.EventHandler(this.propRBTVRad_CheckedChanged);
            // 
            // propRBPano
            // 
            this.propRBPano.AutoSize = true;
            this.propRBPano.Location = new System.Drawing.Point(165, 60);
            this.propRBPano.Name = "propRBPano";
            this.propRBPano.Size = new System.Drawing.Size(50, 17);
            this.propRBPano.TabIndex = 91;
            this.propRBPano.TabStop = true;
            this.propRBPano.Text = "Pano";
            this.propRBPano.UseVisualStyleBackColor = true;
            this.propRBPano.CheckedChanged += new System.EventHandler(this.propRBPano_CheckedChanged);
            // 
            // propRBNovine
            // 
            this.propRBNovine.AutoSize = true;
            this.propRBNovine.Location = new System.Drawing.Point(100, 60);
            this.propRBNovine.Name = "propRBNovine";
            this.propRBNovine.Size = new System.Drawing.Size(59, 17);
            this.propRBNovine.TabIndex = 90;
            this.propRBNovine.TabStop = true;
            this.propRBNovine.Text = "Novine";
            this.propRBNovine.UseVisualStyleBackColor = true;
            this.propRBNovine.CheckedChanged += new System.EventHandler(this.propRBNovine_CheckedChanged);
            // 
            // propTxtCenaZakupa
            // 
            this.propTxtCenaZakupa.Location = new System.Drawing.Point(100, 95);
            this.propTxtCenaZakupa.Name = "propTxtCenaZakupa";
            this.propTxtCenaZakupa.Size = new System.Drawing.Size(204, 20);
            this.propTxtCenaZakupa.TabIndex = 111;
            this.propTxtCenaZakupa.TextChanged += new System.EventHandler(this.propTxtCenaZakupa_TextChanged);
            // 
            // propTxtTrajanjeZakupa
            // 
            this.propTxtTrajanjeZakupa.Location = new System.Drawing.Point(100, 311);
            this.propTxtTrajanjeZakupa.Name = "propTxtTrajanjeZakupa";
            this.propTxtTrajanjeZakupa.Size = new System.Drawing.Size(204, 20);
            this.propTxtTrajanjeZakupa.TabIndex = 110;
            this.propTxtTrajanjeZakupa.TextChanged += new System.EventHandler(this.propTxtTrajanjeZakupa_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
            this.label20.TabIndex = 109;
            this.label20.Text = "Datum Zakupa:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(0, 314);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 13);
            this.label25.TabIndex = 108;
            this.label25.Text = "Trajanje Zakupa:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 98);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 107;
            this.label26.Text = "Cena Zakupa:";
            // 
            // propClndDatumZakupa
            // 
            this.propClndDatumZakupa.Location = new System.Drawing.Point(100, 127);
            this.propClndDatumZakupa.MaxSelectionCount = 100;
            this.propClndDatumZakupa.Name = "propClndDatumZakupa";
            this.propClndDatumZakupa.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2016, 6, 18, 0, 0, 0, 0), new System.DateTime(2016, 6, 20, 0, 0, 0, 0));
            this.propClndDatumZakupa.ShowToday = false;
            this.propClndDatumZakupa.TabIndex = 106;
            this.propClndDatumZakupa.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.propClndDatumZakupa_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Tip Propagande:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 113;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 114;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NovaPropaganda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propTxtCenaZakupa);
            this.Controls.Add(this.propTxtTrajanjeZakupa);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.propClndDatumZakupa);
            this.Controls.Add(this.propRBTVRad);
            this.Controls.Add(this.propRBPano);
            this.Controls.Add(this.propRBNovine);
            this.Name = "NovaPropaganda";
            this.Text = "Dodaj propagandu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton propRBTVRad;
        private System.Windows.Forms.RadioButton propRBPano;
        private System.Windows.Forms.RadioButton propRBNovine;
        private System.Windows.Forms.TextBox propTxtCenaZakupa;
        private System.Windows.Forms.TextBox propTxtTrajanjeZakupa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.MonthCalendar propClndDatumZakupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}