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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT EMPLOYEES.id, EMPLOYEES.fullname, EMPLOYEES.gender, EMPLOYEES.birthdate, EMPLOYEES.CCCD, EMPLOYEES.address, EMPLOYEES.phone, EMPLOYEES.picture, EMPLOYEES.status, ROLE.role_id, ROLE.role_name, ROLE.salary FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id", mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeeByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT EMPLOYEES.id, EMPLOYEES.fullname, EMPLOYEES.gender, EMPLOYEES.birthdate, EMPLOYEES.CCCD, EMPLOYEES.address, EMPLOYEES.phone, EMPLOYEES.picture, EMPLOYEES.status, ROLE.role_id, ROLE.role_name, ROLE.salary FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable findEmployeesByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT EMPLOYEES.id, EMPLOYEES.fullname, EMPLOYEES.gender, EMPLOYEES.birthdate, EMPLOYEES.CCCD, EMPLOYEES.address, EMPLOYEES.phone, EMPLOYEES.picture, EMPLOYEES.status, ROLE.role_id, ROLE.role_name, ROLE.salary FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id WHERE fullname LIKE N'%" + name + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
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
        public DataTable getAllRole()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ROLE", mydb.getConnection);
            adapter.Fill(table);
            return table;

        }
        public bool insertEmployee(EMPLOYEE employee)
        {
            SqlCommand command = new SqlCommand("INSERT INTO EMPLOYEES(fullname, gender, birthdate, CCCD, address, phone, role_id, picture, status) VALUES (@name, @gender, @birthdate, @CCCD, @address, @phone, @rid, @pic, @stt)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.fullname;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employee.gender;
            command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = employee.birthdate;
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = employee.CCCD;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = employee.address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.phone;
            command.Parameters.Add("@rid", SqlDbType.Int).Value = employee.role;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = employee.pic.ToArray();
            command.Parameters.Add("@stt", SqlDbType.VarChar).Value = employee.status;
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
        public bool updateEmployee(EMPLOYEE employee)
        {
            SqlCommand command = new SqlCommand("UPDATE EMPLOYEES SET fullname = @name, gender = @gender, birthdate= @bdate, CCCD = @cccd, address = @addr, phone = @phone, role_id = @rid, picture = @pic, status = @stt WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = employee.id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.fullname;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employee.gender;
            command.Parameters.Add("@bdate", SqlDbType.NVarChar).Value = employee.birthdate;
            command.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = employee.CCCD;
            command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = employee.address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.phone;
            command.Parameters.Add("@rid", SqlDbType.Int).Value = employee.role;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = employee.pic.ToArray();
            command.Parameters.Add("@stt", SqlDbType.VarChar).Value = employee.status;
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
    }
}
