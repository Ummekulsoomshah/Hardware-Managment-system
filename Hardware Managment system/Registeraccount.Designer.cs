namespace Hardware_Managment_system
{
    partial class Registeraccount
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
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            checkpass = new CheckBox();
            regpassinp = new TextBox();
            username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1363, 15);
            label4.Name = "label4";
            label4.Size = new Size(34, 38);
            label4.TabIndex = 25;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.Location = new Point(498, 138);
            label3.Name = "label3";
            label3.Size = new Size(307, 51);
            label3.TabIndex = 24;
            label3.Text = "Register Account";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(598, 571);
            button1.Name = "button1";
            button1.Size = new Size(156, 64);
            button1.TabIndex = 23;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkpass
            // 
            checkpass.AutoSize = true;
            checkpass.Location = new Point(701, 518);
            checkpass.Name = "checkpass";
            checkpass.Size = new Size(162, 29);
            checkpass.TabIndex = 22;
            checkpass.Text = "Show Password";
            checkpass.UseVisualStyleBackColor = true;
            checkpass.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // regpassinp
            // 
            regpassinp.Location = new Point(498, 457);
            regpassinp.Name = "regpassinp";
            regpassinp.PasswordChar = '*';
            regpassinp.Size = new Size(365, 31);
            regpassinp.TabIndex = 21;
            // 
            // username
            // 
            username.Location = new Point(498, 285);
            username.Name = "username";
            username.Size = new Size(365, 31);
            username.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(498, 386);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 19;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(498, 215);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 18;
            label1.Text = "Username";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(301, 739);
            panel7.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(474, 638);
            label5.Name = "label5";
            label5.Size = new Size(333, 38);
            label5.TabIndex = 27;
            label5.Text = "Already have an account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(802, 625);
            label6.Name = "label6";
            label6.Size = new Size(115, 51);
            label6.TabIndex = 28;
            label6.Text = "Login";
            label6.Click += label6_Click;
            // 
            // Registeraccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 739);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(checkpass);
            Controls.Add(regpassinp);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registeraccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registeraccount";
            Load += Registeraccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Button button1;
        private CheckBox checkpass;
        private TextBox regpassinp;
        private TextBox username;
        private Label label2;
        private Label label1;
        private Panel panel7;
        private Label label5;
        private Label label6;
    }
}