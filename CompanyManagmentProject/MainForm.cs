using CompanyManagmentProject.Model;
using CompanyManagmentProject.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CompanyManagmentProject
{
    public partial class MainForm : Form
    {
        //public User currentUser = null;


        /// <summary>
        /// Glowne okno aplikacji
        /// Wyswietla zawartosci w zaleznosci od roli uzytkownika
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            renderDashboardTab();

            if (Program.currentUser.role == Role.USER)
            {
                foreach (TabPage tabPage in this.mainTabControl.TabPages)
                {
                    switch(tabPage.Name)
                    {
                        case "employees":
                        case "companyDetails":
                            this.mainTabControl.TabPages.Remove(tabPage);
                            break;
                    }
                }

                Employee employee = EmployeeRepository.getByUserId(Program.currentUser.id);
                if(employee != null)
                {
                    this.currentUserNameLabel.Text = employee.firstName + "!";
                }
                else
                {
                    this.currentUserLabel.Hide();
                    this.currentUserNameLabel.Hide();
                }
            }
            else
            {
                this.currentUserLabel.Hide();
                this.currentUserNameLabel.Hide();
            }

            this.Text = this.Text + " | " + Program.currentUser.username;

            updateCompanyOverview();
        }

        /// <summary>
        /// Przy zamknieciu okna zamyka watek aplikacji w systemie
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }


        /// <summary>
        /// Obsluguje przycisk nowego uzytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(this);
            employeeForm.Show();
        }


        /// <summary>
        /// Obsluguje zdarzenie wyboru karty
        /// Uruchamia metode w zaleznosci od kliknietej karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name.ToString())
            {
                case "dashboard":
                    renderDashboardTab();
                    break;
                case "companyDetails":
                    renderCompanyDetailsTab();
                    break;
                case "employees":
                    renderEmployeesTab();
                    break;
                case "tasks":
                    renderTasksTab();
                    break;
            }
        }


        /// <summary>
        /// Renderuje zawartosc karty
        /// </summary>
        private void renderDashboardTab()
        {
            List<Model.Task> finished = TaskRepository.getByFinished(true);
            List<Model.Task> unfinished = TaskRepository.getByFinished(false);

            if (Program.currentUser.role == Role.ADMIN)
            {
                overviewCounterActiveTask.Text = unfinished.Count().ToString();
                overviewCounterFinishTask.Text = finished.Count().ToString();
                overviewCounterEmployee.Text = EmployeeRepository.getAll().Count().ToString();
            }
            else
            {
                this.activeTaskLabel.Text = "Twoje zadania:";
                this.finishedTasksLabel.Text = "Twoje ukończone zadania: ";

                Employee employee = EmployeeRepository.getByUserId(Program.currentUser.id);
                string unfinishedTasks = "-";
                string finishedTasks = "-";
                if (employee != null)
                {
                    finishedTasks = finished.FindAll(t => t.employeeId == employee.id).Count().ToString();
                    unfinishedTasks= unfinished.FindAll(t => t.employeeId == employee.id).Count().ToString();
                }
                overviewCounterActiveTask.Text = unfinishedTasks;
                overviewCounterFinishTask.Text = finishedTasks;

                this.employeeCountLabel.Hide();
                this.overviewCounterEmployee.Hide();
            }
        }

        /// <summary>
        /// Renderuje zawartosc karty
        /// </summary>
        private void renderCompanyDetailsTab()
        {
            companyName.Text = CompanyDetails.name;
            companyNIP.Text = CompanyDetails.nip;
            companyAddress.Text = CompanyDetails.address;
            companyCity.Text = CompanyDetails.city;
            companyPostcode.Text = CompanyDetails.postcode;
            companyCountry.Text = CompanyDetails.country;
        }

        /// <summary>
        /// Renderuje zawartosc karty
        /// </summary>
        public void renderEmployeesTab()
        {
            List<Employee> employees = EmployeeRepository.getAll();

            employeeListView.Clear();
            employeeListView.View = View.Details;
            employeeListView.FullRowSelect = true;

            employeeListView.Columns.Add("Id");
            employeeListView.Columns.Add("Imię");
            employeeListView.Columns.Add("Nazwisko");
            employeeListView.Columns.Add("Email");
            employeeListView.Columns.Add("Numer telefonu");
            employeeListView.Columns.Add("Stanowisko");
            employeeListView.Columns.Add("Pensja");
            employeeListView.Columns.Add("Zatrudniony (data)");
            employeeListView.Columns.Add("Zwolniony");

            employees.ForEach(e => {
                string[] row = {
                    e.id.ToString(),
                    e.firstName,
                    e.lastName,
                    e.email,
                    e.phone,
                    e.position,
                    e.salary.ToString(),
                    e.dateHired.ToString(),
                    e.isFired() ? "Tak" : "Nie",
                };
                employeeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                employeeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListViewItem item = new ListViewItem(row);

                employeeListView.Items.Add(item);

            });
        }


        /// <summary>
        /// Obsluguje klikniecie danego pracownika na liscie
        /// Otwiera formularz z wybranym pracownikiem
        /// </summary>
        private void employeeListView_Click(object sender, EventArgs e)
        {
            var selected = employeeListView.SelectedItems[0].SubItems[0];
            int id = int.Parse(selected.Text);

            Employee employee = EmployeeRepository.getById(id);

            EmployeeForm employeeForm = new EmployeeForm(this, employee);
            employeeForm.Show(this);
        }


        /// <summary>
        /// Renderuje zawartosc karty
        /// </summary>
        public void renderTasksTab()
        {
            List<Model.Task> tasks = null;

            if (Program.currentUser.role == Role.USER)
            {
                Employee employee = EmployeeRepository.getByUserId(Program.currentUser.id);
                
                this.newTaskButton.Hide();

                if (employee != null)
                    tasks = TaskRepository.getAllByEmployee(employee.id);
                else
                {
                    MessageBox.Show("Nie masz żadnych prac!");
                    return;
                }
            }
            else
                tasks = TaskRepository.getAll();


            taskListView.Clear();
            taskListView.View = View.Details;
            taskListView.FullRowSelect = true;

            taskListView.Columns.Add("Id");
            taskListView.Columns.Add("Imię");
            taskListView.Columns.Add("Nazwisko");
            taskListView.Columns.Add("Zadanie");
            taskListView.Columns.Add("Data rozpoczęcia");
            taskListView.Columns.Add("Data zakończenia");
            taskListView.Columns.Add("Zakończone");

            tasks.ForEach(t => {
                
                Employee employee = EmployeeRepository.getById((int)t.employeeId);

                string firstName = employee != null ? employee.firstName : "";
                string lastName = employee != null ? employee.lastName : "";
                string phone = employee != null ? employee.phone : "";

                string[] row = {
                    t.id.ToString(),
                    firstName,
                    lastName,
                    t.name,
                    t.startDate.ToString(),
                    t.endDate.ToString(),
                    t.isFinished() ? "Tak" : "Nie",
                };
                ListViewItem item = new ListViewItem(row);
                taskListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                taskListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                taskListView.Items.Add(item);

            });
        }



        /// <summary>
        /// Obsluguje przycisk zapisu
        /// Zapisuje dane firmy
        /// Odswieza dane w oknie
        /// </summary>
        private void companyDetailsSaveButton_Click(object sender, EventArgs e)
        {
            CompanyDetails.name = companyName.Text;
            CompanyDetails.nip = companyNIP.Text;
            CompanyDetails.address = companyAddress.Text;
            CompanyDetails.city = companyCity.Text;
            CompanyDetails.postcode = companyPostcode.Text;
            CompanyDetails.country = companyCountry.Text;
            //msg m = new msg();
            //m.Show();

            updateCompanyOverview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Obsluguje przycisk nowego zadania
        /// Otwiera pusty formularz zadania
        /// </summary>
        private void newTaskButton_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(this);
            taskForm.Show();
        }


        /// <summary>
        /// Obsluguje klikniecie danego zadania na liscie
        /// Otwiera formularz z wybranym zadaniem
        /// </summary>
        private void taskListView_Click(object sender, EventArgs e)
        {
            var selected = taskListView.SelectedItems[0].SubItems[0];
            int id = int.Parse(selected.Text);

            Model.Task task = TaskRepository.getById(id);

            TaskForm taskForm = new TaskForm(this, task);
            taskForm.Show(this);
        }


        /// <summary>
        /// Odswieza dane firmy w oknie
        /// </summary>
        public void updateCompanyOverview()
        {
            overviewCompanyName.Text = CompanyDetails.name;
            overviewCompanyAddres.Text = CompanyDetails.address;
            overviewCompanyCity.Text = CompanyDetails.city;
            overviewCompanyPostcode.Text = CompanyDetails.postcode;
            overviewCompanyDetails.Text = CompanyDetails.country;
            overviewCompanyNIP.Text = CompanyDetails.nip;
        }
    }
}
