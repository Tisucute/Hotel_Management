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
    public class ServiceOfRoomAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public bool insertService(SERVICEOFROOM service)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SERVICES_ROOM( book_id, service_name, amount, room_name, price) VALUES ( @bid, @service ,@amount, @room, @price)", mydb.getConnection);
            command.Parameters.Add("@bid", SqlDbType.Int).Value = service.book_id;
            command.Parameters.Add("@service", SqlDbType.NVarChar).Value = service.service_name;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = service.amount;
            command.Parameters.Add("@room", SqlDbType.NVarChar).Value = service.room_name;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = service.price;

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
        public DataTable getAllServiceOfRoom()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT book_id as [Booking ID], service_name as [Service Name], room_name as [Room Name], amount as Amount, price as Price" +
                " FROM SERVICES_ROOM", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllServices()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT SERVICES.service_id, SERVICES.service_name " +
                " FROM SERVICES", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public DataTable getRoomNameByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT ROOM.room_name FROM ROOM INNER JOIN ROOM_BOOKING ON ROOM_BOOKING.room_id = ROOM.room_id WHERE ROOM_BOOKING.booking_id = @id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllBookID()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT booking_id " +
                " FROM ROOM_BOOKING", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
    }
}
