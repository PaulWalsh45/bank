using System;
using System.Drawing;
using System.Windows.Forms;
using BIZ;
using DAL;

namespace DBSBank
{
    public partial class AccountsListForm : Form
    {
        
        
        public AccountsListForm()
        {
            InitializeComponent();
          
            DataGridViewCellStyle style =
             dgv.ColumnHeadersDefaultCellStyle;
            
            style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);          
        }

        //method for assigning logged in users name at top of Accounts Form
        public void AddUserToLabel(string s)
        {
            lblUser.Text = "Welcome: "+s;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAccountForm addNewAccountForm = new AddNewAccountForm();
            addNewAccountForm.ShowDialog();
            this.Close();

           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        
        }
        //button click event for edit account 
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dgv.SelectedRows.Count > 0)
            {
                //get record from db that matches selected on dgv
                int accountId = GetSelectedDatagridRecordAccountId();
                EditAccountForm editAccountForm = new EditAccountForm(accountId);
                editAccountForm.ShowDialog();
                this.Close();
            
            }
            else
            {
                MessageBox.Show("Please select a Row");
            }
           
  
        }
        

        public void RefreshDataGrid()
        {
            //this.dgv.ResetBindings();//added to try and correct info in grid still using old db info
            CurrentAccount currentAccount = new CurrentAccount();
           // BindingSource bs = new BindingSource();
            //bs.DataSource = currentAccount.GetAccounts();
            dgv.DataSource = null;
            dgv.DataSource = currentAccount.GetAccounts();
            //dgv.DataSource = bs;


            

        }

        //log out button
    private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }
        // to deposit fund in a account
        private void depositFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int Id = GetSelectedDatagridRecordAccountId();
                DepositForm depositForm = new DepositForm(Id);
                depositForm.ShowDialog();
                this.Close();

                
            }
            else
            {
                MessageBox.Show("Please select a Row");
            }
            
            
        }

        //to withdraw fund from account
        private void withdrawFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int id = GetSelectedDatagridRecordAccountId();
                WithdrawalForm WithdrawalForm = new WithdrawalForm(id);
                WithdrawalForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a Row");
            }
            
           
        }
        //button click event for transfer fund
        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int id = GetSelectedDatagridRecordAccountId();
                Transfer transferForm = new Transfer(id);
                transferForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a Row");
            }
              
        }
        //button click event for viewing transactions by Account Number
        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string accountNumber = GetSelectedDatagridRecordAccountNumber();
                ViewTransactions viewTransactionsForm = new ViewTransactions(accountNumber);
                viewTransactionsForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Please select a Row");
            }
           
        }
        //method to get Id for the selected account on the data grid view (i.e column 1 data)
        public int GetSelectedDatagridRecordAccountId()
        {
            int id = 0;

            int columnindex = 0;
            int rowindex = 0;

            if (dgv.SelectedRows.Count > 0)
            {
                rowindex = dgv.SelectedRows[0].Index;
                id = (int)dgv.Rows[rowindex].Cells[columnindex].Value;
                //id = dgv.Rows[rowindex].Cells[columnindex].Value;

            }
            return id;
        }
        //method to get account number for a account
        public string GetSelectedDatagridRecordAccountNumber()
        {
            string accountNumber ="";

            int columnindex = 10;
            int rowindex = 0;

            if (dgv.SelectedRows.Count > 0)
            {
                rowindex = dgv.SelectedRows[0].Index;
                accountNumber = dgv.Rows[rowindex].Cells[columnindex].Value.ToString();
                

            }
            return accountNumber;
        }
        //button click event for xml serailise
        private void xmlSerialiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int Id = GetSelectedDatagridRecordAccountId();
                XmlSerialise xmlSe = new XmlSerialise(Id);
                xmlSe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a Row");
            }           
        }

        private void dgv_BindingContextChanged(object sender, EventArgs e)
        {

        }       
    }
}
