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
    public partial class Auth : Form
    {
        private Form1 formParent;

        public Auth()
        {
            InitializeComponent();
            //this.formParent = form;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            User user = UserRepository.authorizeUser(username, password);
            if(user != null)
            {
                Program.currentUser = user;

                //MessageBox.Show(user.password);

                Form1 form = new Form1();
                //form.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Błędne hasło lub login!");
            }
        }
    }
}
