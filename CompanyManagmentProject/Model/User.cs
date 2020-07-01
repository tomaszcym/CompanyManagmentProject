using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int? privileges { get; set; }
        public bool active { get; set; }
        public DateTime? createdAt { get; set; }

        private User() 
        {
            if (this.privileges == null)
                this.privileges = 10;
        }

        public User(string username, string password) : this()
        {
            this.username = username;
            this.password = Program.encryptPassword(password);
        }
        public User(string username, string password, int privileges) : this(username, password)
        {
            this.privileges = privileges;
        }
    }
}
