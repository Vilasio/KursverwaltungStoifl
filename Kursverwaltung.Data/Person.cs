using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursverwaltung.Data
{
	public class Person
	{
        //------------------------------------------

        #region const
        private const string TABLE = "stoifl.person";
        private const string LINKTABLE = "stoifl.link";
        private const string ADRESSETABLE = "stoifl.adresse";
        private const string KONTAKTTABLE = "stoifl.kontakt";
        private const string COLUMN = "person_id, vorname, nachname, gebdat";
        #endregion

        //------------------------------------------

        #region private properties
        private NpgsqlConnection connection = null;
        #endregion

        //------------------------------------------

        #region Constructor
        public Person()
		{

		}
		public Person(NpgsqlConnection connection)
		{
            this.connection = connection;
		}
        public Person(NpgsqlConnection connection, Kurs kurs)
        {
            this.connection = connection;
            this.kurs = kurs;
        }
        #endregion

        //------------------------------------------

        #region Properties
        public long? PersonId { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime? GebDat { get; set; }
        public string Rolle { get; set; }
        public Kurs kurs = null;
        
        private List<Kontakt> kontakts = null;

        public List<Kontakt> Kontakts
        {
            get
            {
                if (this.kontakts == null) this.kontakts = Kontakt.GetList(this.connection, this);
                return kontakts;
            }
        }

        private List<Adresse> adresses;

        public List<Adresse> Adresses
        {
            get
            {
                if (this.adresses == null) this.adresses = Adresse.GetList(this.connection, this);
                return adresses;
            }
        }
        
        #endregion

        //------------------------------------------
        #region Static

        public static List<Person> GetList(NpgsqlConnection connection, Kurs kurs)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select person.person_id, person.vorname, person.nachname, person.gebdat " +
							$"from {TABLE} inner join {LINKTABLE} on {LINKTABLE}.person_id = {TABLE}.person_id where {LINKTABLE}.kurs_id = {kurs.KursId.Value} " +
			 $"order by vorname", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Person> persons = new List<Person>();

            while (reader.Read())
            {
                persons.Add(new Person(connection, kurs)
                {
                    PersonId = reader.GetInt64(0),
                    Vorname = reader.IsDBNull(1) ? null : reader.GetString(1),
                    Nachname = reader.IsDBNull(2) ? null : reader.GetString(2),
                    GebDat = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                });
            }
            reader.Close();
            return persons;
        }

        public static List<Person> GetListAll(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select {COLUMN} from {TABLE} order by vorname", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Person> persons = new List<Person>();

            while (reader.Read())
            {
                persons.Add(new Person(connection)
                {
                    PersonId = reader.GetInt64(0),
                    Vorname = reader.IsDBNull(1) ? null : reader.GetString(1),
                    Nachname = reader.IsDBNull(2) ? null : reader.GetString(2),
                    GebDat = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                });
            }
            reader.Close();
            return persons;
        }

        public static List<Person> GetListAll_Kurs(NpgsqlConnection connection, Kurs kurs)
        {
            NpgsqlCommand command = new NpgsqlCommand
                ($"Select {COLUMN} from {TABLE} except Select person.person_id, person.vorname, person.nachname, person.gebdat from " +
                $"{TABLE} join {LINKTABLE} on {LINKTABLE}.person_id = {TABLE}.person_id" +
                $" where {LINKTABLE}.kurs_id = {kurs.KursId.Value}", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Person> persons = new List<Person>();

            while (reader.Read())
            {
                persons.Add(new Person(connection)
                {
                    PersonId = reader.GetInt64(0),
                    Vorname = reader.IsDBNull(1) ? null : reader.GetString(1),
                    Nachname = reader.IsDBNull(2) ? null : reader.GetString(2),
                    GebDat = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                });
            }
            reader.Close();
            return persons;
        }
        #endregion

        //------------------------------------------
        #region public Methods

        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.PersonId.HasValue)
            {
                command.CommandText =
                    $"update {TABLE} set vorname = :vo, nachname = :na, gebdat = :ge where person_id = :pid";
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.PersonId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (person_id, vorname, nachname, gebdat)" +
                    $" values(:pid, :vo, :na, :ge)";
            }
            command.Parameters.AddWithValue("pid", this.PersonId.Value);
            command.Parameters.AddWithValue("vo", String.IsNullOrEmpty(this.Vorname) ? (object)DBNull.Value : this.Vorname);
            command.Parameters.AddWithValue("na", String.IsNullOrEmpty(this.Nachname) ? (object)DBNull.Value : this.Nachname);
            command.Parameters.AddWithValue("ge", this.GebDat.HasValue ? (object)this.GebDat.Value : (object)DBNull.Value);
            int result =+ command.ExecuteNonQuery();
            //Befüllen von Adresseliste und Kontakliste------------------------------------------------------------------------------------------
            if (this.kontakts != null)
            {
                foreach (Kontakt kontakt in kontakts)
                {
                    kontakt.Save();
                }
            }
            if (this.adresses != null)
            {
                foreach (Adresse adresse in adresses)
                {
                    adresse.Save();
                }
            }
            //Befüllung der Linktable---------------------------------------------------------------------------------------------------------------
            if (this.kurs != null) 
            {
                command.CommandText = $"select kurs_id from {LINKTABLE} where kurs_id = {kurs.KursId.Value} and person_id = {this.PersonId.Value}";
                object exists = command.ExecuteScalar();
                if (Convert.ToInt64(exists)== 0)
                {
                    command.CommandText = $" insert into {LINKTABLE} (kurs_id, person_id, rolle) values(:kid, :pid, :ro)";
                }
                else
                {
                    command.CommandText = $"update {LINKTABLE} set rolle = :ro";
                }
                command.Parameters.AddWithValue("kid", this.kurs.KursId.Value);
                command.Parameters.AddWithValue("pid", this.PersonId.Value);
                command.Parameters.AddWithValue("ro", String.IsNullOrEmpty(this.Rolle) ? (object)DBNull.Value : this.Rolle);
                result =+ command.ExecuteNonQuery();
            }
            return result;
        }

        public int Delete()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.PersonId.HasValue)
            {
                int result = 0;
                
                //Löschen der Linktableverbindung
                command.CommandText = $"delete from {LINKTABLE} where person_id = :pid";
                command.Parameters.AddWithValue("pid", this.PersonId.Value);
                result += command.ExecuteNonQuery();
                //Löschen der Adressen
                command.CommandText = $"delete from {ADRESSETABLE} where person_id = :pid";
                command.Parameters.AddWithValue("pid", this.PersonId.Value);
                result += command.ExecuteNonQuery();
                //Löschen der Kontakt
                command.CommandText = $"delete from {KONTAKTTABLE} where person_id = :pid";
                command.Parameters.AddWithValue("pid", this.PersonId.Value);
                result += command.ExecuteNonQuery();
                //Löschen der Person
                command.CommandText = $"delete from {TABLE} where person_id = :pid";
                command.Parameters.AddWithValue("pid", this.PersonId.Value);
                result += command.ExecuteNonQuery();
                return result;
            }
            else
            {
                return 0;
            }
        }

        public int LinkDelete(Kurs kurs)
        {
            if (kurs.KursId != null)
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = this.connection;

                int result = 0;

                
                command.CommandText = $"delete from {LINKTABLE} where person_id = :pid and kurs_id = :kid";
                command.Parameters.AddWithValue("pid", this.PersonId.Value);
                command.Parameters.AddWithValue("kid", kurs.KursId.Value);
                return result = command.ExecuteNonQuery();
            }
            return 0;
        }   

            /// <summary>
            /// Gibt dir ein KontaktObjekt zurück dass in die verbunden ist mit diesem PersonObjekt ist
            /// </summary>
            /// <returns>Kontakt</returns>
            public Kontakt AddKontakt()
        {
            if (this.kontakts == null) this.kontakts = new List<Kontakt>();
            Kontakt kontakt = new Kontakt(this.connection, this);
            this.kontakts.Add(kontakt);
            return kontakt;
        }
        /// <summary>
        /// Gibt dir ein AdressenObjekt zurück dass in die verbunden ist mit diesem PersonObjekt ist
        /// </summary>
        /// <returns>Adresse</returns>
        public Adresse AddAdresse()
        {
            if (this.adresses == null) this.adresses = new List<Adresse>();
            Adresse adresse = new Adresse(this.connection, this);
            this.adresses.Add(adresse);
            return adresse;
        }
        
        #endregion
        //------------------------------------------
    }
}
