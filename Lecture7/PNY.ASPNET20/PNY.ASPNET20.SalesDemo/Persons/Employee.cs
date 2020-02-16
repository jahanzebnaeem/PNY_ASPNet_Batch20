using System;
namespace PNY.ASPNET20.SalesDemo.Persons
{
    #region Using Statements
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PNY.ASPNET20.Common;
    #endregion

    /// <summary>
    /// <code>This class is used for employee's declaration</code>
    /// </summary>
    public class Employee : Person
    {
        public int EmpID { get; set; }
        public float Salary { get; set; }
    }
}
