using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class _spClassJobHistory
    {
        DataSet ds = new DataSet();

        static string constring = Validate_Connection.ConString();
        private static SqlConnection conn = new SqlConnection(constring);



        public DataSet _MspJobHistory()
        {
            SqlCommand cmd = new SqlCommand("_spJobHistory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "_spJobHistory");
            return ds;
        }
    }
}
