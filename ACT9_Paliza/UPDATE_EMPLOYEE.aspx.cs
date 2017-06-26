using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace ACT9_Paliza
{
    public partial class UPDATE_EMPLOYEE : System.Web.UI.Page
    {
        _spClassEmployees cc = new _spClassEmployees();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drpMngrId1.DataSource = cc._MspGetManagerInfo().Tables["_spGetManagerInfo"];
                drpMngrId1.DataTextField = "Employee_id";
                drpMngrId1.DataValueField = "Department_id";
                drpMngrId1.DataBind();
            }



            if (Request.QueryString["id"] != null && IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                txtEmployeeId1.Text = id.ToString();
                cc.Employee_id = id;
                txtFirstName1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][1].ToString();
                txtLname1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][2].ToString();
                txtEmail1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][3].ToString();
                txtPhoneNum1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][4].ToString();
                txtHireDate1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][5].ToString();
                txtJobID1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][6].ToString();
                txtSalary1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][7].ToString();
                
                txtCommission1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][8].ToString();
                drpMngrId1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][9].ToString();
                txtDeptId1.Text = cc._MspSearchEmployee().Tables["_spSearchEmployee"].Rows[0][10].ToString();
            }      
                


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            cc.Employee_id = Convert.ToInt32(txtEmployeeId1.Text);
            cc.First_name = txtFirstName1.Text;
            cc.Last_name = txtLname1.Text;
            cc.Email = txtEmail1.Text;
            cc.Phone_number = txtPhoneNum1.Text;
            cc.Hire_date = txtHireDate1.Text;
            cc.Job_id = txtJobID1.Text;
            cc.Salary = Convert.ToDecimal(txtSalary1.Text);


            cc.Commission_pct = Convert.ToDecimal(txtCommission1.Text);
            cc.Manager_id = Convert.ToInt32(drpMngrId1.SelectedItem.Text);
            cc.Department_id = Convert.ToInt32(txtDeptId1.Text);

            cc._MspUpdateEmployee();
            Response.Redirect("EMPLOYEES_MP.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EMPLOYEES_MP.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtDeptId1.Text = Convert.ToString(drpMngrId1.SelectedItem.Value);
        }
    }
}