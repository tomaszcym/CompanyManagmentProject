using CompanyManagmentProject.Model;
using CompanyManagmentProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagmentProject
{
    static class Program
    {
        public static User currentUser = null;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // zainicjowanie repozytoriow
            EmployeeRepository.init();
            TaskRepository.init();
            UserRepository.init();


            // uruchomienie aplikacji
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Auth authForm = new Auth();
            authForm.Show();

            Application.Run();
        }



        public static string encryptPassword(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}
