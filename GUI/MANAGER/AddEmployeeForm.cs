using BLL;
using DTO;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        EmployeeBLL employeeBLL = new EmployeeBLL();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EMPLOYEE employee = new EMPLOYEE();
            employee.fullname = txtBoxFullName.Text.Trim();
            employee.birthdate = DatePicker.Value;
            employee.CCCD = txtBoxCCCD.Text.Trim();
            employee.address = txtBoxAddress.Text.Trim();
            employee.phone = txtBoxPhone.Text.Trim();
            employee.role = Convert.ToInt32(CmbBoxRole.SelectedValue.ToString());
            employee.gender = "Male";
            employee.username = txtUsername.Text.Trim();
            employee.password = txtPassword.Text.Trim();    
            MemoryStream pic = new MemoryStream();
            employee.status = "Working";
            if (RadioBtnFemale.Checked)
            {
                employee.gender = "Female";
            }
            int born_year = DatePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 15 || this_year - born_year > 100))
            {
                MessageBox.Show("Tuổi của nhân viên phải từ 18 trở lên", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verifyInput())
            {
                PictureEmployee.Image.Save(pic, PictureEmployee.Image.RawFormat);
                employee.pic = pic;
                if (employeeBLL.insertEmployee(employee))
                {
                    MessageBox.Show("Thêm thành công", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        bool verifyInput()
        {
            if ((txtBoxFullName.Text.Trim() == "") || txtBoxPhone.Text.Trim() == "" || txtBoxAddress.Text.Trim() == "" || txtBoxCCCD.Text.Trim() == "" || PictureEmployee.Image == null)
            {
                return false;
            }
            if (!IsValidAlphabetInput(txtBoxFullName.Text.Trim().Replace(" ", "")))
            {
                MessageBox.Show("Name Require A Alphabet!");
                txtBoxFullName.Text = "";
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxPhone.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Phone Require A Number!");
                txtBoxPhone.Text = "";
                return false;
            }
            if(!System.Text.RegularExpressions.Regex.IsMatch(txtBoxCCCD.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("CCCD require A Number!");
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


        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            CmbBoxRole.DataSource = employeeBLL.getAllRole();
            CmbBoxRole.DisplayMember = "role_name";
            CmbBoxRole.ValueMember = "role_id";
            RadioBtnKeepOn.Checked = true;
            RadioBtnMale.Checked = true;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image( *.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureEmployee.Image = Image.FromFile(opf.FileName);
            }
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
