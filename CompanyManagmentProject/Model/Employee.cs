using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public class Employee
    {
        private static int employeeId = 0;

        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String position { get; set; }
        public Double salary { get; set; }
        public DateTime date { get; set; }
        public Boolean fired { get; set; }

        public Employee() {
            this.id = ++employeeId;
        }
        public Employee(String firstName, String lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
