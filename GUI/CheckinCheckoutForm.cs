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
using System.Windows.Forms;

namespace GUI
{
    public partial class CheckinCheckoutForm : Form
    {
        public CheckinCheckoutForm()
        {
            InitializeComponent();
            TimePicker.ShowUpDown = true;
        }
        EMPLOYEE employee = new EMPLOYEE();
        public CheckinCheckoutForm(EMPLOYEE tmp)
        {
            employee = tmp;
            InitializeComponent();
            TimePicker.ShowUpDown = true;
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void skyLabel3_Click(object sender, EventArgs e)
        {

        }

        private void CheckinCheckoutForm_Load(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Now.Date;
            txtFullName.Text = employee.fullname;
            txtBoxID.Text = employee.id.ToString();
            txtBoxCCCD.Text = employee.CCCD;
            txtBoxRole.Text = employee.roleName;
            PictureBoxEmployee.Image = Image.FromStream(employee.pic);
        }

        private void GroupBoxCheck_Click(object sender, EventArgs e)
        {

        }
        EmployeeBLL employeeBLL = new EmployeeBLL();    
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            TimeSpan hour = new TimeSpan(TimePicker.Value.Ticks);
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour.Hours, hour.Minutes, 0);
            try
            {
                if (employeeBLL.checkInTime(dateTime, Convert.ToInt32(txtBoxID.Text)))
                {
                    MessageBox.Show("Check In success", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The employee has checked in for this shift or Not during shift", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            TimeSpan hour = new TimeSpan(TimePicker.Value.Ticks);
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour.Hours, hour.Minutes, 0);
            try
            {
                if (employeeBLL.checkOutTime(dateTime, Convert.ToInt32(txtBoxID.Text)))
                {
                    MessageBox.Show("Check out success", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    employeeBLL.calculatorHour(Convert.ToInt32(txtBoxID.Text), dateTime);
                }
                else
                {
                    MessageBox.Show("The employee has checked out for this shift or Not during shift", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void skyLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
