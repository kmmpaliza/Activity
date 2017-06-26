using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class NEW_EMPLOYEE : System.Web.UI.Page
    {
        _spClassEmployees cc = new _spClassEmployees();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drpMngrId.DataSource = cc._MspGetManagerInfo().Tables["_spGetManagerInfo"];
                drpMngrId.DataTextField = "employee_id";
                drpMngrId.DataValueField = "department_id";
                drpMngrId.DataBind();
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDeptId.Text = Convert.ToString(drpMngrId.SelectedItem.Value);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EMPLOYEES_MP.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           cc.Employee_id = Convert.ToInt32(txtEmployeeId.Text);
            cc.First_name = txtFirstName.Text;
            cc.Last_name = txtLname.Text;
            cc.Email = txtEmail.Text;
            cc.Phone_number = txtPhoneNum.Text;
            cc.Hire_date = txtHireDate.Text;
            cc.Job_id = txtJobID.Text;
            cc.Salary = Convert.ToDecimal(txtSalary.Text);
            cc.Commission_pct = Convert.ToDecimal(txtCommission.Text);
            cc.Manager_id = Convert.ToInt32(drpMngrId.SelectedItem.Text);
            cc.Department_id = Convert.ToInt32(txtDeptId.Text);

            cc._MspInsertEmployee();
            Response.Redirect("EMPLOYEES_MP.aspx");

            
        }
    }
}