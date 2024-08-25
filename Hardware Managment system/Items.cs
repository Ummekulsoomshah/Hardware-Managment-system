using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hardware_Managment_system
{
    public partial class Items : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");
        public int itemId;
        public string category { get; set; }
        public Items()
        {
            InitializeComponent();
            categoryMenu();
            DisplayItemdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        public void DisplayItemdata()
        {
            List_Data add_Items = new List_Data();
            List<List_Data> listdata = add_Items.ItemListData();

            dataGridView1.DataSource = listdata;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                if (itemName.Text == "" ||
                    price.Text == "" ||
                    stock.Text == "" ||
                    manufacturer.Text == "")
            {
                    MessageBox.Show("Please fill the feilds", "Error meeage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete" + itemName + " ?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        if (connect.State == ConnectionState.Closed)
                        {
                            try
                            {
                                connect.Open();
                                DateTime today = DateTime.Today;


                                string updateData = "DELETE FROM Itemtbl WHERE ItemId=@itemId";



                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@itemId", this.itemId);


                                    cmd.ExecuteNonQuery();
                                    DisplayItemdata();


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
        public void clearfields()
        {
            itemName.Text = "";
            catagoryName.Text = "";
            price.Text = "";
            stock.Text = "";
            manufacturer.Text = "";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
                if (itemName.Text == "" ||
                    catagoryName.Text == "" ||
                    price.Text == "" ||
                    stock.Text==""||
                    manufacturer.Text=="")
                {
                    MessageBox.Show("Please fill the feilds", "Errro meeage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to update" + itemName + " ?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        if (connect.State == ConnectionState.Closed)
                        {
                            try
                            {
                                connect.Open();
                                DateTime today = DateTime.Today;


                                string updateData = "UPDATE Itemtbl SET ItemName=@itemName,CatagoryName=@catagoryName,Price=@price,Stock=@stock,Manufacturer=@manufacturer, " +
                                    "update_date=@updatedate WHERE ItemId=@itemId";



                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@itemName", itemName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@catagoryName", catagoryName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", price.Text.Trim());
                                cmd.Parameters.AddWithValue("@stock", stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@manufacturer", manufacturer.Text.Trim());
                                cmd.Parameters.AddWithValue("@itemId", this.itemId);
                                    cmd.Parameters.AddWithValue("@updatedate", today);


                                    cmd.ExecuteNonQuery();
                                DisplayItemdata();


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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itemName.Text == "" ||
                catagoryName.Text == "" ||
                price.Text == "" ||
                stock.Text == "" ||
                manufacturer.Text == "")
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

                        string checkName = "SELECT COUNT(*) FROM Itemtbl WHERE ItemName = @itname";
                        MessageBox.Show("Databse connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        using (SqlCommand cmd = new SqlCommand(checkName, connect))
                        {
                            cmd.Parameters.AddWithValue("@itname", itemName.Text);
                            int count = (int)cmd.ExecuteScalar(); // Corrected this line

                            if (count > 1)
                            {
                                MessageBox.Show(itemName.Text.Trim() + " is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Else part run");
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO Itemtbl " +
                                    "(ItemName,CatagoryName,insert_date,price,stock,manufacturer)" +
                                    "VALUES(@itemname,@itemcatagory,@insert_date,@itemprice,@itemstock,@itemmanufacturer)";

                                using (SqlCommand cmd1 = new SqlCommand(insertData, connect))
                                {
                                    cmd1.Parameters.AddWithValue("@itemname", itemName.Text);
                                    cmd1.Parameters.AddWithValue("@itemcatagory", catagoryName.Text);
                                    cmd1.Parameters.AddWithValue("@itemprice", price.Text);
                                    cmd1.Parameters.AddWithValue("@itemstock", stock.Text);
                                    cmd1.Parameters.AddWithValue("@itemmanufacturer", manufacturer.Text);
                                    cmd1.Parameters.AddWithValue("insert_date", today);

                                    MessageBox.Show("cmd1 run");

                                    cmd1.ExecuteNonQuery();

                                    DisplayItemdata();

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

        private void label7_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        public void categoryMenu()
        {
            ComboxDisplay comboboxlist = new ComboxDisplay();
            List<ComboxDisplay> list = comboboxlist.displayComboxItems();

            catagoryName.DisplayMember = "Itemtext";
            catagoryName.ValueMember = "ItemValue";
            catagoryName.DataSource = list;
        }


        private void catagoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            itemId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            itemName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            catagoryName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            stock.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            manufacturer.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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
    }
}
