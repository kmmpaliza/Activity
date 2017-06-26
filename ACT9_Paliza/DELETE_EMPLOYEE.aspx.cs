using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class DELETE_EMPLOYEE : System.Web.UI.Page
    {
        _spClassEmployees cc = new _spClassEmployees();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drpMngrId.DataSource = cc._MspGetManagerInfo().Tables["_spGetManagerInfo"];
                drpMngrId.DataTextField = "Employee_id";
                drpMngrId.DataValueField = "Department_id";
                drpMngrId.DataBind();
            }



            if (Request.QueryString["id"] != null && IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                txtEmployeeId.Text = id.ToString();
                cc.Employee_id = id;
                txtFirstName.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][1].ToString();
                txtLname.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][2].ToString();
                txtEmail.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][3].ToString();
                txtPhoneNum.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][4].ToString();
                txtHireDate.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][5].ToString();
                txtJobID.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][6].ToString();
                txtSalary.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][7].ToString();

                txtCommission.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][8].ToString();
                drpMngrId.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][9].ToString();
                txtDeptId.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][10].ToString();
            }      
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

            cc._MspDeleteEmployee();
            Response.Redirect("EMPLOYEES_MP.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDeptId.Text = Convert.ToString(drpMngrId.SelectedItem.Value);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EMPLOYEES_MP.aspx");
        }
    }
}