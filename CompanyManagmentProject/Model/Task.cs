﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagmentProject.Model
{
    public class Task
    {
        private static int taskId = 0; 

        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Boolean finished { get; set; }
        
        public int employeeId { get; set; }
        public Employee employee { get; set; }

        public Task()
        {
            this.id = ++taskId;
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
