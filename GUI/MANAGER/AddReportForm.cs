using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class AddReportForm : Form
    {
        public AddReportForm()
        {
            InitializeComponent();
        }
        //Modify modify = new Modify();
        private void AddReportForm_Load(object sender, EventArgs e)
        {
            /*reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "";
            reportData.Value = modify.Table("");
            reportViewer1.LocalReport.DataSources.Add(reportData);  
            this.reportViewer1.RefreshReport();*/
        }
    }
}
