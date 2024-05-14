using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class RoomBLL
    {
        static RoomAccess roomAccess = new RoomAccess();
        public DataTable getAllType()
        {
            return roomAccess.getAllType();
        }

        public bool addRoom(ROOM room)
        {
            return roomAccess.addRoom(room);
        }
        
        public DataTable getAllRoom()
        {
            return roomAccess.getAllRoom();
        }
        public bool removeRoom(string name)
        {
            return roomAccess.removeRoom(name);
        }
        public DataTable getRoomByName(string name)
        {
            return roomAccess.getRoomByName(name);  
        }
        public bool updateEmployee(ROOM room)
        {
            return roomAccess.editRoom(room);
        }
        public bool updateStatusRoom(int roomId, string status)
        {
            return roomAccess.updateStatusRoom(roomId, status);
        }
        public bool checkExistRoom(string name)
        {
            return roomAccess.checkExistRoom(name);
        }
    }
}
