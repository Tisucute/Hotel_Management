using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        static EmployeeAccess employeeAccess = new EmployeeAccess();
        
        public DataTable getRoleByID(int id)
        {
            return employeeAccess.getRoleByID(id);
        }
        public bool checkExistUser(string username)
        {
            return employeeAccess.checkExistUser(username);
        }
        public bool checkLogin(EMPLOYEE employee)
        {
            return employeeAccess.checkLogin(employee);
        }
        public DataTable getEmployees(string command)
        {
            return employeeAccess.getEmployees(command);   
        }
        public DataTable getEmployeesnoUser()
        {
            return employeeAccess.getEmployeesnoUser();
        }
        public DataTable getUserNameAndImage(int id)
        {
            return employeeAccess.getUserNameandImage(id);
        }
        public DataTable getEmployees()
        {
            return employeeAccess.getEmployees();
        }
        public DataTable getEmployeesWorking()
        {
            return employeeAccess.getEmployeesWorking();
        }
        public DataTable getEmployeeByID(int id)
        {
            return employeeAccess.getEmployeeByID(id);
        }
        public DataTable findEmployeesByName(string name)
        {
            return employeeAccess.findEmployeesByName(name);
        }
        public bool insertEmployee(EMPLOYEE employee)
        {
            return employeeAccess.insertEmployee(employee);
        } 
        public bool updateEmployee(EMPLOYEE employee)
        {
            return employeeAccess.updateEmployee(employee);
        }
        public bool deleteEmployee(int id)
        {
            return employeeAccess.deleteEmployee(id);
        }
        public DataTable getAllRole()
        {
            return employeeAccess.getAllRole();
        }
        public bool insertShift(int employeeID, DateTime startTime, DateTime endTime)
        {
            return employeeAccess.insertShift(employeeID, startTime, endTime);
        }
        public DataTable getShiftByTime(DateTime time)
        {
            return employeeAccess.getShiftByTime(time);
        }
        public bool checkExistShift(DateTime dateTime)
        {
            return employeeAccess.checkExistShift(dateTime);
        }
        public bool checkInTime(DateTime time, int id)
        {
            return employeeAccess.checkInTime(time, id);
        }
        public bool checkOutTime(DateTime time, int id)
        {
            return employeeAccess.checkOutTime(time, id);
        }
        public bool calculatorHour(int employeeID, DateTime time)
        {
            return  employeeAccess.calculatorHour(employeeID, time);
        }
    }
}
