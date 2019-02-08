using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursverwaltung.Data
{
	public class Adresse
	{
        #region Const
        private const string TABLE = "stoifl.adresse";
        private const string ARTTABLE = "stoifl.art";
        private const string PERSONTABLE = "stoifl.person";
        private const string COLUMN = "adresse_id, art_id, strasse, hnr, ort, plz";
        #endregion
        //------------------------------------------
        #region private Properties
        private NpgsqlConnection connection = null;
        #endregion
        //------------------------------------------

        #region Constructor
        public Adresse()
        {

        }
        public Adresse(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        public Adresse(NpgsqlConnection connection, Person person)
        {
            this.connection = connection;
            this.Person = person;
        }
        #endregion

        //------------------------------------------

        #region Property
        public long? AdresseID { get; set; }
        public Person Person { get; set; }
        public long? ArtId { get; set; }
        public string Art { get; set; }
        public Art ArtObject { get; set; }
        public string Strasse { get; set; }
        public long? Hnr { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }

        #endregion

        //------------------------------------------

        #region Public Methods

        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;

            if (this.AdresseID.HasValue)
            {
                command.CommandText =
                    $"update {TABLE} set art_id = :arid, strasse = :st, hnr = :hn, ort = :or, plz = :pl where adresse_id = :aid";
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.AdresseID = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (adresse_id, person_id, art_id, strasse, hnr, ort, plz)" +
                    $" values(:aid, :pid, :arid, :st, :hn, :or, :pl)";
            }

            command.Parameters.AddWithValue("aid", this.AdresseID.Value);
            command.Parameters.AddWithValue("pid", this.Person.PersonId.Value);
            command.Parameters.AddWithValue("arid", this.ArtId.Value);
            command.Parameters.AddWithValue("st", String.IsNullOrEmpty(this.Strasse) ? (object)DBNull.Value : this.Strasse);
            command.Parameters.AddWithValue("hn", this.Hnr.HasValue ? (object)this.Hnr.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("or", String.IsNullOrEmpty(this.Ort) ? (object)DBNull.Value : this.Ort);
            command.Parameters.AddWithValue("pl", String.IsNullOrEmpty(this.Plz) ? (object)DBNull.Value : this.Plz);
            

            int result = command.ExecuteNonQuery();

            return result;
        }

        public int Delete()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.AdresseID.HasValue)
            {
                int result = 0;

                command.CommandText = $"delete from {TABLE} where adresse_id = :aid";
                command.Parameters.AddWithValue("aid", this.AdresseID.Value);
                result = command.ExecuteNonQuery();
                return result;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        //------------------------------------------

        #region Static
        public static List<Adresse> GetList(NpgsqlConnection connection, Person person)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select adresse.adresse_id, adresse.art_id, adresse.strasse, adresse.hnr, adresse.ort, adresse.plz ,art.bezeichnung " +
                $"from {TABLE} left join {PERSONTABLE} on {TABLE}.person_id = {PERSONTABLE}.person_id " +
                $"inner join {ARTTABLE} on {TABLE}.art_id = {ARTTABLE}.art_id where {TABLE}.person_id = {person.PersonId.Value}", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Adresse> adresses = new List<Adresse>();

            while (reader.Read())
            {
                adresses.Add(new Adresse(connection, person)
                {
                    AdresseID = reader.GetInt64(0),
                    ArtId = reader.GetInt64(1),
                    Strasse = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Hnr = reader.IsDBNull(3) ? null : (long?)reader.GetInt64(3),
                    Ort = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Plz = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Art = reader.IsDBNull(6) ? null : reader.GetString(6)
                });
            }
            reader.Close();
            return adresses;
        }
        #endregion

        //------------------------------------------



    }
}
