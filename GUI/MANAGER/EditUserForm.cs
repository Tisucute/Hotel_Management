using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }
        LOGIN login = new LOGIN();
        public EditUserForm(LOGIN tmp)
        {
            login = tmp;
            InitializeComponent();
        }
        LoginBLL loginBLL = new LoginBLL();
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtBoxFullname.Text = login.fullname;
            txtBoxUsername.Text = login.username;
            txtBoxPass.Text = login.password;
            PictureBoxEmployee.Image = System.Drawing.Image.FromStream(login.pic);
            CmbBoxRole.DataSource = loginBLL.getAllRole();
            CmbBoxRole.DisplayMember = "role_name";
            CmbBoxRole.ValueMember = "role_id";
            CmbBoxRole.SelectedValue = login.role;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image( *.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxEmployee.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
