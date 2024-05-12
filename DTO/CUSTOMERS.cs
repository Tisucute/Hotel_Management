using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CUSTOMERS
    {
        public int customer_id { get; set; }
        public string name { get; set;}
        public string CCCD { get; set; }
        public string kind { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string nation { get; set; }
        public MemoryStream image { get; set; }

    }
}
