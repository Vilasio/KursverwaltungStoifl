namespace Kursverwaltung.GUI
{
    partial class KontaktUC
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
			this.comboBoxArt = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxTel = new System.Windows.Forms.TextBox();
			this.buttonLoeschen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxArt
			// 
			this.comboBoxArt.FormattingEnabled = true;
			this.comboBoxArt.Location = new System.Drawing.Point(209, 16);
			this.comboBoxArt.Name = "comboBoxArt";
			this.comboBoxArt.Size = new System.Drawing.Size(121, 21);
			this.comboBoxArt.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(209, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Art";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Telefonnumer";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "E-Mail";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(3, 16);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
			this.textBoxEmail.TabIndex = 1;
			// 
			// textBoxTel
			// 
			this.textBoxTel.Location = new System.Drawing.Point(3, 55);
			this.textBoxTel.Name = "textBoxTel";
			this.textBoxTel.Size = new System.Drawing.Size(200, 20);
			this.textBoxTel.TabIndex = 2;
			// 
			// buttonLoeschen
			// 
			this.buttonLoeschen.Location = new System.Drawing.Point(255, 52);
			this.buttonLoeschen.Name = "buttonLoeschen";
			this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
			this.buttonLoeschen.TabIndex = 4;
			this.buttonLoeschen.Text = "Löschen";
			this.buttonLoeschen.UseVisualStyleBackColor = true;
			this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
			// 
			// KontaktUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonLoeschen);
			this.Controls.Add(this.textBoxTel);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxArt);
			this.Name = "KontaktUC";
			this.Size = new System.Drawing.Size(350, 80);
			this.Load += new System.EventHandler(this.KontaktUC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTel;
		private System.Windows.Forms.Button buttonLoeschen;
	}
}
