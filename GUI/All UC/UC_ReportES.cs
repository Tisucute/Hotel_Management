using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_UC
{
    public partial class UC_ReportES : UserControl
    {
        public UC_ReportES()
        {
            InitializeComponent();
        }

        private void btnCheckTime_Click(object sender, EventArgs e)
        {
            WorkingTimeAndSalaryForm workingTimeAndSalaryForm = new WorkingTimeAndSalaryForm(); 
            workingTimeAndSalaryForm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AddReportForm addReportForm = new AddReportForm();
            addReportForm.ShowDialog();
        }
    }
}
