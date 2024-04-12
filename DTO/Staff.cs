using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum CaLam { Sang, Chieu, Toi}
    public enum VaiTro { Manager, Receptionist, Janitor}
    public class Staff
    {
        public int id {  get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string permission { get; set; }
        public List<PhienLamViec> phienLamViecs = new List<PhienLamViec>();
    }
    public class PhienLamViec
    {
        public DateTime thoigianVao { get; set; }
        public DateTime thoigianRa {  get; set; }
        public CaLam CaLam { get; set; }
    }
}
