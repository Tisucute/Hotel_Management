using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SelectEmployeeForm : Form
    {
        public SelectEmployeeForm()
        {
            InitializeComponent();
        }

        private void SelectEmployeeForm_Load(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            dgvListEmployees.DataSource = employeeBLL.getEmployeesnoUser();
        }

        private void SelectEmployeeForm_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgvListEmployees_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
