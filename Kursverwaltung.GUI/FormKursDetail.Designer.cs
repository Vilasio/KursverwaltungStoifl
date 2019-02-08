namespace Kursverwaltung.GUI
{
	partial class FormKursDetail
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
			this.tabControlKurs = new System.Windows.Forms.TabControl();
			this.tabPageKurs = new System.Windows.Forms.TabPage();
			this.buttonKursLoeschen = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.listViewAlle = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuListviewDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonLoeschen = new System.Windows.Forms.Button();
			this.buttonHinzufügen = new System.Windows.Forms.Button();
			this.listViewKurs = new System.Windows.Forms.ListView();
			this.columnHeaderVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderGebDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonSpeichern = new System.Windows.Forms.Button();
			this.textBoxAngemeldet = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelKursname = new System.Windows.Forms.Label();
			this.dateTimePickerEnde = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.textBoxFreiePlaetze = new System.Windows.Forms.TextBox();
			this.textBoxMaxTN = new System.Windows.Forms.TextBox();
			this.textBoxRaum = new System.Windows.Forms.TextBox();
			this.textBoxLehreinheiten = new System.Windows.Forms.TextBox();
			this.textBoxKursnummer = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.tabPagePerson = new System.Windows.Forms.TabPage();
			this.buttonKontaktLoeschen = new System.Windows.Forms.Button();
			this.buttonAdresseLoeschen = new System.Windows.Forms.Button();
			this.buttonLoeschenPerson = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dateTimePickerGebDat = new System.Windows.Forms.DateTimePicker();
			this.buttonKontakt = new System.Windows.Forms.Button();
			this.buttonAdresse = new System.Windows.Forms.Button();
			this.buttonSpeichernPerson = new System.Windows.Forms.Button();
			this.flowLayoutPanelKontakt = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanelAdresse = new System.Windows.Forms.FlowLayoutPanel();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxNachname = new System.Windows.Forms.TextBox();
			this.textBoxVorname = new System.Windows.Forms.TextBox();
			this.buttonNeuePerson = new System.Windows.Forms.Button();
			this.pictureBoxWifiMain = new System.Windows.Forms.PictureBox();
			this.personBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neuePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControlKurs.SuspendLayout();
			this.tabPageKurs.SuspendLayout();
			this.contextMenuListviewDetail.SuspendLayout();
			this.tabPagePerson.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWifiMain)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlKurs
			// 
			this.tabControlKurs.Controls.Add(this.tabPageKurs);
			this.tabControlKurs.Controls.Add(this.tabPagePerson);
			this.tabControlKurs.Location = new System.Drawing.Point(12, 12);
			this.tabControlKurs.Name = "tabControlKurs";
			this.tabControlKurs.SelectedIndex = 0;
			this.tabControlKurs.Size = new System.Drawing.Size(776, 488);
			this.tabControlKurs.TabIndex = 0;
			// 
			// tabPageKurs
			// 
			this.tabPageKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.tabPageKurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageKurs.Controls.Add(this.buttonNeuePerson);
			this.tabPageKurs.Controls.Add(this.buttonKursLoeschen);
			this.tabPageKurs.Controls.Add(this.label15);
			this.tabPageKurs.Controls.Add(this.label14);
			this.tabPageKurs.Controls.Add(this.listViewAlle);
			this.tabPageKurs.Controls.Add(this.label10);
			this.tabPageKurs.Controls.Add(this.label9);
			this.tabPageKurs.Controls.Add(this.buttonLoeschen);
			this.tabPageKurs.Controls.Add(this.buttonHinzufügen);
			this.tabPageKurs.Controls.Add(this.listViewKurs);
			this.tabPageKurs.Controls.Add(this.buttonSpeichern);
			this.tabPageKurs.Controls.Add(this.textBoxAngemeldet);
			this.tabPageKurs.Controls.Add(this.label1);
			this.tabPageKurs.Controls.Add(this.label8);
			this.tabPageKurs.Controls.Add(this.label7);
			this.tabPageKurs.Controls.Add(this.label6);
			this.tabPageKurs.Controls.Add(this.label5);
			this.tabPageKurs.Controls.Add(this.label4);
			this.tabPageKurs.Controls.Add(this.label3);
			this.tabPageKurs.Controls.Add(this.label2);
			this.tabPageKurs.Controls.Add(this.labelKursname);
			this.tabPageKurs.Controls.Add(this.dateTimePickerEnde);
			this.tabPageKurs.Controls.Add(this.dateTimePickerStart);
			this.tabPageKurs.Controls.Add(this.textBoxFreiePlaetze);
			this.tabPageKurs.Controls.Add(this.textBoxMaxTN);
			this.tabPageKurs.Controls.Add(this.textBoxRaum);
			this.tabPageKurs.Controls.Add(this.textBoxLehreinheiten);
			this.tabPageKurs.Controls.Add(this.textBoxKursnummer);
			this.tabPageKurs.Controls.Add(this.textBoxName);
			this.tabPageKurs.Location = new System.Drawing.Point(4, 22);
			this.tabPageKurs.Name = "tabPageKurs";
			this.tabPageKurs.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageKurs.Size = new System.Drawing.Size(768, 462);
			this.tabPageKurs.TabIndex = 1;
			this.tabPageKurs.Text = "Kurs";
			// 
			// buttonKursLoeschen
			// 
			this.buttonKursLoeschen.Location = new System.Drawing.Point(644, 428);
			this.buttonKursLoeschen.Name = "buttonKursLoeschen";
			this.buttonKursLoeschen.Size = new System.Drawing.Size(100, 30);
			this.buttonKursLoeschen.TabIndex = 8;
			this.buttonKursLoeschen.Text = "Kurs löschen";
			this.buttonKursLoeschen.UseVisualStyleBackColor = true;
			this.buttonKursLoeschen.Click += new System.EventHandler(this.buttonKursLoeschen_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(416, 102);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(24, 13);
			this.label15.TabIndex = 0;
			this.label15.Text = "Alle";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(4, 102);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(28, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Kurs";
			// 
			// listViewAlle
			// 
			this.listViewAlle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewAlle.ContextMenuStrip = this.contextMenuListviewDetail;
			this.listViewAlle.FullRowSelect = true;
			this.listViewAlle.GridLines = true;
			this.listViewAlle.Location = new System.Drawing.Point(410, 118);
			this.listViewAlle.Name = "listViewAlle";
			this.listViewAlle.Size = new System.Drawing.Size(350, 296);
			this.listViewAlle.TabIndex = 9;
			this.listViewAlle.UseCompatibleStateImageBehavior = false;
			this.listViewAlle.View = System.Windows.Forms.View.Details;
			this.listViewAlle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewAlle_MouseClick);
			this.listViewAlle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAlle_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Vorname";
			this.columnHeader1.Width = 125;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nachname";
			this.columnHeader2.Width = 125;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Geb. Datum";
			this.columnHeader3.Width = 100;
			// 
			// contextMenuListviewDetail
			// 
			this.contextMenuListviewDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personBearbeitenToolStripMenuItem,
            this.neuePersonToolStripMenuItem});
			this.contextMenuListviewDetail.Name = "contextMenuListviewDetail";
			this.contextMenuListviewDetail.Size = new System.Drawing.Size(170, 48);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(367, 171);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(28, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "<-----";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(367, 348);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "----->";
			// 
			// buttonLoeschen
			// 
			this.buttonLoeschen.Location = new System.Drawing.Point(354, 364);
			this.buttonLoeschen.Name = "buttonLoeschen";
			this.buttonLoeschen.Size = new System.Drawing.Size(56, 50);
			this.buttonLoeschen.TabIndex = 12;
			this.buttonLoeschen.Text = "Enfernen";
			this.buttonLoeschen.UseVisualStyleBackColor = true;
			this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
			// 
			// buttonHinzufügen
			// 
			this.buttonHinzufügen.Location = new System.Drawing.Point(354, 118);
			this.buttonHinzufügen.Name = "buttonHinzufügen";
			this.buttonHinzufügen.Size = new System.Drawing.Size(56, 50);
			this.buttonHinzufügen.TabIndex = 10;
			this.buttonHinzufügen.Text = "Hinzufügen";
			this.buttonHinzufügen.UseVisualStyleBackColor = true;
			this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
			// 
			// listViewKurs
			// 
			this.listViewKurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderVorname,
            this.columnHeaderNachname,
            this.columnHeaderGebDat});
			this.listViewKurs.ContextMenuStrip = this.contextMenuListviewDetail;
			this.listViewKurs.FullRowSelect = true;
			this.listViewKurs.GridLines = true;
			this.listViewKurs.Location = new System.Drawing.Point(4, 118);
			this.listViewKurs.Name = "listViewKurs";
			this.listViewKurs.Size = new System.Drawing.Size(350, 296);
			this.listViewKurs.TabIndex = 11;
			this.listViewKurs.UseCompatibleStateImageBehavior = false;
			this.listViewKurs.View = System.Windows.Forms.View.Details;
			this.listViewKurs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewKurs_MouseClick);
			this.listViewKurs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewKurs_MouseDoubleClick);
			// 
			// columnHeaderVorname
			// 
			this.columnHeaderVorname.Text = "Vorname";
			this.columnHeaderVorname.Width = 125;
			// 
			// columnHeaderNachname
			// 
			this.columnHeaderNachname.Text = "Nachname";
			this.columnHeaderNachname.Width = 125;
			// 
			// columnHeaderGebDat
			// 
			this.columnHeaderGebDat.Text = "Geb. Datum";
			this.columnHeaderGebDat.Width = 100;
			// 
			// buttonSpeichern
			// 
			this.buttonSpeichern.Location = new System.Drawing.Point(644, 23);
			this.buttonSpeichern.Name = "buttonSpeichern";
			this.buttonSpeichern.Size = new System.Drawing.Size(100, 50);
			this.buttonSpeichern.TabIndex = 7;
			this.buttonSpeichern.Text = "Speichern";
			this.buttonSpeichern.UseVisualStyleBackColor = true;
			this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
			// 
			// textBoxAngemeldet
			// 
			this.textBoxAngemeldet.Enabled = false;
			this.textBoxAngemeldet.Location = new System.Drawing.Point(421, 25);
			this.textBoxAngemeldet.Name = "textBoxAngemeldet";
			this.textBoxAngemeldet.Size = new System.Drawing.Size(100, 20);
			this.textBoxAngemeldet.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(418, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angemeldet";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(524, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Freie Plätze";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(312, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Max. Teilnehmer";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(418, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Raum";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(312, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Lehreinheiten";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(206, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ende";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(206, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Start";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kursnummer";
			// 
			// labelKursname
			// 
			this.labelKursname.AutoSize = true;
			this.labelKursname.Location = new System.Drawing.Point(0, 9);
			this.labelKursname.Name = "labelKursname";
			this.labelKursname.Size = new System.Drawing.Size(54, 13);
			this.labelKursname.TabIndex = 0;
			this.labelKursname.Text = "Kursname";
			// 
			// dateTimePickerEnde
			// 
			this.dateTimePickerEnde.Checked = false;
			this.dateTimePickerEnde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEnde.Location = new System.Drawing.Point(209, 69);
			this.dateTimePickerEnde.Name = "dateTimePickerEnde";
			this.dateTimePickerEnde.ShowCheckBox = true;
			this.dateTimePickerEnde.Size = new System.Drawing.Size(100, 20);
			this.dateTimePickerEnde.TabIndex = 3;
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Checked = false;
			this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerStart.Location = new System.Drawing.Point(209, 26);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.ShowCheckBox = true;
			this.dateTimePickerStart.Size = new System.Drawing.Size(100, 20);
			this.dateTimePickerStart.TabIndex = 2;
			// 
			// textBoxFreiePlaetze
			// 
			this.textBoxFreiePlaetze.Enabled = false;
			this.textBoxFreiePlaetze.Location = new System.Drawing.Point(527, 25);
			this.textBoxFreiePlaetze.Name = "textBoxFreiePlaetze";
			this.textBoxFreiePlaetze.Size = new System.Drawing.Size(100, 20);
			this.textBoxFreiePlaetze.TabIndex = 0;
			// 
			// textBoxMaxTN
			// 
			this.textBoxMaxTN.Location = new System.Drawing.Point(315, 72);
			this.textBoxMaxTN.Name = "textBoxMaxTN";
			this.textBoxMaxTN.Size = new System.Drawing.Size(100, 20);
			this.textBoxMaxTN.TabIndex = 5;
			this.textBoxMaxTN.TextChanged += new System.EventHandler(this.textBoxMaxTN_TextChanged);
			this.textBoxMaxTN.Leave += new System.EventHandler(this.textBoxMaxTN_Leave);
			// 
			// textBoxRaum
			// 
			this.textBoxRaum.Location = new System.Drawing.Point(421, 72);
			this.textBoxRaum.Name = "textBoxRaum";
			this.textBoxRaum.Size = new System.Drawing.Size(100, 20);
			this.textBoxRaum.TabIndex = 6;
			// 
			// textBoxLehreinheiten
			// 
			this.textBoxLehreinheiten.Location = new System.Drawing.Point(315, 25);
			this.textBoxLehreinheiten.Name = "textBoxLehreinheiten";
			this.textBoxLehreinheiten.Size = new System.Drawing.Size(100, 20);
			this.textBoxLehreinheiten.TabIndex = 4;
			// 
			// textBoxKursnummer
			// 
			this.textBoxKursnummer.Enabled = false;
			this.textBoxKursnummer.Location = new System.Drawing.Point(3, 72);
			this.textBoxKursnummer.Name = "textBoxKursnummer";
			this.textBoxKursnummer.Size = new System.Drawing.Size(200, 20);
			this.textBoxKursnummer.TabIndex = 0;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(3, 25);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(200, 20);
			this.textBoxName.TabIndex = 1;
			// 
			// tabPagePerson
			// 
			this.tabPagePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.tabPagePerson.Controls.Add(this.buttonKontaktLoeschen);
			this.tabPagePerson.Controls.Add(this.buttonAdresseLoeschen);
			this.tabPagePerson.Controls.Add(this.buttonLoeschenPerson);
			this.tabPagePerson.Controls.Add(this.labelStatus);
			this.tabPagePerson.Controls.Add(this.label13);
			this.tabPagePerson.Controls.Add(this.dateTimePickerGebDat);
			this.tabPagePerson.Controls.Add(this.buttonKontakt);
			this.tabPagePerson.Controls.Add(this.buttonAdresse);
			this.tabPagePerson.Controls.Add(this.buttonSpeichernPerson);
			this.tabPagePerson.Controls.Add(this.flowLayoutPanelKontakt);
			this.tabPagePerson.Controls.Add(this.flowLayoutPanelAdresse);
			this.tabPagePerson.Controls.Add(this.label12);
			this.tabPagePerson.Controls.Add(this.label11);
			this.tabPagePerson.Controls.Add(this.textBoxNachname);
			this.tabPagePerson.Controls.Add(this.textBoxVorname);
			this.tabPagePerson.Location = new System.Drawing.Point(4, 22);
			this.tabPagePerson.Name = "tabPagePerson";
			this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePerson.Size = new System.Drawing.Size(768, 462);
			this.tabPagePerson.TabIndex = 2;
			this.tabPagePerson.Text = "Person";
			this.tabPagePerson.Enter += new System.EventHandler(this.tabPagePerson_Enter);
			this.tabPagePerson.Leave += new System.EventHandler(this.tabPagePerson_Leave);
			// 
			// buttonKontaktLoeschen
			// 
			this.buttonKontaktLoeschen.Location = new System.Drawing.Point(387, 419);
			this.buttonKontaktLoeschen.Name = "buttonKontaktLoeschen";
			this.buttonKontaktLoeschen.Size = new System.Drawing.Size(120, 30);
			this.buttonKontaktLoeschen.TabIndex = 10;
			this.buttonKontaktLoeschen.Text = "Kontakt löschen";
			this.buttonKontaktLoeschen.UseVisualStyleBackColor = true;
			this.buttonKontaktLoeschen.Visible = false;
			this.buttonKontaktLoeschen.Click += new System.EventHandler(this.buttonKontaktLoeschen_Click);
			// 
			// buttonAdresseLoeschen
			// 
			this.buttonAdresseLoeschen.Location = new System.Drawing.Point(6, 419);
			this.buttonAdresseLoeschen.Name = "buttonAdresseLoeschen";
			this.buttonAdresseLoeschen.Size = new System.Drawing.Size(120, 30);
			this.buttonAdresseLoeschen.TabIndex = 9;
			this.buttonAdresseLoeschen.Text = "Adresse löschen";
			this.buttonAdresseLoeschen.UseVisualStyleBackColor = true;
			this.buttonAdresseLoeschen.Visible = false;
			this.buttonAdresseLoeschen.Click += new System.EventHandler(this.buttonAdresseLoeschen_Click);
			// 
			// buttonLoeschenPerson
			// 
			this.buttonLoeschenPerson.Location = new System.Drawing.Point(665, 409);
			this.buttonLoeschenPerson.Name = "buttonLoeschenPerson";
			this.buttonLoeschenPerson.Size = new System.Drawing.Size(100, 50);
			this.buttonLoeschenPerson.TabIndex = 11;
			this.buttonLoeschenPerson.Text = "Person Löschen";
			this.buttonLoeschenPerson.UseVisualStyleBackColor = true;
			this.buttonLoeschenPerson.Click += new System.EventHandler(this.buttonLoeschenPerson_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.Location = new System.Drawing.Point(524, 21);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(87, 17);
			this.labelStatus.TabIndex = 0;
			this.labelStatus.Text = "Erfolgreich";
			this.labelStatus.Visible = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(415, 2);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Geb. Datum";
			// 
			// dateTimePickerGebDat
			// 
			this.dateTimePickerGebDat.Checked = false;
			this.dateTimePickerGebDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerGebDat.Location = new System.Drawing.Point(418, 18);
			this.dateTimePickerGebDat.Name = "dateTimePickerGebDat";
			this.dateTimePickerGebDat.ShowCheckBox = true;
			this.dateTimePickerGebDat.Size = new System.Drawing.Size(100, 20);
			this.dateTimePickerGebDat.TabIndex = 3;
			// 
			// buttonKontakt
			// 
			this.buttonKontakt.Location = new System.Drawing.Point(387, 62);
			this.buttonKontakt.Name = "buttonKontakt";
			this.buttonKontakt.Size = new System.Drawing.Size(120, 30);
			this.buttonKontakt.TabIndex = 8;
			this.buttonKontakt.Text = "Kontakt hinzufügen";
			this.buttonKontakt.UseVisualStyleBackColor = true;
			this.buttonKontakt.Click += new System.EventHandler(this.buttonKontakt_Click);
			// 
			// buttonAdresse
			// 
			this.buttonAdresse.Location = new System.Drawing.Point(6, 58);
			this.buttonAdresse.Name = "buttonAdresse";
			this.buttonAdresse.Size = new System.Drawing.Size(120, 30);
			this.buttonAdresse.TabIndex = 7;
			this.buttonAdresse.Text = "Adresse hinzufügen";
			this.buttonAdresse.UseVisualStyleBackColor = true;
			this.buttonAdresse.Click += new System.EventHandler(this.buttonAdresse_Click);
			// 
			// buttonSpeichernPerson
			// 
			this.buttonSpeichernPerson.Location = new System.Drawing.Point(662, 6);
			this.buttonSpeichernPerson.Name = "buttonSpeichernPerson";
			this.buttonSpeichernPerson.Size = new System.Drawing.Size(100, 50);
			this.buttonSpeichernPerson.TabIndex = 6;
			this.buttonSpeichernPerson.Text = "Person Speichern";
			this.buttonSpeichernPerson.UseVisualStyleBackColor = true;
			this.buttonSpeichernPerson.Click += new System.EventHandler(this.buttonSpeichernPerson_Click);
			// 
			// flowLayoutPanelKontakt
			// 
			this.flowLayoutPanelKontakt.AutoScroll = true;
			this.flowLayoutPanelKontakt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanelKontakt.Location = new System.Drawing.Point(387, 98);
			this.flowLayoutPanelKontakt.Name = "flowLayoutPanelKontakt";
			this.flowLayoutPanelKontakt.Size = new System.Drawing.Size(375, 296);
			this.flowLayoutPanelKontakt.TabIndex = 5;
			// 
			// flowLayoutPanelAdresse
			// 
			this.flowLayoutPanelAdresse.AutoScroll = true;
			this.flowLayoutPanelAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanelAdresse.Location = new System.Drawing.Point(6, 98);
			this.flowLayoutPanelAdresse.Name = "flowLayoutPanelAdresse";
			this.flowLayoutPanelAdresse.Size = new System.Drawing.Size(375, 296);
			this.flowLayoutPanelAdresse.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(209, 2);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(59, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Nachname";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 2);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Vorname";
			// 
			// textBoxNachname
			// 
			this.textBoxNachname.Location = new System.Drawing.Point(212, 18);
			this.textBoxNachname.Name = "textBoxNachname";
			this.textBoxNachname.Size = new System.Drawing.Size(200, 20);
			this.textBoxNachname.TabIndex = 2;
			// 
			// textBoxVorname
			// 
			this.textBoxVorname.Location = new System.Drawing.Point(6, 18);
			this.textBoxVorname.Name = "textBoxVorname";
			this.textBoxVorname.Size = new System.Drawing.Size(200, 20);
			this.textBoxVorname.TabIndex = 1;
			// 
			// buttonNeuePerson
			// 
			this.buttonNeuePerson.Location = new System.Drawing.Point(644, 89);
			this.buttonNeuePerson.Name = "buttonNeuePerson";
			this.buttonNeuePerson.Size = new System.Drawing.Size(100, 23);
			this.buttonNeuePerson.TabIndex = 13;
			this.buttonNeuePerson.Text = "Neue Person";
			this.buttonNeuePerson.UseVisualStyleBackColor = true;
			this.buttonNeuePerson.Click += new System.EventHandler(this.buttonNeuePerson_Click);
			// 
			// pictureBoxWifiMain
			// 
			this.pictureBoxWifiMain.Image = global::Kursverwaltung.GUI.Properties.Resources.Wirtschaftsförderungsinstitut_logo_svg;
			this.pictureBoxWifiMain.Location = new System.Drawing.Point(799, 12);
			this.pictureBoxWifiMain.Name = "pictureBoxWifiMain";
			this.pictureBoxWifiMain.Size = new System.Drawing.Size(122, 133);
			this.pictureBoxWifiMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxWifiMain.TabIndex = 4;
			this.pictureBoxWifiMain.TabStop = false;
			// 
			// personBearbeitenToolStripMenuItem
			// 
			this.personBearbeitenToolStripMenuItem.Image = global::Kursverwaltung.GUI.Properties.Resources.Edit_16x;
			this.personBearbeitenToolStripMenuItem.Name = "personBearbeitenToolStripMenuItem";
			this.personBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.personBearbeitenToolStripMenuItem.Text = "Person bearbeiten";
			this.personBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.personBearbeitenToolStripMenuItem_Click);
			// 
			// neuePersonToolStripMenuItem
			// 
			this.neuePersonToolStripMenuItem.Image = global::Kursverwaltung.GUI.Properties.Resources.NewItem_16x;
			this.neuePersonToolStripMenuItem.Name = "neuePersonToolStripMenuItem";
			this.neuePersonToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.neuePersonToolStripMenuItem.Text = "Neue Person";
			this.neuePersonToolStripMenuItem.Click += new System.EventHandler(this.neuePersonToolStripMenuItem_Click);
			// 
			// FormKursDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(933, 512);
			this.Controls.Add(this.pictureBoxWifiMain);
			this.Controls.Add(this.tabControlKurs);
			this.Name = "FormKursDetail";
			this.Text = "FormKursDetail";
			this.Load += new System.EventHandler(this.FormKursDetail_Load);
			this.tabControlKurs.ResumeLayout(false);
			this.tabPageKurs.ResumeLayout(false);
			this.tabPageKurs.PerformLayout();
			this.contextMenuListviewDetail.ResumeLayout(false);
			this.tabPagePerson.ResumeLayout(false);
			this.tabPagePerson.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWifiMain)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl tabControlKurs;
        private System.Windows.Forms.TabPage tabPageKurs;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.TextBox textBoxAngemeldet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKursname;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnde;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox textBoxFreiePlaetze;
        private System.Windows.Forms.TextBox textBoxMaxTN;
        private System.Windows.Forms.TextBox textBoxRaum;
        private System.Windows.Forms.TextBox textBoxLehreinheiten;
        private System.Windows.Forms.TextBox textBoxKursnummer;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.ListView listViewAlle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.ListView listViewKurs;
        private System.Windows.Forms.ColumnHeader columnHeaderVorname;
        private System.Windows.Forms.ColumnHeader columnHeaderNachname;
        private System.Windows.Forms.ColumnHeader columnHeaderGebDat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKontakt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdresse;
        private System.Windows.Forms.Button buttonKontakt;
        private System.Windows.Forms.Button buttonAdresse;
        private System.Windows.Forms.Button buttonSpeichernPerson;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerGebDat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBoxWifiMain;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonKursLoeschen;
        private System.Windows.Forms.Button buttonKontaktLoeschen;
        private System.Windows.Forms.Button buttonAdresseLoeschen;
        private System.Windows.Forms.Button buttonLoeschenPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuListviewDetail;
        private System.Windows.Forms.ToolStripMenuItem personBearbeitenToolStripMenuItem;
		private System.Windows.Forms.Button buttonNeuePerson;
		private System.Windows.Forms.ToolStripMenuItem neuePersonToolStripMenuItem;
	}
}