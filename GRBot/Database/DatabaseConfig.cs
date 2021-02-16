namespace GRBot.Database
{
    /**
     * Represents the database configuration
     */
    public class DatabaseConfig
    {
        private string _connectionString;
        private string _database;
        private string _username;
        private string _password;

        public DatabaseConfig(string connectionString, string database, string username, string password)
        {
            this._connectionString = connectionString;
            this._database = database;
            this._username = username;
            this._password = password;
        }

        public string getConnectionString()
        {
            return this._connectionString;
        }

        public string getDatabase()
        {
            return this._database;
        }

        public string getUserName()
        {
            return this._username;
        }

        public string getPassword()
        {
            return this._password;
        }
    }
}