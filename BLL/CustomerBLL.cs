using DAL;
using DTO;
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
        public DataTable getCustomersByID(int id)
        {
            return customerAccess.getCustomersByID(id);
        }
        public bool insertCustomer(CUSTOMERS customer)
        {
            return customerAccess.insertCustomer(customer);
        }
        public bool updateCustomer(CUSTOMERS customer)
        {
            return customerAccess.updateCustomer(customer);
        }
        public bool deleteEmployee(int id)
        {
            return customerAccess.deleteCustomer(id);
        }
        public DataTable findCustomersByName(string name)
        {
            return customerAccess.findCustomersByName(name);
        }
        public DataTable getCustomersByCCCD(string cccd)
        {
            return customerAccess.getCustomersByCCCD(cccd);
        }
    }
}
