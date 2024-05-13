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
        EMPLOYEE login;
        public JanitorForm(EMPLOYEE login)
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
            LabelName.Text = "Xin chào, " + table.Rows[0]["fullname"].ToString().Trim();
        }
        private void ButtonTimeAndSalary_Click(object sender, EventArgs e)
        {
            EMPLOYEE employee = new EMPLOYEE();
            EmployeeBLL employeeBLL = new EmployeeBLL();
            DataTable dt = employeeBLL.getEmployeeByID(login.id);
            foreach (DataRow row in dt.Rows)
            {
                employee.id = Convert.ToInt32(row["id"].ToString());
                employee.fullname = row["fullname"].ToString();
                employee.CCCD = row["CCCD"].ToString().Trim();
                employee.roleName = row["role_name"].ToString();
                byte[] tmp = (byte[])row["picture"];
                employee.pic = new MemoryStream(tmp);
                employee.role = Convert.ToInt32(row["role_id"].ToString());
            }
            CheckinCheckoutForm check = new CheckinCheckoutForm(employee);
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
