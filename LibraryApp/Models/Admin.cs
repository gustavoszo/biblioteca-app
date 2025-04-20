using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp.Models
{
    internal class Admin
    {
        public string Username { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }

        public Admin(string username, string hash, string salt)
        {
            Username = username;
            Hash = hash;
            Salt = salt;
        }
    }
}
