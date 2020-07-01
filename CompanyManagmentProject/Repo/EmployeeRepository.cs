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
            EmployeeRepository.add(new Employee("Tomek", "Cymerys"));
            EmployeeRepository.add(new Employee("Arek", "Wójcik"));
            EmployeeRepository.add(new Employee("Mariusz", "Kardaś"));
            EmployeeRepository.add(new Employee("Marian", "Kowalski"));
            EmployeeRepository.add(new Employee("Jan", "Nowak"));
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
