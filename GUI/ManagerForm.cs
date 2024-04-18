﻿using BLL;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManagerForm : Form
    {
        private int borderSize = 2;
        public ManagerForm()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }
        string user;
        public ManagerForm(string u)
        {
            InitializeComponent();
            user = u;
        }
        bool sideBarExpand;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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
        private void MenuSideBarButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void MenuSideBar2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }
        
        //Hiện thông tin đăng nhập
        public void showInformation()
        {
            string name = EmployeeBLL.getEmployeeByUsername(user);
            LabelName.Text = name;
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            showInformation();
            SideBar.Width = SideBar.MinimumSize.Width;
            PanelHienThi.Hide();

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void ButtonTimeAndSalary_Click_1(object sender, EventArgs e)
        {
            AddControls(new WorkingTimeAndSalaryForm());
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e) //Panel TitleBar
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

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        //Event methods
        private void ManagerForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        //Private methods
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

        private void PanelHienThi_Paint(object sender, PaintEventArgs e)
        {
            
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

        private void ButtonEmployeeManagement_Click(object sender, EventArgs e)
        {
            AddControls(new EmployeeManagementForm());

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            PanelHienThi.Hide();
        }
    }
}
