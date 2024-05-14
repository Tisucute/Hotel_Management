namespace GUI
{
    partial class CheckinCheckoutForm
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
            this.GroupBoxCheck = new ReaLTaiizor.Controls.RibbonGroupBox();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.skyLabel5 = new ReaLTaiizor.Controls.SkyLabel();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBoxProfile = new ReaLTaiizor.Controls.RibbonGroupBox();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtBoxRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtBoxCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.moonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            this.nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBoxEmployee = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxCheck.SuspendLayout();
            this.GroupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxCheck
            // 
            this.GroupBoxCheck.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxCheck.BaseColor = System.Drawing.Color.Transparent;
            this.GroupBoxCheck.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.GroupBoxCheck.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.GroupBoxCheck.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.GroupBoxCheck.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.GroupBoxCheck.Controls.Add(this.btnCheckIn);
            this.GroupBoxCheck.Controls.Add(this.skyLabel5);
            this.GroupBoxCheck.Controls.Add(this.DateTimePicker);
            this.GroupBoxCheck.Controls.Add(this.pictureBox1);
            this.GroupBoxCheck.Controls.Add(this.TimePicker);
            this.GroupBoxCheck.Controls.Add(this.btnCheckOut);
            this.GroupBoxCheck.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBoxCheck.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxCheck.LineColorA = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.GroupBoxCheck.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.GroupBoxCheck.Location = new System.Drawing.Point(864, 208);
            this.GroupBoxCheck.Name = "GroupBoxCheck";
            this.GroupBoxCheck.Size = new System.Drawing.Size(554, 312);
            this.GroupBoxCheck.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.GroupBoxCheck.TabIndex = 16;
            this.GroupBoxCheck.Text = "Check in & Check out";
            this.GroupBoxCheck.Click += new System.EventHandler(this.GroupBoxCheck_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Animated = true;
            this.btnCheckIn.AutoRoundedCorners = true;
            this.btnCheckIn.BorderRadius = 18;
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(115, 175);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 39);
            this.btnCheckIn.TabIndex = 38;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseTransparentBackground = true;
            // 
            // skyLabel5
            // 
            this.skyLabel5.AutoSize = true;
            this.skyLabel5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel5.Location = new System.Drawing.Point(96, 80);
            this.skyLabel5.Name = "skyLabel5";
            this.skyLabel5.Size = new System.Drawing.Size(52, 14);
            this.skyLabel5.TabIndex = 36;
            this.skyLabel5.Text = "Today:";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Animated = true;
            this.DateTimePicker.AutoRoundedCorners = true;
            this.DateTimePicker.BorderRadius = 21;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.PaleTurquoise;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(65, 111);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(209, 45);
            this.DateTimePicker.TabIndex = 35;
            this.DateTimePicker.Value = new System.DateTime(2024, 5, 9, 22, 36, 36, 407);
            // 
            // TimePicker
            // 
            this.TimePicker.AutoRoundedCorners = true;
            this.TimePicker.BackColor = System.Drawing.Color.Transparent;
            this.TimePicker.BorderRadius = 21;
            this.TimePicker.Checked = true;
            this.TimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(331, 111);
            this.TimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(158, 45);
            this.TimePicker.TabIndex = 34;
            this.TimePicker.UseTransparentBackground = true;
            this.TimePicker.Value = new System.DateTime(2024, 4, 18, 0, 0, 0, 0);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Animated = true;
            this.btnCheckOut.AutoRoundedCorners = true;
            this.btnCheckOut.BorderRadius = 18;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(313, 175);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(150, 39);
            this.btnCheckOut.TabIndex = 33;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseTransparentBackground = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // GroupBoxProfile
            // 
            this.GroupBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxProfile.BaseColor = System.Drawing.Color.Transparent;
            this.GroupBoxProfile.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.GroupBoxProfile.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.GroupBoxProfile.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.GroupBoxProfile.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.GroupBoxProfile.Controls.Add(this.skyLabel4);
            this.GroupBoxProfile.Controls.Add(this.txtBoxRole);
            this.GroupBoxProfile.Controls.Add(this.skyLabel3);
            this.GroupBoxProfile.Controls.Add(this.txtBoxID);
            this.GroupBoxProfile.Controls.Add(this.skyLabel2);
            this.GroupBoxProfile.Controls.Add(this.txtBoxCCCD);
            this.GroupBoxProfile.Controls.Add(this.skyLabel1);
            this.GroupBoxProfile.Controls.Add(this.txtFullName);
            this.GroupBoxProfile.Controls.Add(this.PictureBoxEmployee);
            this.GroupBoxProfile.Controls.Add(this.pictureBox2);
            this.GroupBoxProfile.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBoxProfile.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxProfile.LineColorA = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.GroupBoxProfile.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.GroupBoxProfile.Location = new System.Drawing.Point(246, 208);
            this.GroupBoxProfile.Name = "GroupBoxProfile";
            this.GroupBoxProfile.Size = new System.Drawing.Size(611, 312);
            this.GroupBoxProfile.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.GroupBoxProfile.TabIndex = 17;
            this.GroupBoxProfile.Text = "Employee Profile";
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel4.Location = new System.Drawing.Point(428, 93);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(36, 14);
            this.skyLabel4.TabIndex = 30;
            this.skyLabel4.Text = "Role";
            // 
            // txtBoxRole
            // 
            this.txtBoxRole.AutoRoundedCorners = true;
            this.txtBoxRole.BorderRadius = 14;
            this.txtBoxRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxRole.DefaultText = "";
            this.txtBoxRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRole.Enabled = false;
            this.txtBoxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRole.Location = new System.Drawing.Point(421, 111);
            this.txtBoxRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRole.Name = "txtBoxRole";
            this.txtBoxRole.PasswordChar = '\0';
            this.txtBoxRole.PlaceholderText = "";
            this.txtBoxRole.ReadOnly = true;
            this.txtBoxRole.SelectedText = "";
            this.txtBoxRole.Size = new System.Drawing.Size(146, 31);
            this.txtBoxRole.TabIndex = 29;
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel3.Location = new System.Drawing.Point(320, 93);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(23, 14);
            this.skyLabel3.TabIndex = 28;
            this.skyLabel3.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.AutoRoundedCorners = true;
            this.txtBoxID.BorderRadius = 14;
            this.txtBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxID.DefaultText = "";
            this.txtBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxID.Enabled = false;
            this.txtBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxID.Location = new System.Drawing.Point(313, 111);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PasswordChar = '\0';
            this.txtBoxID.PlaceholderText = "";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.SelectedText = "";
            this.txtBoxID.Size = new System.Drawing.Size(93, 31);
            this.txtBoxID.TabIndex = 27;
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(320, 229);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(44, 14);
            this.skyLabel2.TabIndex = 26;
            this.skyLabel2.Text = "CCCD";
            // 
            // txtBoxCCCD
            // 
            this.txtBoxCCCD.AutoRoundedCorners = true;
            this.txtBoxCCCD.BorderRadius = 14;
            this.txtBoxCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCCCD.DefaultText = "";
            this.txtBoxCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCCCD.Enabled = false;
            this.txtBoxCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCCCD.Location = new System.Drawing.Point(313, 247);
            this.txtBoxCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCCCD.Name = "txtBoxCCCD";
            this.txtBoxCCCD.PasswordChar = '\0';
            this.txtBoxCCCD.PlaceholderText = "";
            this.txtBoxCCCD.ReadOnly = true;
            this.txtBoxCCCD.SelectedText = "";
            this.txtBoxCCCD.Size = new System.Drawing.Size(254, 31);
            this.txtBoxCCCD.TabIndex = 25;
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(320, 161);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(73, 14);
            this.skyLabel1.TabIndex = 24;
            this.skyLabel1.Text = "Full Name";
            this.skyLabel1.Click += new System.EventHandler(this.skyLabel1_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.AutoRoundedCorners = true;
            this.txtFullName.BorderRadius = 14;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.Enabled = false;
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(313, 179);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(254, 31);
            this.txtFullName.TabIndex = 23;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // moonLabel1
            // 
            this.moonLabel1.AutoSize = true;
            this.moonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel1.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel1.Location = new System.Drawing.Point(214, 485);
            this.moonLabel1.Name = "moonLabel1";
            this.moonLabel1.Size = new System.Drawing.Size(0, 16);
            this.moonLabel1.TabIndex = 19;
            // 
            // nightHeaderLabel1
            // 
            this.nightHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.Location = new System.Drawing.Point(542, 91);
            this.nightHeaderLabel1.Name = "nightHeaderLabel1";
            this.nightHeaderLabel1.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel1.Size = new System.Drawing.Size(596, 96);
            this.nightHeaderLabel1.TabIndex = 20;
            this.nightHeaderLabel1.Text = "Attendance";
            this.nightHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1809, 49);
            this.guna2Panel1.TabIndex = 21;
            // 
            // PictureBoxEmployee
            // 
            this.PictureBoxEmployee.ImageRotate = 0F;
            this.PictureBoxEmployee.Location = new System.Drawing.Point(43, 92);
            this.PictureBoxEmployee.Name = "PictureBoxEmployee";
            this.PictureBoxEmployee.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxEmployee.Size = new System.Drawing.Size(200, 190);
            this.PictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEmployee.TabIndex = 22;
            this.PictureBoxEmployee.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.icons8_about_me_50;
            this.pictureBox2.Location = new System.Drawing.Point(18, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_instagram_check_mark_50;
            this.pictureBox1.Location = new System.Drawing.Point(22, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CheckinCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1809, 842);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.nightHeaderLabel1);
            this.Controls.Add(this.moonLabel1);
            this.Controls.Add(this.GroupBoxProfile);
            this.Controls.Add(this.GroupBoxCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckinCheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckinCheckoutForm";
            this.Load += new System.EventHandler(this.CheckinCheckoutForm_Load);
            this.GroupBoxCheck.ResumeLayout(false);
            this.GroupBoxCheck.PerformLayout();
            this.GroupBoxProfile.ResumeLayout(false);
            this.GroupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.RibbonGroupBox GroupBoxCheck;
        private ReaLTaiizor.Controls.RibbonGroupBox GroupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxEmployee;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCCCD;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxRole;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxID;
        private ReaLTaiizor.Controls.MoonLabel moonLabel1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicker;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
    }
}