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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // zainicjowanie repozytoriow
            EmployeeRepository.init();
            TaskRepository.init();

            renderDashboardTab();
        }

        private void newEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(this);
            employeeForm.Show();
        }

        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch(e.TabPage.Name.ToString())
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
                    //
                    break;
            }
        }

        private void renderDashboardTab()
        {
            overviewCompanyName.Text = CompanyDetails.name;
            overviewCounterEmployee.Text = EmployeeRepository.getAll().Count().ToString();
            overviewTime.Text = DateTime.Now.ToString();
        }

        private void renderCompanyDetailsTab()
        {
            companyName.Text = CompanyDetails.name;
            companyNIP.Text = CompanyDetails.nip;
            companyAddress.Text = CompanyDetails.address;
            companyCity.Text = CompanyDetails.city;
            companyPostcode.Text = CompanyDetails.postcode;
            companyCountry.Text = CompanyDetails.country;
        }

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
                ListViewItem item = new ListViewItem(row);
                employeeListView.Items.Add(item);
            });
        }

        private void employeeListView_Click(object sender, EventArgs e)
        {
            var selected = employeeListView.SelectedItems[0].SubItems[0];
            int id = int.Parse(selected.Text);

            Employee employee = EmployeeRepository.getById(id);

            EmployeeForm employeeForm = new EmployeeForm(this, employee);
            employeeForm.Show(this);
        }

        private void companyDetailsSaveButton_Click(object sender, EventArgs e)
        {
            CompanyDetails.name = companyName.Text;
            CompanyDetails.nip = companyNIP.Text;
            CompanyDetails.address = companyAddress.Text;
            CompanyDetails.city = companyCity.Text;
            CompanyDetails.postcode = companyPostcode.Text;
            CompanyDetails.country = companyCountry.Text;
        }
    }
}
