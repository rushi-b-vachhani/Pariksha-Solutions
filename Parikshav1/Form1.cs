using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Parikshav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginPanel.Controls.Add(tbUsername);
            LoginPanel.Controls.Add(tbPassword);
            LoginPanel.Controls.Add(lbLogin);
            LoginPanel.Controls.Add(tbUsername);
            LoginPanel.Controls.Add(tbPassword);
            LoginPanel.Controls.Add(btName);
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tb_student";
            
            MySqlDataReader dataReader = cmd.ExecuteReader();

            var username = tbUsername.Text;
            var password = tbPassword.Text;

            dataReader.Read();
            if (username.Equals(dataReader.GetString("StudentEmail")) && password.Equals(dataReader.GetString("StudentPassword")))
            {
                LoginPanel.Visible = false;
                PHomePage.Controls.Add(lbLoginSuccess);
                PHomePage.Show();
            }

        }
    }
}
