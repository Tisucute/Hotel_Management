using BLL;
using DTO;
using GUI.RECEPTIONIST;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            panelRoom.Controls.Clear();
            loadRoom();
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
                uc.BookClicked += MyControl_BookingClicked;
            }
            foreach (ucRooms uc in panelRoom.Controls.OfType<UserControl>())
            {
                uc.ReceiveClicked += MyControl_ReturnClicked;
            }
            foreach (ucRooms uc in panelRoom.Controls.OfType<UserControl>())
            {
                uc.EditClicked += MyControl_EditClicked;
            }
            foreach (ucRooms uc in panelRoom.Controls.OfType<UserControl>())
            {
                uc.ServiceClicked += MyControl_ServiceClicked;
            }



        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panelRoom.Controls)
            {
                var search = (ucRooms)item;
                search.Visible = search.room_name.ToLower().Contains(TextBoxSearch.Text.Trim().ToLower())
                                || search.type.ToLower().Contains(TextBoxSearch.Text.Trim().ToLower())
                                || search.status.ToLower().Contains(TextBoxSearch.Text.Trim().ToLower());
            }

        }
        private void MyControl_DeleteClicked(object sender, EventArgs e)
        {
            ucRooms controlToRemove = sender as ucRooms;
            if ((MessageBox.Show("Are you sure to delete this room?", "Remove Room", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                panelRoom.Controls.Remove(controlToRemove);
                string nameToRemove = controlToRemove.room_name.ToString(); // Thay 'Id' bằng thuộc tính thực sự của UserControlint id = Convert.ToInt32(dgvListEmployees.CurrentRow.Cells[0].Value.ToString());
                roombll.removeRoom(nameToRemove);
                MessageBox.Show("Deleted Room Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void MyControl_BookingClicked(object sender, EventArgs e)
        {

            ucRooms controlToBook = sender as ucRooms;
            DataTable dt = roombll.getRoomByName(controlToBook.room_name);
            ROOM room = new ROOM();
            room.room_id = Convert.ToInt32(dt.Rows[0]["room_id"].ToString());
            room.room_name = dt.Rows[0]["room_name"].ToString();
            room.type_id = Convert.ToInt32(dt.Rows[0]["type_id"].ToString());
            room.person = Convert.ToInt32(dt.Rows[0]["person"].ToString());
            room.price = dt.Rows[0]["price"].ToString().Trim();
            RoomBookingForm roomBF = new RoomBookingForm(room);
            roomBF.ShowDialog();
            panelRoom.Controls.Clear();
            loadRoom();
        }

        private void MyControl_ReturnClicked(object sender, EventArgs e)
        {
            ucRooms controlToBook = sender as ucRooms;
            DataTable dt = roombll.getRoomByName(controlToBook.room_name);
            ROOM room = new ROOM();
            room.room_id = Convert.ToInt32(dt.Rows[0]["room_id"].ToString());
            room.room_name = dt.Rows[0]["room_name"].ToString();
            room.type_id = Convert.ToInt32(dt.Rows[0]["type_id"].ToString());
            room.person = Convert.ToInt32(dt.Rows[0]["person"].ToString());
            room.price = dt.Rows[0]["price"].ToString().Trim();
            ReturnRoomForm returnRoomForm = new ReturnRoomForm(room);
            returnRoomForm.ShowDialog();
            panelRoom.Controls.Clear();
            loadRoom();

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
            editForm.cmbBoxType.SelectedValue = dt.Rows[0]["type_id"].ToString();
            editForm.txtID.Text = dt.Rows[0]["room_id"].ToString();
            // Hiển thị form
            editForm.ShowDialog();
            panelRoom.Controls.Clear();
            loadRoom();
        }
        private void MyControl_ServiceClicked(object sender, EventArgs e)
        {
            ucRooms controlToEdit = sender as ucRooms;
            ServiceOfRoomForm serviceOfRoom = new ServiceOfRoomForm(controlToEdit.room_name);
            serviceOfRoom.ShowDialog();
            
        }

    }
}
