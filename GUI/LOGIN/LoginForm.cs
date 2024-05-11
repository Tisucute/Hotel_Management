using DTO;
using BLL;
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
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RadioButtonManager.Checked = true;
            if (Properties.Settings.Default.username != string.Empty)
            {
                TextBoxUsername.Text = Properties.Settings.Default.username;
                TextBoxPassword.Text = Properties.Settings.Default.password;
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

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();
            LOGIN login  = new LOGIN();
            if (TextBoxUsername.Text != "" && TextBoxPassword.Text != "")
            {
                login.username = TextBoxUsername.Text;
                login.password = TextBoxPassword.Text;
                if (RadioButtonManager.Checked)
                {
                    login.role = 1;
                    if (loginBLL.checkLogin(login))
                    {
                        ManagerForm managerForm = new ManagerForm(login);
                        this.Hide();
                        managerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc sai quyền truy cập", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (RadioButtonReceptionist.Checked)
                {
                    login.role = 2;
                    if (loginBLL.checkLogin(login))
                    {
                        ReceptionistForm receptionistForm = new ReceptionistForm(login);
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
                    login.role = 3;
                    if (loginBLL.checkLogin(login))
                    {
                        JanitorForm janitorForm = new JanitorForm(login);
                        this.Hide();
                        janitorForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc sai quyền truy cập", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ToggleSwitchRemem.Checked == true)
            {
                Properties.Settings.Default.username = TextBoxUsername.Text;
                Properties.Settings.Default.password = TextBoxPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }

        }

        private void LinkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = '\u25CF';
            if (string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                ErrorProviderPassword.SetError(TextBoxPassword, "Vui long nhap mat khau");
                return;
            }
            else
            {
                ErrorProviderPassword.SetError(TextBoxPassword, "");
            }

        }

        private void ImageButtonFB_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/tisuhuongnoi/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text))
            {
                ErrorProviderUsername.SetError(TextBoxUsername, "Vui long nhap ten nguoi dung");
                return;
            }
            else
            {
                ErrorProviderUsername.SetError(TextBoxUsername, "");
            }

        }

    }
}
