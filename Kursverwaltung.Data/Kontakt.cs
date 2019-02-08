using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursverwaltung.Data
{
	public class Kontakt
	{
        #region Const
        private const string TABLE = "stoifl.kontakt";
        private const string ARTTABLE = "stoifl.art";
        private const string PERSONTABLE = "stoifl.person";
        private const string COLUMN = "kontakt_id, art_id, tel, email";
        #endregion

        //------------------------------------------

        #region private Properties
        private NpgsqlConnection connection = null;
        #endregion

        //------------------------------------------

        #region Constructor
        public Kontakt()
        {

        }
        public Kontakt(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        public Kontakt(NpgsqlConnection connection, Person person)
        {
            this.connection = connection;
            this.Person = person;
        }
        #endregion

        //------------------------------------------

        #region Property
        public long? KontaktId { get; set; }
        public Person Person { get; set; }
        public long? ArtId { get; set; }
        public string Art { get; set; }
        public Art ArtObject { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        #endregion

        //------------------------------------------

        #region Public Methods

        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.KontaktId.HasValue)
            {
                command.CommandText =
                    $"update {TABLE} set tel = :te, email = :em, art_id = :arid where kontakt_id = :kid";
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.KontaktId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (kontakt_id, person_id, art_id, tel, email)" +
                    $" values(:kid, :pid, :arid, :te, :em)";
            }
            command.Parameters.AddWithValue("kid", this.KontaktId.Value);
            command.Parameters.AddWithValue("pid", this.Person.PersonId.Value);
            command.Parameters.AddWithValue("arid", this.ArtId.Value);
            command.Parameters.AddWithValue("te", String.IsNullOrEmpty(this.Tel) ? (object)DBNull.Value : this.Tel);
            command.Parameters.AddWithValue("em", String.IsNullOrEmpty(this.Email) ? (object)DBNull.Value : this.Email);
            int result = command.ExecuteNonQuery();
            return result;
        }

        public int Delete()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.KontaktId.HasValue)
            {
                int result = 0;

                command.CommandText = $"delete from {TABLE} where kontakt_id = :kid";
                command.Parameters.AddWithValue("kid", this.KontaktId.Value);
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
        public static List<Kontakt> GetList(NpgsqlConnection connection, Person person)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select kontakt.kontakt_id, kontakt.art_id, kontakt.tel, kontakt.email, art.bezeichnung " +
                $"from {TABLE} inner join {PERSONTABLE} on {TABLE}.person_id = {PERSONTABLE}.person_id " +
                $"inner join {ARTTABLE} on {TABLE}.art_id = {ARTTABLE}.art_id where {TABLE}.person_id = {person.PersonId.Value}", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Kontakt> kontakts = new List<Kontakt>();

            while (reader.Read())
            {
                kontakts.Add(new Kontakt(connection, person)
                {
                    KontaktId = reader.GetInt64(0),
                    ArtId = reader.GetInt64(1),
                    Tel = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Art = reader.IsDBNull(4) ? null : reader.GetString(4)
                });
            }
            reader.Close();
            return kontakts;
        }
        #endregion

        //------------------------------------------
    }
}
