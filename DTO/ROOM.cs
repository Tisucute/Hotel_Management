using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class ROOM
    {
        public int room_id { get; set; }
        public string room_name { get; set;}
        public int type_id { get; set;}
        public int person { get; set;}
        public string status { get; set;}
        public string price { get; set;}
        public MemoryStream pic { get; set; }

        
        
    }
}
