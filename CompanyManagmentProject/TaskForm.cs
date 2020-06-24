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
        public TaskForm (Form1 form)
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
            this.Text = task.id + " " + task.name + " " + task.startDate;

            this.taskEmployeeSelect.Text = task.name;
            this.taskPhoneNumber.Text = task.phone;
            this.taskToDo.Text = task.name;
            this.taskIsEnd.Checked = task.isFinished();

            //this.taskDateTimePickerStart.Format = DateTimePickerFormat.Custom;
            //this.taskDateTimePickerStart.CustomFormat = "dd-mm-yyyy HH:mm";
            //this.taskDateTimePickerStart.Value = task.startDate;

            //this.taskDataTimePickerEnd.Format = DateTimePickerFormat.Custom;
            //this.taskDataTimePickerEnd.CustomFormat = "dd-mm-yyyy HH:mm";
            //this.taskDataTimePickerEnd.Value = task.endDate;

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
