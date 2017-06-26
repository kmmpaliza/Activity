using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class DEPARTMENT_MP : System.Web.UI.Page
    {
        _spClassDepartments ce = new _spClassDepartments();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdDepartment.DataSource = ce._MspDepartments().Tables["_spDepartments"];
            grdDepartment.DataBind();
        }
    }
}