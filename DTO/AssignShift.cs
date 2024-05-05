using System;
using System.Collections.Generic;
using System.Linq;

namespace DTO
{
    public class AssignShift
    {
        public int id { get; set; }
        public int employeeID { get; set; }
        public DateTime startTime { get; set; }
        public DateTime? endTime { get; set; }

            public class WorkDayController
            {
                private List<EMPLOYEE> workSessions = new List<EMPLOYEE>();

                public void StartShiftForEmployee(int employeeId)
                {
                    var workSession = new WorkSession
                    {
                         = employeeId,
                        ClockInTime = DateTime.Now,
                        ClockOutTime = null
                    };
                    workSessions.Add(workSession);
                    // Additional logic
                }

                public void EndShiftForEmployee(int employeeId)
                {
                    var session = workSessions.FirstOrDefault(s => s.EmployeeID == employeeId && !s.ClockOutTime.HasValue);
                    if (session != null)
                    {
                        session.ClockOutTime = DateTime.Now;
                    }
                    // Additional logic
                }
            }

            public class SalaryCalculator
            {
                // Giả sử lương theo giờ là một hằng số hoặc có thể tìm từ thông tin nhân viên
                private const decimal HourlyRate = 10.00m;

                public decimal CalculateSalary(int employeeId, List<WorkSession> workSessions)
                {
                    var employeeSessions = workSessions.Where(s => s.== employeeId);
                    decimal totalSalary = 0;

                    foreach (var session in employeeSessions)
                    {
                        TimeSpan workDuration = (session.ClockOutTime ?? DateTime.Now) - session.ClockInTime;
                        decimal hoursWorked = (decimal)workDuration.TotalHours;
                        totalSalary += hoursWorked * HourlyRate;

                        // Trừ lương nếu làm dưới 8 giờ hoặc thưởng nếu làm thêm
                        if (hoursWorked < 8)
                        {
                            // Penalty logic
                        }
                        else if (hoursWorked > 8)
                        {
                            // Overtime logic
                        }
                    }

                    return totalSalary;
                }
            }

            public class DailyOperations
            {
                private WorkDayController workDayController = new WorkDayController();
                private SalaryCalculator salaryCalculator = new SalaryCalculator();

                public void PerformDailyOperations()
                {
                    // Loop through employees and start their shifts
                    foreach (var employee in Employees)
                    {
                        // Start shift logic
                    }

                    // End of day: loop through employees to end shifts and calculate salaries
                    foreach (var employee in Employees)
                    {
                        // End shift logic
                        decimal salary = salaryCalculator.CalculateSalary(employee.id, workDayController.workSessions);
                        // Log or display the salary
                    }
                }
            }
        }
    }
}
