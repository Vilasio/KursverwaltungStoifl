using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursverwaltung.GUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			NpgsqlConnection connection = new NpgsqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
			try
			{
				connection.Open();

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new FormMain(connection));
			}
			catch (NpgsqlException sqlEx)
			{
				MessageBox.Show($"NPGSQL: {sqlEx.Message}");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
