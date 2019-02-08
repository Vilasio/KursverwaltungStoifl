using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursverwaltung.Data
{
	public class Art
	{

        //------------------------------------------

        #region Const
        private const string TABLE = "stoifl.art";
        private const string COLUMN = "art_id, bezeichnung";
        #endregion

        //------------------------------------------

        #region private Properties
        private NpgsqlConnection connection = null;
        #endregion

        //------------------------------------------

        #region Constructor
        public Art()
        {

        }

        public Art(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        #endregion

        //------------------------------------------

        #region Property
        public long? ArtId { get; set; }
        public string Bezeichnung { get; set; }
        public static List<Art> arten = null;
        #endregion

        //------------------------------------------

        #region Static
        public static List<Art> GetList(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select {COLUMN} from {TABLE}", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<Art> arten = new List<Art>();

            while (reader.Read())
            {
                arten.Add(new Art(connection)
                {
                    ArtId = reader.GetInt64(0),
                    Bezeichnung = reader.IsDBNull(1) ? null : reader.GetString(1),
                });
            }
            reader.Close();
            return arten;
        }
        #endregion

        //------------------------------------------

        #region Public Methods
        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;

            if (this.ArtId.HasValue)
            {
                command.CommandText =
                    $"update {TABLE} set bezeichnun = :be where art_id = :arid";
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.ArtId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (art_id, bezeichnung) values(:arid, :be)";
            }
            command.Parameters.AddWithValue("arid", this.ArtId.Value);
            command.Parameters.AddWithValue("be", String.IsNullOrEmpty(this.Bezeichnung) ? (object)DBNull.Value : this.Bezeichnung);

            int result = command.ExecuteNonQuery();
            return result;
        }
        #endregion

        //------------------------------------------
    }
}
