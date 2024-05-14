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
        public bool deleteServiceByRoomName(string roomName)
        {
            SqlCommand command = new SqlCommand("DELETE FROM SERVICES_ROOM WHERE room_name = @name", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = roomName;
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
        public bool deleteServiceByID(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM SERVICES_ROOM WHERE service_id = @id", mydb.getConnection);
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
            SqlCommand command = new SqlCommand("SELECT \r\n  SR.room_name,\r\n  S.service_name,\r\n  SR.amount,\r\n  S.price,\r\n  S.price * SR.amount as total\r\nFROM \r\n  SERVICES_ROOM SR\r\nINNER JOIN \r\n  SERVICES S ON S.service_id = SR.service_id\r\n  WHERE room_name = @name\r\nUNION ALL\r\n\r\nSELECT \r\n  room_name,\r\n  'Thuê phòng' as service_name,\r\n  DATEDIFF(DAY, RB.checkInDate, RB.checkOutDate) as amount,\r\n  R.price,\r\n  R.price * DATEDIFF(DAY, RB.checkInDate, RB.checkOutDate) as total\r\nFROM \r\n  ROOM R\r\nLEFT JOIN ROOM_BOOKING RB ON R.room_id = RB.room_id\r\nWHERE \r\n  (RB.booking_id IS NOT NULL OR RB.booking_id IS NULL) AND room_name = @name; ", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = roomName;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertReport(string roomName, string serviceName, int amount, string price, int total, DateTime date) 
        {
            SqlCommand command = new SqlCommand("INSERT INTO Payments(room_name, service_name, amount, price, total, date) VALUES(@rname, @sname, @amount, @price, @total, @date)", mydb.getConnection);
            command.Parameters.Add("@rname", SqlDbType.NVarChar).Value = roomName;
            command.Parameters.Add("@sname", SqlDbType.NVarChar).Value = serviceName;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("@total", SqlDbType.BigInt).Value = total;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;
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
