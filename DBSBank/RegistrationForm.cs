using System;
using System.Windows.Forms;
using DAL;


namespace DBSBank
{
        
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }



        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = new Subscriber(txtUser.Text, txtPass.Text, txtFullName.Text);


            AddData ad = new AddData();//instantiate the AddData class
            ad.AddUser(subscriber);//call AddUser Method passing in values from 3 textboxes
            MessageBox.Show("Registration Successful");
            this.Close();
        }
    }
}
