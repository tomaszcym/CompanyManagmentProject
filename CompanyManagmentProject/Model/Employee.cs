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

        public Employee() {
            this.dateHired = DateTime.Now;
        }

        public Employee(String firstName, String lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Boolean isFired()
        {
            return this.fired;
        }
    }
}
