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
        private bool isOpenConnection()
        {
            connection.Open();
            return true;
        }

        //Close connection
        private bool isCloseConnection()
        {
            connection.Close();
            return true;
        }

        //Insert statement
        public void Insert(string inputString, string encodeValue, string encodedString, string inputCode, string outputCode, string sortedString)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("HH:mm dd/MM/yyyy"); // Format to "HH:mm dd/MM/yyyy"

            string query = $"INSERT INTO strings (inputString, encodeValue, encodedString, inputCode, outputCode, sortedString) VALUES({formattedDateTime}, {inputString}, {encodeValue}, {encodedString}, {inputCode}, {outputCode}, {sortedString})";

            //open connection
            if (isOpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                isCloseConnection();
            }
        }


        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            //Open connection
            if (isOpenConnection() == true)
            {

            }
        }
    }
}
