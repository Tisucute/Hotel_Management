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

namespace GUI
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        LOGIN login = new LOGIN();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();
            login.fullname = txtBoxFullname.Text.Trim();
            login.username = txtBoxUsername.Text.Trim();
            login.password = txtBoxPass.Text.Trim();
            login.role = Convert.ToInt32(CmbBoxRole.SelectedValue.ToString());
            if (verifyInput())
            {
                if (loginBLL.checkExistUser(login.username))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (loginBLL.insertUser(login))
                {
                    MessageBox.Show("Thêm thành công", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (verifyInput())
                {
                    MessageBox.Show("Lỗi", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verifyInput()
        {
            if ((txtBoxFullname.Text.Trim() == "") || txtBoxUsername.Text.Trim() == "" || txtBoxPass.Text.Trim() == "")
            {
                return false;
            }
            if (!IsValidAlphabetInput(txtBoxFullname.Text.Trim().Replace(" ", "")))
            {
                MessageBox.Show("Tên chỉ được nhập chữ cái!");
                txtBoxFullname.Text = "";
                return false;
            }
            return true;
        }
        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }
        LoginBLL loginBLL = new LoginBLL();
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            CmbBoxRole.DataSource = loginBLL.getAllRole();
            CmbBoxRole.DisplayMember = "role_name";
            CmbBoxRole.ValueMember = "role_id";
        }


        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            SelectEmployeeForm selectEmployee = new SelectEmployeeForm();
            selectEmployee.ShowDialog();
            try
            {
                login.id = Convert.ToInt32(selectEmployee.dgvListEmployees.CurrentRow.Cells[0].Value.ToString());
                EmployeeBLL employeeBLL = new EmployeeBLL();
                DataTable dt = employeeBLL.getEmployeeByID(login.id);
                txtBoxFullname.Text = dt.Rows[0]["fullname"].ToString();
                CmbBoxRole.SelectedValue = Convert.ToInt32(dt.Rows[0]["role_id"]);
            }
            catch (Exception)
            {

            }
        }
    }
    }
