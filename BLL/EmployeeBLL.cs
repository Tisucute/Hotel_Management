using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        static EmployeeAccess employeeAccess = new EmployeeAccess();
       
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
        public bool insertShift(int employeeID, DateTime checkInTime)
        {
            return employeeAccess.insertShift(employeeID, checkInTime);
        }
        public DataTable getShiftByTime(DateTime time)
        {
            return employeeAccess.getShiftByTime(time);
        }
        public bool checkExistShift(DateTime dateTime)
        {
            return employeeAccess.checkExistShift(dateTime);
        }

    }
}
