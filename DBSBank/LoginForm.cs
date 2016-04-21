using System;
using System.Windows.Forms;
using BIZ;

namespace DBSBank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            Login l = new Login(user, pass);

            string status = l.CheckUserPass();
            if (status == "no")
            {
                MessageBox.Show("Login Failure");
            }
            else
            {
                MessageBox.Show("Login Successful");              
                //show the Accounts form
                AccountsListForm ac = new AccountsListForm();
                ac.AddUserToLabel(status);//Add logged in users name to label on top of Accounts Form
                ac.ShowDialog();
                txtUser.Clear();
                txtPass.Clear();
                        
            }
        }
       

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            Login l = new Login(user, pass);

            string status = l.CheckUserPass();
            if (status == "no")
            {
                MessageBox.Show("Login Failure");
            }
            else
            {
                MessageBox.Show("Login Successful");
                //show the Accounts form
                AccountsListForm ac = new AccountsListForm();
                ac.AddUserToLabel(status);//Add logged in users name to label on top of Accounts Form
                ac.ShowDialog();
                txtUser.Clear();
                txtPass.Clear();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm r = new RegistrationForm();
            r.ShowDialog();
        }
    }
}
