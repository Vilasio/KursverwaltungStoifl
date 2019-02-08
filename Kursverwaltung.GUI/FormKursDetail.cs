using Kursverwaltung.Data;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursverwaltung.GUI
{
	public partial class FormKursDetail : Form
	{
		#region Connection
		private NpgsqlConnection connection = null;
		#endregion

		//----------------------------------------------

		#region Constructor
		public FormKursDetail()
		{
			InitializeComponent();
		}

		public FormKursDetail(NpgsqlConnection connection, List<Kurs> kurse)
		{
			InitializeComponent();
			this.connection = connection;
			this.kurse = kurse;
		}

		public FormKursDetail(NpgsqlConnection connection, List<Kurs> kurse, Person newPerson)
		{
			InitializeComponent();
			this.connection = connection;
			this.kurse = kurse;
			this.newPerson = newPerson;
			this.tabControlKurs.SelectedTab = tabPagePerson;
		}

		public FormKursDetail(NpgsqlConnection connection, Kurs kurs, List<Kurs> kurse)
		{
			InitializeComponent();
			this.connection = connection;
			this.kurs = kurs;
			this.kurse = kurse;

		}
		#endregion

		//----------------------------------------------

		#region Properties
		private Kurs kurs = null;
		private List<Kurs> kurse = null;
		private List<Person> persons = null;
		private List<Person> allPersons = null;
		private int frei = 0;
		private int maxTN = 0;
		private int angemeldet = 0;

		private ListViewItem selectLVIAlle = null;
		private ListViewItem selectLVIKurs = null;

		private Person newPerson = null;
		private Person editPerson = null;
		#endregion
		//----------------------------------------------

		#region Load
		private void FormKursDetail_Load(object sender, EventArgs e)
		{
			#region KursLoad
			if (kurs != null)
			{
				FillKurs();
				FillListViewKurs();
				this.allPersons = Person.GetListAll_Kurs(this.connection, this.kurs);
				FillListViewAll();
			}
			else
			{
				this.kurs = new Kurs(this.connection);
				this.persons = this.kurs.Persons;
				this.allPersons = Person.GetListAll(this.connection);
				FillListViewAll();
			}
			#endregion

			#region PersonLoad

			#endregion
		}
		#endregion

		#region KursTab
		public void FillKurs()
		{
			this.kurs.Persons = null;
			this.persons = this.kurs.Persons;
			this.textBoxName.Text = this.kurs.Name;
			this.textBoxKursnummer.Text = this.kurs.Kursnummer.ToString();
			this.textBoxLehreinheiten.Text = this.kurs.Lehreinheiten.ToString();
			this.textBoxRaum.Text = this.kurs.Raum;
			this.textBoxMaxTN.Text = this.kurs.MaxTN.ToString();
			this.frei = (int)kurs.MaxTN - this.persons.Count;
			this.textBoxFreiePlaetze.Text = frei.ToString();
			this.dateTimePickerStart.Value = this.kurs.Startkurs.Value;
			this.dateTimePickerEnde.Value = this.kurs.Endekurs.Value;
			this.textBoxAngemeldet.Text = this.kurs.Angemeldet.ToString();
		}

		private void FillListViewKurs()
		{
			ListViewItem item = null;

			foreach (Person person in persons)
			{
				item = new ListViewItem();
				item.Tag = person;
				item.Text = (String.IsNullOrEmpty(person.Vorname) ? string.Empty : person.Vorname); ;
				item.SubItems.Add(String.IsNullOrEmpty(person.Nachname) ? string.Empty : person.Nachname);
				item.SubItems.Add(person.GebDat.HasValue ? person.GebDat.Value.ToShortDateString() : DateTime.MinValue.ToShortDateString());
				listViewKurs.Items.Add(item);
			}
		}

		private void FillListViewAll()
		{
			ListViewItem item = null;

			foreach (Person person in allPersons)
			{

				item = new ListViewItem();
				item.Tag = person;
				item.Text = (String.IsNullOrEmpty(person.Vorname) ? string.Empty : person.Vorname); ;
				item.SubItems.Add(String.IsNullOrEmpty(person.Nachname) ? string.Empty : person.Nachname);
				item.SubItems.Add(person.GebDat.HasValue ? person.GebDat.Value.ToShortDateString() : DateTime.MinValue.ToShortDateString());
				this.listViewAlle.Items.Add(item);
			}
		}

		private void buttonSpeichern_Click(object sender, EventArgs e)
		{
			bool erfolg = Prüfung();
			if (!kurse.Contains(kurs))
			{
				this.kurse.Add(kurs);
			}
			if (erfolg)
			{
				this.kurs.Persons = this.persons;
				this.kurs.Save();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void buttonKursLoeschen_Click(object sender, EventArgs e)
		{
			if (this.kurs != null)
			{
				this.kurs.Delete();
				this.kurse.Remove(this.kurs);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private bool Prüfung()
		{
			bool erfolg = false;
			long wert;

			if (this.textBoxName.Text != "")
			{
				kurs.Name = this.textBoxName.Text;
			}
			else
			{
				MessageBox.Show("Ungültiger Wert bei Feld Lehreinheiten", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return erfolg;
			}
			//--------------------------
			if (dateTimePickerStart.Checked)
			{
				this.kurs.Startkurs = this.dateTimePickerStart.Value;
			}
			else
			{
				this.kurs.Startkurs = DateTime.Now;
			}
			//--------------------------

			if (dateTimePickerEnde.Checked)
			{
				this.kurs.Endekurs = this.dateTimePickerEnde.Value;
			}
			else
			{
				this.kurs.Endekurs = DateTime.Now;
			}
			//--------------------------
			erfolg = long.TryParse(this.textBoxLehreinheiten.Text, out wert);
			if (erfolg)
			{
				this.kurs.Lehreinheiten = wert;
			}
			else
			{
				MessageBox.Show("Ungültiger Wert bei Feld Lehreinheiten", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return erfolg;
			}
			//--------------------------
			kurs.Raum = this.textBoxRaum.Text;
			//--------------------------
			erfolg = long.TryParse(this.textBoxMaxTN.Text, out wert);
			if (erfolg)
			{
				this.kurs.MaxTN = wert;
			}
			else
			{
				MessageBox.Show("Ungültiger Wert bei Feld Max Teilnehmer", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return erfolg;
			}
			//--------------------------
			erfolg = long.TryParse(this.textBoxAngemeldet.Text, out wert);
			if (erfolg)
			{
				this.kurs.Angemeldet = wert;
			}
			else
			{
				MessageBox.Show("Ungültiger Wert bei Feld Angemeldet", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return erfolg;
			}
			//--------------------------
			this.kurs.FreiPlaetze = this.frei;


			return erfolg;
		}

		private void textBoxMaxTN_Leave(object sender, EventArgs e)
		{
			AktualisierenPlaetze();
		}

		private void textBoxMaxTN_TextChanged(object sender, EventArgs e)
		{
			AktualisierenPlaetze();
		}

		//---------------------------------------------------------

		#region Listviews Personen Verwaltung
		private void buttonHinzufügen_Click(object sender, EventArgs e)
		{

			if (this.maxTN > this.listViewKurs.Items.Count)
			{
				if (this.selectLVIAlle != null)
				{
					Person person = null;
					person = (Person)this.selectLVIAlle.Tag;
					person.kurs = this.kurs;
					this.persons.Add(person);
					this.allPersons.Remove(person);
					this.listViewAlle.Items.Remove(this.selectLVIAlle);
					this.listViewKurs.Items.Add(this.selectLVIAlle);
					this.selectLVIAlle = null;
					AktualisierenPlaetze();
				}
				else
				{
					MessageBox.Show("Es muss ein Eintrag zum hinzufügen ausgewählt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Maximale Teilnehmerzahl ereicht", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

		private void buttonLoeschen_Click(object sender, EventArgs e)
		{
			if (this.selectLVIKurs != null)
			{
				Person person = null;
				person = (Person)this.selectLVIKurs.Tag;
				person.kurs = null;
				this.allPersons.Add(person);
				this.persons.Remove(person);
				this.listViewKurs.Items.Remove(this.selectLVIKurs);
				this.listViewAlle.Items.Add(this.selectLVIKurs);
				this.selectLVIKurs = null;
				AktualisierenPlaetze();
				person.LinkDelete(this.kurs);
			}
			else
			{
				MessageBox.Show("Es muss ein Eintrag zum entfernen ausgewählt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

		private void AktualisierenPlaetze()
		{
			if (this.textBoxMaxTN.Text != "" || this.textBoxMaxTN.Text != string.Empty)
			{
				long wert = 0;
				bool erfolg = long.TryParse(this.textBoxMaxTN.Text, out wert);
				if (erfolg)
				{
					this.maxTN = (int)wert;
					this.kurs.MaxTN = this.maxTN;
				}
				else
				{
					MessageBox.Show("Ungültiger Wert bei Feld Max Teilnehmer", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				this.angemeldet = this.listViewKurs.Items.Count;
				this.textBoxAngemeldet.Text = this.angemeldet.ToString();
				this.frei = this.maxTN - this.angemeldet;
				this.textBoxFreiePlaetze.Text = this.frei.ToString();
			}
		}

		private void listViewAlle_MouseClick(object sender, MouseEventArgs e)
		{
			this.selectLVIAlle = null;
			this.selectLVIAlle = this.listViewAlle.GetItemAt(e.X, e.Y);
		}

		private void listViewKurs_MouseClick(object sender, MouseEventArgs e)
		{
			this.selectLVIKurs = null;
			this.selectLVIKurs = this.listViewKurs.GetItemAt(e.X, e.Y);
		}

		private void personBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.selectLVIAlle != null || this.selectLVIKurs != null)
			{
				this.editPerson = null;
				if (this.selectLVIAlle != null)
				{
					this.editPerson = (Person)this.selectLVIAlle.Tag;
					this.tabControlKurs.SelectedTab = tabPagePerson;
					FillPersonTab();
				}

				if (this.selectLVIKurs != null)
				{
					this.editPerson = (Person)this.selectLVIKurs.Tag;
					this.tabControlKurs.SelectedTab = tabPagePerson;
					FillPersonTab();
				}
			}
			else
			{
				MessageBox.Show("Es wurde keine Person zum bearbeiten ausgewählt.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}

		private void listViewKurs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			/*ListViewItem item = this.listViewKurs.GetItemAt(e.X, e.Y);
			this.editPerson = (Person)item.Tag;
			this.tabControlKurs.SelectedTab = tabPagePerson;
			FillPersonTab();*/
			if (this.maxTN > this.listViewKurs.Items.Count)
			{
				ListViewItem item = this.listViewKurs.GetItemAt(e.X, e.Y);
				Person person = (Person)item.Tag;
				person.kurs = null;
				this.allPersons.Add(person);
				this.persons.Remove(person);
				this.listViewKurs.Items.Remove(item);
				this.listViewAlle.Items.Add(item);
				AktualisierenPlaetze();
				person.LinkDelete(this.kurs);
			}
			else
			{
				MessageBox.Show("Maximale Teilnehmerzahl ereicht", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			
		}

		private void listViewAlle_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			/*ListViewItem item = this.listViewAlle.GetItemAt(e.X, e.Y);
			this.editPerson = (Person)item.Tag;
			this.tabControlKurs.SelectedTab = tabPagePerson;
			FillPersonTab();*/

			if (this.maxTN > this.listViewKurs.Items.Count)
			{
				ListViewItem item = this.listViewAlle.GetItemAt(e.X, e.Y);
				Person person = (Person)item.Tag;
				person.kurs = this.kurs;
				this.persons.Add(person);
				this.allPersons.Remove(person);
				this.listViewAlle.Items.Remove(item);
				this.listViewKurs.Items.Add(item);
				AktualisierenPlaetze();
			}
			else
			{
				MessageBox.Show("Maximale Teilnehmerzahl ereicht", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}

		#endregion

		#endregion

		//----------------------------------------------
		//----------------------------------------------
		//----------------------------------------------

		#region PersonTab
		private void buttonAdresse_Click(object sender, EventArgs e)
		{
			if (this.editPerson == null)
			{
				AdresseUcHinzufuegen(this.newPerson.AddAdresse());
				//this.flowLayoutPanelAdresse.Controls.Add(new AdresseUC(this.connection, this.newPerson.AddAdresse()));
			}
			else
			{
				AdresseUcHinzufuegen(this.editPerson.AddAdresse());
				//this.flowLayoutPanelAdresse.Controls.Add(new AdresseUC(this.connection, this.editPerson.AddAdresse()));
			}
		}



		private void buttonSpeichernPerson_Click(object sender, EventArgs e)
		{
			try
			{
				if (editPerson == null)
				{
					if (this.PersonPrüfung(this.newPerson))
					{
						foreach (KontaktUC kontaktUC in this.flowLayoutPanelKontakt.Controls)
						{
							kontaktUC.Datenspeichern();
						}
						foreach (AdresseUC adresseUC in this.flowLayoutPanelAdresse.Controls)
						{
							adresseUC.Datenspeichern();
						}
						this.newPerson.Save();
						this.allPersons.Add(this.newPerson);
						this.newPerson = new Person(this.connection);
						ClearPersonTab();
						this.labelStatus.Visible = true;
					}
				}
				else
				{
					if (this.PersonPrüfung(this.editPerson))
					{
						foreach (KontaktUC kontaktUC in this.flowLayoutPanelKontakt.Controls)
						{
							kontaktUC.Datenspeichern();
						}
						foreach (AdresseUC adresseUC in this.flowLayoutPanelAdresse.Controls)
						{
							adresseUC.Datenspeichern();
						}

						this.editPerson.Save();
						this.editPerson = null;
						ClearPersonTab();
						this.labelStatus.Visible = true;
					}
				}

			}
			catch (NpgsqlException ex)
			{
				if (ex.ErrorCode == -2147467259)
				{
					MessageBox.Show("Diese Person existiert bereits!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				else
				{
					MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

			}


		}

		private bool PersonPrüfung(Person person)
		{
			bool erfolg = false;

			if (this.textBoxVorname.Text != "")
			{
				person.Vorname = this.textBoxVorname.Text;
				erfolg = true;
			}
			else
			{
				MessageBox.Show("Ungültiger Wert bei Feld Vorname", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return erfolg = false;
			}
			if (this.textBoxNachname.Text != "")
			{
				person.Nachname = this.textBoxNachname.Text;
				erfolg = true;
			}
			else
			{
				MessageBox.Show("Ungültiger Wert bei Feld Vorname", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return erfolg = false;
			}
			person.GebDat = (this.dateTimePickerGebDat.Value == null ? DateTime.MinValue : this.dateTimePickerGebDat.Value);
			return erfolg;
		}

		private void buttonKontakt_Click(object sender, EventArgs e)
		{
			if (this.editPerson == null)
			{
				KontaktUcHinzufuegen(this.newPerson.AddKontakt());
				//this.flowLayoutPanelKontakt.Controls.Add(new KontaktUC(this.connection, this.newPerson.AddKontakt()));
			}
			else
			{
				KontaktUcHinzufuegen(this.editPerson.AddKontakt());
				//this.flowLayoutPanelKontakt.Controls.Add(new KontaktUC(this.connection, this.editPerson.AddKontakt()));
			}
		}

		private void tabPagePerson_Enter(object sender, EventArgs e)
		{
			if (this.editPerson == null)
			{
				this.newPerson = new Person(this.connection);
				this.KontaktUcHinzufuegen(newPerson.AddKontakt());
				this.AdresseUcHinzufuegen(newPerson.AddAdresse());
				//this.flowLayoutPanelKontakt.Controls.Add(new KontaktUC(this.connection, this.newPerson.AddKontakt()));
				//this.flowLayoutPanelAdresse.Controls.Add(new AdresseUC(this.connection, this.newPerson.AddAdresse()));
			}
		}

		private void ClearPersonTab()
		{
			if (this.newPerson == null)
			{
				this.newPerson = new Person(this.connection);
			}
			this.textBoxVorname.Text = "";
			this.textBoxNachname.Text = "";
			this.dateTimePickerGebDat.Value = DateTime.Now;
			this.dateTimePickerGebDat.Checked = false;
			this.flowLayoutPanelAdresse.Controls.Clear();
			this.flowLayoutPanelKontakt.Controls.Clear();
			this.KontaktUcHinzufuegen(newPerson.AddKontakt());
			this.AdresseUcHinzufuegen(newPerson.AddAdresse());
			//this.flowLayoutPanelKontakt.Controls.Add(new KontaktUC(this.connection, this.newPerson.AddKontakt()));
			//this.flowLayoutPanelAdresse.Controls.Add(new AdresseUC(this.connection, this.newPerson.AddAdresse()));
		}

		private void tabPagePerson_Leave(object sender, EventArgs e)
		{
			if (this.newPerson != null)
			{
				this.flowLayoutPanelAdresse.Controls.Clear();
				this.flowLayoutPanelKontakt.Controls.Clear();
				this.newPerson = null;
				this.listViewAlle.Items.Clear();
				this.listViewKurs.Items.Clear();
				FillListViewAll();
				if (this.kurs.KursId != null)
				{
					FillListViewKurs();
				}
			}
			else
			{
				this.flowLayoutPanelAdresse.Controls.Clear();
				this.flowLayoutPanelKontakt.Controls.Clear();
				this.editPerson = null;
				this.listViewAlle.Items.Clear();
				this.listViewKurs.Items.Clear();
				FillListViewAll();
				this.textBoxVorname.Text = "";
				this.textBoxNachname.Text = "";
				this.dateTimePickerGebDat.Value = DateTime.Now;
				if (this.kurs.KursId != null)
				{
					FillListViewKurs();
				}
			}

			this.labelStatus.Visible = false;
		}

		private void FillPersonTab()
		{
			List<Kontakt> kontakts = null;
			kontakts = this.editPerson.Kontakts;
			this.textBoxVorname.Text = this.editPerson.Vorname;
			this.textBoxNachname.Text = this.editPerson.Nachname;
			this.dateTimePickerGebDat.Value = (this.editPerson.GebDat.HasValue ? this.editPerson.GebDat.Value : DateTime.Now);
			foreach (Kontakt kontakt in kontakts)
			{
				KontaktUcHinzufuegen(kontakt);
				//this.flowLayoutPanelKontakt.Controls.Add(new KontaktUC(this.connection, kontakt));
			}
			foreach (Adresse adresse in this.editPerson.Adresses)
			{
				AdresseUcHinzufuegen(adresse);
				//this.flowLayoutPanelAdresse.Controls.Add(new AdresseUC(this.connection, adresse));
			}
		}

		private void buttonLoeschenPerson_Click(object sender, EventArgs e)
		{
			if (this.editPerson != null)
			{
				if (this.persons.Contains(editPerson)) this.persons.Remove(editPerson);
				if (this.allPersons.Contains(editPerson)) this.allPersons.Remove(editPerson);
				this.editPerson.Delete();
				ClearPersonTab();
			}
			else
			{
				ClearPersonTab();
			}
		}

		private void buttonAdresseLoeschen_Click(object sender, EventArgs e)
		{/*
			Adresse löschen = null;
			int i;
			i = (this.flowLayoutPanelAdresse.Controls.Count - 1);
			if (i >= 0)
			{
				this.flowLayoutPanelAdresse.Controls.RemoveAt(i);
				if (this.editPerson == null)
				{
					löschen = this.newPerson.Adresses.ElementAt(i);
					löschen.Delete();
					this.newPerson.Adresses.RemoveAt(i);
				}
				else
				{
					löschen = this.editPerson.Adresses.ElementAt(i);
					löschen.Delete();
					this.editPerson.Adresses.RemoveAt(i);
				}
			}*/
		}

		private void buttonKontaktLoeschen_Click(object sender, EventArgs e)
		{
			/*Kontakt löschen = null;
			int i;
			i = (this.flowLayoutPanelKontakt.Controls.Count - 1);
			if (i >= 0)
			{
				this.flowLayoutPanelKontakt.Controls.RemoveAt(i);
				if (this.editPerson == null)
				{
					löschen = this.newPerson.Kontakts.ElementAt(i);
					löschen.Delete();
					this.newPerson.Kontakts.RemoveAt(i);
				}
				else
				{
					löschen = this.editPerson.Kontakts.ElementAt(i);
					löschen.Delete();
					this.editPerson.Kontakts.RemoveAt(i);
				}
			}*/
		}

		private void AdresseUcHinzufuegen(Adresse adresse)
		{
			AdresseUC adresseUC = new AdresseUC(this.connection, adresse);
			adresseUC.Loeschen += AdresseUcLoeschen;
			this.flowLayoutPanelAdresse.Controls.Add(adresseUC);
		}
		private void AdresseUcLoeschen(object sender, EventArgs e)
		{
			this.tabPagePerson.Enter -= tabPagePerson_Enter;
			AdresseUC adresseUC = (AdresseUC)sender;
			adresseUC.adresse.Delete();
			if (editPerson != null) editPerson.Adresses.Remove(adresseUC.adresse);
			if (newPerson != null) newPerson.Adresses.Remove(adresseUC.adresse);
			this.flowLayoutPanelAdresse.Controls.Remove(adresseUC);
			this.tabPagePerson.Enter += tabPagePerson_Enter;
		}

		private void KontaktUcHinzufuegen(Kontakt kontakt)
		{
			KontaktUC kontaktUC = new KontaktUC(this.connection, kontakt);
			kontaktUC.Loeschen += KontaktUcLoeschen;
			this.flowLayoutPanelKontakt.Controls.Add(kontaktUC);
		}
		private void KontaktUcLoeschen(object sender, EventArgs e)
		{
			this.tabPagePerson.Enter -= tabPagePerson_Enter;
			KontaktUC kontaktUC = (KontaktUC)sender;
			kontaktUC.kontakt.Delete();
			if (editPerson != null) editPerson.Kontakts.Remove(kontaktUC.kontakt);
			if (newPerson != null) newPerson.Kontakts.Remove(kontaktUC.kontakt);
			this.flowLayoutPanelKontakt.Controls.Remove(kontaktUC);
			this.tabPagePerson.Enter += tabPagePerson_Enter;
		}

		private void buttonNeuePerson_Click(object sender, EventArgs e)
		{
			this.tabControlKurs.SelectedTab = tabPagePerson;
		}

		private void neuePersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.tabControlKurs.SelectedTab = tabPagePerson;
		}

		#endregion

		//----------------------------------------------
	}
}
