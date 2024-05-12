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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        CUSTOMERS customer = new CUSTOMERS();
        CustomerBLL customerBLL = new CustomerBLL();
        private void dgvListCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvListCustomers.CurrentRow.Cells[0].Value.ToString();
            txtID.ReadOnly = true;
            txtFullName.Text = dgvListCustomers.CurrentRow.Cells[1].Value.ToString(); ;
            txtCCCD.Text = dgvListCustomers.CurrentRow.Cells[2].Value.ToString(); ;
            txtAddress.Text = dgvListCustomers.CurrentRow.Cells[5].Value.ToString(); ;
            txtNation.Text = dgvListCustomers.CurrentRow.Cells[6].Value.ToString(); ;
            txtPhone.Text = dgvListCustomers.CurrentRow.Cells[4].Value.ToString(); ;
            if (dgvListCustomers.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                radioBtnFemale.Checked = true;
            }
            else radioBtnMale.Checked = true;


            byte[] pic;
            pic = (byte[])dgvListCustomers.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            picBox.Image = Image.FromStream(picture);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        
        public void fillGrid()
        {
            dgvListCustomers.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListCustomers.RowTemplate.Height = 60;
            dgvListCustomers.DataSource = customerBLL.getAllCustomers();
            picCol = (DataGridViewImageColumn)dgvListCustomers.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListCustomers.AllowUserToAddRows = false;
            if ((dgvListCustomers.CurrentRow.Cells[3].Value.ToString() == "Female"))
            {
                radioBtnFemale.Checked = true;
            }
            else
            {
                radioBtnMale.Checked = true;
            }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customer.name = txtFullName.Text.Trim();
            customer.CCCD = txtCCCD.Text.Trim();
            customer.address = txtAddress.Text.Trim();
            customer.phone = txtPhone.Text.Trim();
            customer.nation = txtNation.Text.Trim();
            customer.gender = "Male";
            MemoryStream pic = new MemoryStream();
            if (radioBtnFemale.Checked)
            {
                customer.gender = "Female";
            }
            
            if (verifyInput())
            {
                picBox.Image.Save(pic, picBox.Image.RawFormat);
                customer.image = pic;
                if (customerBLL.insertCustomer(customer))
                {
                    MessageBox.Show("Add Customer Successfully", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (verifyInput())
                {
                    MessageBox.Show("ERROR", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Fill The Blank", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fillGrid();
            
        }
        bool verifyInput()
        {
            if ((txtFullName.Text.Trim() == "") || txtPhone.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtCCCD.Text.Trim() == "" || picBox.Image == null)
            {
                return false;
            }
            if (!IsValidAlphabetInput(txtFullName.Text.Trim().Replace(" ", "")))
            {
                MessageBox.Show("Full Name Must Be Text!");
                txtFullName.Text = "";
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Phone Number Must Be Number!");
                txtPhone.Text = "";
                return false;
            }
            return true;
        }
        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Do You Sure To Delete This Costumer?", "Remove Customer", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    // rang buoc neu dang la nguoi dang nhap thi ko duoc xoa
                    int id = Convert.ToInt32(dgvListCustomers.CurrentRow.Cells["ID"].Value);
                    customerBLL.deleteEmployee(id);
                    MessageBox.Show("Delete Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListCustomers.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListCustomers.RowTemplate.Height = 50;
            dgvListCustomers.DataSource = customerBLL.findCustomersByName(TextBoxSearch.Text);
            picCol = (DataGridViewImageColumn)dgvListCustomers.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListCustomers.AllowUserToAddRows = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CUSTOMERS customer = new CUSTOMERS();
            customer.customer_id = Convert.ToInt32(txtID.Text);
            customer.name = txtFullName.Text.Trim();
            customer.CCCD = txtCCCD.Text.Trim();
            customer.address = txtAddress.Text.Trim();
            customer.phone = txtPhone.Text.Trim();
            customer.nation = txtNation.Text.Trim();
            customer.gender = "Male";
            MemoryStream pic = new MemoryStream();
            if (radioBtnFemale.Checked)
            {
                customer.gender = "Female";
            }
            if (verifyInput())
            {
                picBox.Image.Save(pic, picBox.Image.RawFormat);
                customer.image = pic;
                if (customerBLL.updateCustomer(customer))
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
                if ((txtFullName.Text.Trim() == "") || txtPhone.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtCCCD.Text.Trim() == "" || picBox.Image == null)
                {
                    return false;
                }
                return true;
                
            }
            fillGrid();
        }
    }
}
