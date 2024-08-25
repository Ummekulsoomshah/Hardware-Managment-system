using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hardware_Managment_system
{
    internal class List_Data
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public int Price { get; set; }
        public string Stock { get; set; }
        public string Manufacturer { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");

         public List<List_Data> ItemListData()
        {
            List<List_Data> listdata = new List<List_Data>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    
                    string selectData = "SELECT * FROM Itemtbl WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            List_Data item = new List_Data
                            {
                                ItemId = (int)reader["ItemId"],
                                Name = reader["ItemName"].ToString(),
                                Catagory = reader["CatagoryName"].ToString(),
                                Price = Convert.ToInt32(reader["Price"]),
                                Stock = reader["Stock"].ToString(),
                                Manufacturer = reader["Manufacturer"].ToString()
                            };

                            listdata.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            
            return listdata; 
        }
    }
}
