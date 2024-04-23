using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoginAccess
    {
        SqlConnectionDatacs mydb = new SqlConnectionDatacs();
        public DataTable getUserNameandImage(int id) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = LOGIN.id;// lấy id de up thông tin
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool checkLogin()
        {
            SqlConnection conn = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @User AND password = @Pass AND role_id = @Role", conn);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = LOGIN.username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = LOGIN.password;
            command.Parameters.Add("@Role", SqlDbType.Int).Value = LOGIN.role;
            adapter.SelectCommand = command;
            conn.Open();
            adapter.Fill(table);
            LOGIN.id = Convert.ToInt32(table.Rows[0]["id"].ToString());
            if ((table.Rows.Count > 0))
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
