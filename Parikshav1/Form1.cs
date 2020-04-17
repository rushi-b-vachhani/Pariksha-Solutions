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
        User currentLoginingUser;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RegisterPanel.Visible = false;
            pWelcome.Visible = true;
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            
            var username = tbUsername.Text;
            var password = tbPassword.Text;
            User.getUser(username, password);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User currentLoginingUser = new User();
            var username = reg_tbName.Text;
            var email = reg_tbEmail.Text;
            var password = reg_tbPassword.Text;
            //currentLoginingUser.StoreDB(username, email, password);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Visible = false;
            RegisterPanel.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
        }

        private void wp_btnLogin_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
            pWelcome.Visible = false;
        }

        private void wp_btnRegister_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RegisterPanel.Visible = true;
            pWelcome.Visible = false;
        }

        
    }
}
