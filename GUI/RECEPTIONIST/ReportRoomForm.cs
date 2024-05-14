using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RECEPTIONIST
{
    public partial class ReportRoomForm : Form
    {
        public ReportRoomForm()
        {
            InitializeComponent();
        }
        string roomName;
        public ReportRoomForm(string roomName)
        {
            this.roomName = roomName;
            InitializeComponent();
        }
        private void ReportRoomForm_Load(object sender, EventArgs e)
        {
            ServiceOfRoomBLL serviceOfRoomBLL = new ServiceOfRoomBLL();
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report2.rdlc";
            DateTime date = DateTime.Now;
            BookingRoomBLL bookingRoomBLL = new BookingRoomBLL();  
            DataTable dt = bookingRoomBLL.getBookingRoomByRoomName(roomName);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CustomerName", "Tên khách hàng: " + dt.Rows[0]["name"].ToString()));
            reportParameters.Add(new ReportParameter("Date", "Ngày lập hoá đơn " + date.ToString("dd/MM/yyyy HH:mm:ss")));
            reportParameters.Add(new ReportParameter("Room", "Phòng: " + dt.Rows[0]["room_name"].ToString()));
            reportParameters.Add(new ReportParameter("EmployeeName", "Nhân viên lập hoá đơn: " + dt.Rows[0]["fullname"].ToString()));
            reportParameters.Add(new ReportParameter("Person", "Số người: " + dt.Rows[0]["person"].ToString()));
            var diff = (DateTime)dt.Rows[0]["checkOutDate"] - (DateTime)dt.Rows[0]["checkInDate"];
            int day = diff.Days;
            reportParameters.Add(new ReportParameter("NumberOfDays", "Số ngày ở: " + day.ToString()));
            reportParameters.Add(new ReportParameter("TypeRoom", "Loại Phòng: " + dt.Rows[0]["type_name"].ToString()));
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "DataSet1";
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportData.Value = serviceOfRoomBLL.getReportByRoomName(roomName);
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();
            
            
        }
    }
}
