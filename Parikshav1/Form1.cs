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
using Parikshav1.pojo;
namespace Parikshav1
{
    public partial class Form1 : Form
    {
        User currentLoginingUser = null;
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
            currentLoginingUser = User.getUser(username, password);
            if (currentLoginingUser != null)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Panel) c.Visible = false;
                }
                pTempCheck.Visible = true;
                temp_lbName.Text = currentLoginingUser.UserName;
            }
            else
            {
                Login_lbInvalidMessage.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            var username = reg_tbName.Text; 
            var email = reg_tbEmail.Text;
            var password = reg_tbPassword.Text;
            var userType = "student";
            bool registrationStatus = false;
            if (checkRegistrationTextBox(username, email, password))
            {
                User currentRegisteringingUser = new User(username, email, password, userType);
                registrationStatus = User.StoreDB(currentRegisteringingUser);
                if (registrationStatus == true)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel) c.Visible = false;
                    }
                    LoginPanel.Visible = true;
                }
                else
                {
                    Login_lbInvalidMessage.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Your All The Fields", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

            /*currentLoginingUser.StoreDB(username, email, password);*/
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

        public Boolean checkRegistrationTextBox(String Uname, String Uemail, String Upass)
        {
            String name = Uname;
            String email = Uemail;
            String pass = Upass;
            

            if (name.Equals("") || name.Equals(null) ||
                email.Equals("") || email.Equals(null)
                || pass.Equals("") || pass.Equals(null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
