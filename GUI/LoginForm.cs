﻿using Guna.UI2.WinForms;
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
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e) // ImageButtonFB
        {
            string url = "https://www.facebook.com/tisuhuongnoi/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImageButtonTwitter_Click(object sender, EventArgs e)
        {
            string url = "https://twitter.com/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
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
    }
}
