using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace CompanyManagmentProject.Repo
{
    public static class UserRepository
    {
        public static List<User> users { get; set; } = new List<User>();
        private static int userId = 0;


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

        public static List<User> getAll()
        {
            return users;
        }

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
        public static void add(User user)
        {
            user.id = ++userId;
            users.Add(user);
        }

        //public static Boolean update(int id, User user)
        //{
        //    if (id != user.id)
        //    {
        //        return false;
        //    }

        //    try
        //    {
        //        int position = users.FindIndex(i => i.id == user.id);
        //        users[position] = user;
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        //public static Boolean delete(int id)
        //{
        //    try
        //    {
        //        User user = users.SingleOrDefault(t => t.id == id);

        //        if (user != null)
        //        {
        //            users.Remove(user);
        //            return true;
        //        }
        //    }
        //    catch (ArgumentNullException e)
        //    {
        //        return false;
        //    }
        //    return false;
        //}

    }
}
