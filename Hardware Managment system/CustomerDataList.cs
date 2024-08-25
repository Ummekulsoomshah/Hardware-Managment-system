using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hardware_Managment_system
{
    internal class CustomerDataList
    {
        public int CustId { get; set; }
        public string Custname { get; set; }
        public string Custgender { get; set; }
        public string Custphone { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KPPNU8U\SQLEXPRESS;Initial Catalog=HardwaremgtDB;Integrated Security=True;");



        public List<CustomerDataList> CustomerDataListing()
        {
            List<CustomerDataList> customerlistdata = new List<CustomerDataList>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM Customertbl WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomerDataList customer = new CustomerDataList
                            {
                                CustId = (int)reader["CUstId"],
                                Custname = reader["CustName"].ToString(),
                                Custgender = reader["CustGender"].ToString(),
                                Custphone = reader["Phone"].ToString()
                            };

                            customerlistdata.Add(customer);
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
            return customerlistdata;
        }


    }
}
