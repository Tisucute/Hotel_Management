using BLL;
using DTO;
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

namespace GUI.RECEPTIONIST
{
    public partial class ReturnRoomForm : Form
    {
        public ReturnRoomForm()
        {
            InitializeComponent();
        }
        ROOM room;
        public ReturnRoomForm(ROOM room)
        {
            this.room = room;
            InitializeComponent();
        }
        private void btnDelay_Click(object sender, EventArgs e)
        {
            DelayRoomForm delayRoomForm = new DelayRoomForm();
            delayRoomForm.ShowDialog();
        }
        int customerID;
        int bookingID;
        private void ReturnRoomForm_Load(object sender, EventArgs e)
        {
            BookingRoomBLL bookingRoomBLL = new BookingRoomBLL();
            DataTable dt = bookingRoomBLL.getBookingRoomByRoomName(room.room_name);
            RoomBLL roomBLL = new RoomBLL();
            bookingID = Convert.ToInt32(dt.Rows[0]["booking_id"].ToString());
            datePickerFrom.Value = (DateTime)dt.Rows[0]["checkInDate"];
            datePickerTo.Value = (DateTime)dt.Rows[0]["checkOutDate"];
            txtRoomID.Text = room.room_id.ToString();
            txtRoomName.Text = room.room_name.ToString();
            txtPerson.Text = room.person.ToString();
            txtPrice.Text = room.price.ToString();
            cmbBoxType.DataSource = roomBLL.getAllType();
            cmbBoxType.ValueMember = "type_id"; 
            cmbBoxType.DisplayMember = "type_name";
            cmbBoxType.SelectedValue = room.type_id;
            cmbBoxType.Enabled = false;
            EmployeeBLL employeeBLL = new EmployeeBLL();
            DataTable dt2 = employeeBLL.getEmployeeByID(Convert.ToInt32(dt.Rows[0]["employee_id"]));
            txtEmployee.Text = "Booking By " + dt2.Rows[0]["fullname"].ToString();
            var from = datePickerFrom.Value.Date;
            var to = datePickerTo.Value.Date;
            var diff = to - from;
            int date = diff.Days;
            txtNight.Text = date.ToString();
            CustomerBLL customerBLL = new CustomerBLL();
            int cusID = Convert.ToInt32(dt.Rows[0]["customer_id"].ToString());
            DataTable dt1 = customerBLL.getCustomersByID(cusID);
            if (dt1.Rows.Count > 0)
            {
                customerID = Convert.ToInt32(dt1.Rows[0]["ID"].ToString());
                txtCustomerName.Text = dt1.Rows[0]["Full Name"].ToString();
                txtCCCD.Text = dt1.Rows[0]["CCCD"].ToString();
                txtAddress.Text = dt1.Rows[0]["Address"].ToString();
                txtNation.Text = dt1.Rows[0]["Nation"].ToString();
                txtPhone.Text = dt1.Rows[0]["Phone"].ToString();
                radioBtnMale.Checked = true;
                if (dt1.Rows[0]["Gender"].ToString().Trim() == "Female")
                {
                    radioBtnFemale.Checked = true;
                }
                byte[] p = (byte[])dt1.Rows[0]["Image"];
                MemoryStream pic = new MemoryStream(p);
                picBox.Image = System.Drawing.Image.FromStream(pic);
            }
            else
            {
                MessageBox.Show("No information found for this customer", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var timeOut = datePickerTo.Value.Date;
            var diff = now - timeOut;
            int date = diff.Days;
            if (date > 0)
            {
                datePickerTo.Value = now; 
                MessageBox.Show("This room is past the check out deadline " + date + " Days. " + "So Check out time has been set to Today", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookingRoomBLL bookingRoomBLL = new BookingRoomBLL();
                bookingRoomBLL.updateBookingRoom(datePickerTo.Value, bookingID);
            }
        }
    }
}
