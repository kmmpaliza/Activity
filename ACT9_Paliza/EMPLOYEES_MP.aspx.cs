using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        _spClassEmployees ce = new _spClassEmployees();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdEmployee.DataSource = ce._MspEmployees().Tables["_spEmployees"];
                grdEmployee.DataBind();
            }
        }

        protected void grdEmployee_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("NEW_EMPLOYEE.aspx");
        }

        protected void grdEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEmployee.PageIndex = e.NewPageIndex;
            grdEmployee.DataSource = ce._MspEmployees().Tables["_spEmployees"];
            grdEmployee.DataBind();
        }

        protected void grdEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var id = this.grdEmployee.DataKeys[e.NewEditIndex].Value;
            Response.Redirect("UPDATE_EMPLOYEE.aspx?id=" + id.ToString());
        }

        protected void grdEmployee_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
           // var id = this.grdEmployee.DataKeys[e.AffectedRows].Value;
           // Response.Redirect("EMPLOYEE_MP.aspx?id=" + id.ToString());


        }

        protected void grdEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = this.grdEmployee.DataKeys[e.RowIndex].Value;
            Response.Redirect("DELETE_EMPLOYEE.aspx?id=" + id.ToString());
        }
    }
}