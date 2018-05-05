using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    class DBConnection
    {
        SqlConnection connection;
        string connString;

        public DBConnection()
        {
            connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection = new SqlConnection(connString);
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Open();
            }
        }
    }
}
