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
    public partial class Registeraccount : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");
        public Registeraccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(regpassinp.Text=="" | username.Text == "")
            {
                MessageBox.Show("Please fill the required fields","Error Mesaage",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State!= ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectusername = "SELECT COUNT(id) from registertbl WHERE username=@user";
                        using(SqlCommand checkuser=new SqlCommand(selectusername,connect))
                        {
                            checkuser.Parameters.AddWithValue("@user", username.Text.Trim());
                            int count = (int)checkuser.ExecuteScalar();
                            if (count > 0) { 
                                MessageBox.Show(username.Text.Trim() + " is already registered", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO registertbl" +
                                    "(username,password,dateregistry)" +
                                    "VALUES(@username,@password,@dateregistry)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", regpassinp.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateregistry", today);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered Successfully", "Success Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Items items = new Items();
                                    items.Show();
                                    this.Hide();


                                }

                            }

                        }
                        

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : "+ex, "Error Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();

                    }
                }
            }
        }

        private void Registeraccount_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

            Loginaccount loginaccount = new Loginaccount();
            loginaccount.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            regpassinp.PasswordChar = checkpass.Checked ? '\0' : '*';

        }
    }
}
