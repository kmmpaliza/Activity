using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class COUNTRIES_MP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _spClassCountries ce = new _spClassCountries();
            grdCountries.DataSource = ce._MspCountries().Tables["_spCountries"];
            grdCountries.DataBind();

        }
    }
}