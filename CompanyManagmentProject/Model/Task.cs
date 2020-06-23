using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public class Task
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime date { get; set; }
        public Boolean finished { get; set; }
        
        public int employeeId { get; set; }
        public Employee employee { get; set; }
    }
}
