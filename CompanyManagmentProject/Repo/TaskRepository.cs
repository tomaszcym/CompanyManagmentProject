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
            Task task5 = new Task("Raport z czerwca");
            task5.employeeId = 4;
            task5.startDate = new DateTime(2020, 7, 1, 15, 30, 00);
            task5.endDate = new DateTime(2020, 5, 20, 15, 30, 00);
            task5.finished = true;
            Task task6 = new Task("Wykopki w Jaśle");
            task6.employeeId = 5;
            task6.startDate = new DateTime(2020, 8, 11, 14, 30, 00);
            task6.endDate = new DateTime(2020, 5, 20, 15, 30, 00);
            task6.finished = true;
            Task task7 = new Task("Rozliczenie za 2019");
            task7.employeeId = 6;
            task7.startDate = new DateTime(2020, 1, 3, 14, 30, 00);
            task7.endDate = new DateTime(2020, 1, 5, 15, 30, 00);
            task7.finished = false;
            Task task8 = new Task("Przeporowadzenie szkolenia");
            task8.employeeId = 4;
            task8.startDate = new DateTime(2020, 5, 11, 12, 30, 00);
            task8.endDate = new DateTime(2020, 5, 10, 15, 30, 00);
            task8.finished = true;
            Task task9 = new Task("Kontora sprzętu");
            task9.employeeId = 5;
            task9.startDate = new DateTime(2020, 2, 11, 14, 30, 00);
            task9.endDate = new DateTime(2020, 2, 13, 15, 30, 00);
            task9.finished = false;
            Task task10 = new Task("Segregacja dokumentów");
            task10.employeeId = 6;
            task10.startDate = new DateTime(2020, 4, 12, 14, 30, 00);
            task10.endDate = new DateTime(2020, 4, 15, 15, 30, 00);
            task10.finished = true;



            TaskRepository.add(task1);
            TaskRepository.add(task2);
            TaskRepository.add(task3);
            TaskRepository.add(task4);
            TaskRepository.add(task5);
            TaskRepository.add(task6);
            TaskRepository.add(task7);
            TaskRepository.add(task8);
            TaskRepository.add(task9);
            TaskRepository.add(task10);

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

        public static List<Task> getAllByEmployee(int id)
        {
            return tasks.FindAll(t => t.employeeId == id);
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
