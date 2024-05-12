using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public DataTable getAllCustomers()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT customer_id as ID, name as [Full Name], CCCD, kind as Kind, gender as Gender, phone as Phone, address as Address, nation as Nation, image as Image" +
                " FROM CUSTOMERS", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
    }
}
