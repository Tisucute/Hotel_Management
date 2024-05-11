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
            txtFullName.Text = employee.fullname;
            txtBoxID.Text = employee.id.ToString();
            txtBoxCCCD.Text = employee.CCCD;
            txtBoxRole.Text = employee.roleName;
            PictureBoxEmployee.Image = Image.FromStream(employee.pic);
        }
    }
}
