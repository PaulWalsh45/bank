using DAL;


namespace BIZ
{
    public class AddNewAccount
    {
        //instantiate the AddData class from DAL layer
        AddData ad = new AddData();

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
        

        public int Sortcode
        {
            set { sortcode = value; }
        }

        public decimal InitialBalance { get; set; }


        public decimal OverdraftLimit { get; set; }

        //constructor(s)
        public AddNewAccount()
        {

        }

        public AddNewAccount(string fname, string sname, string email, string phone, string add1, string add2,
            string city, string cnty,  string accType, int accNum,  int sortcode,  decimal bal, decimal od)
        {
            FirstName = fname;
            Surname = sname;
            Email = email;
            Phone = phone;
            Address1 = add1;
            Address2 = add2;
            City = city;
            County = cnty;
            AccountType = accType;
            AccountNumber = accNum;
            Sortcode = sortcode;
            InitialBalance = bal;
            OverdraftLimit = od;

        }

        //method
        public void AddAccToDb()
        {
            if (OverdraftLimit != 0)
            {
                AddAccountDetails newAcc = new AddAccountDetails();
                ad.AddSavingsAccount(newAcc);
                //ad.AddSavingsAccount(newAcc);
                //ad.AddSavingsAccount(FirstName, Surname, Email, Phone, Address1, Address2, City, County, AccountType, AccountNumber, sortcode, InitialBalance,OverdraftLimit);
            }
            else
            {
                AddAccountDetails newAcc = new AddAccountDetails();
                ad.AddCurrentAccount(newAcc); 
               // ad.AddCurrentAccount(FirstName, Surname, Email, Phone, Address1, Address2, City, County, AccountType, AccountNumber, sortcode, InitialBalance, OverdraftLimit);
            }

        }






    }
}
