﻿namespace GUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.PBTwitter = new System.Windows.Forms.PictureBox();
            this.PBeye = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageButtonInsta = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LinkForgot = new System.Windows.Forms.LinkLabel();
            this.ImageButtonFB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.RadioButtonJanitor = new System.Windows.Forms.RadioButton();
            this.RadioButtonRecep = new System.Windows.Forms.RadioButton();
            this.RadioButtonManager = new System.Windows.Forms.RadioButton();
            this.CheckBoxRemember = new System.Windows.Forms.CheckBox();
            this.LinkSignUp = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.PBhide = new System.Windows.Forms.PictureBox();
            this.PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.BorderRadius = 15;
            this.PanelLogin.Controls.Add(this.PBTwitter);
            this.PanelLogin.Controls.Add(this.PBeye);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.ImageButtonInsta);
            this.PanelLogin.Controls.Add(this.LinkForgot);
            this.PanelLogin.Controls.Add(this.ImageButtonFB);
            this.PanelLogin.Controls.Add(this.RadioButtonJanitor);
            this.PanelLogin.Controls.Add(this.RadioButtonRecep);
            this.PanelLogin.Controls.Add(this.RadioButtonManager);
            this.PanelLogin.Controls.Add(this.CheckBoxRemember);
            this.PanelLogin.Controls.Add(this.LinkSignUp);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Controls.Add(this.TextBoxPassword);
            this.PanelLogin.Controls.Add(this.TextBoxUsername);
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Controls.Add(this.PBhide);
            this.PanelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin.Location = new System.Drawing.Point(-3, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(502, 671);
            this.PanelLogin.TabIndex = 3;
            this.PanelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // PBTwitter
            // 
            this.PBTwitter.Image = ((System.Drawing.Image)(resources.GetObject("PBTwitter.Image")));
            this.PBTwitter.Location = new System.Drawing.Point(204, 553);
            this.PBTwitter.Name = "PBTwitter";
            this.PBTwitter.Size = new System.Drawing.Size(84, 70);
            this.PBTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTwitter.TabIndex = 17;
            this.PBTwitter.TabStop = false;
            this.PBTwitter.Click += new System.EventHandler(this.PBTwitter_Click);
            // 
            // PBeye
            // 
            this.PBeye.BackColor = System.Drawing.Color.Gainsboro;
            this.PBeye.BackgroundImage = global::GUI.Properties.Resources.icons8_eye_48;
            this.PBeye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBeye.Location = new System.Drawing.Point(339, 302);
            this.PBeye.Name = "PBeye";
            this.PBeye.Size = new System.Drawing.Size(30, 28);
            this.PBeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBeye.TabIndex = 14;
            this.PBeye.TabStop = false;
            this.PBeye.Click += new System.EventHandler(this.PBeye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "----------------Follow Us----------------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageButtonInsta
            // 
            this.ImageButtonInsta.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonInsta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageButtonInsta.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.Image = ((System.Drawing.Image)(resources.GetObject("ImageButtonInsta.Image")));
            this.ImageButtonInsta.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonInsta.ImageRotate = 0F;
            this.ImageButtonInsta.ImageSize = new System.Drawing.Size(70, 70);
            this.ImageButtonInsta.Location = new System.Drawing.Point(329, 553);
            this.ImageButtonInsta.Name = "ImageButtonInsta";
            this.ImageButtonInsta.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.Size = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.TabIndex = 7;
            this.ImageButtonInsta.Click += new System.EventHandler(this.ImageButtonInsta_Click);
            // 
            // LinkForgot
            // 
            this.LinkForgot.AutoSize = true;
            this.LinkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.LinkForgot.Location = new System.Drawing.Point(121, 372);
            this.LinkForgot.Name = "LinkForgot";
            this.LinkForgot.Size = new System.Drawing.Size(116, 16);
            this.LinkForgot.TabIndex = 12;
            this.LinkForgot.TabStop = true;
            this.LinkForgot.Text = "Forgot Password?";
            // 
            // ImageButtonFB
            // 
            this.ImageButtonFB.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonFB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonFB.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonFB.Image = ((System.Drawing.Image)(resources.GetObject("ImageButtonFB.Image")));
            this.ImageButtonFB.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonFB.ImageRotate = 0F;
            this.ImageButtonFB.ImageSize = new System.Drawing.Size(60, 60);
            this.ImageButtonFB.Location = new System.Drawing.Point(95, 553);
            this.ImageButtonFB.Name = "ImageButtonFB";
            this.ImageButtonFB.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonFB.Size = new System.Drawing.Size(70, 70);
            this.ImageButtonFB.TabIndex = 5;
            this.ImageButtonFB.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // RadioButtonJanitor
            // 
            this.RadioButtonJanitor.AutoSize = true;
            this.RadioButtonJanitor.Location = new System.Drawing.Point(347, 199);
            this.RadioButtonJanitor.Name = "RadioButtonJanitor";
            this.RadioButtonJanitor.Size = new System.Drawing.Size(68, 20);
            this.RadioButtonJanitor.TabIndex = 11;
            this.RadioButtonJanitor.TabStop = true;
            this.RadioButtonJanitor.Text = "Janitor";
            this.RadioButtonJanitor.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRecep
            // 
            this.RadioButtonRecep.AutoSize = true;
            this.RadioButtonRecep.Location = new System.Drawing.Point(204, 199);
            this.RadioButtonRecep.Name = "RadioButtonRecep";
            this.RadioButtonRecep.Size = new System.Drawing.Size(103, 20);
            this.RadioButtonRecep.TabIndex = 10;
            this.RadioButtonRecep.TabStop = true;
            this.RadioButtonRecep.Text = "Receptionist";
            this.RadioButtonRecep.UseVisualStyleBackColor = true;
            // 
            // RadioButtonManager
            // 
            this.RadioButtonManager.AutoSize = true;
            this.RadioButtonManager.Location = new System.Drawing.Point(80, 199);
            this.RadioButtonManager.Name = "RadioButtonManager";
            this.RadioButtonManager.Size = new System.Drawing.Size(82, 20);
            this.RadioButtonManager.TabIndex = 9;
            this.RadioButtonManager.TabStop = true;
            this.RadioButtonManager.Text = "Manager";
            this.RadioButtonManager.UseVisualStyleBackColor = true;
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.AutoSize = true;
            this.CheckBoxRemember.Location = new System.Drawing.Point(124, 349);
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Size = new System.Drawing.Size(148, 20);
            this.CheckBoxRemember.TabIndex = 8;
            this.CheckBoxRemember.Text = "Remeber password";
            this.CheckBoxRemember.UseVisualStyleBackColor = true;
            // 
            // LinkSignUp
            // 
            this.LinkSignUp.AutoSize = true;
            this.LinkSignUp.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.LinkSignUp.Location = new System.Drawing.Point(304, 473);
            this.LinkSignUp.Name = "LinkSignUp";
            this.LinkSignUp.Size = new System.Drawing.Size(54, 16);
            this.LinkSignUp.TabIndex = 7;
            this.LinkSignUp.TabStop = true;
            this.LinkSignUp.Text = "Sign up";
            this.LinkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don\'t have an account?";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoRoundedCorners = true;
            this.ButtonLogin.BorderRadius = 16;
            this.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.ButtonLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(124, 413);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(255, 34);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AutoRoundedCorners = true;
            this.TextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPassword.BorderRadius = 17;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.FillColor = System.Drawing.Color.Gainsboro;
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.TextBoxPassword.HideSelection = false;
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBoxPassword.IconLeft")));
            this.TextBoxPassword.Location = new System.Drawing.Point(124, 296);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.PlaceholderText = "Password";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.ShadowDecoration.BorderRadius = 17;
            this.TextBoxPassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.TextBoxPassword.ShadowDecoration.Depth = 20;
            this.TextBoxPassword.ShadowDecoration.Enabled = true;
            this.TextBoxPassword.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.TextBoxPassword.Size = new System.Drawing.Size(255, 37);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.Tag = "";
            this.TextBoxPassword.WordWrap = false;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AutoRoundedCorners = true;
            this.TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUsername.BorderRadius = 17;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TextBoxUsername.DefaultText = "";
            this.TextBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.FillColor = System.Drawing.Color.Gainsboro;
            this.TextBoxUsername.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.TextBoxUsername.HideSelection = false;
            this.TextBoxUsername.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBoxUsername.IconLeft")));
            this.TextBoxUsername.Location = new System.Drawing.Point(124, 239);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.PlaceholderText = "Username";
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.ShadowDecoration.BorderRadius = 17;
            this.TextBoxUsername.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.TextBoxUsername.ShadowDecoration.Depth = 20;
            this.TextBoxUsername.ShadowDecoration.Enabled = true;
            this.TextBoxUsername.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.TextBoxUsername.Size = new System.Drawing.Size(255, 37);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.UseWaitCursor = true;
            this.TextBoxUsername.WordWrap = false;
            this.TextBoxUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Camranh", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.LabelLogin.Location = new System.Drawing.Point(117, 62);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(276, 111);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login";
            this.LabelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // PBhide
            // 
            this.PBhide.BackColor = System.Drawing.Color.Gainsboro;
            this.PBhide.BackgroundImage = global::GUI.Properties.Resources.icons8_closed_eye_48;
            this.PBhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBhide.Location = new System.Drawing.Point(339, 302);
            this.PBhide.Name = "PBhide";
            this.PBhide.Size = new System.Drawing.Size(30, 28);
            this.PBhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBhide.TabIndex = 15;
            this.PBhide.TabStop = false;
            this.PBhide.Click += new System.EventHandler(this.PBhide_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(493, -36);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(500, 707);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLogin.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 671);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Load);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonLogin;
        private System.Windows.Forms.LinkLabel LinkSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxRemember;
        private System.Windows.Forms.RadioButton RadioButtonJanitor;
        private System.Windows.Forms.RadioButton RadioButtonRecep;
        private System.Windows.Forms.RadioButton RadioButtonManager;
        private System.Windows.Forms.LinkLabel LinkForgot;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonFB;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonInsta;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBeye;
        private System.Windows.Forms.PictureBox PBhide;
        private System.Windows.Forms.PictureBox PBTwitter;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
    }
}