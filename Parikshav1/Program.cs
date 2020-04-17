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
        User currentUser = null;
        bool loginStatus = false;
        String userName;
        String useremail;
        String userLastLogin;
        String userType;
        String userPassword;

        
        public User getUser(String email, String Pass)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tb_student";

            MySqlDataReader dataReader = cmd.ExecuteReader();

            var username = email;
            var password = Pass;

            dataReader.Read();
            if (username.Equals(dataReader.GetString("UserEmail")) && password.Equals(dataReader.GetString("UserPassword")))
            {
                currentUser.userName = dataReader.GetString("UserName");
                currentUser.useremail = dataReader.GetString("UserEmail");
                currentUser.loginStatus = true;
                currentUser.userLastLogin = dataReader.GetString("UserLastLogin");
                currentUser.userType = dataReader.GetString("UserType");
                return currentUser;
            }

            return null;
        }
        

    }
}
