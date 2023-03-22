using System.Collections;
namespace AppDependencies
{
    public class UserDataScheme
    {
        private string username;
        private string password;
        private string email;
        private int userID;
        static private int userIndexer = 1;


        public int User_ID() => ++userIndexer;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int UserID { get => userID; set => userID = value; }
    }
}