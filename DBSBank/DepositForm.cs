using System;
using System.Windows.Forms;
using BIZ;
using DAL;

namespace DBSBank
{
    public partial class DepositForm : Form
    {
        public DepositForm(int id)
        {
            InitializeComponent();

            
            DepositFunds deposit = new DepositFunds();

            
            txtId.Text = id.ToString();
            
            deposit = deposit.GetAccountBalance(id);

            txtAccountNumber.Text = deposit.AccountNumber.ToString();
            txtBal.Text = deposit.Balance.ToString();


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal debit = decimal.Parse(txtDebAmount.Text);
            decimal principal = decimal.Parse(txtBal.Text);
            decimal updatedBalance = debit + principal;
            txtBal.Text = updatedBalance.ToString();

            //record transaction 
            AddData ad = new AddData();//to make transaction

            //gather deposit variables
            string type = "Deposit";
            decimal amount = decimal.Parse(txtDebAmount.Text);
            int accNum = int.Parse(txtAccountNumber.Text);
            decimal balance = decimal.Parse(txtBal.Text);
            DateTime date = DateTime.Now;

            ad.AddDepTransaction(type, amount, accNum, balance, date);
            MessageBox.Show("Success, Make Another Deposit or Update Database");
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            //Update Accounts
            EditData ed = new EditData();//instantiate the editData class
           
            int id = int.Parse(txtId.Text);
            decimal updatedBalance = decimal.Parse(txtBal.Text);

            ed.UpdateBalance(updatedBalance,id);
            MessageBox.Show("Account debit Successful");
            this.Close();

            var form = new AccountsListForm();
            form.Show();
            form.RefreshDataGrid();

        }
    }
}
