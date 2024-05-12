using DTO;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServiceAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public DataTable getAllServices()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT service_id as ID, service_name as [Service Name], price as Price, image as Image" +
                " FROM SERVICES", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public DataTable getServicesByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT service_id as ID, service_name as [Service Name], price as Price, image as Image FROM SERVICES WHERE service_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertService(SERVICE service)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SERVICES( service_name, price, image) VALUES ( @name, @price ,@pic)", mydb.getConnection);
            /*command.Parameters.Add("@id", SqlDbType.Int).Value = service.service_id;*/
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = service.service_name;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = service.price;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = service.image.ToArray();

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
        public bool updateService(SERVICE service)
        {
            SqlCommand command = new SqlCommand("UPDATE SERVICES SET service_name = @name, price = @price, image = @pic WHERE service_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = service.service_id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = service.service_name;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = service.price;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = service.image.ToArray();
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
            SqlCommand command = new SqlCommand("DELETE FROM SERVICES WHERE service_id = @id", mydb.getConnection);
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
        public DataTable findServicesByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT service_id as ID, service_name as [Service Name], price as Price, image as Image FROM SERVICES  WHERE service_name LIKE N'%" + name + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
