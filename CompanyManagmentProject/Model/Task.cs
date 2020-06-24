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
        public String phone { get; set; }
        public String description { get; set; }
        public DateTime ?startDate { get; set; }
        public DateTime ?endDate { get; set; }
        public Boolean finished { get; set; }

        public int? employeeId { get; set; } = 0;
        public Employee employee { get; set; } = null;

        public Task()
        {
        }

        public Task(String name) : this()
        {
            this.name = name;
        }


        public Boolean isFinished()
        {
            return this.finished;
        }
    }
}
