using GUI;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            manager.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
