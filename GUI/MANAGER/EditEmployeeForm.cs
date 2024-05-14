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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }
        EMPLOYEE employee = new EMPLOYEE();
        public EditEmployeeForm(EMPLOYEE tmp) 
        {
            employee = tmp;
            InitializeComponent();
        }
        EmployeeBLL employeeBLL = new EmployeeBLL();
        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            txtBoxFullName.Text = employee.fullname;
            txtBoxID.Text = employee.id.ToString();
            txtBoxID.ReadOnly = true;
            txtBoxCCCD.Text = employee.CCCD;
            txtBoxAddress.Text = employee.address;
            txtUsername.Text = employee.username;
            txtPassword.Text = employee.password;
            txtBoxPhone.Text = employee.phone;
            DatePicker.Value = employee.birthdate;
            if (employee.gender.Trim() == "Male")
            {
                RadioBtnMale.Checked = true;
            }
            else RadioBtnFemale.Checked = true; 
            if (employee.status.Trim() == "Working")
            {
                RadioBtnKeepOn.Checked = true;
            }
            else RadioBtnQuit.Checked = true;
            PictureBoxEmployee.Image = System.Drawing.Image.FromStream(employee.pic);
            CmbBoxRole.DataSource = employeeBLL.getAllRole();
            CmbBoxRole.DisplayMember = "role_name";
            CmbBoxRole.ValueMember = "role_id";
            CmbBoxRole.SelectedValue = employee.role;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            EMPLOYEE employee = new EMPLOYEE();
            employee.id = Convert.ToInt32(txtBoxID.Text);
            employee.fullname = txtBoxFullName.Text.Trim();
            employee.birthdate = DatePicker.Value;
            employee.CCCD = txtBoxCCCD.Text.Trim();
            employee.address = txtBoxAddress.Text.Trim();
            employee.phone = txtBoxPhone.Text.Trim();
            employee.username = txtUsername.Text.Trim();
            employee.password = txtPassword.Text.Trim();
            employee.role = Convert.ToInt32(CmbBoxRole.SelectedValue.ToString());
            employee.gender = "Male";
            MemoryStream pic = new MemoryStream();
            employee.status = "Working";
            if (RadioBtnQuit.Checked)
            {
                employee.status = "Quit";
            }
            if (RadioBtnFemale.Checked)
            {
                employee.gender = "Female";
            }
            int born_year = DatePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 15 || this_year - born_year > 100))
            {
                MessageBox.Show("The employee age must be between 10 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verifyInput())
            {
                PictureBoxEmployee.Image.Save(pic, PictureBoxEmployee.Image.RawFormat);
                employee.pic = pic;
                if (employeeBLL.updateEmployee(employee))
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            bool verifyInput()
            {
                if ((txtBoxFullName.Text.Trim() == "") || txtBoxPhone.Text.Trim() == "" || txtBoxAddress.Text.Trim() == "" || txtBoxCCCD.Text.Trim() == "" || PictureBoxEmployee.Image == null)
                {
                    return false;
                }
                if (!IsValidAlphabetInput(txtBoxFullName.Text.Trim().Replace(" ", "")))
                {
                    MessageBox.Show("Tên chỉ được nhập chữ cái!");
                    txtBoxFullName.Text = "";
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxPhone.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
                {
                    MessageBox.Show("Số điện thoại phải là số!");
                    txtBoxPhone.Text = "";
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxCCCD.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
                {
                    MessageBox.Show("CCCD phải là số!");
                    txtBoxCCCD.Text = "";
                    return false;
                }
                if (!Regex.IsMatch(txtBoxCCCD.Text.Trim(), @"^\d{12}$"))
                {
                    MessageBox.Show("CCCD require 12 numbers!");
                    return false;
                }
                return true;
            }
            bool IsValidAlphabetInput(string input)
            {
                // Sử dụng biểu thức chính quy để kiểm tra
                return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
            }

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image( *.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxEmployee.Image = System.Drawing.Image.FromFile(opf.FileName);
            }
        }
    }
}
