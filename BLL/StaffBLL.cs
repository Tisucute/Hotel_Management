using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffBLL
    {
        StaffAccess staffAccess = new StaffAccess();
        public bool checkLogin(Staff staff)
        {
            return staffAccess.checkLogin(staff);
        }
    }
}
