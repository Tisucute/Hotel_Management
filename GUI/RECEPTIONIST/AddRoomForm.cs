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
using System.Text.RegularExpressions;

namespace GUI.RECEPTIONIST
{
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }
        RoomBLL roomBLL = new RoomBLL();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ROOM room = new ROOM();
            room.room_name = txtName.Text.Trim();
            room.person = Convert.ToInt32(txtPerson.Text.ToString());
            room.price = txtPrice.Text.Trim();
            room.type = cmbBoxType.Text.ToString();
            room.status = "Empty";
            MemoryStream pic = new MemoryStream();
            if (BtnRadioHire.Checked)
            {
                room.status = "Hire";
            }
            
            
            if (verifyInput())
            {
                picBox.Image.Save(pic, picBox.Image.RawFormat);
                room.pic = pic;
                if (roomBLL.addRoom(room))
                {
                    MessageBox.Show("Add Room Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (verifyInput())
                {
                    MessageBox.Show("ERROR", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Fill In Blank Information", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                

            


        }

        bool IsValidAlphabetInput(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra
            return Regex.IsMatch(input, @"^[\p{L}\p{Mn}\p{Mc}]+$");
        }
        bool verifyInput()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPerson.Text.Trim().Replace(" ", ""), "^[0-9]*$"))
            {
                MessageBox.Show("Number of people in this room may number!");
                txtPerson.Text = "";
                return false;
            }
            return true;
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

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            cmbBoxType.DataSource = roomBLL.getAllType();
            cmbBoxType.DisplayMember = "type_name";
            cmbBoxType.ValueMember = "type_name";
            BtnRadioEmpty.Checked = true;
        }
        private void AddItems(string name, string kind, string status, Image picture)
        {

            var w = new ucRooms();
            {
                w.room_name = name;
                w.status = status;
                w.type = kind;
                w.Ppicture = picture;
            };
            RoomManagementForm rMF = new RoomManagementForm();
            rMF.panelRoom.Controls.Add(w);


        }

    }
}
