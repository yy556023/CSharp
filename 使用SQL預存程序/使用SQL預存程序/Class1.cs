using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用SQL預存程序
{
    class Class1
    {
        private string cnStr = "Data Source=localhost;Initial Catalog=AdventureWorksDW;Integrated Security=True";
        private SqlConnection cn;
        private SqlDataAdapter da;

        public Class1()
        {
            cn = new SqlConnection(cnStr);
            da = new SqlDataAdapter();
        }

        public void getdata(CommandType ct,string command,ref DataTable dt,Dictionary<string,string> dc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = command;
            cmd.CommandType = ct;
            cmd.Connection = cn;
            foreach (KeyValuePair<string,string> item in dc)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            da.SelectCommand = cmd;
            da.Fill(dt);
        }
    }
}
