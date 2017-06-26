using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class _spClassEmployees
    {
        

        #region Connection String Setup
        static string constring = Validate_Connection.ConString();
        private static SqlConnection conn = new SqlConnection(constring);
        #endregion

        #region Variables
        
        DataSet ds = new DataSet();

        private string first_name, last_name, email, phone_number, hire_date, job_id;
        private int employee_id, manager_id, department_id;
        private decimal salary, commission_pct;
        #endregion


        #region Encapsulation
        public string Job_id
        {
            get { return job_id; }
            set { job_id = value; }
        }

        public string Hire_date
        {
            get { return hire_date; }
            set { hire_date = value; }
        }

        public string Phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }


        public int Department_id
        {
            get { return department_id; }
            set { department_id = value; }
        }

        public int Manager_id
        {
            get { return manager_id; }
            set { manager_id = value; }
        }

        public int Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }

        public decimal Commission_pct
        {
            get { return commission_pct; }
            set { commission_pct = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        #endregion


        public DataSet _MspEmployees()
        {
            SqlCommand cmd = new SqlCommand("_spEmployees", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "_spEmployees");
            return ds;
        }

        public DataSet _MspGetManagerInfo()
        {
            SqlCommand cmd = new SqlCommand("_spGetManagerInfo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "_spGetManagerInfo");
            return ds;
        }

        public DataSet _MspSearchEmployee()
        {
            SqlCommand cmd = new SqlCommand("_spSearchEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EMPLOYEE_ID", SqlDbType.VarChar).Value = employee_id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "_spSearchEmployee");
            return ds;
        }

        public void _MspInsertEmployee()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("_spInsertEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@first_name", SqlDbType.VarChar).Value = first_name;
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar).Value = last_name;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar).Value = phone_number;
            cmd.Parameters.Add("@hire_date", SqlDbType.VarChar).Value = hire_date;
            cmd.Parameters.Add("@job_id", SqlDbType.VarChar).Value = job_id;
            cmd.Parameters.Add("@employee_id", SqlDbType.Int).Value = Convert.ToInt32(employee_id);
            cmd.Parameters.Add("@manager_id", SqlDbType.Int).Value = Convert.ToInt32(manager_id);
            cmd.Parameters.Add("@department_id", SqlDbType.Int).Value = Convert.ToInt32(department_id);
            cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = Convert.ToDecimal(salary);
            cmd.Parameters.Add("@commission_pct", SqlDbType.Int).Value = Convert.ToInt32(commission_pct);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void _MspUpdateEmployee()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("_spUpdateEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@first_name", SqlDbType.VarChar).Value = first_name;
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar).Value = last_name;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar).Value = phone_number;
            cmd.Parameters.Add("@hire_date", SqlDbType.VarChar).Value = hire_date;
            cmd.Parameters.Add("@job_id", SqlDbType.VarChar).Value = job_id;
            cmd.Parameters.Add("@employee_id", SqlDbType.Int).Value = Convert.ToInt32(employee_id);
            cmd.Parameters.Add("@manager_id", SqlDbType.Int).Value = Convert.ToInt32(manager_id);
            cmd.Parameters.Add("@department_id", SqlDbType.Int).Value = Convert.ToInt32(department_id);
            cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = Convert.ToDecimal(salary);
            cmd.Parameters.Add("@commission_pct", SqlDbType.Decimal).Value = Convert.ToDecimal(commission_pct);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void _MspDeleteEmployee()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("_spDeleteEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@employee_id", SqlDbType.Int).Value = Convert.ToInt32(employee_id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }




    }
}
