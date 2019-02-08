namespace Kursverwaltung.GUI
{
    partial class AdresseUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.textBoxStrasse = new System.Windows.Forms.TextBox();
			this.textBoxOrt = new System.Windows.Forms.TextBox();
			this.textBoxHnr = new System.Windows.Forms.TextBox();
			this.textBoxPlz = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxArt = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonLoeschen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxStrasse
			// 
			this.textBoxStrasse.Location = new System.Drawing.Point(3, 14);
			this.textBoxStrasse.Name = "textBoxStrasse";
			this.textBoxStrasse.Size = new System.Drawing.Size(125, 20);
			this.textBoxStrasse.TabIndex = 1;
			// 
			// textBoxOrt
			// 
			this.textBoxOrt.Location = new System.Drawing.Point(3, 51);
			this.textBoxOrt.Name = "textBoxOrt";
			this.textBoxOrt.Size = new System.Drawing.Size(125, 20);
			this.textBoxOrt.TabIndex = 3;
			// 
			// textBoxHnr
			// 
			this.textBoxHnr.Location = new System.Drawing.Point(134, 13);
			this.textBoxHnr.Name = "textBoxHnr";
			this.textBoxHnr.Size = new System.Drawing.Size(70, 20);
			this.textBoxHnr.TabIndex = 2;
			// 
			// textBoxPlz
			// 
			this.textBoxPlz.Location = new System.Drawing.Point(134, 50);
			this.textBoxPlz.Name = "textBoxPlz";
			this.textBoxPlz.Size = new System.Drawing.Size(70, 20);
			this.textBoxPlz.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Straße";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(131, -1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "H.Nr.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(131, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "PLZ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ort";
			// 
			// comboBoxArt
			// 
			this.comboBoxArt.FormattingEnabled = true;
			this.comboBoxArt.Location = new System.Drawing.Point(210, 14);
			this.comboBoxArt.Name = "comboBoxArt";
			this.comboBoxArt.Size = new System.Drawing.Size(137, 21);
			this.comboBoxArt.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(210, -2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Art";
			// 
			// buttonLoeschen
			// 
			this.buttonLoeschen.Location = new System.Drawing.Point(272, 47);
			this.buttonLoeschen.Name = "buttonLoeschen";
			this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
			this.buttonLoeschen.TabIndex = 6;
			this.buttonLoeschen.Text = "Löschen";
			this.buttonLoeschen.UseVisualStyleBackColor = true;
			this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
			// 
			// AdresseUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonLoeschen);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxArt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPlz);
			this.Controls.Add(this.textBoxHnr);
			this.Controls.Add(this.textBoxOrt);
			this.Controls.Add(this.textBoxStrasse);
			this.Name = "AdresseUC";
			this.Size = new System.Drawing.Size(350, 76);
			this.Load += new System.EventHandler(this.AdresseUC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStrasse;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.TextBox textBoxHnr;
        private System.Windows.Forms.TextBox textBoxPlz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArt;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonLoeschen;
	}
}
