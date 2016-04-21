using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace DBSBank
{
    public partial class ViewTransactions : Form
    {
        public ViewTransactions(string accountNumber)
        {
            InitializeComponent();

            
            DataTable dt = new DataTable();
            DAO connection = new DAO();
            string sqlStatement = "SELECT * from Transactions WHERE AccountNumber = @id";
            SqlCommand cmd = new SqlCommand(sqlStatement, connection.OpenCon());
            cmd.Parameters.AddWithValue("@id", accountNumber);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgv1.DataSource = dt;
            }
        }
    }
}
