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
    public class ServiceBLL
    {
        ServiceAccess serviceAccess = new ServiceAccess();
        public DataTable getAllServices()
        {
            return serviceAccess.getAllServices();
        }
        public DataTable getServicersByID(int id)
        {
            return serviceAccess.getServicesByID(id);
        }
        public bool insertService(SERVICE service)
        {
            return serviceAccess.insertService(service);
        }
        public bool updateService(SERVICE service)
        {
            return serviceAccess.updateService(service);
        }
        public bool deleteService(int id)
        {
            return serviceAccess.deleteService(id);
        }
        public DataTable findServicesByName(string name)
        {
            return serviceAccess.findServicesByName(name);
        }
    }
}
