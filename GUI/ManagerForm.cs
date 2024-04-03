using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManagerForm : Form
    {
        bool sideBarExpand;
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                //ì sidebar is expand, minimize
                SideBar.Width -= 200;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 200;
                if (SideBar.Width == SideBar.MaximumSize.Width)
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
    }
}
