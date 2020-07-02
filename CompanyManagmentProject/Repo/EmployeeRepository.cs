using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagmentProject.Repo
{
    public static class EmployeeRepository
    {
        public static List<Employee> employees { get; set; } = new List<Employee>();
        private static int employeeId = 0;


        public static void init()
        {
            Employee employee1 = new Employee("Mariusz", "Kardaś");
            employee1.email = "mariuszkardas@poczta.pl";
            employee1.phone = "888666444";
            employee1.position = "Mechanik";
            employee1.salary = 3200;
            employee1.dateHired = new DateTime(2018, 1, 7);
            Employee employee2 = new Employee("Arek", "Wójcik");
            employee2.email = "arek_wystarczy@poczta.pl";
            employee2.phone = "737883883";
            employee2.position = "Kierowca";
            employee2.salary = 3200;
            employee2.dateHired = new DateTime(2017, 2, 13);
            Employee employee3 = new Employee("Tomasz", "Cymerys");
            employee3.email = "tomaszcymerys@poczta.pl";
            employee3.phone = "828616425";
            employee3.position = "Mechanik";
            employee3.salary = 3200;
            employee3.dateHired = new DateTime(2018, 2, 10);
            Employee employee4 = new Employee("Jan", "Kowalski");
            employee4.email = "jankowalski22@poczta.pl";
            employee4.phone = "838882215";
            employee4.position = "Kierownik";
            employee4.salary = 4300;
            employee4.dateHired = new DateTime(2017, 5, 11);
            Employee employee5 = new Employee("Roman", "Nowak");
            employee5.email = "romannowak211@poczta.pl";
            employee5.phone = "899113772";
            employee5.position = "Operator";
            employee5.salary = 3600;
            employee5.dateHired = new DateTime(2016, 7, 13);
            Employee employee6 = new Employee("Andrzej", "Kuchta");
            employee6.email = "andrzejkuchta992@poczta.pl";
            employee6.phone = "828616425";
            employee6.position = "Księgowy";
            employee6.salary = 3500;
            employee6.dateHired = new DateTime(2017, 1, 18);



            EmployeeRepository.add(employee1);
            EmployeeRepository.add(employee2);
            EmployeeRepository.add(employee3);
            EmployeeRepository.add(employee4);
            EmployeeRepository.add(employee5);
            EmployeeRepository.add(employee6);

        }

        // GETTERS
        public static Employee getById(int id)
        {
            return employees.Find(e => e.id == id);
        }

        internal static void delete(object id)
        {
            throw new NotImplementedException();
        }

        public static List<Employee> getAll()
        {
            return employees;
        }



        // MODIFIERS
        public static Employee add(Employee employee)
        {
            employee.id = ++employeeId;
            employees.Add(employee);
            return employee;
        }

        public static Boolean update(int id, Employee employee)
        {
            if(id != employee.id)
            {
                return false;
            }

            try
            {
                int position = employees.FindIndex(i => i.id == employee.id);
                employees[position] = employee;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static Boolean delete(int id)
        {
            try
            {
                Employee employee = employees.Find(e => e.id == id);

                if (employee != null)
                {
                    employees.Remove(employee);
                    return true;
                }
            }
            catch (ArgumentNullException e)
            {
                return false;
            }
            return false;
        }
    }
}
