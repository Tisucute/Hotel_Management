using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerAccess customerAccess = new CustomerAccess();
        public DataTable getAllCustomers()
        {
            return customerAccess.getAllCustomers();
        }

    }
}
