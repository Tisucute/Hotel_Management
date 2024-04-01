using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffAccess
    {
        public bool checkLogin(Staff staff)
        {
            SqlConnection conn = SqlConnectionData.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @User AND password = @Pass AND permission = @Per", conn);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = staff.username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = staff.password;
            command.Parameters.Add("@Per", SqlDbType.VarChar).Value = staff.permission;
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
