using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SHIFTS
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string type { get; set; }

        public List<EMPLOYEE> assignEmployees { get; set; }  = new List<EMPLOYEE>();
        public void AssignEmployee(EMPLOYEE employee)
        {
            // Method to assign an employee to a shift
            WorkSession workSession = new WorkSession();
            workSession.employeeID = employee.id;
            workSession.startTime = startTime;
            employee.workSessions.Add(workSession);
            assignEmployees.Add(employee);
        }
    }
}
