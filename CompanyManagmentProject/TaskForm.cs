using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyManagmentProject.Model;

namespace CompanyManagmentProject
{
    public partial class TaskForm : Form
    {
        private Model.Task task;
        private Form1 formParent;

        public TaskForm()
        {
            InitializeComponent();

        }
        public TaskForm(Form1 form)
        {
            InitializeComponent();
            this.formParent = form;
            this.task = new Model.Task();
        }
        public TaskForm(Form1 form, Model.Task task = null) : this(form)
        {
            if (task != null)
            {
                initTask(task);
            }
        }
        private void initTask(Model.Task task)
        {
            this.task = task;
            this.Text = task.id + " " + task.startDate + " " + task.startDate;

            this.taskEmployeeSelect.Text = ":dupa" ;
            this.taskPhoneNumber.Text = task.phone;
            this.taskToDo.Text = task.name;

            this.taskDateTimePickerStart.Format = DateTimePickerFormat.Custom;
            //this.taskDateTimePickerStart.CustomFormat = "dd-mm-yyyy HH:mm";
            //this.taskDateTimePickerStart.Value = task.startDate;

            //this.taskDataTimePickerEnd.Format = DateTimePickerFormat.Custom;
            //this.taskDataTimePickerEnd.CustomFormat = "dd-mm-yyyy HH:mm";
            //this.taskDataTimePickerEnd.Value = task.endDate;

        }

        private void taskSave_Click(object sender, EventArgs e)
        {
            Model.Task taskToSave = this.task;

            taskToSave.name = this.taskName.Text;
            taskToSave.description = this.taskPhoneNumber.Text;
            taskToSave.startDate = this.taskDateTimePickerStart.Value;
            taskToSave.endDate = this.taskDataTimePickerEnd.Value;
            if (this.task.id != 0)
                Repo.TaskRepository.update(this.task.id, taskToSave);
            else
                Repo.TaskRepository.add(taskToSave);

            this.formParent.renderTasksTab();
            this.Close();
        }


        }
    }
