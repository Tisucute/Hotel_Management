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
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void BtnCheckTime_Click(object sender, EventArgs e)
        {
            CheckinCheckoutForm check = new CheckinCheckoutForm();
            check.ShowDialog();
        }
    }
}
