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
            service.room_name = txtRoomName.Text.Trim();
            service.book_id = Convert.ToInt32(cmbBookID.SelectedItem.ToString());
            service.amount = Convert.ToInt32(txtAmount.Text.ToString());
            service.price = txtPrice.Text.Trim();
            service.service_name = cmbService.SelectedItem.ToString();

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

        }
        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }
        bool verifyInput()
        {
            if ((txtRoomName.Text.Trim() == "") || txtPrice.Text.Trim() == "" || txtAmount.Text.Trim() == "")
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
            dgvListServices.DataSource = serviceOfRoomBLL.getAllServiceOfRoom();
            cmbService.DataSource = serviceOfRoomBLL.getAllServices();
            cmbService.DisplayMember = "service_name";
            cmbService.ValueMember = "service_id";
            cmbBookID.DataSource = serviceOfRoomBLL.getAllBookID();
            cmbBookID.ValueMember = "booking_id";
            cmbBookID.DisplayMember = "booking_id";
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomID = Convert.ToInt32(cmbBookID.SelectedValue.ToString());
            DataTable dt = serviceOfRoomBLL.getRoomNameByID(roomID);
            if (dt.Rows.Count > 0)
            {
                txtRoomName.Text = dt.Rows[0]["room_name"].ToString();
            }
            else
            {
                MessageBox.Show("No information found", "Booking Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
    
}
