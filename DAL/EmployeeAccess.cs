using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class EmployeeAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public DataTable getRoleByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ROLE WHERE role_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkExistUser(string username)
        {
            SqlConnection conn = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEES WHERE username = @User", conn);
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
                employee.id = Convert.ToInt32(table.Rows[0]["id"].ToString());
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        public DataTable getEmployeesnoUser()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT EMPLOYEES.id, EMPLOYEES.fullname, gender, birthdate, CCCD, phone FROM LOGIN RIGHT JOIN EMPLOYEES ON EMPLOYEES.id = LOGIN.employee_id WHERE EMPLOYEES.id NOT IN (  SELECT employee_id   FROM LOGIN);", mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployees(string command) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command, mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployees()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT EMPLOYEES.id, EMPLOYEES.fullname, EMPLOYEES.gender, EMPLOYEES.birthdate, EMPLOYEES.CCCD, EMPLOYEES.address, EMPLOYEES.phone, EMPLOYEES.picture, EMPLOYEES.status, ROLE.role_id, ROLE.role_name, ROLE.salary FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id", mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeesWorking()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT EMPLOYEES.id, EMPLOYEES.fullname, EMPLOYEES.gender, EMPLOYEES.birthdate, EMPLOYEES.CCCD, EMPLOYEES.address, EMPLOYEES.phone, EMPLOYEES.picture, EMPLOYEES.status, ROLE.role_id, ROLE.role_name, ROLE.salary FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id WHERE status = 'Working'", mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getUserNameandImage(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEES WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeeByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT EMPLOYEES.id, EMPLOYEES.fullname, EMPLOYEES.gender, EMPLOYEES.birthdate, EMPLOYEES.username, EMPLOYEES.password, EMPLOYEES.CCCD, EMPLOYEES.address, EMPLOYEES.phone, EMPLOYEES.picture, EMPLOYEES.status, ROLE.role_id, ROLE.role_name, ROLE.salary FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id WHERE id = @id", mydb.getConnection);
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
            SqlCommand command = new SqlCommand("INSERT INTO EMPLOYEES(fullname, gender, birthdate, CCCD, address, phone, role_id, picture, status, username, password) VALUES (@name, @gender, @birthdate, @CCCD, @address, @phone, @rid, @pic, @stt, @user, @pass)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.fullname;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employee.gender;
            command.Parameters.Add("@birthdate", SqlDbType.Date).Value = employee.birthdate;
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = employee.CCCD;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = employee.address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.phone;
            command.Parameters.Add("@rid", SqlDbType.Int).Value = employee.role;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = employee.pic.ToArray();
            command.Parameters.Add("@stt", SqlDbType.VarChar).Value = employee.status;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = employee.username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = employee.password;
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
            SqlCommand command = new SqlCommand("UPDATE EMPLOYEES SET fullname = @name, gender = @gender, birthdate= @bdate, CCCD = @cccd, address = @addr, phone = @phone, role_id = @rid, picture = @pic, status = @stt, username = @user, password = @pass WHERE id = @id", mydb.getConnection);
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
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = employee.username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = employee.password;
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
        public bool insertShift(int employeeID, DateTime startTime, DateTime endTime)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ATTENDANCE(employee_id, ScheduledStartTime, ScheduledEndTime) VALUES (@eid, @st, @et)", mydb.getConnection);

            command.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
            command.Parameters.Add("@st", SqlDbType.DateTime).Value = startTime;
            command.Parameters.Add("@et", SqlDbType.DateTime).Value = endTime;
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
        public DataTable getShiftByTime(DateTime dateTime)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT EMPLOYEES.id as [ID], EMPLOYEES.fullname as [Full Name], EMPLOYEES.gender as [Gender], EMPLOYEES.birthdate as [Birthdate], EMPLOYEES.CCCD as [CCCD], EMPLOYEES.phone as [Phone], ROLE.role_name as [Role],  EMPLOYEES.status as [Status],  EMPLOYEES.picture as [Picture] FROM EMPLOYEES INNER JOIN ROLE ON EMPLOYEES.role_id = ROLE.role_id INNER JOIN ATTENDANCE ON ATTENDANCE.employee_id = EMPLOYEES.id WHERE ATTENDANCE.ScheduledStartTime = @time", mydb.getConnection);
            command.Parameters.Add("@time", SqlDbType.VarChar).Value = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;

        }
        public bool checkExistShift(DateTime dateTime)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ATTENDANCE WHERE ScheduledStartTime = @time", mydb.getConnection);
            command.Parameters.Add("@time", SqlDbType.VarChar).Value = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            mydb.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool checkInTime(DateTime dateTime, int employeeID)
        {
            SqlCommand command = new SqlCommand("UPDATE ATTENDANCE SET CheckInTime = @CheckInTime WHERE employee_id = @eid AND CAST(ScheduledStartTime AS DATE) = CAST(@CheckInTime AS DATE) AND ScheduledStartTime <= @CheckInTime AND ScheduledEndTime >= @CheckInTime AND CheckInTime IS NULL", mydb.getConnection);
            command.Parameters.AddWithValue("@eid", employeeID);
            command.Parameters.AddWithValue("@CheckInTime", dateTime);
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
        public bool checkOutTime(DateTime dateTime, int employeeID)
        {

            SqlCommand command = new SqlCommand("UPDATE ATTENDANCE SET checkOutTime = @CheckInTime WHERE employee_id = @eid AND CAST(ScheduledStartTime AS DATE) = CAST(@CheckInTime AS DATE) AND ScheduledStartTime <= @CheckInTime AND ScheduledEndTime >= @CheckInTime AND checkOutTime IS NULL AND checkInTime IS NOT NULL", mydb.getConnection);
            command.Parameters.AddWithValue("@eid", employeeID);
            command.Parameters.AddWithValue("@CheckInTime", dateTime);
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
        public bool calculatorHour(int employeeID, DateTime dateTime)
        {
            
            SqlCommand command = new SqlCommand("UPDATE ATTENDANCE SET hoursWorked = DATEDIFF(second, checkInTime, checkOutTime) / 3600.0 FROM ATTENDANCE WHERE  employee_id = @eid and CAST(ScheduledStartTime AS DATE) = CAST(@checkInTime AS DATE) AND ScheduledStartTime <= @checkInTime AND ScheduledEndTime >= @checkInTime", mydb.getConnection);
            command.Parameters.AddWithValue("@eid", employeeID);
            command.Parameters.AddWithValue("@CheckInTime", dateTime);
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
