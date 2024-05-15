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
    public partial class RevenueReportForm : Form
    {
        public RevenueReportForm()
        {
            InitializeComponent();
        }

        private void RevenueReportForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report3.rdlc";
            ServiceOfRoomBLL serviceOfRoomBLL = new ServiceOfRoomBLL();
            DateTime date = DateTime.Now;
            DataTable dt = serviceOfRoomBLL.getPayment(date);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Date", "Ngày " + date.ToString("dd/MM/yyyy HH:mm:ss")));
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "DataSet1";
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportData.Value = serviceOfRoomBLL.getPayment(date);
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();
        }
    }
}
