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
    public class CustomerAccess
    {
        SqlConnectionData mydb = new SqlConnectionData();
        public DataTable getAllCustomers()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT customer_id as ID, name as [Full Name], CCCD, gender as Gender, phone as Phone, address as Address, nation as Nation, image as Image" +
                " FROM CUSTOMERS", mydb.getConnection);
            adapter.Fill(table);
            return table;
        }
        public DataTable getCustomersByCCCD(string CCCD)
        {
            SqlCommand command = new SqlCommand("SELECT customer_id as ID, name as [Full Name], CCCD, gender as Gender, phone as Phone, address as Address, nation as Nation, image as Image FROM CUSTOMERS WHERE CCCD = @CCCD", mydb.getConnection);
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = CCCD;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCustomersByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT customer_id as ID, name as [Full Name], CCCD, gender as Gender, phone as Phone, address as Address, nation as Nation, image as Image FROM CUSTOMERS WHERE customer_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertCustomer(CUSTOMERS customer )
        {
            SqlCommand command = new SqlCommand("INSERT INTO CUSTOMERS(name, CCCD, gender, phone, address, nation, image) VALUES (@name, @CCCD, @gender, @phone, @address, @nation,@pic)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customer.name;
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = customer.CCCD;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = customer.gender;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customer.phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customer.address;
            command.Parameters.Add("@nation", SqlDbType.VarChar).Value = customer.nation;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = customer.image.ToArray();
            
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
        public bool updateCustomer(CUSTOMERS customer)
        {
            SqlCommand command = new SqlCommand("UPDATE CUSTOMERS SET name = @name, CCCD = @cccd, gender = @gender, phone = @phone, address = @addr, nation = @nation, image = @pic WHERE customer_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = customer.customer_id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customer.name;
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = customer.CCCD;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = customer.gender;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customer.phone;
            command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = customer.address;
            command.Parameters.Add("@nation", SqlDbType.VarChar).Value = customer.nation;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = customer.image.ToArray();
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
        public bool deleteCustomer(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CUSTOMERS WHERE customer_id = @id", mydb.getConnection);
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
        public DataTable findCustomersByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT customer_id as ID, name as [Full Name], CCCD, gender as Gender, phone as Phone, address as Address, nation as Nation, image as Image FROM CUSTOMERS WHERE name LIKE N'%" + name + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
