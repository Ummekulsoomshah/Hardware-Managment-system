using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Managment_system
{
    public partial class Customer : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");
        public int custid;
        public Customer()
        {
            InitializeComponent();
            displayCustomerlist();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (custname.Text == "" ||
                custgender.Text == "" ||
                custphone.Text == "")
            {
                MessageBox.Show("Please fill the feilds", "Errro meeage", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete" + custname + " ?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;


                            string updateData = "DELETE FROM Customertbl WHERE CUstId=@custid";



                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custid", this.custid);


                                cmd.ExecuteNonQuery();
                                displayCustomerlist();


                                MessageBox.Show("Deleted Successfully", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        finally
                        {
                            connect.Close();

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        public void displayCustomerlist()
        {
            CustomerDataList add_customer = new CustomerDataList();
            List<CustomerDataList> listdata = add_customer.CustomerDataListing();

            customergrid.DataSource = listdata;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (custname.Text == "" ||
                custgender.Text == "" ||
                custphone.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string checkName = "SELECT COUNT(*) FROM Customertbl WHERE CustName = @custname";
                        MessageBox.Show("Databse connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        using (SqlCommand cmd = new SqlCommand(checkName, connect))
                        {
                            cmd.Parameters.AddWithValue("@custname", custname.Text);
                            int count = (int)cmd.ExecuteScalar(); // Corrected this line

                            if (count > 1)
                            {
                                MessageBox.Show(custname.Text.Trim() + " is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Else part run");
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO Customertbl " +
                                    "(CustName,CustGender,insert_date,Phone)" +
                                    "VALUES(@custname,@custgender,@insert_date,@custphone)";

                                using (SqlCommand cmd1 = new SqlCommand(insertData, connect))
                                {
                                    cmd1.Parameters.AddWithValue("@custname", custname.Text);
                                    cmd1.Parameters.AddWithValue("@custgender", custgender.Text);
                                    cmd1.Parameters.AddWithValue("@custphone", custphone.Text);
                                    cmd1.Parameters.AddWithValue("insert_date", today);

                                    MessageBox.Show("cmd1 run");

                                    cmd1.ExecuteNonQuery();

                                    displayCustomerlist();

                                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Catagory catagory = new Catagory();
            catagory.Show();
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Loginaccount loginaccount = new Loginaccount();
            loginaccount.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Catagory catagory = new Catagory();
            catagory.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (custname.Text == "" ||
                custgender.Text == "" ||
                custphone.Text == "")
            {
                MessageBox.Show("Please fill the feilds", "Errro meeage", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update" + custname + " ?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;


                            string updateData = "UPDATE Customertbl SET CustName=@custname,CustGender=@custgender,Phone=@custphone, " +
                                "update_date=@updatedate WHERE CUstId=@custid";



                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custname", custname.Text.Trim());
                                cmd.Parameters.AddWithValue("@custgender", custgender.Text.Trim());
                                cmd.Parameters.AddWithValue("@custphone", custphone.Text.Trim());
                                cmd.Parameters.AddWithValue("@custid", this.custid);
                                cmd.Parameters.AddWithValue("@updatedate", today);


                                cmd.ExecuteNonQuery();
                                displayCustomerlist();


                                MessageBox.Show("Updated Successfully", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        finally
                        {
                            connect.Close();

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }


        public void clearfields()
        {
            custname.Text = "";
            custgender.Text = "";
            custphone.Text = "";
        }

        private void customergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            custid = (int)customergrid.SelectedRows[0].Cells[0].Value;
            custname.Text = customergrid.SelectedRows[0].Cells[1].Value.ToString();
            custgender.Text = customergrid.SelectedRows[0].Cells[2].Value.ToString();
            custphone.Text = customergrid.SelectedRows[0].Cells[3].Value.ToString();


        }
    }
}
