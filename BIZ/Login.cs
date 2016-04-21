using DAL;

namespace BIZ
{
    public class Login
    {
        //poperties
        public string Username { get; set; }
        public string Password { get; set; }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        CheckLogin checkLoginDetails = new CheckLogin();


        public string CheckUserPass()
        {
            string login = checkLoginDetails.CheckUser(Username, Password);
            if (login == "no")
            {
                return "no";
            }
            else
            {
                return login;
            }

        }
    }
}
