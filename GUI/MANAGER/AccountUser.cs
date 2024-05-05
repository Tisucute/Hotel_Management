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

namespace GUI
{
    public partial class AccountUserForm : Form
    {
        public AccountUserForm()
        {
            InitializeComponent();
        }
        LOGIN login = new LOGIN();
        public AccountUserForm(LOGIN tmp)
        {
            login = tmp;
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            fillGrid();
        }

        private void dgvListEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        LoginBLL loginBLL = new LoginBLL();
        public void fillGrid()
        {
            dgvListEmployees.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListEmployees.RowTemplate.Height = 60;
            dgvListEmployees.DataSource = loginBLL.getAllUser();
            picCol = (DataGridViewImageColumn)dgvListEmployees.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListEmployees.AllowUserToAddRows = false;
            // Dem nhan vien
            // labelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }
        private void AccountUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSetLogin.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.qLKSDataSetLogin.LOGIN);
            fillGrid();
        }

        private void dgvListEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListEmployees.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                LOGIN login = new LOGIN();
                int id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells[0].Value.ToString());
                DataTable table = loginBLL.getUserByID(id);
                login.fillData(table);
                EditUserForm editUserForm = new EditUserForm(login);
                editUserForm.ShowDialog();
                fillGrid();
            }
            if (dgvListEmployees.CurrentCell.OwningColumn.Name == "dgvdelete")
            {
                try
                {
                    int id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells["ID"].Value);
                    if (id == login.id)
                    {
                        MessageBox.Show("Không thể xoá tài khoản đang sử dụng để thao tác", "Remove Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if ((MessageBox.Show("Bạn chắc chắn muốn xoá tài khoản này?", "Remove Account", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        loginBLL.deleteUser(id);
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

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListEmployees.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListEmployees.RowTemplate.Height = 50;
            dgvListEmployees.DataSource = loginBLL.findUserByName(TextBoxSearch.Text);
            picCol = (DataGridViewImageColumn)dgvListEmployees.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListEmployees.AllowUserToAddRows = false;
        }
    }
}
