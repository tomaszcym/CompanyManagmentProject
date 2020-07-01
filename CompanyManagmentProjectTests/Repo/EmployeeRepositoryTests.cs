using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyManagmentProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagmentProject.Model;

namespace CompanyManagmentProject.Repo.Tests
{
    [TestClass()]
    public class EmployeeRepositoryTests
    {
        private Employee createEmployee(string firstname, string lastname)
        {
            Employee employee = new Employee(firstname, lastname);
            return EmployeeRepository.add(employee);
           
        }
        [TestMethod()]
        public void updateTest()
        {
            Employee employee = createEmployee("Jacek", "Placek");
            employee.lastName = "Ciastko";
            EmployeeRepository.update(employee.id, employee);
            Employee updateEmployee = EmployeeRepository.getById(employee.id);
            Assert.AreNotEqual("Placek", updateEmployee.lastName);
        }
    }
}