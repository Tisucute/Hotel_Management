using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookingRoomAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public bool insertBookingRoom(int customerID, int roomID, int employeeID, DateTime checkInTime, DateTime checkOutTime)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ROOM_BOOKING(customer_id, room_id, employee_id, checkInDate, checkOutDate) VALUES (@cid, @rid, @eid, @ci, @co)", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = customerID;
            command.Parameters.Add("@rid", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
            command.Parameters.Add("@ci", SqlDbType.DateTime).Value = checkInTime;
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = checkOutTime;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool editRoom(ROOM room)
        {
            SqlCommand command = new SqlCommand("UPDATE ROOM SET room_name = @name, type_id = @type, person = @person, status = @status, price = @price, picture = @pic WHERE room_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = room.room_id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = room.room_name;
            command.Parameters.Add("@type", SqlDbType.Int).Value = room.type_id;
            command.Parameters.Add("@person", SqlDbType.Int).Value = room.person;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = room.status;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = room.price;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = room.pic.ToArray();

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool removeRoom(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM ROOM WHERE room_name = @name", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
