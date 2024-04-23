using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOGIN
    {
        public static int id {  get; set; }
        public static string name { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static int role { get; set; }
        public static MemoryStream pic { get; set; }
    }
}
