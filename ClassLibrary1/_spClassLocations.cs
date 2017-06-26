using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class _spClassLocations
    {
        DataSet ds = new DataSet();

        static string constring = Validate_Connection.ConString();
        private static SqlConnection conn = new SqlConnection(constring);



        public DataSet _MspLocations()
        {
            SqlCommand cmd = new SqlCommand("_spLocations", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "_spLocations");
            return ds;
        }
    }
}
