using System.Data;
using MySql.Data.MySqlClient;

namespace Part1.classes
{
    class DBConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnector()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "comp1551";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private bool OpenConnection()
        {
            connection.Open();
            return true;
        }

        //Close connection
        private bool CloseConnection()
        {
            connection.Close();
            return true;
        }

        //Insert statement
        public void Insert(string inputString, int encodeValue, string encodedString, string inputCode, string outputCode, string sortedString)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss"); // Format to "yyyy-MM-dd HH:mm:ss"

            string query = $"INSERT INTO strings (datetime, inputString, encodeValue, encodedString, inputCode, outputCode, sortedString) VALUES('{formattedDateTime}', '{inputString}', {encodeValue}, '{encodedString}', '{inputCode}', '{outputCode}', '{sortedString}')";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                CloseConnection();
            }
        }



        public DataTable GetAllRecords()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM strings ORDER BY datetime DESC";

            if (OpenConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                finally
                {
                    CloseConnection();
                }
            }
            return dataTable;
        }
    }
}
