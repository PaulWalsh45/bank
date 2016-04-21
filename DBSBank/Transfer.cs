using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BIZ;
using DBSBank;




namespace DAL
{

    public partial class Transfer : Form
    {
        //list for retrieved account numbers
        List<string> list = new List<string>();
       
        //instantiate classes to be used throughout this class
        EditData ed = new EditData();
        AddData ad = new AddData();

        //declare binding source for combobox internal account numbers
        BindingSource bs = new BindingSource();

        TransferFunds tf = new TransferFunds();

        public Transfer(int id)
        {
            InitializeComponent();

            txtId.Text = id.ToString();
            tf = tf.GetAccountDetails(id);
           
            txtAccNum.Text = tf.AccountNumber.ToString();
            txtBal.Text = tf.Balance.ToString();
            txtOverdraft.Text = tf.Overdraft.ToString();           
        }

        private void cbxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variables
            string dbsSortCode = "101010";
            string boiSortCode = "901095";
            string aibSortCode = "501055";
            string ulsterBankSortCode = "802080";
            int bank = cbxBank.SelectedIndex;

            switch (bank)
            {
                case 0: txtSortCode.Text = dbsSortCode; break;
                case 1: txtSortCode.Text = boiSortCode; break;
                case 2: txtSortCode.Text = aibSortCode; break;
                case 3: txtSortCode.Text = ulsterBankSortCode; break;

            }
           
            // retrieve account numbers for combo box for DBS Accounts
            if (cbxBank.SelectedIndex == 0)
            {
                //populate combobox with list of account numbers
                list = tf.GetAccountNumbers();
                bs.DataSource = list;
                cbxAccNumInternal.DataSource = bs;
            }
            else
            {
                bs.DataSource = null;
                
                //cbxAccNumInternal.Text = "Not Applicable";
                txtCreditedBal.Text= "N/A Ext.Account";
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //internal Account Variables
            decimal balance = decimal.Parse(txtBal.Text);
            decimal oDraft = decimal.Parse(txtOverdraft.Text);
            decimal limit = balance + oDraft;
            decimal amount = decimal.Parse(txtTransAmount.Text);         
            
            //check for duplicate account transfer
            if (txtAccNum.Text == cbxAccNumInternal.Text)
            {
                MessageBox.Show("Duplicate accounts, select another crediting account");
                cbxAccNumInternal.Focus();
            }
            else
            {
                if (amount <= limit)
                {

                    balance = balance - amount;
                    txtBal.Text = balance.ToString();

                    if (txtCreditedBal.Text != "N/A Ext.Account")
                    {

                        //update DBS internal account transfer
                        decimal oldBal = decimal.Parse(txtCreditedBal.Text);
                        oldBal = oldBal + amount;
                        txtCreditedBal.Text = oldBal.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Amount Exceeds Limit");
                }




                //Record Transactions Two Required, Transfer and deposit for DBS Accounts 

                //gather transfer variables
                string type = "Transfer";
                //amount already defined above
                int accNum = int.Parse(txtAccNum.Text);
                //balance already defined above
                DateTime date = DateTime.Now;
                int destSC = int.Parse(txtSortCode.Text);
                int destAccNum = int.Parse(cbxAccNumInternal.Text);

                //execute transfer Query
                ad.AddTransferTransaction(type, amount, accNum, balance, date, destSC, destAccNum);

                //execute deposit Query for DBS Accounts Only
                if (cbxBank.SelectedIndex == 0)
                {
                    string typ = "Deposit";
                    int acNum = int.Parse(cbxAccNumInternal.Text);
                    ad.AddDepTransaction(typ, amount, acNum, balance, date);

                }
                MessageBox.Show("Success,Update Database prior to further Transfers");
            }
        }
        public decimal GetBalance(int accNum)
        {
            decimal bal;
            TransferFunds tranF = new TransferFunds();
            tranF = tranF.GetCreditingAccBal(accNum);
            bal = tranF.Balance;
            return bal;
        }
        private void cbxAccNumInternal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                //get current balance of the DBS account
                int accNumber = int.Parse(cbxAccNumInternal.SelectedValue.ToString());
                decimal currentBal = GetBalance(accNumber);
                txtCreditedBal.Text = currentBal.ToString();
        }

        private void btnUpdateAccs_Click(object sender, EventArgs e)
        {            
            //account 1 debiting account
            int acNum = int.Parse(txtAccNum.Text);
            decimal balOne = decimal.Parse(txtBal.Text);
            ed.UpdateAccBalOne(acNum,balOne);
            

            //account crediting account Applicable only If Internal DBS Account
            if (cbxBank.SelectedIndex == 0)
                {
                    int accNumber = int.Parse(cbxAccNumInternal.SelectedValue.ToString());

                    decimal balTwo = decimal.Parse(txtCreditedBal.Text);
                    ed.UpdateAccBalTwo(accNumber, balTwo);
                }
            
            MessageBox.Show("Database Updated Successfully");
            this.Close();

            new AccountsFormLoader().LoadForm();
        }
    }
}
