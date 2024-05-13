using BLL;
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
using System.IO;

namespace GUI.RECEPTIONIST
{
    public partial class EditRoomForm : Form
    {
        public EditRoomForm()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ROOM room = new ROOM();
            room.room_id = Convert.ToInt32(txtID.Text);
            room.room_name = txtName.Text;
            room.type_id = (int)cmbBoxType.SelectedValue;
            room.person = Convert.ToInt32(txtPerson.Text);
            room.price = txtPrice.Text;
            if (BtnRadioEmpty.Checked)
            {
                room.status = "Empty";
            }
            else room.status = "Hire";
            MemoryStream pic = new MemoryStream();
            if (verifyInput())
            {
                picBox.Image.Save(pic, picBox.Image.RawFormat);
                room.pic = pic;
                if (roomBLL.updateEmployee(room))
                {
                    MessageBox.Show("Edit Success", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Fail", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Person require a number", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verifyInput()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPerson.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                txtPerson.Text = "";
                return false;
            }
            return true;
        }
        RoomBLL roomBLL = new RoomBLL();
        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            cmbBoxType.DataSource = roomBLL.getAllType();
            cmbBoxType.ValueMember = "type_id";
            cmbBoxType.DisplayMember = "type_name";
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image( *.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
