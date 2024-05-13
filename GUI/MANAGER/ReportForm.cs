using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void BtnEmployeeSalary_Click(object sender, EventArgs e)
        {
            panelMoving.Left = BtnEmployeeSalary.Left + 42;
            uC_ReportES1.Visible = true;
            uC_ReportES1.BringToFront();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            uC_ReportES1.Visible = false;
            uC_ReportRS1.Visible = false;
            BtnEmployeeSalary.PerformClick();
        }

        private void btnRoomService_Click(object sender, EventArgs e)
        {
            panelMoving.Left = BtnEmployeeSalary.Left + 465;
            uC_ReportRS1.Visible= true;
            uC_ReportRS1.BringToFront();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
