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

        /// <summary>
        /// Konstruktor bezparametrowy
        /// </summary>
        private User() 
        {
        }


        /// <summary>
        /// Konstruktor pomocniczy
        /// </summary>
        /// <param name="username">Reprezentuje pole nazwy uzytkownika modelu</param>
        /// <param name="password">Reprezentuje pole hasla modelu</param>
        public User(string username, string password) : this()
        {
            this.username = username;
            this.password = Program.encryptPassword(password);
        }

        /// <summary>
        /// Konstruktor pomocniczy
        /// </summary>
        /// <param name="username">Reprezentuje pole nazwy uzytkownika modelu</param>
        /// <param name="password">Reprezentuje pole hasla modelu</param>
        /// <param name="role">Reprezentuje role jaka spelnia uzytkownik w systemie</param>
        public User(string username, string password, Role role) : this(username, password)
        {
            this.role = role;
        }
    }
}
