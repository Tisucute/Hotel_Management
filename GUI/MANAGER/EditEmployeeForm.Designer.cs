namespace GUI
{
    partial class EditEmployeeForm
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
            this.LabelManager = new System.Windows.Forms.Label();
            this.BtnSave = new Guna.UI2.WinForms.Guna2CircleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtnQuit = new ReaLTaiizor.Controls.FoxRadioButton();
            this.RadioBtnKeepOn = new ReaLTaiizor.Controls.FoxRadioButton();
            this.nightLabel5 = new ReaLTaiizor.Controls.NightLabel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.nightLabel7 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel6 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.RadioBtnFemale = new ReaLTaiizor.Controls.FoxRadioButton();
            this.RadioBtnMale = new ReaLTaiizor.Controls.FoxRadioButton();
            this.BtnUpload = new ReaLTaiizor.Controls.AirButton();
            this.CmbBoxRole = new ReaLTaiizor.Controls.SkyComboBox();
            this.DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxEmployee = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelManager
            // 
            this.LabelManager.AutoSize = true;
            this.LabelManager.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManager.Location = new System.Drawing.Point(74, 52);
            this.LabelManager.Name = "LabelManager";
            this.LabelManager.Size = new System.Drawing.Size(429, 23);
            this.LabelManager.TabIndex = 120;
            this.LabelManager.Text = "Hotel_Management | MANAGER | Edit Information";
            // 
            // BtnSave
            // 
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(365, 609);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnSave.Size = new System.Drawing.Size(117, 48);
            this.BtnSave.TabIndex = 119;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBtnQuit);
            this.groupBox1.Controls.Add(this.RadioBtnKeepOn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Location = new System.Drawing.Point(486, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 90);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // RadioBtnQuit
            // 
            this.RadioBtnQuit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RadioBtnQuit.Checked = false;
            this.RadioBtnQuit.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnQuit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RadioBtnQuit.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RadioBtnQuit.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.RadioBtnQuit.EnabledCalc = true;
            this.RadioBtnQuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadioBtnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.RadioBtnQuit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnQuit.Location = new System.Drawing.Point(60, 55);
            this.RadioBtnQuit.Name = "RadioBtnQuit";
            this.RadioBtnQuit.Size = new System.Drawing.Size(147, 23);
            this.RadioBtnQuit.TabIndex = 72;
            this.RadioBtnQuit.Text = "Quit";
            // 
            // RadioBtnKeepOn
            // 
            this.RadioBtnKeepOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RadioBtnKeepOn.Checked = false;
            this.RadioBtnKeepOn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnKeepOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnKeepOn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RadioBtnKeepOn.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RadioBtnKeepOn.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.RadioBtnKeepOn.EnabledCalc = true;
            this.RadioBtnKeepOn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadioBtnKeepOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.RadioBtnKeepOn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnKeepOn.Location = new System.Drawing.Point(60, 26);
            this.RadioBtnKeepOn.Name = "RadioBtnKeepOn";
            this.RadioBtnKeepOn.Size = new System.Drawing.Size(147, 23);
            this.RadioBtnKeepOn.TabIndex = 71;
            this.RadioBtnKeepOn.Text = "Keep On";
            // 
            // nightLabel5
            // 
            this.nightLabel5.AutoSize = true;
            this.nightLabel5.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel5.Location = new System.Drawing.Point(92, 133);
            this.nightLabel5.Name = "nightLabel5";
            this.nightLabel5.Size = new System.Drawing.Size(24, 20);
            this.nightLabel5.TabIndex = 110;
            this.nightLabel5.Text = "ID";
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(679, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 73;
            // 
            // nightLabel7
            // 
            this.nightLabel7.AutoSize = true;
            this.nightLabel7.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel7.Location = new System.Drawing.Point(488, 143);
            this.nightLabel7.Name = "nightLabel7";
            this.nightLabel7.Size = new System.Drawing.Size(72, 20);
            this.nightLabel7.TabIndex = 117;
            this.nightLabel7.Text = "BirthDate";
            // 
            // nightLabel3
            // 
            this.nightLabel3.AutoSize = true;
            this.nightLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel3.Location = new System.Drawing.Point(92, 495);
            this.nightLabel3.Name = "nightLabel3";
            this.nightLabel3.Size = new System.Drawing.Size(47, 20);
            this.nightLabel3.TabIndex = 116;
            this.nightLabel3.Text = "CCCD";
            // 
            // txtBoxCCCD
            // 
            this.txtBoxCCCD.Animated = true;
            this.txtBoxCCCD.AutoRoundedCorners = true;
            this.txtBoxCCCD.BorderRadius = 21;
            this.txtBoxCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCCCD.DefaultText = "";
            this.txtBoxCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCCCD.Location = new System.Drawing.Point(78, 519);
            this.txtBoxCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCCCD.Name = "txtBoxCCCD";
            this.txtBoxCCCD.PasswordChar = '\0';
            this.txtBoxCCCD.PlaceholderText = "";
            this.txtBoxCCCD.SelectedText = "";
            this.txtBoxCCCD.Size = new System.Drawing.Size(306, 44);
            this.txtBoxCCCD.TabIndex = 115;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(390, 117);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(65, 476);
            this.guna2VSeparator1.TabIndex = 114;
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel2.Location = new System.Drawing.Point(92, 413);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(62, 20);
            this.nightLabel2.TabIndex = 113;
            this.nightLabel2.Text = "Address";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Animated = true;
            this.txtBoxAddress.AutoRoundedCorners = true;
            this.txtBoxAddress.BorderRadius = 21;
            this.txtBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAddress.DefaultText = "";
            this.txtBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.Location = new System.Drawing.Point(78, 437);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.PasswordChar = '\0';
            this.txtBoxAddress.PlaceholderText = "";
            this.txtBoxAddress.SelectedText = "";
            this.txtBoxAddress.Size = new System.Drawing.Size(306, 44);
            this.txtBoxAddress.TabIndex = 112;
            // 
            // nightLabel6
            // 
            this.nightLabel6.AutoSize = true;
            this.nightLabel6.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel6.Location = new System.Drawing.Point(215, 133);
            this.nightLabel6.Name = "nightLabel6";
            this.nightLabel6.Size = new System.Drawing.Size(39, 20);
            this.nightLabel6.TabIndex = 111;
            this.nightLabel6.Text = "Role";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Animated = true;
            this.txtBoxID.AutoRoundedCorners = true;
            this.txtBoxID.BorderRadius = 17;
            this.txtBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxID.DefaultText = "";
            this.txtBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxID.Location = new System.Drawing.Point(78, 166);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PasswordChar = '\0';
            this.txtBoxID.PlaceholderText = "";
            this.txtBoxID.SelectedText = "";
            this.txtBoxID.Size = new System.Drawing.Size(102, 36);
            this.txtBoxID.TabIndex = 109;
            // 
            // nightLabel4
            // 
            this.nightLabel4.AutoSize = true;
            this.nightLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel4.Location = new System.Drawing.Point(92, 331);
            this.nightLabel4.Name = "nightLabel4";
            this.nightLabel4.Size = new System.Drawing.Size(50, 20);
            this.nightLabel4.TabIndex = 108;
            this.nightLabel4.Text = "Phone";
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Animated = true;
            this.txtBoxFullName.AutoRoundedCorners = true;
            this.txtBoxFullName.BorderRadius = 21;
            this.txtBoxFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFullName.DefaultText = "";
            this.txtBoxFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullName.Location = new System.Drawing.Point(78, 247);
            this.txtBoxFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.PasswordChar = '\0';
            this.txtBoxFullName.PlaceholderText = "";
            this.txtBoxFullName.SelectedText = "";
            this.txtBoxFullName.Size = new System.Drawing.Size(306, 44);
            this.txtBoxFullName.TabIndex = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 49);
            this.panel1.TabIndex = 104;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Animated = true;
            this.txtBoxPhone.AutoRoundedCorners = true;
            this.txtBoxPhone.BorderRadius = 21;
            this.txtBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPhone.DefaultText = "";
            this.txtBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPhone.Location = new System.Drawing.Point(78, 355);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PasswordChar = '\0';
            this.txtBoxPhone.PlaceholderText = "";
            this.txtBoxPhone.SelectedText = "";
            this.txtBoxPhone.Size = new System.Drawing.Size(306, 44);
            this.txtBoxPhone.TabIndex = 107;
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(92, 223);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(76, 20);
            this.nightLabel1.TabIndex = 106;
            this.nightLabel1.Text = "Full Name";
            // 
            // RadioBtnFemale
            // 
            this.RadioBtnFemale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RadioBtnFemale.Checked = false;
            this.RadioBtnFemale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnFemale.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RadioBtnFemale.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RadioBtnFemale.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.RadioBtnFemale.EnabledCalc = true;
            this.RadioBtnFemale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadioBtnFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.RadioBtnFemale.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnFemale.Location = new System.Drawing.Point(245, 300);
            this.RadioBtnFemale.Name = "RadioBtnFemale";
            this.RadioBtnFemale.Size = new System.Drawing.Size(177, 23);
            this.RadioBtnFemale.TabIndex = 102;
            this.RadioBtnFemale.Text = "Female";
            // 
            // RadioBtnMale
            // 
            this.RadioBtnMale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RadioBtnMale.Checked = false;
            this.RadioBtnMale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnMale.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RadioBtnMale.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RadioBtnMale.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.RadioBtnMale.EnabledCalc = true;
            this.RadioBtnMale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadioBtnMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.RadioBtnMale.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.RadioBtnMale.Location = new System.Drawing.Point(102, 300);
            this.RadioBtnMale.Name = "RadioBtnMale";
            this.RadioBtnMale.Size = new System.Drawing.Size(177, 23);
            this.RadioBtnMale.TabIndex = 101;
            this.RadioBtnMale.Text = "Male";
            // 
            // BtnUpload
            // 
            this.BtnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpload.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.BtnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUpload.Image = null;
            this.BtnUpload.Location = new System.Drawing.Point(483, 413);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.NoRounding = false;
            this.BtnUpload.Size = new System.Drawing.Size(272, 39);
            this.BtnUpload.TabIndex = 100;
            this.BtnUpload.Text = "Upload Picture";
            this.BtnUpload.Transparent = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
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
            this.CmbBoxRole.Location = new System.Drawing.Point(209, 166);
            this.CmbBoxRole.Name = "CmbBoxRole";
            this.CmbBoxRole.Size = new System.Drawing.Size(175, 36);
            this.CmbBoxRole.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.CmbBoxRole.StartIndex = 0;
            this.CmbBoxRole.TabIndex = 99;
            this.CmbBoxRole.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.CmbBoxRole.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            // 
            // DatePicker
            // 
            this.DatePicker.Checked = true;
            this.DatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(483, 166);
            this.DatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(272, 31);
            this.DatePicker.TabIndex = 98;
            this.DatePicker.Value = new System.DateTime(2024, 4, 17, 23, 51, 44, 196);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_writer_male_48;
            this.pictureBox1.Location = new System.Drawing.Point(8, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBoxEmployee
            // 
            this.PictureBoxEmployee.ImageRotate = 0F;
            this.PictureBoxEmployee.Location = new System.Drawing.Point(483, 225);
            this.PictureBoxEmployee.Name = "PictureBoxEmployee";
            this.PictureBoxEmployee.Size = new System.Drawing.Size(272, 182);
            this.PictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEmployee.TabIndex = 103;
            this.PictureBoxEmployee.TabStop = false;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 670);
            this.Controls.Add(this.LabelManager);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nightLabel5);
            this.Controls.Add(this.nightLabel7);
            this.Controls.Add(this.nightLabel3);
            this.Controls.Add(this.txtBoxCCCD);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.nightLabel2);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.nightLabel6);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.nightLabel4);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.nightLabel1);
            this.Controls.Add(this.PictureBoxEmployee);
            this.Controls.Add(this.RadioBtnFemale);
            this.Controls.Add(this.RadioBtnMale);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.CmbBoxRole);
            this.Controls.Add(this.DatePicker);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelManager;
        private Guna.UI2.WinForms.Guna2CircleButton BtnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private ReaLTaiizor.Controls.FoxRadioButton RadioBtnQuit;
        private ReaLTaiizor.Controls.FoxRadioButton RadioBtnKeepOn;
        private ReaLTaiizor.Controls.NightLabel nightLabel5;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.NightLabel nightLabel7;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCCCD;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAddress;
        private ReaLTaiizor.Controls.NightLabel nightLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxID;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPhone;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxEmployee;
        private ReaLTaiizor.Controls.FoxRadioButton RadioBtnFemale;
        private ReaLTaiizor.Controls.FoxRadioButton RadioBtnMale;
        private ReaLTaiizor.Controls.AirButton BtnUpload;
        private ReaLTaiizor.Controls.SkyComboBox CmbBoxRole;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicker;
    }
}