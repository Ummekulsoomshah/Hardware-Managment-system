using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Managment_system
{
    internal class ComboxDisplay
    {
        public string Itemtext { get; set; }
        public int ItemValue { get; set; }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");





        public List<ComboxDisplay> displayComboxItems()
        {
            List<ComboxDisplay> Menu = new List<ComboxDisplay>();
            if(connect.State!=ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string query = "SELECT CategoryID, CatagoryName FROM Category";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // Assuming combobox is named cbCategory
                            ComboxDisplay item=new ComboxDisplay
                            { 
                                   Itemtext = reader["CatagoryName"].ToString(),
                                    ItemValue = Convert.ToInt32(reader["CategoryId"])
                             };

                            Menu.Add(item);

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
            return Menu;

        }
    }
}
