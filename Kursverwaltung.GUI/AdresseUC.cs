using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursverwaltung.Data;
using Npgsql;

namespace Kursverwaltung.GUI
{
	public partial class AdresseUC : UserControl
	{
		public event EventHandler Loeschen;

		private NpgsqlConnection connection = null;

		public AdresseUC()
		{
			InitializeComponent();
		}

		public AdresseUC(NpgsqlConnection connection, Adresse adresse)
		{
			InitializeComponent();
			this.adresse = adresse;
			this.connection = connection;
		}

		public Adresse adresse { get; set; }

		public string Strasse
		{
			get { return this.textBoxStrasse.Text; }
			set { this.textBoxStrasse.Text = value; }
		}

		public string Hnr
		{
			get { return this.textBoxHnr.Text; }
			set { this.textBoxHnr.Text = value; }
		}

		public string Ort
		{
			get { return this.textBoxOrt.Text; }
			set { this.textBoxOrt.Text = value; }
		}

		public string Plz
		{
			get { return this.textBoxPlz.Text; }
			set { this.textBoxPlz.Text = value; }
		}
		public long? ArtId { get; set; }
		private List<Art> arten = null;

		private void AdresseUC_Load(object sender, EventArgs e)
		{
			this.arten = Art.GetList(connection);
			ComboBoxFill();
			if (adresse.AdresseID != null)
			{
				this.textBoxStrasse.Text = this.adresse.Strasse;
				this.textBoxHnr.Text = this.adresse.Hnr.ToString();
				this.textBoxPlz.Text = this.adresse.Plz;
				this.textBoxOrt.Text = this.adresse.Ort;
				this.ArtId = this.adresse.ArtId;
				this.comboBoxArt.SelectedValue = ArtId;
			}


		}

		private void ComboBoxFill()
		{
			this.comboBoxArt.DataSource = this.arten;
			this.comboBoxArt.DisplayMember = "Bezeichnung";
			this.comboBoxArt.ValueMember = "ArtId";
		}

		public void Datenspeichern()
		{
			bool erfolg = true;
			long wert = 0;
			this.adresse.Strasse = this.textBoxStrasse.Text;
			//---------------------------
			erfolg = long.TryParse(this.textBoxHnr.Text, out wert);
			if (erfolg)
			{
				this.adresse.Hnr = wert;
			}
			else
			{
				this.adresse.Hnr = 0;
			}
			//-----------------------------
			this.adresse.Ort = this.textBoxOrt.Text;
			this.adresse.Plz = this.textBoxPlz.Text;
			this.adresse.ArtId = (long?)this.comboBoxArt.SelectedValue;

		}

		private void buttonLoeschen_Click(object sender, EventArgs e)
		{
			if (this.Loeschen !=null)
			{
				Loeschen(this, EventArgs.Empty);
			}
		}
	}
}
