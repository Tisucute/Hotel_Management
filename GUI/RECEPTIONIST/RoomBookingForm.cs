using BLL;
using DTO;
using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            datePickerFrom.Value = DateTime.Now;
            datePickerTo.Value = DateTime.Now;
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
        int customerID;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TextBoxSearch.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("CCCD Require A Number");
                TextBoxSearch.Text = "";
                return;
            }
            CustomerBLL customerBLL = new CustomerBLL();
            DataTable dt = customerBLL.getCustomersByCCCD(TextBoxSearch.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                customerID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
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
            BookingRoomBLL bookingRoom = new BookingRoomBLL();
            RoomBLL roomBLL = new RoomBLL();
            if (verify())
            {
                int roomID = Convert.ToInt32(txtRoomID.Text);
                DateTime checkInTime = datePickerFrom.Value;
                DateTime checkOutTime = datePickerTo.Value;
                if (bookingRoom.insertBookingRoom(customerID, roomID, EMPLOYEE.emID, checkInTime, checkOutTime))
                {
                    roomBLL.updateStatusRoom(roomID, "Hire");
                    MessageBox.Show("Booking successfully!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Booking failed!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verify()
        {
            if (txtNight.Text.Trim() == "" || txtNight.Text.Trim() == "0")
            {
                MessageBox.Show("Please select an out date!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Please select customer!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
