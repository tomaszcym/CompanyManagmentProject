using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Repo
{
    public class EmployeeRepository
    {
        public List<Employee> employees { get; } = new List<Employee>();


        // GETTERS
        public Employee getById(int id)
        {
            return this.employees.Find(e => e.id == id);
        }

        public List<Employee> getAll()
        {
            return this.employees;
        }



        // MODIFIERS
        public void add(Employee employee)
        {
            this.employees.Add(employee);
        }

        public Boolean update(int id, Employee employee)
        {
            if(id != employee.id)
            {
                return false;
            }

            try
            {
                int position = this.employees.FindIndex(i => i.id == employee.id);
                this.employees[position] = employee;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public Boolean delete(int id)
        {
            int position = -1;
            try
            {
                position = this.employees.FindIndex(i => i.id == id);
            }
            catch(ArgumentNullException e)
            {
                return false;
            }

            if(position > -1)
            {
                this.employees.RemoveAt(position);
                return true;
            }
            return false;
        }
    }
}
