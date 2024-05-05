using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class ShiftScheduler
    {
        private List<EMPLOYEE> employees;
        private List<SHIFTS> shifts;
        public ShiftScheduler(List<EMPLOYEE> employees, DateTime datetime)
        {
            this.employees = new List<EMPLOYEE>();
            this.employees = employees;
            shifts = new List<SHIFTS>();
            InitializeShifts(datetime);
        }
        public void InitializeShifts(DateTime datetime)
        {
            // Ví dụ, khởi tạo các ca làm việc cho một ngày cụ thể
            DateTime startOfTheDay = new DateTime(datetime.Year, datetime.Month, datetime.Day, 7, 0, 0); // bắt đầu từ 0h ngày hôm nay

            // Tạo ca làm việc 4 tiếng mỗi ca
            for (int i = 0; i < 24; i += 4)
            {
                SHIFTS shift = new SHIFTS()
                {
                    startTime = startOfTheDay.AddHours(i),
                    endTime = startOfTheDay.AddHours(i + 4),
                    assignEmployees = new List<EMPLOYEE>() // Khởi tạo danh sách rỗng của những nhân viên được phân ca
                };
                shifts.Add(shift);
            }
        }
        public List<SHIFTS> AssignShift()
        {
            AssignManagerShifts();
            AutoAssignShifts();
            return shifts;
        }
        private bool CanAssign(EMPLOYEE employee, SHIFTS shift)
        {
            if (shift.startTime.TimeOfDay < new TimeSpan(19, 0, 0) && shift.startTime.TimeOfDay >= new TimeSpan(7, 0, 0))
            {
                if (employee.role == 1)
                {
                    // Kiểm tra xem nhân viên đã đủ 2 ca làm trong ngày chưa
                    int shiftsToday = employee.workSessions.Count(s => s.startTime.Date == shift.startTime.Date);
                    if (shiftsToday >= 2)
                    {
                        // Nhân viên đã đủ ca làm cho hôm nay
                        return false;
                    }
                    if (employee.shifts.Any(s => s.startTime < shift.endTime && s.endTime > shift.startTime))
                    {
                        // Nhân viên đang ở trong ca làm khác
                        return false;
                    }
                    var lastShift = employee.workSessions.OrderByDescending(s => s.endTime).FirstOrDefault();
                    if (lastShift != null && (shift.startTime - lastShift.endTime).TotalHours < 4)
                    {
                        // Khoảng cách giữa 2 ca làm quá ngắn
                        return false;
                    }
                    int currentStaffInShift = shift.assignEmployees.Count(s => s.role == 1 && s.workSessions.Count(e => e.startTime.Date == shift.startTime.Date) > 0);
                    int maxStaffPerShift = 1; // Số lượng nhân viên tối đa cho mỗi ca 4 tiếng
                    if (currentStaffInShift >= maxStaffPerShift)
                    {
                        // Ca làm đã đầy
                        return false;
                    }
                }
                else if (employee.role == 2)
                {
                    // Kiểm tra xem nhân viên đã đủ 2 ca làm trong ngày chưa
                    int shiftsToday = employee.workSessions.Count(s => s.startTime.Date == shift.startTime.Date);
                    if (shiftsToday >= 2)
                    {
                        // Nhân viên đã đủ ca làm cho hôm nay
                        return false;
                    }

                    // Kiểm tra số lượng nhân viên trong ca làm hiện tại
                    int currentStaffInShift = shift.assignEmployees.Count(s => s.role == 2 && s.workSessions.Count(e => e.startTime.Date == shift.startTime.Date) > 0);
                    int maxStaffPerShift = 2; // Số lượng nhân viên tối đa cho mỗi ca 4 tiếng
                    if (currentStaffInShift >= maxStaffPerShift)
                    {
                        // Ca làm đã đầy
                        return false;
                    }
                }
                else
                {
                    // Kiểm tra xem nhân viên đã đủ 2 ca làm trong ngày chưa
                    int shiftsToday = employee.workSessions.Count(s => s.startTime.Date == shift.startTime.Date);
                    if (shiftsToday >= 2)
                    {
                        // Nhân viên đã đủ ca làm cho hôm nay
                        return false;
                    }

                    // Kiểm tra số lượng nhân viên trong ca làm hiện tại
                    int currentStaffInShift = shift.assignEmployees.Count(s => s.role == 3 && s.workSessions.Count(e => e.startTime.Date == shift.startTime.Date) > 0);
                    int maxStaffPerShift = 4; // Số lượng nhân viên tối đa cho mỗi ca 4 tiếng
                    if (currentStaffInShift >= maxStaffPerShift)
                    {
                        // Ca làm đã đầy
                        return false;
                    }
                }

            }
            else if (shift.startTime.TimeOfDay >= new TimeSpan(19, 0, 0) || shift.startTime.TimeOfDay < new TimeSpan(7, 0, 0))
            {
                if (employee.role == 1 || employee.role == 2)
                {
                    // Kiểm tra xem nhân viên đã đủ 2 ca làm trong ngày chưa
                    DateTime adjustedStartTime = shift.startTime.TimeOfDay < new TimeSpan(7, 0, 0) ? shift.startTime.Date.AddDays(-1) : shift.startTime.Date;

                    // Đếm số ca trong "ngày làm việc" đã điều chỉnh
                    int shiftsToday = employee.workSessions.Count(s =>
                    {
                        DateTime sAdjustedStartTime = s.startTime.TimeOfDay < new TimeSpan(7, 0, 0) ? s.startTime.Date.AddDays(-1) : s.startTime.Date;
                        return sAdjustedStartTime == adjustedStartTime;
                    });
                    if (shiftsToday >= 2)
                    {
                        // Nhân viên đã đủ ca làm cho hôm nay
                        return false;
                    }


                    // Kiểm tra số lượng nhân viên trong ca làm hiện tại
                    int currentStaffInShift = shift.assignEmployees.Count(s => s.role == 1 || s.role == 2);
                    int maxStaffPerShift = 1; // Số lượng nhân viên tối đa cho mỗi ca 4 tiếng
                    if (currentStaffInShift >= maxStaffPerShift)
                    {
                        // Ca làm đã đầy
                        return false;
                    }
                }
                else if (employee.role == 3)
                {
                    DateTime adjustedStartTime = shift.startTime.TimeOfDay < new TimeSpan(7, 0, 0) ? shift.startTime.Date.AddDays(-1) : shift.startTime.Date;

                    // Đếm số ca trong "ngày làm việc" đã điều chỉnh
                    int shiftsToday = employee.workSessions.Count(s =>
                    {
                        DateTime sAdjustedStartTime = s.startTime.TimeOfDay < new TimeSpan(7, 0, 0) ? s.startTime.Date.AddDays(-1) : s.startTime.Date;
                        return sAdjustedStartTime == adjustedStartTime;
                    });
                    if (shiftsToday >= 2)
                    {
                        // Nhân viên đã đủ ca làm cho hôm nay
                        return false;
                    }

                    // Kiểm tra số lượng nhân viên trong ca làm hiện tại
                    int currentStaffInShift = shift.assignEmployees.Count(s => s.role == 3);

                    int maxStaffPerShift = 1; // Số lượng nhân viên tối đa cho mỗi ca 4 tiếng
                    if (currentStaffInShift >= maxStaffPerShift)
                    {
                        // Ca làm đã đầy
                        return false;
                    }
                }
            }
            return true;
        }
        private void AssignManagerShifts()
        {
            var random = new Random();
            var managers = employees.Where(e => e.role == 1).ToList();
            foreach (var shift in shifts)
            {
                foreach (var employee in managers.OrderBy(x => random.Next()))
                {
                    if (CanAssign(employee, shift))
                    {
                        shift.AssignEmployee(employee);
                    }
                }
            }
        }

        private void AutoAssignShifts()
        {
            var currentDate = DateTime.Now;
            var random = new Random();
            var receptionists = employees.Where(e => e.role == 2).ToList();
            var janitor = employees.Where(e => e.role == 3).ToList();

            foreach (var shift in shifts)
            {
                // Randomly select an employee to assign to this shift
                foreach (var x in receptionists.OrderBy(x => random.Next()))
                {
                    if (CanAssign(x, shift))
                    {
                        shift.AssignEmployee(x);
                    }
                }

                foreach (var x in janitor.OrderBy(x => random.Next()))
                {
                    if (CanAssign(x, shift))
                    {
                        shift.AssignEmployee(x);
                    }
                }
            }
        }
    }
}