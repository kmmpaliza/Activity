using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class LOCATIONS_MP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _spClassLocations ce = new _spClassLocations();

            grdLocations.DataSource = ce._MspLocations().Tables["_spLocations"];
            grdLocations.DataBind();
        

        }
    }
}