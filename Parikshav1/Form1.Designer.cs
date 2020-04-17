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
            this.lbLoginSuccess = new System.Windows.Forms.Label();
            this.PHomePage = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btName = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PHomePage.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoginSuccess
            // 
            this.lbLoginSuccess.AutoSize = true;
            this.lbLoginSuccess.Location = new System.Drawing.Point(321, 198);
            this.lbLoginSuccess.Name = "lbLoginSuccess";
            this.lbLoginSuccess.Size = new System.Drawing.Size(115, 17);
            this.lbLoginSuccess.TabIndex = 0;
            this.lbLoginSuccess.Text = "Login Successful";
            // 
            // PHomePage
            // 
            this.PHomePage.Controls.Add(this.LoginPanel);
            this.PHomePage.Controls.Add(this.lbLoginSuccess);
            this.PHomePage.Location = new System.Drawing.Point(12, 12);
            this.PHomePage.Name = "PHomePage";
            this.PHomePage.Size = new System.Drawing.Size(794, 429);
            this.PHomePage.TabIndex = 7;
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
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(134, 205);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(182, 24);
            this.tbPassword.TabIndex = 2;
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
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(134, 136);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(182, 24);
            this.tbUsername.TabIndex = 1;
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
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.lbLogin);
            this.LoginPanel.Controls.Add(this.tbUsername);
            this.LoginPanel.Controls.Add(this.btName);
            this.LoginPanel.Controls.Add(this.lbPassword);
            this.LoginPanel.Controls.Add(this.tbPassword);
            this.LoginPanel.Controls.Add(this.lbUsername);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(638, 429);
            this.LoginPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.PHomePage);
            this.Name = "Form1";
            this.Text = "Pariksha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PHomePage.ResumeLayout(false);
            this.PHomePage.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLoginSuccess;
        private System.Windows.Forms.Panel PHomePage;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsername;
    }
}

