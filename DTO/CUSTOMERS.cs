using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DTO
{
    public class CUSTOMERS
    {
        public int customer_id { get; set; }
        public string name { get; set;}
        public string CCCD { get; set; }
        
        public string phone { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string nation { get; set; }
        public MemoryStream image { get; set; }

        public void fillData(DataTable table)
        {
            customer_id = Convert.ToInt32(table.Rows[0]["customer_id"].ToString());
            name = table.Rows[0]["name"].ToString();
            CCCD = table.Rows[0]["CCCD"].ToString();
            gender = table.Rows[0]["gender"].ToString();
            phone = table.Rows[0]["phone"].ToString();
            address = table.Rows[0]["address"].ToString();
            
            nation = table.Rows[0]["nation"].ToString();
            byte[] tmp = (byte[])table.Rows[0]["image"];
            image = new MemoryStream(tmp);
        }

    }
}
