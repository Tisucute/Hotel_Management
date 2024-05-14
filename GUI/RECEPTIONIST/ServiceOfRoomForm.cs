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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.RECEPTIONIST
{
    public partial class ServiceOfRoomForm : Form
    {
        public ServiceOfRoomForm()
        {
            InitializeComponent();
        }
        string roomName = "";
        public ServiceOfRoomForm(string name)
        {
            roomName = name;    
            InitializeComponent();
        }
        ServiceOfRoomBLL serviceOfRoomBLL = new ServiceOfRoomBLL();
        private void skyLabel3_Click(object sender, EventArgs e)
        {

        }

        private void skyLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            SERVICEOFROOM service = new SERVICEOFROOM();
            service.room_name = roomName;
            service.book_id = Convert.ToInt32(txtBookID.Text.Trim());
            service.amount = Convert.ToInt32(txtAmount.Text.ToString());
            service.price = txtPrice.Text.Trim();
            service.service_id = Convert.ToInt32(cmbService.SelectedValue.ToString());

            if (verifyInput())
            {
                if (serviceOfRoomBLL.insertService(service))
                {
                    MessageBox.Show("Add Service Successfully", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (verifyInput())
                {
                    MessageBox.Show("ERROR", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Fill In Blank Information", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvListServices.DataSource = serviceOfRoomBLL.getAllServiceOfRoomByID(Convert.ToInt32(txtBookID.Text));

        }
        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }
        bool verifyInput()
        {
            if ((txtBookID.Text.Trim() == "") || txtPrice.Text.Trim() == "" || txtAmount.Text.Trim() == "")
            {
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Require Number");
                txtPrice.Text = "";
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Require Number");
                txtPrice.Text = "";
                return false;
            }
           
            return true;
        }

        private void ServiceOfRoomForm_Load(object sender, EventArgs e)
        {
            txtRoomName.Text = roomName;
            try
            {
                BookingRoomBLL bookingRoomBLL = new BookingRoomBLL();
                DataTable dt = bookingRoomBLL.getBookingRoomByRoomName(roomName);
                txtBookID.Text = dt.Rows[0]["booking_id"].ToString();
                txtBookID.Enabled = false;
            }
            catch { }
            RoomBLL roomBLL = new RoomBLL();
            dgvListServices.DataSource = serviceOfRoomBLL.getAllServiceOfRoomByID(Convert.ToInt32(txtBookID.Text));
            cmbService.DataSource = serviceOfRoomBLL.getAllServices();
            cmbService.DisplayMember = "service_name";
            cmbService.ValueMember = "service_id";
            try
            {
                DataTable dt = serviceOfRoomBLL.getServiceByID(Convert.ToInt32(cmbService.SelectedValue));
                txtPrice.Text = dt.Rows[0]["price"].ToString();
            }
            catch { }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = serviceOfRoomBLL.getServiceByID(Convert.ToInt32(cmbService.SelectedValue));
                txtPrice.Text = dt.Rows[0]["price"].ToString();
            }
            catch { }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Do You Sure To Delete This Service?", "Remove Service", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    int id = Convert.ToInt32(dgvListServices.CurrentRow.Cells["id"].Value);
                    serviceOfRoomBLL.deleteService(id);
                    MessageBox.Show("Delete Successfully", "Delete Information of Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvListServices.DataSource = serviceOfRoomBLL.getAllServiceOfRoomByID(Convert.ToInt32(txtBookID.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
