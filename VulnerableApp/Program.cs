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
            conn.Open();


            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand(cmdText);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand(cmdText);
            cmd2.Connection = conn;
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand(cmdText);
            cmd3.Connection = conn;
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand(cmdText);
            cmd4.Connection = conn;
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand(cmdText);
            cmd5.Connection = conn;
            cmd5.ExecuteNonQuery();

            conn.Close();


            Console.WriteLine("{0} - {1}", args[0], args[1]);
            Console.WriteLine("{0} - {1}", user, pwd);



        }
    }
}
