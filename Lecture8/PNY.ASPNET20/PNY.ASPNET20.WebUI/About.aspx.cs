using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PNY.ASPNET20.Application;

namespace PNY.ASPNET20.WebUI
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCountries.DataSource = new CountryHandler().GetAllCountries();
                // ddlCountries.DataBind();
                ddlCountries.DataTextField = "Name";
                ddlCountries.DataValueField = "ID";
                ddlCountries.DataBind();
            }
        }
    }
}