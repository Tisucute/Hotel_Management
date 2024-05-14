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
    public partial class UC_ReportES : UserControl
    {
        public UC_ReportES()
        {
            InitializeComponent();
        }
        
        private void btnCheckTime_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells["ID"].Value);
                DateTime dateTime = DatePicker.Value;
                ShiftInformation shiftInformation = new ShiftInformation(id, dateTime);
                shiftInformation.Show();
            }
            catch 
            {
                MessageBox.Show("Please Enter A Employee!", "Check Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AddReportForm addReportForm = new AddReportForm(DatePicker.Value);
            addReportForm.ShowDialog();
        }
        AttendanceBLL attendanceBLL = new AttendanceBLL();
        private void UC_ReportES_Load(object sender, EventArgs e)
        {
            double total = Math.Round(attendanceBLL.calculatorTotalHour(DatePicker.Value), 2);
            dgvListEmployees.DataSource = attendanceBLL.getAttendance(DatePicker.Value);
            labelTotalTime.Text = "Total Time: " + total  + " Hours";
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListEmployees.DataSource = attendanceBLL.getAttendanceByName(DatePicker.Value, TextBoxSearch.Text.Trim());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvListEmployees.DataSource = attendanceBLL.getAttendanceByName(DatePicker.Value, TextBoxSearch.Text.Trim());
        }
    }
}
