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
            Task task1 = new Task("Transport Nestle Rzeszów - Nestle Kraków");
            task1.employeeId = 1;
            task1.startDate = new DateTime(2020, 5, 20, 8, 00, 00);
            task1.endDate = new DateTime(2020, 5, 20, 14, 00, 00);
            task1.finished = true;
            Task task2 = new Task("Transport beczek x881 do Oslo");
            task2.employeeId = 2;
            task2.startDate = new DateTime(2020, 8, 10, 7, 00, 00);
            task2.endDate = new DateTime(2020, 8, 12, 10, 30, 00);
            task2.finished = false;
            Task task3 = new Task("Serwis samochodu - Audi A4");
            task3.employeeId = 1;
            task3.startDate = new DateTime(2020, 8, 11, 12, 15, 00);
            task3.endDate = new DateTime(2020, 8, 11, 14, 30, 00);
            task3.finished = false;
            Task task4 = new Task("Odstawienie samochodu - Audi A4");
            task4.employeeId = 3;
            task4.startDate = new DateTime(2020, 8, 11, 14, 30, 00);
            task4.endDate = new DateTime(2020, 5, 20, 15, 30, 00);
            task4.finished = false;

            TaskRepository.add(task1);
            TaskRepository.add(task2);
            TaskRepository.add(task3);
            TaskRepository.add(task4);
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
