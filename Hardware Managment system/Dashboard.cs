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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            displayusers();
            displayitems();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");

        public void displayusers()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectusers = "SELECT COUNT(CUstId) FROM Customertbl WHERE delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectusers, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            users.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();

                }

            }
            else
            {

            }

        }

        public void displayitems()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectitem = "SELECT COUNT(ItemId) FROM Itemtbl WHERE delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectitem, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            items.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();

                }

            }
            else
            {

            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult logoutbtn = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (logoutbtn == DialogResult.Yes)
            {
                Loginaccount loginaccount = new Loginaccount();
                loginaccount.Show();
                this.Show();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Catagory catagory = new Catagory();
            catagory.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
