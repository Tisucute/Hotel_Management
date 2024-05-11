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
    }
}
