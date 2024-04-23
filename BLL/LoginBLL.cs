using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        LoginAccess loginAccess = new LoginAccess();
        public DataTable getUserNameandImage(int id)
        {
            return loginAccess.getUserNameandImage(id);
        }
        public bool checkLogin()
        {
            try
            {
                return loginAccess.checkLogin();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }
        
    }
}
