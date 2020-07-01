using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public enum Role
    {
        ADMIN,USER
    }

    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Role role { get; set; } = Role.USER;
        public bool active { get; set; }
        public DateTime? createdAt { get; set; }

        private User() 
        {
        }

        public User(string username, string password) : this()
        {
            this.username = username;
            this.password = Program.encryptPassword(password);
        }
        public User(string username, string password, Role role) : this(username, password)
        {
            this.role = role;
        }
    }
}
