using System.Data.SqlClient;
using DAL;

namespace BIZ
{
    public class XmlSerialAcc : DAO
    {
        //instantiate the xml class from DAL layer
        EditData ed = new EditData();

        //variables
        private int sortcode = 101010;

        //properties
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public decimal DepositAmount(decimal amount)
        {
            InitialBalance += amount;
            return InitialBalance;
        }


        public int Sortcode
        {
            set { sortcode = value; }
        }

        public decimal InitialBalance { get; set; }


        public decimal OverdraftLimit { get; set; }


        //constructors
        Account acc = new CurrentAccount();




        //method to retrieve account id 
        public CurrentAccount RetrieveAccount(int id)
        {
            CurrentAccount acc = new CurrentAccount();          
            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                acc.FirstName = dr["FirstName"].ToString();
                acc.Surname = dr["SurName"].ToString();
                acc.Email = dr["email"].ToString();
                acc.Phone = dr["Phone"].ToString();
                acc.AddressLine1 = dr["Address1"].ToString();
                acc.AddressLine2 = dr["Address2"].ToString();
                acc.City = dr["City"].ToString();
                acc.Country = dr["Country"].ToString();
                acc.AccountType = dr["AccountType"].ToString();
                acc.AccountNumber =(dr["AccountNumber"].ToString());
                acc.Sortcode = int.Parse(dr["SortCode"].ToString());
                acc.InitialBalance = decimal.Parse(dr["InitialBalance"].ToString());
                acc.OverdraftLimit = decimal.Parse(dr["Overdraft"].ToString());

            }
            CloseCon();
            return acc;
        }
    }
}
