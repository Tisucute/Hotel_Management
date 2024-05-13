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
    
    public partial class ucRooms : UserControl
    {
        public ucRooms()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        public event EventHandler DeleteClicked;
        public event EventHandler BookClicked;
        public event EventHandler ReceiveClicked;
        public event EventHandler EditClicked;
        public event EventHandler SelectClicked;
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (labelStatus.Text == "Hire")
            {
                RadioBtnStatus.Hide();
                btnBook.Hide();

            }


        }
        
        public int room_id { get; set; }
        public int person { get; set; }
        public string status
        {
            get { return labelStatus.Text;}
            set { labelStatus.Text = value; }

            
        }

        public string type 
        { 
            get { return labelKind.Text; }
            set { labelKind.Text = value; }
            
        }
        public string room_name
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }
        public string Pprice { get; set; }
        public Image Ppicture
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void RadioBtnStatus_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
           ReceiveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void labelKind_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            SelectClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
