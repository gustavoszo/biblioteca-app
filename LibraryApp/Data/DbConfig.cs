using System;

namespace LibraryApp.Data
{
    internal class DbConfig
    {
        public string Address { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public DbConfig(string address, string username, string password, string database)
        {
            Address = address;
            Username = username;
            Password = password;
            Database = database;
        }

        public string BuildConnectionString()
        {
            return $"server={Address};database={Database};username={Username};password={Password}";
        }
    }
}
