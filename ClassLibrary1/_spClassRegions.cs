using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class _spClassRegions
    {
        DataSet ds = new DataSet();

        static string constring = Validate_Connection.ConString();
        private static SqlConnection conn = new SqlConnection(constring);



        public DataSet _MspRegions()
        {
            SqlCommand cmd = new SqlCommand("_spRegions", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "_spRegions");
            return ds;
        }
    }
}
