using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace blog_feladat
{
    public class connect
    {
        public MySqlConnection connection;
        public string Host;
        public string Database;
        public string User;
        public string Password;
        public string ConnectionString;



        public connect()
        {
            Host = "localhost";
            Database = "blog";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";



            connection = new MySqlConnection(ConnectionString);
        }
    }
}
