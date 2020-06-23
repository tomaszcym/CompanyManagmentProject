using CompanyManagmentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
