using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection GetConnection()
        {
            string strcon = @"Data Source=NOOB;Initial Catalog=QLKS;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
