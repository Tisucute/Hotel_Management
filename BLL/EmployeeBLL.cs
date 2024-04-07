using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        static EmployeeAccess employee = new EmployeeAccess();
        public static bool checkLogin(EMPLOYEE emp)
        {
            try
            {
                return employee.checkLogin(emp);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
            

        }

    }
}
