using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace CompanyManagmentProject.Repo
{
    public static class UserRepository
    {
        /// <summary>
        /// Lista uzytkownikow w aplikacji
        /// Zastepuje baze danych
        /// </summary>
        public static List<User> users { get; set; } = new List<User>();

        /// <summary>
        /// Przetrzymuje id ostatniego uzytkownika
        /// Dodanie kolejnego zwieksza id
        /// </summary>
        private static int userId = 0;


        /// <summary>
        /// Zapelnienie repozytorium przykladowymi danymi
        /// </summary>
        public static void init()
        {
            UserRepository.add(new User("admin", "admin", Role.ADMIN));
            UserRepository.add(new User("mkardas", "demo123")); // id 2
            UserRepository.add(new User("awojcik", "demo123")); // id 3
            UserRepository.add(new User("tcymerys", "demo123")); // id 4
            UserRepository.add(new User("jkowalski", "demo123")); // id 5
            UserRepository.add(new User("rnowak", "demo123")); // id 6
            UserRepository.add(new User("akuchta", "demo123")); // id 7
        }


        // GETTERS

        /// <summary>
        /// Zwraca uzytkownika o podanym id
        /// </summary>
        /// <param name="id">Przyjmuje ID użytkownika</param>
        /// <returns>Zwraca uzytkownika o padanym ID</returns>
        public static User getById(int id)
        {
            User user = null;
            try
            {
                user = users.Find(e => e.id == id);
            }
            catch (ArgumentNullException e)
            {
                return null;
            }
            return user;
        }

        /// <summary>
        /// Zwraca wszystkich uzytkownikow
        /// </summary>
        /// <returns>Zwraca wszystkich pracowników</returns>
        public static List<User> getAll()
        {
            return users;
        }


        /// <summary>
        /// Sprawdza poprawnosc danych autoryzujacego sie uzytkownika
        /// </summary>
        /// <param name="username">Przyjmuje nazwe użytkownika</param>
        /// <param name="password">Przyjmuje hasło użytownika</param>
        /// <returns>Zwraca użytkowniuka lub "null"</returns>
        public static User authorizeUser(string username, string password)
        {
            User user = null;
            try
            {
                user = users.Find(u => u.username == username);
                if (user == null)
                {
                    return null;
                }

                if(user.password == Program.encryptPassword(password))
                {
                    return user;
                }

                return null;
            }
            catch (ArgumentNullException e)
            {
                return null;
            }
        }

        // MODIFIERS

        /// <summary>
        /// Nadaje id przeslanemu modelowi
        /// Dodaje model do repozytorium
        /// </summary>
        /// <param name="user">Instancja obiektu User</param>
        public static void add(User user)
        {
            user.id = ++userId;
            users.Add(user);
        }
    }
}
