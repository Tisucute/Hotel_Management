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
       
        public DataTable getEmployees()
        {
            return employeeAccess.getEmployees();
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
       
    }
}
