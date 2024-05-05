using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkSession
    {
        public int employeeID {  get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public double hoursWorked { get; set; }
        //public void CheckIn(DateTime time)
        //{
        //    startTime = time;
        //}

        //public void CheckOut(DateTime time)
        //{
        //    endTime = time;
        //    CalculateHours();
        //}
        public void CalculateHours()
        {
            hoursWorked = (endTime - startTime).TotalHours;
        }
    }
}
