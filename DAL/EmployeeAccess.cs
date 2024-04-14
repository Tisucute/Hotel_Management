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
        public DataTable getEmployees()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, fullname, gender, birthdate, CCCD, phone, address, role_id, status, picture FROM EMPLOYEES", mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool deleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM EMPLOYEES WHERE id = @id", mydb.getConnection);
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

        public DataTable getEmployeesByUsername(string username)
        {
            SqlCommand command = new SqlCommand("SELECT id, fullname, gender, birthdate, CCCD, phone, address, role_id, status, picture FROM EMPLOYEES WHERE username = @user ", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkLogin(EMPLOYEE employee)
        {
            SqlConnection conn = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEES WHERE username = @User AND password = @Pass AND role_id = @Role", conn);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = employee.username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = employee.password;
            command.Parameters.Add("@Role", SqlDbType.Int).Value = employee.role;
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
