using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RECEPTIONIST
{
    public partial class ReturnRoomForm : Form
    {
        public ReturnRoomForm()
        {
            InitializeComponent();
        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            DelayRoomForm delayRoomForm = new DelayRoomForm();
            delayRoomForm.ShowDialog();
        }
    }
}
