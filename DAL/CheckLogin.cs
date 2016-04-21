using System.Data.SqlClient;

namespace DAL
{
    public class CheckLogin : DAO
    {
        public string UserLoginName { get; set; }

        public string CheckUser(string username, string password)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName=@user AND userPass=@pass", OpenCon());
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return UserLoginName = dr.GetString(3);
            }
            else
            {
                string no = "no";
                return no;
            }

        }
    }
}
