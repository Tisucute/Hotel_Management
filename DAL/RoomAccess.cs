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
        public bool addRoom(ROOM room)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ROOM(room_name, type, person, status, price, picture) VALUES (@name, @type, @person, @status, @price, @pic)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = room.room_name;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = room.type;
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ROOM", mydb.getConnection);
            adapter.Fill(table);
            return table;
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
