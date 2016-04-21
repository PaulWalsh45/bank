using System;



using DAL;

namespace BIZ
{
    public class Transactions:DAO
    {
        
        //properties
        public string TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime  Date { get; set; }
        public int DestinationSortCode { get; set; }
        public int DestinationAccountNumber { get; set; }

        //constructor
        public Transactions()
        {

        }

        
    }
}
