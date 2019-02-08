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
	public partial class FormMain : Form
	{
        private NpgsqlConnection connection = null;
		public FormMain()
		{
			InitializeComponent();
		}

		public FormMain(NpgsqlConnection connection)
		{
            InitializeComponent();
            this.connection = connection;
		}
        private List<Kurs> kurse = null;
        private Kurs kurs = null;


        private void Fillistview()
        {
            listViewKursübersicht.Items.Clear();
            ListViewItem item = null;
            foreach (Kurs kurs in kurse)
            {
                item = new ListViewItem();
                item.Tag = kurs;
                item.Text = kurs.Name;
                item.SubItems.Add(kurs.Startkurs.Value.ToShortDateString());
                item.SubItems.Add(kurs.Endekurs.Value.ToShortDateString());
                item.SubItems.Add(kurs.Lehreinheiten.ToString());
                item.SubItems.Add(kurs.MaxTN.ToString());
                item.SubItems.Add(kurs.Angemeldet.ToString()); 
                item.SubItems.Add(kurs.FreiPlaetze.ToString());
                listViewKursübersicht.Items.Add(item);
            }
            this.StatusLabelAnzahlkurse.Visible = true;
            this.StatusLabelAnzahlkurse.Text = kurse.Count.ToString();
            this.StatusLabelDbUser.Visible = true;
            this.StatusLabelDbUser.Text = this.connection.UserName;
            this.StatusLabelDbNamen.Visible = true;
            this.StatusLabelDbNamen.Text = this.connection.Database;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.kurse = Kurs.GetList(this.connection);
            Fillistview();
        }

        private void listViewKursübersicht_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = null;
            Kurs kurs = null;
            item = listViewKursübersicht.GetItemAt(e.X, e.Y);
            kurs = (Kurs)item.Tag;

            FormKursDetail kursDetail = new FormKursDetail(this.connection, kurs, kurse);

            if(kursDetail.ShowDialog() == DialogResult.OK)
            {
                Fillistview();
            }

        }

        private void MenuItemNeuerKurs_Click(object sender, EventArgs e)
        {
            FormKursDetail kursDetail = new FormKursDetail(this.connection, this.kurse);

            if (kursDetail.ShowDialog() == DialogResult.OK)
            {
                Fillistview();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemNeuePerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person(this.connection);
            FormKursDetail kursDetail = new FormKursDetail(this.connection, this.kurse, newPerson);

            if (kursDetail.ShowDialog() == DialogResult.OK)
            {
                Fillistview();
            }
        }

        private void ContextMenuItemKursBearbeiten_Click(object sender, EventArgs e)
        {
            if (this.kurs != null)
            {
                FormKursDetail kursDetail = new FormKursDetail(this.connection, kurs, kurse);

                if (kursDetail.ShowDialog() == DialogResult.OK)
                {
                    Fillistview();
                }
            }
            else
            {
                MessageBox.Show("Es wurde kein Kurs zum bearbeiten ausgewählt.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.kurs = null;
        }

        private void listViewKursübersicht_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = null;
            this.kurs = null;
            item = listViewKursübersicht.GetItemAt(e.X, e.Y);
            this.kurs = (Kurs)item.Tag;
        }
    }
}
