using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNY.ASPNET20.Common
{
    public class Person
    {
        public string Name { get; set; }
        public int CNIC { get; set; }
        public DateTime DoB { get; set; }
        public int Gender { get; set; }
        public string BloodGroup { get; set; }
        public Address CurrentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public ContactNumber ContactNumber { get; set; }

    }
}
