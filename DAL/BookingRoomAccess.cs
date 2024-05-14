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
            SqlCommand command = new SqlCommand("INSERT INTO ROOM_BOOKING(customer_id, room_id, employee_id, checkInDate, checkOutDate, status) VALUES (@cid, @rid, @eid, @ci, @co, @status)", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = customerID;
            command.Parameters.Add("@rid", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
            command.Parameters.Add("@ci", SqlDbType.DateTime).Value = checkInTime;
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = checkOutTime;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Hire";
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
        public DataTable getBookingRoomByRoomName(string name)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM ROOM_BOOKING " +
                "INNER JOIN ROOM ON ROOM.room_id = ROOM_BOOKING.room_id INNER JOIN CUSTOMERS ON CUSTOMERS.customer_id = ROOM_BOOKING.customer_id " +
                "INNER JOIN EMPLOYEES ON EMPLOYEES.id = ROOM_BOOKING.employee_id INNER JOIN TYPE ON TYPE.type_id = ROOM.type_id " +
                " WHERE ROOM.room_name = @name AND ROOM_BOOKING.status = 'Hire'", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getCustomerBookingRoomByRoomName(string name)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM ROOM_BOOKING " +
                "INNER JOIN ROOM ON ROOM.room_id = ROOM_BOOKING.room_id INNER JOIN CUSTOMERS CUSTOMERS.customer_id = ROOM_BOOKING.customer_id" +
                " WHERE ROOM.room_name = @name AND ROOM_BOOKING.status = 'Hire'", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public bool updateBookingRoom(DateTime dateTime , int booking_id)
        {
            SqlCommand command = new SqlCommand("UPDATE ROOM_BOOKING SET checkOutDate = @co WHERE booking_id = @id", mydb.getConnection);
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = dateTime;
            command.Parameters.Add("@id", SqlDbType.Int).Value = booking_id;
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
        public bool deleteBookingRoomByRoomID(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM ROOM_BOOKING WHERE room_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
