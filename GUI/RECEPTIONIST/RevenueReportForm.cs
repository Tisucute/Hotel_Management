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
            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }
    }
}
