using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class EmployeeAccess
    {
        SqlConnectionDatacs mydb = new SqlConnectionDatacs();
        public bool checkLogin(EMPLOYEE employee)
        {
            SqlConnection conn = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @User AND password = @Pass AND role = @Role", conn);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = employee.username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = employee.password;
            command.Parameters.Add("@Role", SqlDbType.VarChar).Value = employee.role;
            adapter.SelectCommand = command;
            conn.Open();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
