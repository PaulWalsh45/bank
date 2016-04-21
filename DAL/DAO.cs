using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO
    {
        private SqlConnection con;
        //DataTable datatable = new DataTable();

        public DAO()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSBank"].ConnectionString);
        }

        public SqlConnection OpenCon()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        public void CloseCon()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public DataTable ReadAllAccounts()
        {
            DataTable datatable = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", con);
            
            //bring in a class to read the data
            SqlDataReader dataReader = cmd.ExecuteReader();
            //load the data into data table
            datatable.Load(dataReader);

            return datatable;
        }

        public DataTable ReadTrans(int id)
        {
            DataTable datatable = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Transactions WHERE AccountNumber = @id", con);

            SqlDataReader rd = cmd.ExecuteReader();
            datatable.Load(rd);

            return datatable;
        }
    }
}
