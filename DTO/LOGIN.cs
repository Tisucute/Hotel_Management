using System;
using System.Data;
using System.IO;

namespace DTO
{
    public class LOGIN
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int role { get; set; }
        public MemoryStream pic { get; set; }
        public void fillData(DataTable table)
        {
            id = Convert.ToInt32(table.Rows[0]["employee_id"].ToString());
            fullname = table.Rows[0]["fullname"].ToString();
            username = table.Rows[0]["username"].ToString();
            password = table.Rows[0]["password"].ToString();
            role = Convert.ToInt32(table.Rows[0]["role_id"].ToString());
            byte[] tmp = (byte[])table.Rows[0]["picture"];
            pic = new MemoryStream(tmp);
        }
    }
}
