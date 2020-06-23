using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Repo
{
    public static class EmployeeRepository
    {
        public static List<Employee> employees { get; set;  }


        public static void init()
        {
            employees = new List<Employee> {
                new Employee("Tomek", "Cymerys"),
                new Employee("Arek", "Wójcik"),
                new Employee("Mariusz", "Kardaś"),
                new Employee("Marian", "Kowalski"),
                new Employee("Jan", "Nowak"),
            };
        }

        // GETTERS
        public static Employee getById(int id)
        {
            return employees.Find(e => e.id == id);
        }

        public static List<Employee> getAll()
        {
            return employees;
        }



        // MODIFIERS
        public static void add(Employee employee)
        {
            employees.Add(employee);
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
            int position = -1;
            try
            {
                position = employees.FindIndex(i => i.id == id);
            }
            catch(ArgumentNullException e)
            {
                return false;
            }

            if(position > -1)
            {
                employees.RemoveAt(position);
                return true;
            }
            return false;
        }
    }
}
