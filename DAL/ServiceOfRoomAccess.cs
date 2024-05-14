using DTO;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ServiceOfRoomAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public bool insertService(SERVICEOFROOM service)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SERVICES_ROOM(book_id, service_id, amount, room_name, price) VALUES ( @bid, @service ,@amount, @room, @price)", mydb.getConnection);
            command.Parameters.Add("@bid", SqlDbType.Int).Value = service.book_id;
            command.Parameters.Add("@service", SqlDbType.Int).Value = service.service_id;
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
        public bool deleteService(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM SERVICES_ROOM WHERE id = @id", mydb.getConnection);
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
        public DataTable getAllServiceOfRoom()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, book_id as [Booking ID], service_name as [Service Name], room_name as [Room Name], amount as Amount, SERVICES.price * amount as [Total Price] FROM SERVICES_ROOM INNER JOIN SERVICES ON SERVICES.service_id = SERVICES_ROOM.service_id", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllServiceOfRoomByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT id, book_id as [Booking ID], service_name as [Service Name], room_name as [Room Name], amount as Amount, SERVICES.price * amount as [Total Price] FROM SERVICES_ROOM INNER JOIN SERVICES ON SERVICES.service_id = SERVICES_ROOM.service_id WHERE book_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
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
        public DataTable getServiceByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SERVICES WHERE service_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getServiceByRoom(string name)
        {
            SqlCommand command = new SqlCommand("SELECT booking_id FROM ROOM INNER JOIN ROOM_BOOKING ON ROOM_BOOKING.room_id = ROOM.room_id WHERE ROOM.room_name = @name ", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
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
        public DataTable getReportByRoomName(string roomName)
        {
            SqlCommand command = new SqlCommand("SELECT SERVICES_ROOM.room_name,  SERVICES.service_name,\r\n  SERVICES_ROOM.amount,\r\n  SERVICES.price,\r\n  SERVICES.price * SERVICES_ROOM.amount as total\r\nFROM \r\n  SERVICES_ROOM\r\n" +
                "INNER JOIN \r\n  SERVICES ON SERVICES.service_id = SERVICES_ROOM.service_id WHERE SERVICES_ROOM.room_name = @name UNION ALL\r\n\r\nSELECT DISTINCT\r\n  SERVICES_ROOM.room_name,\r\n  'Thuê phòng' as service_name,\r\n  DATEDIFF(DAY, checkInDate, checkOutDate) as amount,\r\n  ROOM.price,\r\n  ROOM.price * DATEDIFF(DAY, checkInDate, checkOutDate) as total\r\nFROM \r\n  ROOM_BOOKING\r\nINNER JOIN ROOM ON ROOM.room_id = ROOM_BOOKING.room_id\r\n" +
                "INNER JOIN SERVICES_ROOM ON SERVICES_ROOM.room_name = ROOM.room_name\r\nWHERE \r\n  booking_id IN (SELECT DISTINCT book_id FROM SERVICES_ROOM WHERE SERVICES_ROOM.room_name = @name ); ", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = roomName;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertReport(string roomName, string serviceName, int amount, string price, int total) 
        {
            SqlCommand command = new SqlCommand("INSERT INTO Report_Room(room_name, service_name, amount, price, total) VALUES(@rname, @sname, @amount, @price, @total", mydb.getConnection);
            command.Parameters.Add("@rname", SqlDbType.Int).Value = roomName;
            command.Parameters.Add("@sname", SqlDbType.Int).Value = serviceName;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("@total", SqlDbType.BigInt).Value = total;

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
