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
using CompanyManagmentProject.Repo;

namespace CompanyManagmentProject
{
    public partial class TaskForm : Form
    {
        private Model.Task task;
        private Form1 formParent;
        
        public TaskForm(Form1 form)
        {
            InitializeComponent();
            this.formParent = form;
            this.task = new Model.Task();

            fillSelect();
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

        private void taskSave_Click(object sender, EventArgs e)
        {
            Model.Task taskToSave = this.task;

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

            if (this.task.id != 0)
                Repo.TaskRepository.update(this.task.id, taskToSave);
            else
                Repo.TaskRepository.add(taskToSave);

            this.formParent.renderTasksTab();
            this.Close();
        }

        private void fillSelect()
        {
            List<Employee> employees = EmployeeRepository.getAll();

           
            employees.ForEach(e =>
            {
                EmployeeSelectItem item = new EmployeeSelectItem(e.id, e.firstName + " " + e.lastName);
                this.taskEmployeeSelect.Items.Add(item);
            });
        }

        private void taskExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

    }


    class EmployeeSelectItem
    {
        public int id { get; set; }
        public String name { get; set; }

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
