using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ADOExample
{
    public partial class CountryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conString = "Data Source=.;Initial Catalog=PNYASPBatch20;User ID=sa;Password=1234";
            string selectCountries = "Select * From Country";
            if (!IsPostBack)
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    SqlCommand command = new SqlCommand(selectCountries, connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            MessageBox.Show("Country ID = " + reader[0].ToString() + " Country Name = " + reader[1].ToString());
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}