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
        }

        public virtual void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.qLKSDataSet.EMPLOYEES);
            fillGrid();

        }
        public void fillGrid()
        {
            dgvListEmployees.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListEmployees.RowTemplate.Height = 50;
            dgvListEmployees.DataSource = EmployeeBLL.getEmployees();
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
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm();
                editEmployeeForm.ShowDialog();
                fillGrid();
            }
            if (dgvListEmployees.CurrentCell.OwningColumn.Name == "dgvdelete")
            {
                try
                {
                    if ((MessageBox.Show("Are You Sure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        // rang buoc neu dang la nguoi dang nhap thi ko duoc xoa
                        int id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells["ID"].Value);
                        EmployeeBLL.deleteEmployee(id);
                        MessageBox.Show("Delete successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
