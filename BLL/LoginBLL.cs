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

        public bool checkLogin(LOGIN login)
        {
            try
            {
                return loginAccess.checkLogin(login);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }
        public DataTable getAllUser()
        {
            return loginAccess.getAllUser();
        }
        public DataTable getUserByID(int id)
        {
            return loginAccess.getUserByID(id);
        }
        public bool deleteUser(int id)
        {
            return loginAccess.deleteUser(id);
        }
        public DataTable getAllRole()
        {
            return loginAccess.getAllRole();
        }
        public bool insertUser(LOGIN login)
        {
            return loginAccess.insertUser(login);
        }
        public bool checkExistUser(string username)
        {
            return loginAccess.checkExistUser(username);
        }
        public DataTable findUserByName(string name)
        {
            return loginAccess.findUserByName(name);
        }
    }
}
