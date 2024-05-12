using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml.Linq;

namespace DTO
{
    public class SERVICE
    {
        public int service_id {  get; set; }
        public string service_name { get; set; }
        public string price { get; set;}
        public MemoryStream image { get; set; }
        public void fillData(DataTable table)
        {
            service_id = Convert.ToInt32(table.Rows[0]["service_id"].ToString());
            service_name = table.Rows[0]["service_name"].ToString();
            price = table.Rows[0]["price"].ToString();
            byte[] tmp = (byte[])table.Rows[0]["image"];
            image = new MemoryStream(tmp);
        }
    }
}
