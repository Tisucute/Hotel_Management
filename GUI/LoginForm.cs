using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        StaffBLL staffBLL = new StaffBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RadioButtonManager.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e) //TextBoxPassword
        {
            TextBoxPassword.PasswordChar = '\u25CF';
            if (string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                errorProviderLogin.SetError(TextBoxPassword, "Vui long nhap mat khau");
                return;
            }
            else
            {
                errorProviderLogin.SetError(TextBoxPassword, "");
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e) // ImageButtonFB
        {
            string url = "https://www.facebook.com/tisuhuongnoi/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text))
            {
                errorProviderLogin.SetError(TextBoxUsername, "Vui long nhap ten nguoi dung");
                return;
            }
            else
            {
                errorProviderLogin.SetError(TextBoxUsername, "");
            }
        }

        private void ImageButtonInsta_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/histtuw._ti/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
        }

        private void PBeye_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.PasswordChar == '\u25CF')
            {
                PBhide.BringToFront();
                TextBoxPassword.PasswordChar = '\0';
            }
        }

        private void PBhide_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.PasswordChar == '\0')
            {
                PBeye.BringToFront();
                TextBoxPassword.PasswordChar = '\u25CF';
            }
        }

        private void PBTwitter_Click(object sender, EventArgs e)
        {
            string url = "https://twitter.com/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text != "" && TextBoxPassword.Text != "")
            {
                Staff staff = new Staff();
                staff.username = TextBoxUsername.Text;
                staff.password = TextBoxPassword.Text;
                if (RadioButtonManager.Checked)
                {
                    staff.permission = "Manager";
                    if (staffBLL.checkLogin(staff))
                    {
                        ManagerForm managerForm = new ManagerForm();
                        this.Hide();
                        managerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc sai quyền truy cập", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (RadioButtonRecep.Checked)
                {
                    staff.permission = "Receptionist";
                    if (staffBLL.checkLogin(staff))
                    {
                        ReceptionistForm receptionistForm = new ReceptionistForm();
                        this.Hide();
                        receptionistForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc sai quyền truy cập", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    staff.permission = "Janitor";
                    if (staffBLL.checkLogin(staff))
                    {
                        JanitorForm janitorForm = new JanitorForm();
                        this.Hide();
                        janitorForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc sai quyền truy cập", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
