using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EMPLOYEE
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime birthdate { get; set; }
        public string CCCD { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int role { get; set; }
        public string roleName { get; set; }
        public MemoryStream pic { get; set; }
        public string status { get; set; }
        public List<WorkSession> workSessions { get; set; } = new List<WorkSession>();
        public List<SHIFTS> shifts { get; set; } = new List<SHIFTS>();
        public void fillData(DataTable table)
        {
            id = Convert.ToInt32(table.Rows[0]["id"].ToString());
            fullname = table.Rows[0]["fullname"].ToString();
            gender = table.Rows[0]["gender"].ToString();
            birthdate = (DateTime)table.Rows[0]["birthdate"];
            CCCD = table.Rows[0]["CCCD"].ToString();
            address = table.Rows[0]["address"].ToString();
            phone = table.Rows[0]["phone"].ToString();
            username = table.Rows[0]["username"].ToString();
            password = table.Rows[0]["password"].ToString();    
            role = Convert.ToInt32(table.Rows[0]["role_id"].ToString());
            status = table.Rows[0]["status"].ToString();
            byte[] tmp = (byte[])table.Rows[0]["picture"];
            pic = new MemoryStream(tmp);
        }
        public void CheckIn(DateTime time)
        {
            WorkSession session = new WorkSession();
            session.startTime = time;
            workSessions.Add(session);
        }

        public void CheckOut(DateTime time)
        {
            WorkSession session = workSessions.Last();
            session.endTime = time;
            session.CalculateHours();
        }
    }    
}
