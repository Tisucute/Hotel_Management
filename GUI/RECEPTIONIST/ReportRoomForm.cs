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
            reportViewer1.LocalReport.DataSources.Clear();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "DataSet1";
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportData.Value = serviceOfRoomBLL.getReportByRoomName(roomName);
            reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();

        }
    }
}
