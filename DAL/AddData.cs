using System;
using System.Data.SqlClient;



namespace DAL
{
    public class AccountNumber
    {
        public string AccountNum { get; set; }

        public AccountNumber(string accountNumber)
        {
            if (accountNumber.Length != 8) throw new ArgumentException("Account number must contain 8 digits");
            AccountNum = accountNumber;
        }
    }

    public class AddAccountDetails : EditAccountDetails
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AccountType { get; set; }
        public AccountNumber AccountNumber { get; set; }
        public string SortCode { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal Overdraft { get; set; }

        public AddAccountDetails()
        {

        }

        public AddAccountDetails(string firstname, string surname, string accountType, AccountNumber accountNumber, string sortCode, decimal openingBalance, decimal overdraft, AccountId id, Email email, Phone phone, string addressLine1, string addressLine2, string city, string country)
            :base (id, email,  phone,  addressLine1,  addressLine2,  city,  country)
        {
            FirstName = firstname;
            Surname = surname;
            AccountType = accountType;
            AccountNumber = accountNumber;
            SortCode = sortCode;
            OpeningBalance = openingBalance;
            Overdraft = overdraft;
            
        }
    }

    public class Subscriber
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }

        public Subscriber(string username, string password, string fullname)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
        }
    }


    public class AddData : DAO
    {

        //methods
        //public void AddUser(string uname,string pass, string fname)
        public void AddUser(Subscriber details)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (userName,userPass,fullName) VALUES (@un,@pw,@fn)",OpenCon());
            cmd.Parameters.AddWithValue("@un",details.Username);
            cmd.Parameters.AddWithValue("@pw", details.Password);
            cmd.Parameters.AddWithValue("@fn", details.Fullname);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        //public void AddCurrentAccount(string fname, string sname, string email, string phone, string add1, string add2,
        //    string city, string cnty, string accType, int accNum, int scode, decimal bal, decimal od)
        public void AddCurrentAccount(AddAccountDetails details)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Accounts(FirstName,Surname,Email,Phone,Address1,Address2,City,Country,AccountType,AccountNumber,SortCode,InitialBalance,Overdraft) VALUES (@fn,@sn,@em,@ph,@ad1,@ad2,@cty,@ctry,@at,@an,@sc,@ib,@od)",OpenCon());
            cmd.Parameters.AddWithValue("@fn",details.FirstName);
            cmd.Parameters.AddWithValue("@sn", details.Surname);
            cmd.Parameters.AddWithValue("@em", details.Email.EmailAddress);
            cmd.Parameters.AddWithValue("@ph", details.Phone.PhoneNumber);
            cmd.Parameters.AddWithValue("@ad1", details.AddressLine1);
            cmd.Parameters.AddWithValue("@ad2", details.AddressLine2);
            cmd.Parameters.AddWithValue("@cty", details.City);
            cmd.Parameters.AddWithValue("@ctry", details.Country);
            cmd.Parameters.AddWithValue("@at", details.AccountType); 
            cmd.Parameters.AddWithValue("@an", details.AccountNumber.AccountNum);
            cmd.Parameters.AddWithValue("@sc", details.SortCode);
            cmd.Parameters.AddWithValue("@ib", details.OpeningBalance);
            cmd.Parameters.AddWithValue("@od", details.Overdraft);
            cmd.ExecuteNonQuery();
            CloseCon();
            
        }

        //public void AddSavingsAccount(string fname, string sname, string email, string phone, string add1, string add2,
        //    string city, string cnty, string accType, int accNum, int scode, decimal bal,decimal od)
        public void AddSavingsAccount(AddAccountDetails details)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Accounts(FirstName,Surname,Email,Phone,Address1,Address2,City,Country,AccountType,AccountNumber,SortCode,InitialBalance,Overdraft) VALUES (@fn,@sn,@em,@ph,@ad1,@ad2,@cty,@ctry,@at,@an,@sc,@ib,@od)", OpenCon());
            cmd.Parameters.AddWithValue("@fn", details.FirstName);
            cmd.Parameters.AddWithValue("@sn", details.Surname);
            cmd.Parameters.AddWithValue("@em", details.Email.EmailAddress);
            cmd.Parameters.AddWithValue("@ph", details.Phone.PhoneNumber);
            cmd.Parameters.AddWithValue("@ad1", details.AddressLine1);
            cmd.Parameters.AddWithValue("@ad2", details.AddressLine2);
            cmd.Parameters.AddWithValue("@cty", details.City);
            cmd.Parameters.AddWithValue("@ctry", details.Country);
            cmd.Parameters.AddWithValue("@at", details.AccountType);
            cmd.Parameters.AddWithValue("@an", details.AccountNumber.AccountNum);
            cmd.Parameters.AddWithValue("@sc", details.SortCode);
            cmd.Parameters.AddWithValue("@ib", details.OpeningBalance);
            cmd.Parameters.AddWithValue("@od", details.Overdraft);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddDepTransaction(string type, decimal amount, int accNum, decimal balance, DateTime date)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Transactions(TransactionType,TransactionAmount,AccountNumber,Balance,Date) VALUES (@tt,@ta,@an,@bal,@date)", OpenCon());
            cmd.Parameters.AddWithValue("@tt", type);
            cmd.Parameters.AddWithValue("@ta", amount);
            cmd.Parameters.AddWithValue("@an", accNum);
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();
            CloseCon();

        }

        public void AddWithdrawTransaction(string type, decimal amount, int accNum, decimal balance, DateTime date)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Transactions(TransactionType,TransactionAmount,AccountNumber,Balance,Date) VALUES (@tt,@ta,@an,@bal,@date)", OpenCon());
            cmd.Parameters.AddWithValue("@tt", type);
            cmd.Parameters.AddWithValue("@ta", amount);
            cmd.Parameters.AddWithValue("@an", accNum);
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();
            CloseCon();

        }

        public void AddTransferTransaction(string type, decimal amount, int accNum, decimal balance, DateTime date,int scode,int acNum)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Transactions(TransactionType,TransactionAmount,AccountNumber,Balance,Date,DestinationSortCode,DestinationAccNumber) VALUES (@tt,@ta,@an,@bal,@date,@dsc,@dac)", OpenCon());
            cmd.Parameters.AddWithValue("@tt", type);
            cmd.Parameters.AddWithValue("@ta", amount);
            cmd.Parameters.AddWithValue("@an", accNum);
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@dsc", scode);
            cmd.Parameters.AddWithValue("@dac", acNum);

            cmd.ExecuteNonQuery();
            CloseCon();

        }
    }
}
