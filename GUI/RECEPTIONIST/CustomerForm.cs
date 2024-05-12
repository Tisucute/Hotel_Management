using BLL;
using DTO;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void dgvListCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CUSTOMERS customer = new CUSTOMERS();
            int id = Convert.ToInt32(dgvListCustomers.CurrentRow.Cells[0].Value.ToString());
            DataTable table = customerBLL.getEmployeeByID(id);
            customer.fillData(table);
            fillGrid();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        CustomerBLL customerBLL = new CustomerBLL();
        public void fillGrid()
        {
            dgvListCustomers.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListCustomers.RowTemplate.Height = 60;
            dgvListCustomers.DataSource = customerBLL.getAllCustomers();
            picCol = (DataGridViewImageColumn)dgvListCustomers.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListCustomers.AllowUserToAddRows = false;
            dgvListCustomers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListCustomers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvListCustomers.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvListCustomers.Columns[i].Width;

                // Remove AutoSizing:
                dgvListCustomers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvListCustomers.Columns[i].Width = colw;
            }
            
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image( *.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = System.Drawing.Image.FromFile(opf.FileName);
            }
        }
    }
}
