using CompanyManagmentProject.Model;
using CompanyManagmentProject.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagmentProject
{
    public partial class AuthForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private MainForm formParent;

        public AuthForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 10;
            username.MaxLength = 12;
            //this.formParent = form;
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            User user = UserRepository.authorizeUser(username, password);
            if (user != null)
            {
                Program.currentUser = user;

                MainForm form = new MainForm();
                form.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Błędne hasło lub login!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void Auth_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Auth_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Auth_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }






        //protected override void OnFormClosed(FormClosedEventArgs e)
        //{
        //    base.OnFormClosed(e);
        //    Application.Exit();
        //}
    }
}
