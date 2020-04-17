using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Parikshav1.pojo
{
    class User
    {
        

        bool loginStatus = false;
        String userName;
        String userEmail;
        String userLastLogin;
        String userType = "student";
        String userPassword;
        public User()
        {
            //Code....................
        }
        public User(String UName, String UEmail, String UPassword, String UType)
        {
            this.userName = UName;
            this.userEmail = UEmail;
            this.userPassword = UPassword;
            this.userType = UType;

        }
        public bool LoginStatus
        {
            get { return loginStatus; }
            set { loginStatus = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
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
            
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tb_user where UserEmail ='" + email + "'";
            Console.WriteLine("Db working1");
            MySqlDataReader dataReader = cmd.ExecuteReader();

            var username = email;
            var password = Pass;
            if (dataReader.Read())
            {
                if (username.Equals(dataReader.GetString("UserEmail")) && password.Equals(dataReader.GetString("UserPassword")))
                {
                    Console.WriteLine("Db working2");
                    User currentUser = new User();
                    currentUser.loginStatus = true;
                    currentUser.userName = dataReader.GetString("UserName");
                    currentUser.userEmail = dataReader.GetString("UserEmail");
                    currentUser.loginStatus = true;
                    currentUser.userLastLogin = dataReader.GetString("UserLastLogin");
                    currentUser.userType = dataReader.GetString("UserType");
                    con.Close();
                    return currentUser;
                }
            }
            Console.WriteLine("Db working3");
            con.Close();
            return null;
        }
        public static bool StoreDB(User user)
        {
            db db = new db();
            db.openConnection();
            Console.WriteLine("Db working1");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `tb_user`(`UserName`, `UserEmail`, `UserPassword`, `UserType`) VALUES (@UserName, @UserEmail, @UserPassword, @UserType)", db.getConnection());

            cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = user.UserName;
            cmd.Parameters.Add("@UserEmail", MySqlDbType.VarChar).Value = user.UserEmail;
            cmd.Parameters.Add("@UserPassword", MySqlDbType.VarChar).Value = user.UserPassword;
            cmd.Parameters.Add("@UserType", MySqlDbType.VarChar).Value = user.UserType;

            if (checkEmail(user.UserEmail))
            {
                Console.WriteLine("Db working2");
                MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
            else 
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Db working3");
                    MessageBox.Show("Your Account Has Been Registered", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeConnection();
                    return true;
                }
                else
                {
                    Console.WriteLine("Db working4");
                    MessageBox.Show("ERROR");
                    db.closeConnection();

                    return false;
                }
            }
        }

        public static Boolean checkEmail(String UName)
        {
            db db = new db();
            String local_email = UName;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_user` WHERE `UserEmail` = @Email", db.getConnection());
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = local_email;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
