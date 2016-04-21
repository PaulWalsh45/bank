using System;
using System.Windows.Forms;
using BIZ;
using DAL;

namespace DBSBank
{
    public partial class EditAccountForm : Form
    {
                
        public EditAccountForm(int accountId)
        {
            CurrentAccount acc = new CurrentAccount();
            InitializeComponent();
            txtAccId.Text = accountId.ToString();//
            EditExistingAccount exa = new EditExistingAccount();
            acc = exa.RetrieveAccount(accountId);

            txtFName.Text = acc.FirstName;
            txtSurname.Text = acc.Surname;
            txtEmail.Text = acc.Email;
            txtPhone.Text = acc.Phone;
            txtAddress1.Text = acc.AddressLine1;
            txtAddress2.Text = acc.AddressLine2;
            txtCity.Text = acc.City;
            cbxCounty.Text = acc.Country;
            cbxAccountType.Text = acc.AccountType;
            txtAccountNumber.Text = acc.AccountNumber.ToString();
            txtSortCode.Text = "101010";
            txtOpeningBalance.Text = acc.InitialBalance.ToString();
            txtOverdraftLimit.Text = acc.OverdraftLimit.ToString();

            //dis-enable the overdraft textbox for a savings account
            if (cbxAccountType.Text == "Savings")
            {
                txtOverdraftLimit.Enabled = false;
            }
            else
            {
                txtOverdraftLimit.Enabled = true;
            }            
        }
        private void txtAccId_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txtAccId.Text);                      
        }
        //update the account
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditData ed = InstantiateDataAccessObject();
            ParseFormDataAndUpdateDataAccessObject(ed);
            ShowSuccessMessageAndCloseForm();
            OpenAndRefreshAccountsForm();
        }

        private static void OpenAndRefreshAccountsForm()
        {
            new AccountsFormLoader().LoadForm();
        }

        private void ShowSuccessMessageAndCloseForm()
        {
            MessageBox.Show("Account Updated");
            this.Close();
        }

        private void ParseFormDataAndUpdateDataAccessObject(EditData ed)
        {
            var id = new AccountId(int.Parse(txtAccId.Text));
            var email = new DAL.Email(txtEmail.Text);
            var phone = new Phone(txtPhone.Text);
            var add1 = txtAddress1.Text;
            var add2 = txtAddress2.Text;
            var cty = txtCity.Text;
            var ctry = cbxCounty.Text;

            var details = new EditAccountDetails(id, email, phone, add1, add2, cty, ctry);
            ed.UpdateAccount(details);
        }

        private static EditData InstantiateDataAccessObject()
        {
            EditData ed = new EditData();
            return ed;
        }
    }
}
