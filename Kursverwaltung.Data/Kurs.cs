using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursverwaltung.Data
{
    public class Kurs
    {
        #region Const
        private const string TABLE = "stoifl.kurs";
        private const string COLUMN = "kurs_id, kursnummer, name, startkurs, endekurs, lehreinheiten, raum, maxTN, angemeldet, freiePlaetze";
        #endregion
        //------------------------------------------
        #region private Properties
        private NpgsqlConnection connection = null;
        #endregion
        //------------------------------------------

        #region Constructor
        public Kurs(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        #endregion

        //------------------------------------------

        #region Property
        public long? KursId { get; set; }
        public long? Kursnummer { get; set; }
        public string Name { get; set; }
        public DateTime? Startkurs { get; set; }
        public DateTime? Endekurs { get; set; }
        public long? Lehreinheiten { get; set; }
        public string Raum { get; set; }
        public long? MaxTN { get; set; }
        public long? FreiPlaetze { get; set; }
        public long? Angemeldet { get; set; }
        private DateTime year;
        private List<Person> persons = null;

        public List<Person> Persons
        {
            get
            {
                if (this.persons == null && this.KursId != null) this.persons = Person.GetList(connection, this);
                if (this.KursId == null) this.persons = new List<Person>();
                return persons;
            }
            set
            {
                this.persons = value;
            }
        }

        #endregion

        //------------------------------------------

        #region Public Methods

        public Person AddPerson()
        {
            if (this.persons == null) this.persons = new List<Person>();
            Person person = new Person(this.connection, this);
            this.persons.Add(person);
            return person;
        }

        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;

            if (this.KursId.HasValue)
            {
                command.CommandText = 
                    $"update {TABLE} set name = :na, startkurs = :st, endekurs = :en, " +
                    $"lehreinheiten = :le, raum = :ra, maxTN = :ma, angemeldet = :an, freiePlaetze = :fr where kurs_id = :kid" ;
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.KursId = (long?) command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (kurs_id, kursnummer, name, startkurs, endekurs, lehreinheiten, raum, maxTN,angemeldet, freiePlaetze)" +
                    $" values(:kid, :ku, :na, :st, :en, :le, :ra, :ma, :an, :fr)";
                string knu = $"{this.KursId}";
                knu.PadLeft(6, '0');
                this.year = DateTime.Now;
                knu = $"{this.year.Year.ToString()}{knu}";
                this.Kursnummer = Convert.ToInt64(knu);
            }

            command.Parameters.AddWithValue("kid", this.KursId.Value);
            command.Parameters.AddWithValue("ku", this.Kursnummer.Value);
            command.Parameters.AddWithValue("na", String.IsNullOrEmpty(this.Name) ? (object)DBNull.Value : this.Name);
            command.Parameters.AddWithValue("st", this.Startkurs.HasValue ? (object)this.Startkurs.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("en", this.Endekurs.HasValue ? (object)this.Endekurs.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("le", this.Lehreinheiten.HasValue ? (object)this.Lehreinheiten.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("ra", String.IsNullOrEmpty(this.Raum) ? (object)DBNull.Value : this.Raum);
            command.Parameters.AddWithValue("ma", this.MaxTN.HasValue ? (object)this.MaxTN.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("an", this.Angemeldet.HasValue ? (object)this.Angemeldet.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("fr", this.FreiPlaetze.HasValue ? (object)this.FreiPlaetze.Value : (object)DBNull.Value);

            int result = command.ExecuteNonQuery();

            if(this.persons != null)
            {
                foreach (Person person in this.persons)
                {
                    person.Save();
                }
            }
            return result;
        }

        public int Delete()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.KursId.HasValue)
            {
                //Löschen der Linktableverbindung
                command.CommandText = "delete from stoifl.link where kurs_id = :kid";
                command.Parameters.AddWithValue("kid", this.KursId.Value);
                command.ExecuteNonQuery();
                //Löschen des Kurses
                command.CommandText = $"delete from {TABLE} where kurs_id = :kid";
                command.Parameters.AddWithValue("kid", this.KursId.Value);
                return command.ExecuteNonQuery();
            }
            else
            {
                return 0;
            }
        }

        

        #endregion

        //------------------------------------------

        #region Static
        public static List<Kurs> GetList(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select {COLUMN} from {TABLE} order by name", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Kurs> kurse = new List<Kurs>();

            while (reader.Read())
            {
                kurse.Add(new Kurs(connection)
                {
                    KursId = reader.GetInt64(0),
                    Kursnummer = reader.IsDBNull(1) ? null : (long?)reader.GetInt64(1),
                    Name = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Startkurs = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                    Endekurs = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                    Lehreinheiten = reader.IsDBNull(5) ? null : (long?)reader.GetInt64(5),
                    Raum = reader.IsDBNull(6) ? null : reader.GetString(6),
                    MaxTN = reader.IsDBNull(7) ? null : (long?)reader.GetInt64(7),
                    Angemeldet = reader.IsDBNull(8) ? null : (long?)reader.GetInt64(8),
                    FreiPlaetze = reader.IsDBNull(9) ? null : (long?)reader.GetInt64(9)
                });
            }
            reader.Close();
            return kurse;
        }
        #endregion

        //------------------------------------------


    }
}
