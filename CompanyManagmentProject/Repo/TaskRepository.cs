using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyManagmentProject.Repo
{
    public static class TaskRepository
    {
        public static List<Task> tasks { get; } = new List<Task>();


        // GETTERS
        public static Task getById(int id)
        {
            Task task = null;
            try
            {
                task = tasks.Find(e => e.id == id);
            }
            catch(ArgumentNullException e)
            {
                return null;
            }

            if (task != null)
            {
                task.employee = EmployeeRepository.getById(task.id);
                return tasks.Find(e => e.id == id);
            }
            return null;
        }

        public static List<Task> getAll()
        {
            return tasks;
        }


        // MODIFIERS
        public static void add(Task employee)
        {
            tasks.Add(employee);
        }

        public static Boolean update(int id, Task employee)
        {
            if (id != employee.id)
            {
                return false;
            }

            try
            {
                int position = tasks.FindIndex(i => i.id == employee.id);
                tasks[position] = employee;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Boolean delete(int id)
        {
            int position = -1;
            try
            {
                position = tasks.FindIndex(i => i.id == id);
            }
            catch (ArgumentNullException e)
            {
                return false;
            }

            if (position > -1)
            {
                tasks.RemoveAt(position);
                return true;
            }
            return false;
        }

    }
}
