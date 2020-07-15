using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public class Employee
    {
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String position { get; set; }
        public Double salary { get; set; }
        public DateTime dateHired { get; set; }
        public Boolean fired { get; set; }

        public int? userId { get; set; }
        public User user { get; set; }


        /// <summary>
        /// Domyślny konstruktor bezparametrowy
        /// Ustawia datę obiektu na aktualną
        /// </summary>
        public Employee() {
            this.dateHired = DateTime.Now;
        }

        /// <summary>
        /// Konstruktor pomocniczy
        /// </summary>
        /// <param name="firstName">Reprezentuje imie modelu</param>
        /// <param name="lastName">Reprezentuje nazwisko modelu</param>
        public Employee(String firstName, String lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        /// <summary>
        /// Zwraca wartosc - czy pracownik zostal zwolniony czy nie
        /// </summary>
        /// <returns>Wartosc pola fires modelu</returns>
        public Boolean isFired()
        {
            return this.fired;
        }
    }
}
