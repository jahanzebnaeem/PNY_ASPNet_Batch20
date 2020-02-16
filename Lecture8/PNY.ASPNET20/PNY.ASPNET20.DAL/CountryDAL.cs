using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PNY.ASPNET20.Common;

namespace PNY.ASPNET20.DAL
{
    public class CountryDAL
    {
        private readonly string getAllCountries = "Select * from Country";

        public List<Country> GetAllCountries()
        {
            SqlConnection sqlConnection = DBHelper.GetSqlConnection();
            SqlCommand sqlCommand = new SqlCommand(getAllCountries, sqlConnection);
            SqlDataReader sqlDataReader = null;
            List<Country> countries = null;
            sqlConnection.Open();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                countries = new List<Country>();
                while (sqlDataReader.Read())
                {
                    Country country = new Country(Convert.ToString(sqlDataReader["Name"].ToString()), Convert.ToInt32(sqlDataReader["ID"].ToString()));
                    countries.Add(country);
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
                if (countries != null)
                {
                    countries.TrimExcess();
                }
            }
            return countries;
        }
    }
}
