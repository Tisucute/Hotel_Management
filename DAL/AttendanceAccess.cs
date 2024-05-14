using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AttendanceAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public DataTable getAttendanceByEmployeeID(int empID, DateTime dateTime)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT employee_id as [ID], fullname as [Full Name], checkInTime, checkOutTime FROM ATTENDANCE INNER JOIN EMPLOYEES ON EMPLOYEES.id = ATTENDANCE.employee_id WHERE employee_id = @eid AND ScheduledStartTime >= @st AND ScheduledEndTime <= @et", mydb.getConnection);
            command.Parameters.Add("eid", SqlDbType.Int).Value = empID;
            command.Parameters.Add("@st", SqlDbType.VarChar).Value = dateTime.ToString("yyyy-MM-dd 00:00:00");
            command.Parameters.Add("@et", SqlDbType.VarChar).Value = dateTime.ToString("yyyy-MM-dd 23:59:59");
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable getAttendance(DateTime dateTime)
        {

            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT DISTINCT id as [ID], fullname as [Full Name], CCCD, ROLE.role_name as [Role], SUM(hoursWorked) as [Hour Worked] FROM ATTENDANCE INNER JOIN EMPLOYEES ON EMPLOYEES.id = ATTENDANCE.employee_id INNER JOIN ROLE ON ROLE.role_id = EMPLOYEES.role_id  WHERE ROLE.role_id IN (2, 3) AND ScheduledStartTime >= @st AND ScheduledEndTime <= @et GROUP BY id, fullname, CCCD, ROLE.role_name", mydb.getConnection);
            command.Parameters.Add("st", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 00:00:00");
            command.Parameters.Add("et", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 23:59:59");
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public double caculatorTotalHour(DateTime dateTime)
        {
            SqlCommand command = new SqlCommand("SELECT SUM(hoursWorked) as total FROM ATTENDANCE WHERE ScheduledStartTime >= @st AND ScheduledEndTime <= @et", mydb.getConnection);
            DataTable dataTable = new DataTable();
            command.Parameters.Add("st", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 00:00:00");
            command.Parameters.Add("et", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 23:59:59");
            mydb.openConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            double total = 0;
            if (dataTable.Rows.Count > 0)
            {
                total = Convert.ToDouble(dataTable.Rows[0]["total"].ToString());
            }
            dataAdapter.Fill(dataTable);
            return total;
        }
        public double getTotalHourByEmployeeID(int empID, DateTime dateTime)
        {
            SqlCommand command = new SqlCommand("SELECT SUM(hoursWorked) as total FROM ATTENDANCE WHERE employee_id = @id AND ScheduledStartTime >= @st AND ScheduledEndTime <= @et", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = empID;
            command.Parameters.Add("@st", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 00:00:00");
            command.Parameters.Add("@et", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 23:59:59");
            mydb.openConnection();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            double total = 0;
            if (dataTable.Rows[0]["total"] != null || dataTable.Rows[0]["total"] != "")
            {
                total = Convert.ToDouble(dataTable.Rows[0]["total"]);
            }
            return total;
        }
        public double getSalaryOfEmployee(int employeeID)
        {
            SqlCommand command = new SqlCommand("SELECT id, ROLE.salary as salary FROM EMPLOYEES INNER JOIN ROLE ON ROLE.role_id = EMPLOYEES.role_id WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = employeeID;
            mydb.openConnection();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            return Convert.ToDouble(dataTable.Rows[0]["salary"]);
        }
        public bool insertReport(int employeeID, DateTime date, double salary, double total)
        {
            SqlCommand command = new SqlCommand("INSERT INTO REPORTS(employee_id, date, salary, hourWorked) VALUES (@eid, @date, @salary, @total)", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;
            command.Parameters.Add("@salary", SqlDbType.Float).Value = salary;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;
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
        public DataTable getReport(DateTime date)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT EMPLOYEES.id, fullname, CCCD, hourWorked as total, salary FROM REPORTS INNER JOIN EMPLOYEES ON EMPLOYEES.id = REPORTS.employee_id WHERE Date = @date", mydb.getConnection);
            command.Parameters.Add("date", SqlDbType.Date).Value = date.Date;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool checkExistReport(DateTime date)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT EMPLOYEES.id, fullname, CCCD, salary FROM REPORTS INNER JOIN EMPLOYEES ON EMPLOYEES.id = REPORTS.employee_id WHERE Date = @date", mydb.getConnection);
            command.Parameters.Add("date", SqlDbType.Date).Value = date.Date;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }
        public DataTable getAttendanceByName(DateTime dateTime, string name)
        {

            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT DISTINCT id as [ID], fullname as [Full Name], CCCD, ROLE.role_name as [Role], SUM(hoursWorked) as [Hour Worked] FROM ATTENDANCE INNER JOIN EMPLOYEES ON EMPLOYEES.id = ATTENDANCE.employee_id INNER JOIN ROLE ON ROLE.role_id = EMPLOYEES.role_id  WHERE ROLE.role_id IN (2, 3) AND ScheduledStartTime >= @st AND ScheduledEndTime <= @et AND fullname LIKE N'%" + name + "%' GROUP BY id, fullname, CCCD, ROLE.role_name", mydb.getConnection);
            command.Parameters.Add("st", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 00:00:00");
            command.Parameters.Add("et", SqlDbType.DateTime).Value = dateTime.ToString("yyyy-MM-dd 23:59:59");
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
