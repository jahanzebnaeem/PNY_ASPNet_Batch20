using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PNY.ASPNET20.Application;

namespace PNY.ASPNET20.WinUI
{
    public partial class frmCountryList : Form
    {
        public frmCountryList()
        {
            InitializeComponent();
            grdCountries.DataSource = new CountryHandler().GetAllCountries();
        }
    }
}
