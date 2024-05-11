using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Common;

namespace DAL
{
    public class LoginAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();

        public bool checkExistUser(string username)
        {
            SqlConnection conn = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @User", conn);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;
            conn.Open();
            adapter.Fill(table);
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

        public DataTable getAllUser()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT employee_id,  LOGIN.fullname, username, password, ROLE.role_id, EMPLOYEES.picture, ROLE.role_name FROM dbo.LOGIN INNER JOIN ROLE ON ROLE.role_id = LOGIN.role_id INNER JOIN EMPLOYEES ON EMPLOYEES.id = LOGIN.employee_id", mydb.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public DataTable getUserByID(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT employee_id,  LOGIN.fullname, username, password, ROLE.role_id, EMPLOYEES.picture, ROLE.role_name FROM dbo.LOGIN INNER JOIN ROLE ON ROLE.role_id = LOGIN.role_id INNER JOIN EMPLOYEES ON EMPLOYEES.id = LOGIN.employee_id WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool deleteUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM LOGIN WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkLogin(LOGIN login)
        {
            SqlConnection conn = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @User AND password = @Pass AND role_id = @Role", conn);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = login.username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = login.password;
            command.Parameters.Add("@Role", SqlDbType.Int).Value = login.role;
            adapter.SelectCommand = command;
            conn.Open();
            adapter.Fill(table);
            login.id = Convert.ToInt32(table.Rows[0]["employee_id"].ToString());
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
        public DataTable getAllRole()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ROLE", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public bool insertUser(LOGIN login)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LOGIN(employee_id, fullname, username, password, role_id) VALUES (@id, @name, @user, @pass, @role)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = login.id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = login.fullname;
            command.Parameters.Add("@user", SqlDbType.NChar).Value = login.username;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = login.password;
            command.Parameters.Add("@role", SqlDbType.Int).Value = login.role;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        } 
        public DataTable findUserByName(string name)
        {
                SqlCommand command = new SqlCommand("SELECT id, fullname, username, password, ROLE.role_name, picture, ROLE.role_id FROM LOGIN INNER JOIN ROLE ON ROLE.role_id = LOGIN.role_id WHERE fullname LIKE N'%" + name + "%'", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
        }
    }
}
