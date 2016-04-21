using System.Data.SqlClient;
using DAL;

namespace BIZ
{
    public class WithdrawFunds:DAO
    {

        EditData ed = new EditData();
        //properties
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Overdraft { get; set; }

        public WithdrawFunds()
        {

        }
        //method
        public WithdrawFunds GetAccountDetails(int id)
        {
            WithdrawFunds wDraw = new WithdrawFunds();
            //DepositFunds deposit = new DepositFunds();
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                wDraw.AccountNumber = int.Parse(dr["AccountNumber"].ToString());
                wDraw.Balance = decimal.Parse(dr["InitialBalance"].ToString());
                wDraw.Overdraft=decimal.Parse(dr["Overdraft"].ToString());


            }
            CloseCon();
            return wDraw;
        }
    }
}
