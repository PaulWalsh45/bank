using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace DBSBank
{
    public partial class ViewTransactions : Form
    {
        public ViewTransactions(int id)
        {
            InitializeComponent();

            
            DataTable dt = new DataTable();
            DAO connection = new DAO();
            string sqlStatement = "SELECT * from Transactions WHERE AccountNumber = @id";
            SqlCommand sqlCmd = new SqlCommand(sqlStatement, connection.OpenCon());
            sqlCmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgv1.DataSource = dt;
            }
        }
    }
}
