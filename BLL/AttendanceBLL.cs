using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AttendanceBLL
    {
        AttendanceAccess attendanceAccess = new AttendanceAccess();
        public DataTable getAttendance(DateTime dateTime)
        {
            return attendanceAccess.getAttendance(dateTime);
        }
        public double calculatorTotalHour(DateTime dateTime)
        {
            return attendanceAccess.caculatorTotalHour(dateTime);
        }   
        public double getTotalHourByEmployeeID(int employeeID, DateTime dateTime)
        {
            return attendanceAccess.getTotalHourByEmployeeID(employeeID, dateTime);
        }
        public double getSalaryOfEmployee(int employeeID)
        {
            return attendanceAccess.getSalaryOfEmployee(employeeID);
        }
        public bool insertReport(int employeeID, DateTime date, double salary, double total)
        {
            return attendanceAccess.insertReport(employeeID, date, salary, total);
        }
        public DataTable getReport(DateTime date)
        {
            return attendanceAccess.getReport(date);
        }
        public bool checkExistReport(DateTime date)
        {
            return attendanceAccess.checkExistReport(date);
        }
        public DataTable getAttendanceByEmployeeID(int employeeID, DateTime date)
        {
            return attendanceAccess.getAttendanceByEmployeeID(employeeID, date);
        }
        public DataTable getAttendanceByName(DateTime dateTime, string name)
        {
            return attendanceAccess.getAttendanceByName(dateTime, name);
        }
    }
}
