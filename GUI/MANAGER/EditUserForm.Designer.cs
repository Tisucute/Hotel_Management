namespace GUI
{
    partial class EditUserForm
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
            this.BtnEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel6 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbBoxRole = new ReaLTaiizor.Controls.SkyComboBox();
            this.PictureBoxEmployee = new Guna.UI2.WinForms.Guna2PictureBox();
            this.nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            this.BtnUpload = new ReaLTaiizor.Controls.AirButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(159, 629);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnEdit.Size = new System.Drawing.Size(117, 48);
            this.BtnEdit.TabIndex = 125;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel2.Location = new System.Drawing.Point(83, 281);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(70, 20);
            this.nightLabel2.TabIndex = 122;
            this.nightLabel2.Text = "Password";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Animated = true;
            this.txtBoxPass.AutoRoundedCorners = true;
            this.txtBoxPass.BorderRadius = 21;
            this.txtBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPass.DefaultText = "";
            this.txtBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPass.Location = new System.Drawing.Point(69, 305);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '\0';
            this.txtBoxPass.PlaceholderText = "";
            this.txtBoxPass.SelectedText = "";
            this.txtBoxPass.Size = new System.Drawing.Size(306, 44);
            this.txtBoxPass.TabIndex = 121;
            // 
            // nightLabel6
            // 
            this.nightLabel6.AutoSize = true;
            this.nightLabel6.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel6.Location = new System.Drawing.Point(83, 128);
            this.nightLabel6.Name = "nightLabel6";
            this.nightLabel6.Size = new System.Drawing.Size(39, 20);
            this.nightLabel6.TabIndex = 120;
            this.nightLabel6.Text = "Role";
            // 
            // nightLabel4
            // 
            this.nightLabel4.AutoSize = true;
            this.nightLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel4.Location = new System.Drawing.Point(78, 200);
            this.nightLabel4.Name = "nightLabel4";
            this.nightLabel4.Size = new System.Drawing.Size(75, 20);
            this.nightLabel4.TabIndex = 119;
            this.nightLabel4.Text = "Username";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Animated = true;
            this.txtBoxUsername.AutoRoundedCorners = true;
            this.txtBoxUsername.BorderRadius = 21;
            this.txtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUsername.DefaultText = "";
            this.txtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Location = new System.Drawing.Point(69, 224);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.PasswordChar = '\0';
            this.txtBoxUsername.PlaceholderText = "";
            this.txtBoxUsername.SelectedText = "";
            this.txtBoxUsername.Size = new System.Drawing.Size(306, 44);
            this.txtBoxUsername.TabIndex = 118;
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(83, 45);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(69, 20);
            this.nightLabel1.TabIndex = 117;
            this.nightLabel1.Text = "Fullname";
            // 
            // txtBoxFullname
            // 
            this.txtBoxFullname.Animated = true;
            this.txtBoxFullname.AutoRoundedCorners = true;
            this.txtBoxFullname.BorderRadius = 21;
            this.txtBoxFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFullname.DefaultText = "";
            this.txtBoxFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullname.Location = new System.Drawing.Point(69, 69);
            this.txtBoxFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxFullname.Name = "txtBoxFullname";
            this.txtBoxFullname.PasswordChar = '\0';
            this.txtBoxFullname.PlaceholderText = "";
            this.txtBoxFullname.SelectedText = "";
            this.txtBoxFullname.Size = new System.Drawing.Size(306, 44);
            this.txtBoxFullname.TabIndex = 116;
            // 
            // CmbBoxRole
            // 
            this.CmbBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.CmbBoxRole.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.CmbBoxRole.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CmbBoxRole.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.CmbBoxRole.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CmbBoxRole.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.CmbBoxRole.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.CmbBoxRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxRole.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.CmbBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.CmbBoxRole.FormattingEnabled = true;
            this.CmbBoxRole.ItemHeight = 30;
            this.CmbBoxRole.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.CmbBoxRole.LineColorA = System.Drawing.Color.White;
            this.CmbBoxRole.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.CmbBoxRole.LineColorC = System.Drawing.Color.White;
            this.CmbBoxRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbBoxRole.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbBoxRole.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CmbBoxRole.ListForeColor = System.Drawing.Color.Black;
            this.CmbBoxRole.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbBoxRole.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbBoxRole.Location = new System.Drawing.Point(69, 151);
            this.CmbBoxRole.Name = "CmbBoxRole";
            this.CmbBoxRole.Size = new System.Drawing.Size(175, 36);
            this.CmbBoxRole.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.CmbBoxRole.StartIndex = 0;
            this.CmbBoxRole.TabIndex = 115;
            this.CmbBoxRole.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.CmbBoxRole.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            // 
            // PictureBoxEmployee
            // 
            this.PictureBoxEmployee.ImageRotate = 0F;
            this.PictureBoxEmployee.Location = new System.Drawing.Point(87, 386);
            this.PictureBoxEmployee.Name = "PictureBoxEmployee";
            this.PictureBoxEmployee.Size = new System.Drawing.Size(272, 182);
            this.PictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEmployee.TabIndex = 126;
            this.PictureBoxEmployee.TabStop = false;
            // 
            // nightLabel3
            // 
            this.nightLabel3.AutoSize = true;
            this.nightLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel3.Location = new System.Drawing.Point(83, 363);
            this.nightLabel3.Name = "nightLabel3";
            this.nightLabel3.Size = new System.Drawing.Size(54, 20);
            this.nightLabel3.TabIndex = 124;
            this.nightLabel3.Text = "Picture";
            // 
            // BtnUpload
            // 
            this.BtnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpload.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.BtnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUpload.Image = null;
            this.BtnUpload.Location = new System.Drawing.Point(87, 574);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.NoRounding = false;
            this.BtnUpload.Size = new System.Drawing.Size(272, 39);
            this.BtnUpload.TabIndex = 127;
            this.BtnUpload.Text = "Upload Picture";
            this.BtnUpload.Transparent = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 689);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.PictureBoxEmployee);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.nightLabel3);
            this.Controls.Add(this.nightLabel2);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.nightLabel6);
            this.Controls.Add(this.nightLabel4);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.nightLabel1);
            this.Controls.Add(this.txtBoxFullname);
            this.Controls.Add(this.CmbBoxRole);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton BtnEdit;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPass;
        private ReaLTaiizor.Controls.NightLabel nightLabel6;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUsername;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFullname;
        private ReaLTaiizor.Controls.SkyComboBox CmbBoxRole;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxEmployee;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private ReaLTaiizor.Controls.AirButton BtnUpload;
    }
}