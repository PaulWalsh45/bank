using System;
using System.Windows.Forms;
using DAL;
using BIZ;

namespace DBSBank
{
    public partial class AddNewAccountForm : Form
    {
        public AddNewAccountForm()
        {
            InitializeComponent();
            //**** tooltip for phone number format *****
            ToolTip phoneFormat = new ToolTip();
            phoneFormat.SetToolTip(txtPhone, "XXX-XXXXXXX");
            //*******************************************
           

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddData ad = InstantiateDataAccessObject();

            if (cbxAccountType.SelectedIndex == 1)//savings account - no o/draft
                ParseFormDataAndAddNewSavingsAccount(ad);
            else
                ParseFormDataAndAddNewCurrentAccount(ad);

        }

        private void ParseFormDataAndAddNewCurrentAccount(AddData ad)
        {
            
            AddAccountDetails addNewCurrentAccount = new AddAccountDetails();
            //Account addAcc = new CurrentAccount();
            addNewCurrentAccount.FirstName = txtFName.Text;
            addNewCurrentAccount.Surname = txtSurname.Text;
            //Email email = new Email(txtEmail.Text);
            addNewCurrentAccount.Email = new Email(txtEmail.Text); 
            //Phone phone = new Phone(txtPhone.Text);
            addNewCurrentAccount.Phone = new Phone(txtPhone.Text);
            addNewCurrentAccount.AddressLine1 = txtAddress1.Text;
            addNewCurrentAccount.AddressLine2 = txtAddress2.Text;
            addNewCurrentAccount.City = txtCity.Text;
            addNewCurrentAccount.Country = cbxCounty.Items[cbxCounty.SelectedIndex].ToString();
            addNewCurrentAccount.AccountType = cbxAccountType.Items[cbxAccountType.SelectedIndex].ToString();
            //AccountNumber accNo = new AccountNumber(txtAccountNumber.Text);
            addNewCurrentAccount.AccountNumber = new AccountNumber(txtAccountNumber.Text);
            addNewCurrentAccount.SortCode = txtSortCode.Text;
            addNewCurrentAccount.OpeningBalance = decimal.Parse(txtOpeningBalance.Text);
            addNewCurrentAccount.Overdraft = decimal.Parse(txtOverdraftLimit.Text);


            //check account number is 8 digits
            if (txtAccountNumber.Text.Length == 8)
            {
                ad.AddCurrentAccount(addNewCurrentAccount);
                CloseCon();
            }
            else
            {
                AccountNumberLengthErrorMessage();
            }
        }

        private void ParseFormDataAndAddNewSavingsAccount(AddData ad)
        {
            AddAccountDetails addNewSavingAccount = new AddAccountDetails();
            txtOverdraftLimit.Text = "0";
            addNewSavingAccount.FirstName = txtFName.Text;
            addNewSavingAccount.Surname = txtFName.Text;
            addNewSavingAccount.Email = new Email(txtEmail.Text);
            addNewSavingAccount.Phone = new Phone(txtPhone.Text);
            addNewSavingAccount.AddressLine1 = txtAddress1.Text;
            addNewSavingAccount.AddressLine2 = txtAddress2.Text;
            addNewSavingAccount.City = txtCity.Text;
            addNewSavingAccount.Country = cbxCounty.Items[cbxCounty.SelectedIndex].ToString();
            addNewSavingAccount.AccountType = cbxAccountType.Items[cbxAccountType.SelectedIndex].ToString();
            addNewSavingAccount.AccountNumber = new AccountNumber(txtAccountNumber.Text);
            addNewSavingAccount.SortCode = txtSortCode.Text;
            addNewSavingAccount.OpeningBalance = decimal.Parse(txtOpeningBalance.Text);
            addNewSavingAccount.Overdraft = decimal.Parse(txtOverdraftLimit.Text);

            //check account number is 8 digits
            if (txtAccountNumber.Text.Length == 8)
            {
                ad.AddSavingsAccount(addNewSavingAccount);
                CloseCon();
            }
            else
            {
                AccountNumberLengthErrorMessage();
            }
                
        }

        private void AccountNumberLengthErrorMessage()
        {
            MessageBox.Show(" FIRST ERROR MESSAGE Account number must be 8 digits");
            this.DialogResult = DialogResult.None;
            txtAccountNumber.Focus();
        }

        private static AddData InstantiateDataAccessObject()
        {
            AddData ad = new AddData();//instantiate the AddData class
            //var details = AddAccountDetails
            return ad;
        }  
        

            

        private void cbxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disable the overdraft textbox if savings account is selected
            if (cbxAccountType.SelectedIndex == 1)
            {
                txtOverdraftLimit.Enabled = false;
                txtOverdraftLimit.Text = "0";
            }
            else
            {
                txtOverdraftLimit.Enabled = true;
            }
        }

        public void CloseCon()
        {
            MessageBox.Show("New Account added to database");
            //this.Close();

            var form = new AccountsListForm();
            form.Show();
            form.RefreshDataGrid();



            //clear all fields
            txtFName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            cbxCounty.SelectedIndex = -1;
            cbxAccountType.SelectedIndex = -1;
            txtAccountNumber.Clear();
            //txtSortCode.Clear();
            txtOpeningBalance.Clear();
            txtOverdraftLimit.Clear();
        }
    }
}