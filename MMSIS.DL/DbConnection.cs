using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MMSIS.DL
{
    class DbConnection
    {


        public static SqlConnection GetConnection()
        {

            string connectionString =
                "Data Source = ATTIC-PC; Initial Catalog = mmsis;" +
                "Persist Security Info = True;" +
                "User ID = sa; Password = 7644691";
                 // "Data Source=localhost\\MSSQLSERVER2012;Initial Catalog=CISDB;" +
                //"Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}