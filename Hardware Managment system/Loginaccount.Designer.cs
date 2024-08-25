namespace Hardware_Managment_system
{
    partial class Loginaccount
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
            panel7 = new Panel();
            label1 = new Label();
            label2 = new Label();
            logusername = new TextBox();
            loginpass = new TextBox();
            showloginpass = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(300, 777);
            panel7.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(503, 209);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(503, 380);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // logusername
            // 
            logusername.Location = new Point(503, 279);
            logusername.Name = "logusername";
            logusername.Size = new Size(365, 31);
            logusername.TabIndex = 11;
            // 
            // loginpass
            // 
            loginpass.Location = new Point(503, 451);
            loginpass.Name = "loginpass";
            loginpass.PasswordChar = '*';
            loginpass.Size = new Size(365, 31);
            loginpass.TabIndex = 12;
            // 
            // showloginpass
            // 
            showloginpass.AutoSize = true;
            showloginpass.Location = new Point(706, 512);
            showloginpass.Name = "showloginpass";
            showloginpass.Size = new Size(162, 29);
            showloginpass.TabIndex = 14;
            showloginpass.Text = "Show Password";
            showloginpass.UseVisualStyleBackColor = true;
            showloginpass.CheckedChanged += showloginpass_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(603, 565);
            button1.Name = "button1";
            button1.Size = new Size(156, 64);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.Location = new Point(503, 132);
            label3.Name = "label3";
            label3.Size = new Size(115, 51);
            label3.TabIndex = 16;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1368, 9);
            label4.Name = "label4";
            label4.Size = new Size(34, 38);
            label4.TabIndex = 17;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(775, 636);
            label6.Name = "label6";
            label6.Size = new Size(157, 51);
            label6.TabIndex = 31;
            label6.Text = "Register";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(479, 649);
            label5.Name = "label5";
            label5.Size = new Size(306, 38);
            label5.TabIndex = 30;
            label5.Text = "Don't have an account?";
            // 
            // Loginaccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 777);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(showloginpass);
            Controls.Add(loginpass);
            Controls.Add(logusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loginaccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loginaccount";
            Load += Loginaccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Label label1;
        private Label label2;
        private TextBox logusername;
        private TextBox loginpass;
        private CheckBox showloginpass;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}