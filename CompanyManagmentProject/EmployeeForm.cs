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
    public partial class EmployeeForm : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        /// <summary>
        /// Edytowany pracownik w formularzu
        /// </summary>
        private Employee employee;

        /// <summary>
        /// Nadrzędny formularz (rodzic)
        /// </summary>
        private MainForm formParent;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="form">Formularz nadrzędny (rodzic)</param>
        public EmployeeForm(MainForm form)
        {
            InitializeComponent();
            this.formParent = form;
            this.employee = new Employee();
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="form">Formularz nadrzędny (rodzic)</param>
        /// <param name="employee">
        /// Model pracownika (w celu wyświetlenia bądź aktualizacji)
        /// null - w przypadku dodania nowego pracownika
        /// </param>
        public EmployeeForm(MainForm form, Employee employee = null) : this(form)
        {
            if(employee != null)
            {
                initEmployee(employee);
            }
        }

        /// <summary>
        /// Uzupełnienie kontrolek danymi
        /// Puste jeśli employee to null
        /// </summary>
        /// <param name="employee">Model przekazanego pracownika w konstruktorze</param>
        private void initEmployee(Employee employee)
        {
            this.employee = employee;
            this.Text = employee.firstName + " " + employee.lastName;

            this.employeeFirstName.Text = employee.firstName;
            this.employeeLastName.Text = employee.lastName;
            this.employeeEmail.Text = employee.email;
            this.employeePhoneNumber.Text = employee.phone;
            this.employeePosition.Text = employee.position;
            this.employeeSalary.Text = employee.salary.ToString();

            this.employeeDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.employeeDateTimePicker.CustomFormat = "dd-mm-yyyy HH:mm";
            this.employeeDateTimePicker.Value = employee.dateHired;

            this.employeeIsFired.Checked = employee.isFired();
        }

        /// <summary>
        /// Dodawanie nowego pracownika z walidacją pól
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Akrumenty zdarzenia</param>
        private void employeeSave_Click(object sender, EventArgs e)
        {

            if (this.employeeFirstName.TextLength <= 4 || this.employeeLastName.TextLength <= 4  || this.employeePosition.TextLength <= 5 || this.employeePhoneNumber.TextLength <= 8 || this.employeeEmail.Text.Contains("@") != true)
            {
                if (this.employeeFirstName.TextLength <= 4)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Imię pracownika' minimalna długość to 5 znaków! ");
                }
                else if (this.employeeLastName.TextLength <= 4)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Nazwisko pracownika' minimalna długość to 5 znaków! ");
                }
                else if (this.employeePosition.TextLength <= 5)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Stanowisko' minimalna długość to 6 znaków! ");
                }
                else if (this.employeePhoneNumber.TextLength <= 8)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Numer telefonu' minimalna długość to 9 znaków! ");
                }
                else if (this.employeeEmail.Text.Contains("@") != true)
                {
                    MessageBox.Show("Prosze uzupełnij poprawnie 'Email' powinien zawierać znak '@' !");
                }
                return;
            }

            Employee empToSave = this.employee;

            empToSave.firstName = this.employeeFirstName.Text;
            empToSave.lastName = this.employeeLastName.Text;
            empToSave.email = this.employeeEmail.Text;
            empToSave.phone = this.employeePhoneNumber.Text;
            empToSave.position = this.employeePosition.Text;
            empToSave.dateHired = this.employeeDateTimePicker.Value;

            double salary;
            if(!double.TryParse(this.employeeSalary.Text, out salary))
                salary = 0.0;

            empToSave.salary = salary;
            empToSave.fired = this.employeeIsFired.Checked;



            if(this.employee.id != 0)
                EmployeeRepository.update(this.employee.id, empToSave);
            else
                EmployeeRepository.add(empToSave);


            this.formParent.renderEmployeesTab();
            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        /// <summary>
        /// Usuwanie pracownika
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Akrumenty zdarzenia</param>
        private void employeeDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Czy na pewno chcesz usunąć tego pracownika? \nZmiana jest nieodwracalna!", "Usuwanie pracownika: " + employee.firstName + " " + employee.lastName, MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                EmployeeRepository.delete(this.employee.id);

                this.formParent.renderEmployeesTab();
                this.Close();
            }
        }


    }
}
