using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNY.ASPNET20.DAL
{
    public class DBHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            string conString = @"Data Source=.;Initial Catalog=PNYASPBatch20;User ID=sa;Password=1234";
            return new SqlConnection(conString);
        }
    }
}
