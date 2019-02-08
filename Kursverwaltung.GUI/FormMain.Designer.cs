namespace Kursverwaltung.GUI
{
	partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNeuerKurs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.StatusLabelPlatzhalter3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelAnzahlkurse = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelPaltzhalter2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelDbNamen = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelPlatzhalter1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelDbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewKursübersicht = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEnde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLehreinheiten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaxTN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAngemeldet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFreiePlaetze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuItemNeuePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListviewMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemKursBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxWifiMain = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.contextMenuStripListviewMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWifiMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.MenuItemBearbeiten});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // MenuItemBearbeiten
            // 
            this.MenuItemBearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNeuerKurs,
            this.MenuItemNeuePerson});
            this.MenuItemBearbeiten.Name = "MenuItemBearbeiten";
            this.MenuItemBearbeiten.Size = new System.Drawing.Size(75, 20);
            this.MenuItemBearbeiten.Text = "Bearbeiten";
            // 
            // MenuItemNeuerKurs
            // 
            this.MenuItemNeuerKurs.Image = global::Kursverwaltung.GUI.Properties.Resources.NewRelationship_16x;
            this.MenuItemNeuerKurs.Name = "MenuItemNeuerKurs";
            this.MenuItemNeuerKurs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemNeuerKurs.Size = new System.Drawing.Size(182, 22);
            this.MenuItemNeuerKurs.Text = "Neuer Kurs";
            this.MenuItemNeuerKurs.Click += new System.EventHandler(this.MenuItemNeuerKurs_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelPlatzhalter3,
            this.StatusLabelAnzahlkurse,
            this.StatusLabelPaltzhalter2,
            this.StatusLabelDbNamen,
            this.StatusLabelPlatzhalter1,
            this.StatusLabelDbUser});
            this.statusStripMain.Location = new System.Drawing.Point(0, 428);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(800, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // StatusLabelPlatzhalter3
            // 
            this.StatusLabelPlatzhalter3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.StatusLabelPlatzhalter3.Name = "StatusLabelPlatzhalter3";
            this.StatusLabelPlatzhalter3.Size = new System.Drawing.Size(112, 17);
            this.StatusLabelPlatzhalter3.Text = "|Anzahl der Kurse:|";
            // 
            // StatusLabelAnzahlkurse
            // 
            this.StatusLabelAnzahlkurse.Name = "StatusLabelAnzahlkurse";
            this.StatusLabelAnzahlkurse.Size = new System.Drawing.Size(71, 17);
            this.StatusLabelAnzahlkurse.Text = "Anzahlkurse";
            this.StatusLabelAnzahlkurse.Visible = false;
            // 
            // StatusLabelPaltzhalter2
            // 
            this.StatusLabelPaltzhalter2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.StatusLabelPaltzhalter2.Name = "StatusLabelPaltzhalter2";
            this.StatusLabelPaltzhalter2.Size = new System.Drawing.Size(83, 17);
            this.StatusLabelPaltzhalter2.Text = "| DatenBank:|";
            // 
            // StatusLabelDbNamen
            // 
            this.StatusLabelDbNamen.Name = "StatusLabelDbNamen";
            this.StatusLabelDbNamen.Size = new System.Drawing.Size(61, 17);
            this.StatusLabelDbNamen.Text = "DBNamen";
            this.StatusLabelDbNamen.Visible = false;
            // 
            // StatusLabelPlatzhalter1
            // 
            this.StatusLabelPlatzhalter1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.StatusLabelPlatzhalter1.Name = "StatusLabelPlatzhalter1";
            this.StatusLabelPlatzhalter1.Size = new System.Drawing.Size(78, 17);
            this.StatusLabelPlatzhalter1.Text = "| Username:|";
            // 
            // StatusLabelDbUser
            // 
            this.StatusLabelDbUser.Name = "StatusLabelDbUser";
            this.StatusLabelDbUser.Size = new System.Drawing.Size(45, 17);
            this.StatusLabelDbUser.Text = "DBUser";
            this.StatusLabelDbUser.Visible = false;
            // 
            // listViewKursübersicht
            // 
            this.listViewKursübersicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderStart,
            this.columnHeaderEnde,
            this.columnHeaderLehreinheiten,
            this.columnHeaderMaxTN,
            this.columnHeaderAngemeldet,
            this.columnHeaderFreiePlaetze});
            this.listViewKursübersicht.ContextMenuStrip = this.contextMenuStripListviewMain;
            this.listViewKursübersicht.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewKursübersicht.FullRowSelect = true;
            this.listViewKursübersicht.GridLines = true;
            this.listViewKursübersicht.Location = new System.Drawing.Point(0, 24);
            this.listViewKursübersicht.Name = "listViewKursübersicht";
            this.listViewKursübersicht.Size = new System.Drawing.Size(655, 404);
            this.listViewKursübersicht.TabIndex = 1;
            this.listViewKursübersicht.UseCompatibleStateImageBehavior = false;
            this.listViewKursübersicht.View = System.Windows.Forms.View.Details;
            this.listViewKursübersicht.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewKursübersicht_MouseClick);
            this.listViewKursübersicht.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewKursübersicht_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Kursname";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderStart
            // 
            this.columnHeaderStart.Text = "Start";
            this.columnHeaderStart.Width = 80;
            // 
            // columnHeaderEnde
            // 
            this.columnHeaderEnde.Text = "Ende";
            this.columnHeaderEnde.Width = 80;
            // 
            // columnHeaderLehreinheiten
            // 
            this.columnHeaderLehreinheiten.Text = "Lehreinheiten";
            this.columnHeaderLehreinheiten.Width = 80;
            // 
            // columnHeaderMaxTN
            // 
            this.columnHeaderMaxTN.Text = "Max. Teilnehmer";
            this.columnHeaderMaxTN.Width = 100;
            // 
            // columnHeaderAngemeldet
            // 
            this.columnHeaderAngemeldet.Text = "Angemeldet";
            this.columnHeaderAngemeldet.Width = 80;
            // 
            // columnHeaderFreiePlaetze
            // 
            this.columnHeaderFreiePlaetze.Text = "Freie Plätze";
            this.columnHeaderFreiePlaetze.Width = 80;
            // 
            // MenuItemNeuePerson
            // 
            this.MenuItemNeuePerson.Image = global::Kursverwaltung.GUI.Properties.Resources.NewRow_16x;
            this.MenuItemNeuePerson.Name = "MenuItemNeuePerson";
            this.MenuItemNeuePerson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuItemNeuePerson.Size = new System.Drawing.Size(182, 22);
            this.MenuItemNeuePerson.Text = "Neue Person";
            this.MenuItemNeuePerson.Click += new System.EventHandler(this.MenuItemNeuePerson_Click);
            // 
            // contextMenuStripListviewMain
            // 
            this.contextMenuStripListviewMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemKursBearbeiten});
            this.contextMenuStripListviewMain.Name = "contextMenuStripListviewMain";
            this.contextMenuStripListviewMain.Size = new System.Drawing.Size(181, 48);
            // 
            // ContextMenuItemKursBearbeiten
            // 
            this.ContextMenuItemKursBearbeiten.Image = global::Kursverwaltung.GUI.Properties.Resources.Edit_16x;
            this.ContextMenuItemKursBearbeiten.Name = "ContextMenuItemKursBearbeiten";
            this.ContextMenuItemKursBearbeiten.Size = new System.Drawing.Size(180, 22);
            this.ContextMenuItemKursBearbeiten.Text = "Kurs Bearbeiten";
            this.ContextMenuItemKursBearbeiten.Click += new System.EventHandler(this.ContextMenuItemKursBearbeiten_Click);
            // 
            // pictureBoxWifiMain
            // 
            this.pictureBoxWifiMain.Image = global::Kursverwaltung.GUI.Properties.Resources.Wirtschaftsförderungsinstitut_logo_svg;
            this.pictureBoxWifiMain.Location = new System.Drawing.Point(678, 12);
            this.pictureBoxWifiMain.Name = "pictureBoxWifiMain";
            this.pictureBoxWifiMain.Size = new System.Drawing.Size(122, 133);
            this.pictureBoxWifiMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWifiMain.TabIndex = 3;
            this.pictureBoxWifiMain.TabStop = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Kursverwaltung.GUI.Properties.Resources.Close_red_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxWifiMain);
            this.Controls.Add(this.listViewKursübersicht);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Wifi Kursverwaltung";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.contextMenuStripListviewMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWifiMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelAnzahlkurse;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelDbNamen;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelDbUser;
        private System.Windows.Forms.ListView listViewKursübersicht;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderStart;
        private System.Windows.Forms.ColumnHeader columnHeaderEnde;
        private System.Windows.Forms.ColumnHeader columnHeaderLehreinheiten;
        private System.Windows.Forms.ColumnHeader columnHeaderMaxTN;
        private System.Windows.Forms.ColumnHeader columnHeaderAngemeldet;
        private System.Windows.Forms.ColumnHeader columnHeaderFreiePlaetze;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNeuerKurs;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelPaltzhalter2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelPlatzhalter1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelPlatzhalter3;
        private System.Windows.Forms.PictureBox pictureBoxWifiMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNeuePerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListviewMain;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemKursBearbeiten;
    }
}

