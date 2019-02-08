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

	public partial class KontaktUC : UserControl
	{
		public event EventHandler Loeschen;

		private NpgsqlConnection connection = null;

		public KontaktUC()
		{
			InitializeComponent();
		}
		public KontaktUC(NpgsqlConnection connection, Kontakt kontakt)
		{
			InitializeComponent();
			this.kontakt = kontakt;
			this.connection = connection;
		}

		public Kontakt kontakt = null;
		public string Tel
		{
			get { return this.textBoxTel.Text; }
			set { this.textBoxTel.Text = value; }
		}

		public string Email
		{
			get { return this.textBoxEmail.Text; }
			set { this.textBoxEmail.Text = value; }
		}

		public long? ArtId { get; set; }
		private List<Art> arten = null;




		private void ComboBoxFill()
		{
			this.comboBoxArt.DataSource = this.arten;
			this.comboBoxArt.DisplayMember = "Bezeichnung";
			this.comboBoxArt.ValueMember = "ArtId";
		}

		public void Datenspeichern()
		{
			this.kontakt.Tel = this.textBoxTel.Text;
			this.kontakt.Email = this.textBoxEmail.Text;
			this.kontakt.ArtId = (long?)this.comboBoxArt.SelectedValue;
		}

		private void KontaktUC_Load(object sender, EventArgs e)
		{
			this.arten = Art.GetList(this.connection);
			ComboBoxFill();
			if (kontakt.KontaktId != null)
			{
				this.textBoxTel.Text = this.kontakt.Tel;
				this.textBoxEmail.Text = this.kontakt.Email;
				this.ArtId = (long?)this.kontakt.ArtId;
				this.comboBoxArt.SelectedValue = ArtId;
			}
		}

		private void buttonLoeschen_Click(object sender, EventArgs e)
		{
			if (this.Loeschen != null)
			{
				this.Loeschen(this, EventArgs.Empty);
			}
		}
	}
}
