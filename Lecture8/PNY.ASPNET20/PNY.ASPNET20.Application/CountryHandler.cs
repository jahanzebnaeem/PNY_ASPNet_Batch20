using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNY.ASPNET20.Common;
using PNY.ASPNET20.DAL;

namespace PNY.ASPNET20.Application
{
    public class CountryHandler
    {
        public List<Country> Countries { get; set; }

        public CountryHandler () { }

        public List<Country> GetAllCountries()
        {
            return new CountryDAL().GetAllCountries();
        }
    }
}
