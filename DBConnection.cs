using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;

namespace FitnessPlanner
{
    public class DBConnection
    {
        private static DBConnection instance = null;
        private MySqlConnection connection;

        private string server = "localhost";
        private string database = "FitnessPlannerDB";
        private string uid = "root";
        private string password = "";

        private string connectionString;

        private DBConnection()
        {
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public static DBConnection Instance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        
        public bool OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
                return false;
            }
        }

        //close the db connection
        public bool CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public MySqlConnection Connection
        {
            get { return connection; }
        }
    }
}