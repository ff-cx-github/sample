using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VulnerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String user = args[0];
            String pwd = args[1];

            String connStr = "shdlhalhsdl";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connStr;

            String cmdText = String.Format("insert into users values({0}, {1})", user, pwd);    
            SqlCommand cmd = new SqlCommand(cmdText);

            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();



        }
    }
}
