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
using BLL;
using DTO;

namespace GUI
{
    public partial class JanitorForm : Form
    {
        public JanitorForm()
        {
            InitializeComponent();
        }
        LOGIN login;
        public JanitorForm(LOGIN login)
        {
            InitializeComponent();
            this.login = login;
        }
        public void getImageAndUsername()
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            DataTable table = employeeBLL.getUserNameAndImage(login.id);
            byte[] pic = (byte[])table.Rows[0]["picture"];
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxJanitor.Image = Image.FromStream(picture);
            LabelName.Text = "Welcome, " + table.Rows[0]["fullname"].ToString().Trim();
        }
        LoginBLL loginBLL = new LoginBLL();
        private void ButtonTimeAndSalary_Click(object sender, EventArgs e)
        {
            EMPLOYEE employee = new EMPLOYEE();
            DataTable dt = loginBLL.getUserByID(login.id);
            foreach (DataRow row in dt.Rows)
            {
                employee.id = Convert.ToInt32(row["id"].ToString());
            }
            CheckinCheckoutForm check = new CheckinCheckoutForm();
            check.ShowDialog();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JanitorForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
        }
    }
}
