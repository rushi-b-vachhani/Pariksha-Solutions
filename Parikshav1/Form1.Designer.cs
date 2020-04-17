namespace Parikshav1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btName = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_tbName = new System.Windows.Forms.TextBox();
            this.reg_tbEmail = new System.Windows.Forms.TextBox();
            this.reg_tbPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pWelcome = new System.Windows.Forms.Panel();
            this.wp_btnLogin = new System.Windows.Forms.Button();
            this.wp_btnRegister = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.pWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.label6);
            this.LoginPanel.Controls.Add(this.linkLabel2);
            this.LoginPanel.Controls.Add(this.lbLogin);
            this.LoginPanel.Controls.Add(this.tbUsername);
            this.LoginPanel.Controls.Add(this.btName);
            this.LoginPanel.Controls.Add(this.lbPassword);
            this.LoginPanel.Controls.Add(this.tbPassword);
            this.LoginPanel.Controls.Add(this.lbUsername);
            this.LoginPanel.Location = new System.Drawing.Point(12, 29);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(403, 396);
            this.LoginPanel.TabIndex = 6;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(125, 41);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(123, 51);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Login";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(134, 136);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(182, 24);
            this.tbUsername.TabIndex = 1;
            // 
            // btName
            // 
            this.btName.BackColor = System.Drawing.Color.Black;
            this.btName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btName.Location = new System.Drawing.Point(134, 273);
            this.btName.Name = "btName";
            this.btName.Size = new System.Drawing.Size(101, 28);
            this.btName.TabIndex = 0;
            this.btName.Text = "Login";
            this.btName.UseVisualStyleBackColor = false;
            this.btName.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPassword.Location = new System.Drawing.Point(26, 207);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(97, 20);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(134, 205);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(182, 24);
            this.tbPassword.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbUsername.Location = new System.Drawing.Point(24, 138);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 21);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username:";
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.linkLabel1);
            this.RegisterPanel.Controls.Add(this.button1);
            this.RegisterPanel.Controls.Add(this.reg_tbPassword);
            this.RegisterPanel.Controls.Add(this.reg_tbEmail);
            this.RegisterPanel.Controls.Add(this.reg_tbName);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.label2);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Location = new System.Drawing.Point(421, 29);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(416, 396);
            this.RegisterPanel.TabIndex = 7;
            this.RegisterPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(66, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(30, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(65, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email :";
            // 
            // reg_tbName
            // 
            this.reg_tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_tbName.Location = new System.Drawing.Point(141, 133);
            this.reg_tbName.Margin = new System.Windows.Forms.Padding(5);
            this.reg_tbName.Name = "reg_tbName";
            this.reg_tbName.Size = new System.Drawing.Size(182, 24);
            this.reg_tbName.TabIndex = 10;
            // 
            // reg_tbEmail
            // 
            this.reg_tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_tbEmail.Location = new System.Drawing.Point(141, 191);
            this.reg_tbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.reg_tbEmail.Name = "reg_tbEmail";
            this.reg_tbEmail.Size = new System.Drawing.Size(182, 24);
            this.reg_tbEmail.TabIndex = 11;
            // 
            // reg_tbPassword
            // 
            this.reg_tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_tbPassword.Location = new System.Drawing.Point(141, 250);
            this.reg_tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.reg_tbPassword.Name = "reg_tbPassword";
            this.reg_tbPassword.Size = new System.Drawing.Size(182, 24);
            this.reg_tbPassword.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(141, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(248, 348);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(107, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Already a member ?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(206, 339);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 17);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(95, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Not a member?";
            // 
            // pWelcome
            // 
            this.pWelcome.Controls.Add(this.wp_btnRegister);
            this.pWelcome.Controls.Add(this.wp_btnLogin);
            this.pWelcome.Location = new System.Drawing.Point(843, 29);
            this.pWelcome.Name = "pWelcome";
            this.pWelcome.Size = new System.Drawing.Size(285, 230);
            this.pWelcome.TabIndex = 16;
            this.pWelcome.Visible = false;
            // 
            // wp_btnLogin
            // 
            this.wp_btnLogin.BackColor = System.Drawing.Color.Black;
            this.wp_btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wp_btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wp_btnLogin.Location = new System.Drawing.Point(92, 53);
            this.wp_btnLogin.Name = "wp_btnLogin";
            this.wp_btnLogin.Size = new System.Drawing.Size(101, 49);
            this.wp_btnLogin.TabIndex = 14;
            this.wp_btnLogin.Text = "Login";
            this.wp_btnLogin.UseVisualStyleBackColor = false;
            this.wp_btnLogin.Click += new System.EventHandler(this.wp_btnLogin_Click);
            // 
            // wp_btnRegister
            // 
            this.wp_btnRegister.BackColor = System.Drawing.Color.Black;
            this.wp_btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wp_btnRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wp_btnRegister.Location = new System.Drawing.Point(92, 115);
            this.wp_btnRegister.Name = "wp_btnRegister";
            this.wp_btnRegister.Size = new System.Drawing.Size(101, 49);
            this.wp_btnRegister.TabIndex = 15;
            this.wp_btnRegister.Text = "Register";
            this.wp_btnRegister.UseVisualStyleBackColor = false;
            this.wp_btnRegister.Click += new System.EventHandler(this.wp_btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pWelcome);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.Text = "Pariksha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.pWelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox reg_tbPassword;
        private System.Windows.Forms.TextBox reg_tbEmail;
        private System.Windows.Forms.TextBox reg_tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pWelcome;
        private System.Windows.Forms.Button wp_btnLogin;
        private System.Windows.Forms.Button wp_btnRegister;
    }
}

