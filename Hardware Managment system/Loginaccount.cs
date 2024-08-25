using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Managment_system
{
    public partial class Loginaccount : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");
        public Loginaccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logusername.Text == "" || loginpass.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "Error Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM registertbl WHERE username=@username AND password=@password";
                        using(SqlCommand cmd=new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@username", logusername.Text.Trim());
                            cmd.Parameters.AddWithValue("@password",loginpass.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("login successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Items items = new Items();
                                items.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Invalid username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                     }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex, "Error Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    finally
                    {

                        connect.Close();

                    }
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginaccount_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Registeraccount registeraccount = new Registeraccount();
            registeraccount.Show();
            this.Hide();

        }

        private void showloginpass_CheckedChanged(object sender, EventArgs e)
        {
            loginpass.PasswordChar = showloginpass.Checked ? '\0' : '*';

        }
    }
}
