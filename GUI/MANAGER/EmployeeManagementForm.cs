using BLL;
using DTO;
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
    public partial class EmployeeManagementForm : Form
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        public virtual void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            fillGrid();
        }

        public virtual void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListEmployees.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListEmployees.RowTemplate.Height = 50;
            dgvListEmployees.DataSource = employeeBLL.findEmployeesByName(TextBoxSearch.Text);
            picCol = (DataGridViewImageColumn)dgvListEmployees.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListEmployees.AllowUserToAddRows = false;
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.qLKSDataSet.EMPLOYEES);
            fillGrid();

        }
        EmployeeBLL employeeBLL = new EmployeeBLL();
        public void fillGrid()
        {
            dgvListEmployees.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListEmployees.RowTemplate.Height = 60;
            dgvListEmployees.DataSource = employeeBLL.getEmployees();
            picCol = (DataGridViewImageColumn)dgvListEmployees.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListEmployees.AllowUserToAddRows = false;
            // Dem nhan vien
            // labelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        private void dgvListEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvListEmployees.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                EMPLOYEE employee = new EMPLOYEE();
                int id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells[0].Value.ToString());
                DataTable table = employeeBLL.getEmployeeByID(id);
                employee.fillData(table);
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employee);
                editEmployeeForm.ShowDialog();
                fillGrid();
            }
            if (dgvListEmployees.CurrentCell.OwningColumn.Name == "dgvdelete")
            {
                try
                {
                    if ((MessageBox.Show("Bạn chắc chắn muốn xoá nhân viên này?", "Remove Employees", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        // rang buoc neu dang la nguoi dang nhap thi ko duoc xoa
                        int id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells["ID"].Value);
                        employeeBLL.deleteEmployee(id);
                        MessageBox.Show("Xoá thành công", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
