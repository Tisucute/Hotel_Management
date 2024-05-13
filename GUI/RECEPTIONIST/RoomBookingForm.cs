using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.IO;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class RoomBookingForm : Form
    {
        public RoomBookingForm()
        {
            InitializeComponent();
        }
        ROOM room;
        public RoomBookingForm(ROOM room)
        {
            this.room = room;
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        RoomBLL roomBLL = new RoomBLL();
        private void RoomBookingForm_Load(object sender, EventArgs e)
        {
            txtRoomID.Text = room.room_id.ToString();
            txtRoomName.Text = room.room_name.ToString();
            txtPerson.Text = room.person.ToString(); 
            txtPrice.Text = room.price.ToString();
            cmbBoxType.DataSource = roomBLL.getAllType();
            cmbBoxType.ValueMember = "type_id";
            cmbBoxType.DisplayMember = "type_name";
            cmbBoxType.SelectedValue = room.type_id;
            cmbBoxType.Enabled = false;
        }

        private void datePickerTo_ValueChanged(object sender, EventArgs e)
        {
            var from = datePickerFrom.Value.Date;
            var to = datePickerTo.Value.Date;
            var diff = to - from;
            int date = diff.Days;
            txtNight.Text = date.ToString();
        }
        
        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TextBoxSearch.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Số điện thoại phải là số!");
                TextBoxSearch.Text = "";
                return;
            }
            CustomerBLL customerBLL = new CustomerBLL();
            DataTable dt = customerBLL.getCustomersByCCCD(TextBoxSearch.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtCustomerName.Text = dt.Rows[0]["Full Name"].ToString();
                txtCCCD.Text = dt.Rows[0]["CCCD"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtNation.Text = dt.Rows[0]["Nation"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                radioBtnMale.Checked = true;
                if (dt.Rows[0]["Gender"].ToString().Trim() == "Female")
                {
                    radioBtnFemale.Checked = true;
                }
                byte[] p = (byte[])dt.Rows[0]["Image"];
                MemoryStream pic = new MemoryStream(p);
                picBox.Image = System.Drawing.Image.FromStream(pic);
            }
            else
            {
                MessageBox.Show("No information found for this customer", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
