using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                using (SqlConnection connection =
            new SqlConnection(conString))
                {
                    SqlCommand command = new SqlCommand(selectCountries, connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // todo: logic to load data in class;
                        }
                        reader.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {

                    }
                }
            }
        }
    }
}