using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookingRoomBLL
    {
        BookingRoomAccess bookingRoomAccess = new BookingRoomAccess();
        public bool insertBookingRoom(int customerID, int roomID, int employeeID, DateTime checkInTime, DateTime checkOutTime)
        {
            return bookingRoomAccess.insertBookingRoom(customerID, roomID, employeeID, checkInTime, checkOutTime);
        }
        public DataTable getBookingRoomByRoomName(string name)
        {
            return bookingRoomAccess.getBookingRoomByRoomName(name);
        }
        public bool updateBookingRoom(DateTime dateTime, int booking_id)
        {
            return bookingRoomAccess.updateBookingRoom(dateTime, booking_id);
        }
    }
}
