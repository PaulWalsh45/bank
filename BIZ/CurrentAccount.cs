using System.Data;
using DAL;

namespace BIZ
{
    public class CurrentAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        //constructor(s)
        public CurrentAccount()
        {

        }
        
        public CurrentAccount(string fname, string sname, string email, string phone, string add1, string add2,
            string city, string cnty, string accNum, int sortcode, decimal bal, decimal od)
            : base (fname, sname, email, phone, add1, add2, city, cnty, accNum, sortcode, bal)
        {
            OverdraftLimit = od;

        }

        public DataTable GetAccounts()
        {
            DAO getListOfAllAccounts = new DAO();
            return getListOfAllAccounts.ReadAllAccounts();
        }

    }
}
