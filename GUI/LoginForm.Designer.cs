namespace GUI
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
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CheckBoxRemember = new System.Windows.Forms.CheckBox();
            this.RadioButtonManager = new System.Windows.Forms.RadioButton();
            this.RadioButtonReceptionist = new System.Windows.Forms.RadioButton();
            this.RadioButtonJanitor = new System.Windows.Forms.RadioButton();
            this.LinkLabelForgot = new System.Windows.Forms.LinkLabel();
            this.LinkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.LabelFollow = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageButtonFB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.PBTwitter = new System.Windows.Forms.PictureBox();
            this.PBeye = new System.Windows.Forms.PictureBox();
            this.ImageButtonInsta = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PBhide = new System.Windows.Forms.PictureBox();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ErrorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.ButtonLogin.Font = new System.Drawing.Font("Phatdiem", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(124, 418);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(255, 34);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.AutoSize = true;
            this.CheckBoxRemember.Location = new System.Drawing.Point(124, 349);
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Size = new System.Drawing.Size(106, 21);
            this.CheckBoxRemember.TabIndex = 8;
            this.CheckBoxRemember.Text = "Remeber Me";
            this.CheckBoxRemember.UseVisualStyleBackColor = true;
            this.CheckBoxRemember.CheckedChanged += new System.EventHandler(this.CheckBoxRemember_CheckedChanged);
            // 
            // RadioButtonManager
            // 
            this.RadioButtonManager.AutoSize = true;
            this.RadioButtonManager.Location = new System.Drawing.Point(80, 199);
            this.RadioButtonManager.Name = "RadioButtonManager";
            this.RadioButtonManager.Size = new System.Drawing.Size(82, 21);
            this.RadioButtonManager.TabIndex = 9;
            this.RadioButtonManager.TabStop = true;
            this.RadioButtonManager.Text = "Manager";
            this.RadioButtonManager.UseVisualStyleBackColor = true;
            this.RadioButtonManager.CheckedChanged += new System.EventHandler(this.RadioButtonManager_CheckedChanged);
            // 
            // RadioButtonReceptionist
            // 
            this.RadioButtonReceptionist.AutoSize = true;
            this.RadioButtonReceptionist.Location = new System.Drawing.Point(204, 199);
            this.RadioButtonReceptionist.Name = "RadioButtonReceptionist";
            this.RadioButtonReceptionist.Size = new System.Drawing.Size(104, 21);
            this.RadioButtonReceptionist.TabIndex = 10;
            this.RadioButtonReceptionist.TabStop = true;
            this.RadioButtonReceptionist.Text = "Receptionist";
            this.RadioButtonReceptionist.UseVisualStyleBackColor = true;
            this.RadioButtonReceptionist.CheckedChanged += new System.EventHandler(this.RadioButtonReceptionist_CheckedChanged);
            // 
            // RadioButtonJanitor
            // 
            this.RadioButtonJanitor.AutoSize = true;
            this.RadioButtonJanitor.Location = new System.Drawing.Point(347, 199);
            this.RadioButtonJanitor.Name = "RadioButtonJanitor";
            this.RadioButtonJanitor.Size = new System.Drawing.Size(68, 21);
            this.RadioButtonJanitor.TabIndex = 11;
            this.RadioButtonJanitor.TabStop = true;
            this.RadioButtonJanitor.Text = "Janitor";
            this.RadioButtonJanitor.UseVisualStyleBackColor = true;
            this.RadioButtonJanitor.CheckedChanged += new System.EventHandler(this.RadioButtonJanitor_CheckedChanged);
            // 
            // LinkLabelForgot
            // 
            this.LinkLabelForgot.AutoSize = true;
            this.LinkLabelForgot.Font = new System.Drawing.Font("Phatdiem", 7.799999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.LinkLabelForgot.Location = new System.Drawing.Point(121, 372);
            this.LinkLabelForgot.Name = "LinkLabelForgot";
            this.LinkLabelForgot.Size = new System.Drawing.Size(113, 17);
            this.LinkLabelForgot.TabIndex = 12;
            this.LinkLabelForgot.TabStop = true;
            this.LinkLabelForgot.Text = "Forgot Password?";
            this.LinkLabelForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelForgot_LinkClicked);
            // 
            // LinkLabelSignUp
            // 
            this.LinkLabelSignUp.AutoSize = true;
            this.LinkLabelSignUp.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.LinkLabelSignUp.Location = new System.Drawing.Point(304, 480);
            this.LinkLabelSignUp.Name = "LinkLabelSignUp";
            this.LinkLabelSignUp.Size = new System.Drawing.Size(54, 16);
            this.LinkLabelSignUp.TabIndex = 18;
            this.LinkLabelSignUp.TabStop = true;
            this.LinkLabelSignUp.Text = "Sign up";
            this.LinkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSignUp_LinkClicked);
            // 
            // LabelFollow
            // 
            this.LabelFollow.AutoSize = true;
            this.LabelFollow.Location = new System.Drawing.Point(153, 514);
            this.LabelFollow.Name = "LabelFollow";
            this.LabelFollow.Size = new System.Drawing.Size(196, 17);
            this.LabelFollow.TabIndex = 21;
            this.LabelFollow.Text = "----------------Follow Us----------------";
            this.LabelFollow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFollow.Click += new System.EventHandler(this.LabelFollow_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Camranh", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.LabelLogin.Location = new System.Drawing.Point(117, 62);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(276, 111);
            this.LabelLogin.TabIndex = 22;
            this.LabelLogin.Text = "Login";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.BorderRadius = 15;
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.ImageButtonFB);
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Controls.Add(this.LabelFollow);
            this.PanelLogin.Controls.Add(this.TextBoxUsername);
            this.PanelLogin.Controls.Add(this.LinkLabelSignUp);
            this.PanelLogin.Controls.Add(this.PBTwitter);
            this.PanelLogin.Controls.Add(this.PBeye);
            this.PanelLogin.Controls.Add(this.ImageButtonInsta);
            this.PanelLogin.Controls.Add(this.LinkLabelForgot);
            this.PanelLogin.Controls.Add(this.RadioButtonJanitor);
            this.PanelLogin.Controls.Add(this.RadioButtonReceptionist);
            this.PanelLogin.Controls.Add(this.RadioButtonManager);
            this.PanelLogin.Controls.Add(this.CheckBoxRemember);
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Controls.Add(this.PBhide);
            this.PanelLogin.Controls.Add(this.TextBoxPassword);
            this.PanelLogin.Font = new System.Drawing.Font("Phatdiem", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin.Location = new System.Drawing.Point(-3, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(502, 671);
            this.PanelLogin.TabIndex = 3;
            this.PanelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Don\'t have an account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.ImageButtonFB.TabIndex = 23;
            this.ImageButtonFB.Click += new System.EventHandler(this.ImageButtonFB_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AutoRoundedCorners = true;
            this.TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUsername.BorderRadius = 17;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.TextBoxUsername.IconLeft = global::GUI.Properties.Resources.icons8_login_67;
            this.TextBoxUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.TextBoxUsername.TabIndex = 19;
            this.TextBoxUsername.Tag = "";
            this.TextBoxUsername.WordWrap = false;
            this.TextBoxUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
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
            this.TextBoxPassword.IconLeft = global::GUI.Properties.Resources.icons8_key_64;
            this.TextBoxPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.TextBoxPassword.TabIndex = 20;
            this.TextBoxPassword.Tag = "";
            this.TextBoxPassword.WordWrap = false;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // ErrorProviderPassword
            // 
            this.ErrorProviderPassword.ContainerControl = this;
            // 
            // ErrorProviderUsername
            // 
            this.ErrorProviderUsername.ContainerControl = this;
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
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 671);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Load);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private System.Windows.Forms.PictureBox PBhide;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonLogin;
        private System.Windows.Forms.CheckBox CheckBoxRemember;
        private System.Windows.Forms.RadioButton RadioButtonManager;
        private System.Windows.Forms.RadioButton RadioButtonReceptionist;
        private System.Windows.Forms.RadioButton RadioButtonJanitor;
        private System.Windows.Forms.LinkLabel LinkLabelForgot;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonInsta;
        private System.Windows.Forms.PictureBox PBeye;
        private System.Windows.Forms.PictureBox PBTwitter;
        private System.Windows.Forms.LinkLabel LinkLabelSignUp;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelFollow;
        private System.Windows.Forms.Label LabelLogin;
        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonFB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProviderPassword;
        private System.Windows.Forms.ErrorProvider ErrorProviderUsername;
    }
}