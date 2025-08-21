using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public Dictionary<string, int> Portfolio { get; set; } = new Dictionary<string, int>();

        public Guid ID { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; } = 10000m;

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
