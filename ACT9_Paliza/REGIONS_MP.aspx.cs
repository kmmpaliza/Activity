using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class REGIONS_MP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _spClassRegions ce = new _spClassRegions();

            grdRegions.DataSource = ce._MspRegions().Tables["_spRegions"];
            grdRegions.DataBind();

        }
    }
}