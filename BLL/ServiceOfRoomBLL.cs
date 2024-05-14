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
    public class ServiceOfRoomBLL
    {
        ServiceOfRoomAccess serviceOfRoomAccess = new ServiceOfRoomAccess();
        public bool insertService(SERVICEOFROOM service)
        {
            return serviceOfRoomAccess.insertService(service);
        }
        public DataTable getAllServiceOfRoom()
        {
            return serviceOfRoomAccess.getAllServiceOfRoom();
        }
        public DataTable getAllServices()
        {
            return serviceOfRoomAccess.getAllServices();
        }
        public DataTable getServiceByRoom(string name)
        {
            return serviceOfRoomAccess.getServiceByRoom(name);
        }
        public DataTable getAllBookID()
        {
            return serviceOfRoomAccess.getAllBookID();
        }
        public DataTable getServiceByID(int id)
        {
            return serviceOfRoomAccess.getServiceByID(id);
        }
        public DataTable getAllServiceOfRoomByID(int id)
        {
            return serviceOfRoomAccess.getAllServiceOfRoomByID(id);
        }
        public bool deleteService(int id)
        {
            return serviceOfRoomAccess.deleteService(id);
        }
        public DataTable getReportByRoomName(string roomName)
        {
            return serviceOfRoomAccess.getReportByRoomName(roomName);
        }
        public bool insertReport(string roomName, string serviceName, int amount, string price, int total)
        {
            return serviceOfRoomAccess.insertReport(roomName, serviceName, amount, price, total);
        }
    }
}
