﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyManagmentProject.Model;
using CompanyManagmentProject.Repo;

namespace CompanyManagmentProject
{
    public partial class TaskForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        private Model.Task task;
        private MainForm formParent;
        
        /// <summary>
        /// Konstruktor TaskFrom
        /// </summary>
        /// <param name="form"></param>
        public TaskForm(MainForm form)
        {
            InitializeComponent();
            this.formParent = form;
            fillSelect();

            if (Program.currentUser.role == Role.USER)
            {
                this.taskDelete.Hide();
                this.taskSave.Hide();
            }
        }
        /// <summary>
        /// Konstruktor TaskForm 
        /// </summary>
        /// <param name="form"></param>
        /// <param name="task"></param>
        public TaskForm(MainForm form, Model.Task task = null) : this(form)
        {
            if (task != null)
            {
                initTask(task);
            }
            else
            {
                this.task = new Model.Task();
            }
            fillSelect();
        }
        /// <summary>
        /// Inicjlalizacja wszystkich zadań
        /// </summary>
        /// <param name="task"></param>
        private void initTask(Model.Task task)
        {
            this.task = task;
            this.Text = task.id + " " + task.startDate + " " + task.startDate;

            this.taskName.Text = task.name ;
            this.taskDescription.Text = task.description;

            this.taskDateTimePickerStart.Format = DateTimePickerFormat.Custom;
            this.taskDateTimePickerStart.CustomFormat = "dd-mm-yyyy HH:mm";
            if(task.startDate != null)
                this.taskDateTimePickerStart.Value = (DateTime) task.startDate;

            this.taskDataTimePickerEnd.Format = DateTimePickerFormat.Custom;
            this.taskDataTimePickerEnd.CustomFormat = "dd-mm-yyyy HH:mm";
            if (task.endDate != null)
                this.taskDataTimePickerEnd.Value = (DateTime)task.endDate;

            this.taskFinished.Checked = task.isFinished();

        }
        /// <summary>
        /// Dodawanie nowego zadania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskSave_Click(object sender, EventArgs e)
        {
            Model.Task taskToSave = this.task;
            if (taskToSave == null)
                taskToSave = new Model.Task();

            MessageBox.Show(taskToSave.name);

            if (this.taskName.TextLength < 10 || this.taskDescription.TextLength < 10)
            { 
                if (this.taskName.TextLength <= 10)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Zadanie' minimalna długość to 10 znaków! ");
                }else if(this.taskDescription.TextLength <= 4)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Opis zadania' minimalna długość to 10 znaków! ");
                }              
                return;
            }

            EmployeeSelectItem selectedEmployee = this.taskEmployeeSelect.SelectedItem as EmployeeSelectItem;

            taskToSave.name = this.taskName.Text;
            taskToSave.description = this.taskDescription.Text;
            taskToSave.startDate = this.taskDateTimePickerStart.Value;
            taskToSave.endDate = this.taskDataTimePickerEnd.Value;
            taskToSave.finished = this.taskFinished.Checked;

            if(selectedEmployee != null)
                taskToSave.employeeId = selectedEmployee.id;


            if (this.task != null && this.task.id != 0)
                Repo.TaskRepository.update(this.task.id, taskToSave);
            else
                Repo.TaskRepository.add(taskToSave);

            this.formParent.renderTasksTab();
            this.Close();
        }
        /// <summary>
        /// Wypełnienia selecta danymi 
        /// </summary>
        private void fillSelect()
        {
            List<Employee> employees = EmployeeRepository.getAll();

            this.taskEmployeeSelect.Items.Clear();
            employees.ForEach(e =>
            {
                EmployeeSelectItem item = new EmployeeSelectItem(e.id, e.firstName + " " + e.lastName);
                this.taskEmployeeSelect.Items.Add(item);
                if (this.task != null && e.id == this.task.employeeId)
                {
                    this.taskEmployeeSelect.SelectedItem = item;
                }
            });
        }
        /// <summary>
        /// Zamykanie aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Usuwanie wybranego zadania na podstawie ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Czy na pewno chcesz usunąć to zadanie?",
                "Potwierdź działanie.", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                TaskRepository.delete(this.task.id);

                this.formParent.renderTasksTab();
                this.Close();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }


    class EmployeeSelectItem
    {
        public int id { get; set; }
        public String name { get; set; }

        /// <summary>
        /// Konstruktor klasy EmployeeSelectItem
        /// Ustawia id i nazwę 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public EmployeeSelectItem(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public override String ToString()
        {
            return this.name;
        }
    }



}
