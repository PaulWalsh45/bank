using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL;

namespace BIZ
{
    public class TransferFunds:DAO
    {
        //properties
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Overdraft { get; set; }

        //constructor(s)
        public TransferFunds()
        {

        }
        //method to get account dettail to transfer fund
        public TransferFunds GetAccountDetails(int accountId)
        {
            TransferFunds trans = new TransferFunds();
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", accountId);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                trans.AccountNumber = int.Parse(dr["AccountNumber"].ToString());
                trans.Balance = decimal.Parse(dr["InitialBalance"].ToString());
                trans.Overdraft = decimal.Parse(dr["Overdraft"].ToString());


            }
            CloseCon();
            return trans;
        }
        //get account numbers list
        public List<string> GetAccountNumbers()
        {
            List<string> listOfAccountNumbers = new List<string>();
            
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts", OpenCon());
            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                listOfAccountNumbers.Add(Convert.ToString(dataReader["AccountNumber"]));
               
                
            }
            CloseCon();
            return listOfAccountNumbers;
        }
        //method to transer fund
        public TransferFunds GetCreditingAccountBalance(int accountNumber)
        {
            TransferFunds transferFunds = new TransferFunds();
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountNumber = @an", OpenCon());
            cmd.Parameters.AddWithValue("@an", accountNumber.ToString());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                transferFunds.Balance = decimal.Parse(dr["InitialBalance"].ToString());
               
            }
            CloseCon();
            return transferFunds;
        }

    }
}
