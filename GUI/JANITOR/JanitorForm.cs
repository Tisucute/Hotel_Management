using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.Padding = new Padding(borderSize);
        }
        EMPLOYEE login;
        private int borderSize = 2;
        bool sideBarExpand;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public JanitorForm(EMPLOYEE login)
        {
            InitializeComponent();
            this.login = login;
        }
        public void getImageAndUsername()
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            DataTable table = employeeBLL.getUserNameAndImage(EMPLOYEE.emID);
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
            AddControls(check);
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JanitorForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                //ì sidebar is expand, minimize
                SideBar.Width -= 253;
                if (SideBar.Width <= SideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    SideBarTimer.Stop();

                }
            }
            else
            {
                SideBar.Width += 253;
                if (SideBar.Width >= SideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    SideBarTimer.Stop();

                }
            }
        }

        private void MenuSideBar2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Tắt border của form
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                // Khôi phục border khi form không phải là maximum
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        public void AddControls(Form f)
        {
            PanelHienThi.Show();
            PanelHienThi.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            PanelHienThi.Controls.Add(f);
            f.Show();
            PanelHienThi.BringToFront();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PanelHienThi.Hide();
        }
    }
}
