using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Parikshav1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class User
    {
        
        bool loginStatus = false;
        String userName;
        String useremail;
        String userLastLogin;
        String userType;
        String userPassword;

        public string UserName
        {
            get { return userName; } 
            set { userName = value; }
        }
        public string Useremail
        {
            get { return useremail; }
            set { useremail = value; }
        }
        public string UserLastLogin
        {
            get { return userLastLogin; }
            set { userLastLogin = value; }
        }
        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public static User getUser(String email, String Pass)
        {
            User currentUser = new User();
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tb_student";
            Console.WriteLine("Db working");
            MySqlDataReader dataReader = cmd.ExecuteReader();

            var username = email;
            var password = Pass;
            Console.WriteLine("Db working");
            dataReader.Read();
            if (username.Equals(dataReader.GetString("UserEmail")) && password.Equals(dataReader.GetString("UserPassword")))
            {
                Console.WriteLine("Db working");
                currentUser.userName = dataReader.GetString("UserName");
                currentUser.useremail = dataReader.GetString("UserEmail");
                currentUser.loginStatus = true;
                currentUser.userLastLogin = dataReader.GetString("UserLastLogin");
                currentUser.userType = dataReader.GetString("UserType");
                con.Close();
                return currentUser;
            }
            con.Close();
            return null;
        }
    }
}
