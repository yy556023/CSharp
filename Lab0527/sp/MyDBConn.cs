using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sp
{
    class MyDBConn
    {
        private string cnStr = Properties.Settings.Default.cn;
        private SqlConnection cn;
        private SqlDataAdapter da;

        public MyDBConn()
        {
            cn = new SqlConnection(cnStr);
            da = new SqlDataAdapter();
        }

        public void MyGetData(CommandType ct, string command, ref DataTable dt, Dictionary<string, string> dc)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandText = command;
            cmd.CommandType = ct;
            foreach (KeyValuePair<string,string> item in dc)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            da.SelectCommand = cmd;
            da.Fill(dt);
        }
    }
}
