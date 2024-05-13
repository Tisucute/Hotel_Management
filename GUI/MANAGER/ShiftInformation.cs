using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ShiftInformation : Form
    {
        public ShiftInformation()
        {
            InitializeComponent();
        }
        int employeeID;
        DateTime dateTime;
        public ShiftInformation(int id, DateTime date)
        {
            employeeID = id;
            dateTime = date;
            InitializeComponent();
        }

        AttendanceBLL attendanceBLL = new AttendanceBLL();
        private void ShiftInformation_Load(object sender, EventArgs e)
        {
            dgvListCheck.DataSource = attendanceBLL.getAttendanceByEmployeeID(employeeID, dateTime);
        }
    }
}
