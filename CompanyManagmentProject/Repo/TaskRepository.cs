using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompanyManagmentProject.Repo
{
    public static class TaskRepository
    {
        public static List<Task> tasks { get; set; } = new List<Task>();
        private static int taskId = 0;


        public static void init()
        {
            TaskRepository.add(new Task("Transport Nestle Rzeszów - Nestle Kraków"));
            TaskRepository.add(new Task("Transport beczek x881 do Oslo"));
            TaskRepository.add(new Task("Serwis samochodu"));
            TaskRepository.add(new Task("Odstawienie samochodu"));
        }


        // GETTERS
        public static Task getById(int id)
        {
            Task task = null;
            try
            {
                task = tasks.Find(e => e.id == id);
                if (task != null && task.employeeId != 0)
                {
                    task.employee = EmployeeRepository.getById((int)task.employeeId);
                }
            }
            catch(ArgumentNullException e)
            {
                return null;
            }
            return task;
        }

        public static List<Task> getAll()
        {
            return tasks;
        }

        public static List<Task> getByFinished(bool finished)
        {
            return tasks.FindAll(t => t.finished == finished);
        }


        // MODIFIERS
        public static void add(Task task)
        {
            task.id = ++taskId;
            tasks.Add(task);
        }

        public static Boolean update(int id, Task task)
        {
            if (id != task.id)
            {
                return false;
            }

            try
            {
                int position = tasks.FindIndex(i => i.id == task.id);
                tasks[position] = task;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Boolean delete(int id)
        {
            try
            {
                Task task = tasks.SingleOrDefault(t => t.id == id);
       
                if (task != null)
                {
                    tasks.Remove(task);
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
