using System;
using DAL;



namespace BIZ
{

    //public class AccountNumber
    //{
    //    public string AccountNum { get; set; }

    //    public AccountNumber(string accountNumber)
    //    {
    //        if (accountNumber.Length != 8) throw new ArgumentException("Account number must contain 8 digits");
    //        AccountNum = accountNumber;
    //    }
    //}

    //public class Email
    //{
    //    public string EmailAddress { get; private set; }

    //    public Email(string email)
    //    {
    //        if (!email.Contains("@")) throw new ArgumentException("email must contain an @");
    //        EmailAddress = email;
    //        if (email.Equals("@")) throw new ArgumentException("email address in-complete");
    //        EmailAddress = email;
    //        if (email.Equals("@.com")) throw new ArgumentException("email address in-complete");
    //        EmailAddress = email;
    //    }
    //}

    //public class Phone
    //{
    //    public string PhoneNumber { get; private set; }

    //    public Phone(string number)
    //    {
    //        if (!number.Contains("-")) throw new ArgumentException("Phone number must be of the format XXX-XXXXXXX");
    //        PhoneNumber = number;
    //        if (number.Length != 11) throw new ArgumentException("Phone number contains incorrect amount of digits");
    //        PhoneNumber = number;
    //    }
    //}
    public class Account
    {
        //variables
        private int sortcode = 101010;

        //properties
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public int Sortcode
        {
            set { sortcode = value; }
        }

        public decimal InitialBalance { get; set; }


        //constructor(s)
        public Account()
        {

        }

        public Account(string fname, string sname, string email, string phone, string add1, string add2,
            string city, string cnty, string accNum, int sortcode, decimal bal)
        {
            FirstName = fname;
            Surname = sname;
            Email = email;
            Phone = phone;
            AddressLine1 = add1;
            AddressLine2 = add2;
            City = city;
            Country = cnty;
            AccountNumber = accNum;
            Sortcode = sortcode;
            InitialBalance = bal;
            
        }

    }
}
