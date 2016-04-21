using System.Data.SqlClient;
using DAL;

namespace BIZ
{
    public class DepositFunds:DAO
   {

        EditData ed = new EditData();
        //properties
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal DebitAmount { get; set; }

        public DepositFunds()
        {

        }
        //deposit fund in a account and get id
        public DepositFunds GetAccountBalance(int id)
        {
           
            DepositFunds deposit = new DepositFunds();
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                deposit.AccountNumber = int.Parse(dr["AccountNumber"].ToString());

                deposit.Balance = decimal.Parse(dr["InitialBalance"].ToString());
            }
            CloseCon();
            return deposit;
        }
    }
}
