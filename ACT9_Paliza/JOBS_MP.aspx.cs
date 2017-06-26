using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class JOBS_MP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _spClassJobs ce = new _spClassJobs();
            grdJobs.DataSource = ce._MspJobs().Tables["_spJobs"];
            grdJobs.DataBind();
        }
    }
}