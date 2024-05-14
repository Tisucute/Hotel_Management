using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.SqlServer.Management.Smo.RegSvrEnum;

namespace DAL
{
    public class RoomAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public DataTable getAllType()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TYPE", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public DataTable getRoomByName(string roomName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ROOM WHERE room_name = @name", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = roomName;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
           
            adapter.Fill(table);
            return table;
        }
        public bool updateStatusRoom(int roomID, string status)
        {
            SqlCommand command = new SqlCommand("UPDATE ROOM SET status = @status WHERE room_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
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
        public bool addRoom(ROOM room)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ROOM(room_name, type_id, person, status, price, picture) VALUES (@name, @type, @person, @status, @price, @pic)", mydb.getConnection);
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
        public DataTable getAllRoom()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT *, TYPE.type_name FROM ROOM INNER JOIN TYPE ON TYPE.type_id = ROOM.type_id", mydb.getConnection);
            adapter.Fill(table);
            return table;
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
        public bool checkExistRoom(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ROOM WHERE room_name = @name", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
    }
}
