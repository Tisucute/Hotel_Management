using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RECEPTIONIST
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }
        ServiceBLL serviceBLL = new ServiceBLL();
        SERVICE service = new SERVICE();
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            fillGrid();
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
        public void fillGrid()
        {
            dgvList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvList.RowTemplate.Height = 60;
            dgvList.DataSource = serviceBLL.getAllServices();
            picCol = (DataGridViewImageColumn)dgvList.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvList.AllowUserToAddRows = false;
            
            dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvList.Columns[i].Width;

                // Remove AutoSizing:
                dgvList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvList.Columns[i].Width = colw;
            }

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
            txtID.ReadOnly = true;
            txtName.Text = dgvList.CurrentRow.Cells[1].Value.ToString(); ;
            txtPrice.Text = dgvList.CurrentRow.Cells[2].Value.ToString(); ;

            byte[] pic;
            pic = (byte[])dgvList.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            picBox.Image = Image.FromStream(picture);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service.service_id = Convert.ToInt32(txtID.Text);
            service.service_name = txtName.Text.Trim();
            service.price = txtPrice.Text.Trim();
       
            MemoryStream pic = new MemoryStream();
            
            if (verifyInput())
            {
                picBox.Image.Save(pic, picBox.Image.RawFormat);
                service.image = pic;
                if (serviceBLL.insertService(service))
                {
                    MessageBox.Show("Add Service Successfully", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (verifyInput())
                {
                    MessageBox.Show("ERROR", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Fill The Blank", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fillGrid();
        }
        bool verifyInput()
        {
            if ((txtName.Text.Trim() == "") || txtPrice.Text.Trim() == "" ||  picBox.Image == null)
            {
                return false;
            }
            if (!IsValidAlphabetInput(txtName.Text.Trim().Replace(" ", "")))
            {
                MessageBox.Show("Service Name Must Be Text!");
                txtName.Text = "";
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Price Must Be Number!");
                txtPrice.Text = "";
                return false;
            }
            return true;
        }
        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            service.service_id = Convert.ToInt32(txtID.Text);
            service.service_name = txtName.Text.Trim();
            service.price = txtPrice.Text.Trim();

            MemoryStream pic = new MemoryStream();

            if (verifyInput())
            {
                picBox.Image.Save(pic, picBox.Image.RawFormat);
                service.image = pic;
                if (serviceBLL.updateService(service))
                {
                    MessageBox.Show("Edit Information Of Customer Successfully", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (verifyInput())
                {
                    MessageBox.Show("ERROR", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            bool verifyInput()
            {
                if ((txtName.Text.Trim() == "") || txtPrice.Text.Trim() == "" || picBox.Image == null)
                {
                    return false;
                }
                return true;

            }
            fillGrid();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvList.RowTemplate.Height = 50;
            dgvList.DataSource = serviceBLL.findServicesByName(TextBoxSearch.Text);
            picCol = (DataGridViewImageColumn)dgvList.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvList.AllowUserToAddRows = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            try
            {
                if ((MessageBox.Show("Do You Sure To Delete This Service?", "Remove Service", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    int id = Convert.ToInt32(dgvList.CurrentRow.Cells["ID"].Value);
                    serviceBLL.deleteService(id);
                    MessageBox.Show("Delete Successfully", "Delete Information of Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
