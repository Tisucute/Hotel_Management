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
            if ((this_year - born_year < 15 && this_year - born_year > 100))
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
                else if (verifyInput())
                {
                    MessageBox.Show("Lỗi", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else return true;
            }

        }
    }
}
