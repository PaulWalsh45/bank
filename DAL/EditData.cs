﻿using System;
using System.Data.SqlClient;

namespace DAL
{
    public class Email
    {
        public string EmailAddress { get; private set; }

        public Email(string email)
        {
            if (!email.Contains("@")) throw new ArgumentException("email must contain an @");
            EmailAddress = email;
            if (email.Equals("@")) throw new ArgumentException("email address in-complete");
            EmailAddress = email;
            if (email.Equals("@.com")) throw new ArgumentException("email address in-complete");
            EmailAddress = email;
        }
    }

    public class AccountId
    {
        public int Id { get; private set; }

        public AccountId(int id)
        {
            Id = id;
        }
    }

    public class Phone
    {
        public string PhoneNumber { get; private set; }

        public Phone(string number)
        {
            if (!number.Contains("-")) throw new ArgumentException("Phone number must be of the format XXX-XXXXXXX");
            PhoneNumber = number;
            if (number.Length != 11) throw new ArgumentException("Phone number contains incorrect amount of digits");
            PhoneNumber = number;
        }
    }

    public class EditAccountDetails 
    {
        public AccountId Id { get; private set; }
        public Email Email { get;  set; }
        public Phone Phone { get;  set; }
        public string AddressLine1 { get;  set; }
        public string AddressLine2 { get;  set; }
        public string City { get;  set; }
        public string County { get;  set; }

        public EditAccountDetails()
        {

        }

        public EditAccountDetails(AccountId id, Email email, Phone phone, string addressLine1, string addressLine2, string city, string county)
        {
            Id = id;
            Email = email;
            Phone = phone;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
        }
    }

    public class EditData : DAO
    {
        //methods
        public void GetAccountDetails(int id)
        {

            SqlCommand cmd = new SqlCommand("SELECT * from Accounts WHERE AccountId = @id", OpenCon());
            SqlDataReader dr = cmd.ExecuteReader();
        }

        public void UpdateAccount(EditAccountDetails details)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET Email=@em, Phone=@phone, Address1=@ad1, Address2=@ad2, City=@cy,County=@cty WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", details.Id.Id);
            cmd.Parameters.AddWithValue("@em", details.Email.EmailAddress);
            cmd.Parameters.AddWithValue("@phone", details.Phone.PhoneNumber);
            cmd.Parameters.AddWithValue("@ad1", details.AddressLine1);
            cmd.Parameters.AddWithValue("@ad2", details.AddressLine2);
            cmd.Parameters.AddWithValue("@cy", details.City);
            cmd.Parameters.AddWithValue("@cty", details.County);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void UpdateBalance(decimal balance, int accountId)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET InitialBalance=@bal WHERE AccountId = @id", OpenCon());
            cmd.Parameters.AddWithValue("@id", accountId);
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void UpdateDebitingAccountBalance(int accountNumber, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET InitialBalance=@bal WHERE AccountNumber = @num", OpenCon());
            cmd.Parameters.AddWithValue("@num", accountNumber.ToString());
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void UpdateCreditingAccountBalance(int accountNumber, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET InitialBalance=@bal WHERE AccountNumber = @num", OpenCon());
            cmd.Parameters.AddWithValue("@num", accountNumber.ToString());
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}
