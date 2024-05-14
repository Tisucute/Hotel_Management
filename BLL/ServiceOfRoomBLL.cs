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
        public DataTable getRoomNameByID(int id)
        {
            return serviceOfRoomAccess.getRoomNameByID(id);
        }
        public DataTable getAllBookID()
        {
            return serviceOfRoomAccess.getAllBookID();
        }
    }
}
