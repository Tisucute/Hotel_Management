using GUI.RECEPTIONIST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.IO;

namespace GUI
{
    public partial class RoomManagementForm : Form
    {
        public RoomManagementForm()
        {
            InitializeComponent();
            


        }
        SqlConnection mydb = new SqlConnection();
        RoomBLL roombll = new RoomBLL();
        ucRooms myControl = new ucRooms();
        
        
        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            panelRoom.Controls.Clear();
            loadRoom();
            
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
            panelRoom.Controls.Add(w);
            

        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addRF = new AddRoomForm();
            addRF.ShowDialog();
            


        }
        private void loadRoom()
        {
            DataTable table = new DataTable();
            table = roombll.getAllRoom();
            foreach (DataRow item in table.Rows)
            {
                Byte[] imagearray = (byte[])item["picture"];
                byte[] imagebytearray = imagearray;
                AddItems(item["room_name"].ToString(), item["type_name"].ToString(), item["status"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
                
            }
            foreach (ucRooms uc in panelRoom.Controls.OfType<UserControl>())
            {
                uc.DeleteClicked += MyControl_DeleteClicked;
            }
            foreach (ucRooms uc in panelRoom.Controls.OfType<UserControl>())
            {
                uc.EditClicked += MyControl_EditClicked;
            }


        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panelRoom.Controls)
            {
                var search = (ucRooms)item;
                search.Visible = search.room_name.ToLower().Contains(TextBoxSearch.Text.Trim().ToLower());
            }
        }
        private void MyControl_DeleteClicked(object sender, EventArgs e)
        {
            ucRooms controlToRemove = sender as ucRooms;
            panelRoom.Controls.Remove(controlToRemove);
            string nameToRemove = controlToRemove.room_name.ToString(); // Thay 'Id' bằng thuộc tính thực sự của UserControlint id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells[0].Value.ToString());
            roombll.removeRoom(nameToRemove);
            MessageBox.Show("Deleted Room Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MyControl_EditClicked(object sender, EventArgs e)
        {
            ucRooms controlToEdit = sender as ucRooms;
            // Tạo một form mới
            EditRoomForm editForm = new EditRoomForm();
            // Tạo một textbox mới và đặt text bằng thông tin từ UserControl
            DataTable dt = roombll.getRoomByName(controlToEdit.room_name);
            //TextBox textBox = new TextBox();
            editForm.txtName.Text = controlToEdit.room_name;
            editForm.txtPerson.Text = dt.Rows[0]["person"].ToString();
            editForm.txtPrice.Text = dt.Rows[0]["price"].ToString();
            editForm.picBox.Image = controlToEdit.Ppicture;
            editForm.txtName.Text = controlToEdit.room_name;
            if (dt.Rows[0]["status"].ToString().Trim() == "Empty")
            {
                editForm.BtnRadioEmpty.Checked = true;
            }
            else
            {
                editForm.BtnRadioHire.Checked = true;
            }

            // Hiển thị form
            editForm.Show();
            editForm.cmbBoxType.SelectedValue = dt.Rows[0]["type_id"].ToString();
            editForm.txtID.Text = dt.Rows[0]["room_id"].ToString();
        }



    }
}
