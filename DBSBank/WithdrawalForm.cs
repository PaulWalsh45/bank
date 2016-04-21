using System;
using System.Windows.Forms;
using BIZ;
using DAL;

namespace DBSBank
{
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm(int id)
        {
            InitializeComponent();

            //Withdrawal wd = new Withdrawal(id);
            WithdrawFunds wf = new WithdrawFunds();

            txtId.Text = id.ToString();//
            //EditExistingAccount exa = new EditExistingAccount();

            wf = wf.GetAccountDetails(id);

            txtAccountNumber.Text = wf.AccountNumber.ToString();
            txtBal.Text = wf.Balance.ToString();
            txtOverdraft.Text = wf.Overdraft.ToString();
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //variables
            decimal minusAmount = decimal.Parse(txtMinusAmount.Text);
            decimal currentBalance = decimal.Parse(txtBal.Text);
            decimal overdraft = decimal.Parse(txtOverdraft.Text);

            decimal limit = currentBalance + overdraft;
            if (minusAmount > limit)
            {
                MessageBox.Show("Transaction not allowed, Overdraft exceeded");
                this.DialogResult = DialogResult.None;
                txtMinusAmount.Clear();
                txtMinusAmount.Focus();
            }
            else
            {
                txtBal.Text = (currentBalance - minusAmount).ToString();

                //record transaction 
                AddData ad = new AddData();//to make transaction

                //gather withdrawal variables
                string type = "Withdrawal";
                decimal amount = decimal.Parse(txtMinusAmount.Text);
                int accNum = int.Parse(txtAccountNumber.Text);
                decimal balance = decimal.Parse(txtBal.Text);
                DateTime date = DateTime.Now;

                ad.AddWithdrawTransaction(type, amount, accNum, balance, date);
                MessageBox.Show("Success, Make Another Withdrawal or Update Database");
            }
            
        }
        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            EditData ed = new EditData();//instantiate the AddData class

            int id = int.Parse(txtId.Text);
            decimal updatedBalance = decimal.Parse(txtBal.Text);

            ed.UpdateBalance(updatedBalance, id);
            MessageBox.Show("Accounted Withdrawal Successful");
            this.Close();

            var form = new AccountsListForm();
            form.Show();
            form.RefreshDataGrid();
        }
    }
}
