using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNY.ASPNET20.SalesDemo.Sales
{
    public class SaleLineItem
    {
        public int ID { get; set; }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
    }
}
