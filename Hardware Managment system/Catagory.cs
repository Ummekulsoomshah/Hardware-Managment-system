using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Managment_system
{
    public partial class Catagory : Form
    {
        public Catagory()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");
        private void Catagory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (catagName.Text == "")
            {
                MessageBox.Show("Please fill the catagory field ");
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string insertcatag = "SELECT COUNT(*) FROM Category WHERE CatagoryName=@catagName";
                        using (SqlCommand cmd = new SqlCommand(insertcatag, connect))
                        {
                            cmd.Parameters.AddWithValue("catagName", catagName.Text.Trim());
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 1)
                            {
                                MessageBox.Show("This catagory already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Else part run");
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO Category " +
                                    "(CatagoryName,insert_date)" +
                                    "VALUES(@Catagoryname,@insert_date)";

                                using (SqlCommand cmd1 = new SqlCommand(insertData, connect))
                                {
                                    cmd1.Parameters.AddWithValue("@CatagoryName", catagName.Text);
                                    cmd1.Parameters.AddWithValue("insert_date", today);

                                    MessageBox.Show("cmd1 run");

                                    cmd1.ExecuteNonQuery();


                                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
