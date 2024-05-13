using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddReportForm : Form
    {
        public AddReportForm()
        {
            InitializeComponent();
        }
        DateTime date;
        public AddReportForm(DateTime date)
        {
            this.date = date;
            InitializeComponent();
        }
        AttendanceBLL attendanceBLL = new AttendanceBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();
        private void AddReportForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            DataTable dt = attendanceBLL.getAttendance(date);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameter1", "Ngày " + date.ToString("dd/MM/yyyy")));
            if (!attendanceBLL.checkExistReport(date))
            {
                foreach (DataRow x in dt.Rows)
                {
                    int id = Convert.ToInt32(x["ID"]);
                    CalculateAndSavePayroll(id, date);
                }
            }
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "DataSet1";
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportData.Value = attendanceBLL.getReport(date);
            reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();
        }
        public void CalculateAndSavePayroll(int employeeID, DateTime date)
        {
            double totalHoursWorked = GetTotalHoursWorked(employeeID, date);
            double hourlyRate = GetHourlyRate(employeeID);
            double earnings = totalHoursWorked * hourlyRate;
            double penalty = 0;
            if (totalHoursWorked < 8)
            {
                penalty = GetPenaltyRate(employeeID) * (8 - totalHoursWorked);
                earnings -= penalty;
            }
            attendanceBLL.insertReport(employeeID, date, earnings, totalHoursWorked);
        }

        private double GetTotalHoursWorked(int employeeID, DateTime date)
        {
            return attendanceBLL.getTotalHourByEmployeeID(employeeID, date);

        }

        private double GetHourlyRate(int employeeID)
        {
            return attendanceBLL.getSalaryOfEmployee(employeeID);
        }

        private double GetPenaltyRate(int employeeID)
        {
            DataTable dt = employeeBLL.getEmployeeByID(employeeID);
            if (Convert.ToInt32(dt.Rows[0]["role_id"]) == 2)
            {
                return 120000;
            }
            else
            {
                return 80000;
            }
        }

    }
}
