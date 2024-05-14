using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SERVICEOFROOM
    {
        public int book_id { get; set; }
        public int service_id{ get; set; }
        public int amount { get; set; }
        public string room_name { get; set; }
        public string price { get; set; }
    }
}
