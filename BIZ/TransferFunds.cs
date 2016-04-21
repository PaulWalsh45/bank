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
        public TransferFunds GetAccountDetails(int id)
        {
            TransferFunds trans = new TransferFunds();
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", id);
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
            List<string> list = new List<string>();
            
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts", OpenCon());
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                list.Add(Convert.ToString(dr["AccountNumber"]));
                
            }
            CloseCon();
            return list;
        }
        //method to transer fund
        public TransferFunds GetCreditingAccBal(int accNo)
        {
            TransferFunds trans = new TransferFunds();
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountNumber = @an", OpenCon());
            cmd.Parameters.AddWithValue("@an", accNo);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                trans.Balance = decimal.Parse(dr["InitialBalance"].ToString());
               
            }
            CloseCon();
            return trans;
        }

    }
}
