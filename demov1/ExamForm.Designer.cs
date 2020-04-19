namespace demov1
{
    partial class ExamForm
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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.eName = new System.Windows.Forms.Label();
            this.timeCountdown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qPanel = new System.Windows.Forms.Panel();
            this.op4 = new System.Windows.Forms.RadioButton();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.qText = new System.Windows.Forms.Label();
            this.qNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.finishBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.qPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.eName);
            this.headerPanel.Controls.Add(this.timeCountdown);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(992, 46);
            this.headerPanel.TabIndex = 0;
            // 
            // eName
            // 
            this.eName.AutoSize = true;
            this.eName.Location = new System.Drawing.Point(12, 18);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(57, 13);
            this.eName.TabIndex = 2;
            this.eName.Text = "NIS Sess1";
            // 
            // timeCountdown
            // 
            this.timeCountdown.AutoSize = true;
            this.timeCountdown.Location = new System.Drawing.Point(907, 18);
            this.timeCountdown.Name = "timeCountdown";
            this.timeCountdown.Size = new System.Drawing.Size(34, 13);
            this.timeCountdown.TabIndex = 1;
            this.timeCountdown.Text = "10:50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time Remaining";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 44);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(877, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total: 60 Ques | Attempted: 50 | Current : 5/60";
            // 
            // qPanel
            // 
            this.qPanel.Controls.Add(this.finishBtn);
            this.qPanel.Controls.Add(this.op1);
            this.qPanel.Controls.Add(this.label4);
            this.qPanel.Controls.Add(this.op4);
            this.qPanel.Controls.Add(this.op3);
            this.qPanel.Controls.Add(this.op2);
            this.qPanel.Controls.Add(this.qText);
            this.qPanel.Controls.Add(this.qNo);
            this.qPanel.Controls.Add(this.label2);
            this.qPanel.Location = new System.Drawing.Point(48, 53);
            this.qPanel.Name = "qPanel";
            this.qPanel.Size = new System.Drawing.Size(896, 380);
            this.qPanel.TabIndex = 2;
            // 
            // op4
            // 
            this.op4.AutoSize = true;
            this.op4.Location = new System.Drawing.Point(31, 250);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(99, 17);
            this.op4.TabIndex = 6;
            this.op4.TabStop = true;
            this.op4.Text = "Yogi Adityanath";
            this.op4.UseVisualStyleBackColor = true;
            this.op4.Click += new System.EventHandler(this.option_Click);
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(31, 214);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(73, 17);
            this.op3.TabIndex = 5;
            this.op3.TabStop = true;
            this.op3.Text = "Amit Shah";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.Click += new System.EventHandler(this.option_Click);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(31, 181);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(90, 17);
            this.op2.TabIndex = 4;
            this.op2.TabStop = true;
            this.op2.Text = "Rahul Gandhi";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.Click += new System.EventHandler(this.option_Click);
            // 
            // qText
            // 
            this.qText.AutoSize = true;
            this.qText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qText.Location = new System.Drawing.Point(24, 58);
            this.qText.Name = "qText";
            this.qText.Size = new System.Drawing.Size(167, 26);
            this.qText.TabIndex = 2;
            this.qText.Text = "Who is our PM?";
            // 
            // qNo
            // 
            this.qNo.AutoSize = true;
            this.qNo.Location = new System.Drawing.Point(90, 31);
            this.qNo.Name = "qNo";
            this.qNo.Size = new System.Drawing.Size(13, 13);
            this.qNo.TabIndex = 1;
            this.qNo.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question: ";
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(13, 228);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(29, 23);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(951, 228);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(29, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "You answered: ";
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(29, 148);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(90, 17);
            this.op1.TabIndex = 8;
            this.op1.TabStop = true;
            this.op1.Text = "Rahul Gandhi";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.option_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(777, 331);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 9;
            this.finishBtn.Text = "Finish Exam";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Visible = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 497);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.qPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.qPanel.ResumeLayout(false);
            this.qPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label eName;
        private System.Windows.Forms.Label timeCountdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel qPanel;
        private System.Windows.Forms.RadioButton op4;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.Label qText;
        private System.Windows.Forms.Label qNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button finishBtn;
    }
}