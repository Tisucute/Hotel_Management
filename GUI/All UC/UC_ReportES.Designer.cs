namespace GUI.All_UC
{
    partial class UC_ReportES
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.DatePicker = new ReaLTaiizor.Controls.PoisonDateTime();
            this.RadioBtnAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButtonJanitor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButtonRecep = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BtnSearch = new System.Windows.Forms.PictureBox();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTotalTime = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.labelTotalTime = new ReaLTaiizor.Controls.MetroLabel();
            this.panelTotalSalary = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.labelTotalSalary = new ReaLTaiizor.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaticData = new Guna.UI2.WinForms.Guna2Button();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.panelTotalTime.SuspendLayout();
            this.panelTotalSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.DatePicker);
            this.parrotGroupBox1.Controls.Add(this.RadioBtnAll);
            this.parrotGroupBox1.Controls.Add(this.RadioButtonJanitor);
            this.parrotGroupBox1.Controls.Add(this.RadioButtonRecep);
            this.parrotGroupBox1.Controls.Add(this.BtnSearch);
            this.parrotGroupBox1.Controls.Add(this.TextBoxSearch);
            this.parrotGroupBox1.Location = new System.Drawing.Point(26, 13);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.ShowText = true;
            this.parrotGroupBox1.Size = new System.Drawing.Size(1050, 82);
            this.parrotGroupBox1.TabIndex = 0;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "Search Box";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(350, 30);
            this.DatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(243, 30);
            this.DatePicker.TabIndex = 22;
            // 
            // RadioBtnAll
            // 
            this.RadioBtnAll.AutoSize = true;
            this.RadioBtnAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioBtnAll.CheckedState.BorderThickness = 0;
            this.RadioBtnAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioBtnAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioBtnAll.CheckedState.InnerOffset = -4;
            this.RadioBtnAll.Font = new System.Drawing.Font("VNbahamas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnAll.Location = new System.Drawing.Point(250, 32);
            this.RadioBtnAll.Name = "RadioBtnAll";
            this.RadioBtnAll.Size = new System.Drawing.Size(48, 28);
            this.RadioBtnAll.TabIndex = 21;
            this.RadioBtnAll.Text = "All";
            this.RadioBtnAll.UncheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.RadioBtnAll.UncheckedState.BorderThickness = 1;
            this.RadioBtnAll.UncheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.RadioBtnAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioButtonJanitor
            // 
            this.RadioButtonJanitor.AutoSize = true;
            this.RadioButtonJanitor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioButtonJanitor.CheckedState.BorderThickness = 0;
            this.RadioButtonJanitor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioButtonJanitor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonJanitor.CheckedState.InnerOffset = -4;
            this.RadioButtonJanitor.Font = new System.Drawing.Font("VNbahamas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonJanitor.Location = new System.Drawing.Point(155, 32);
            this.RadioButtonJanitor.Name = "RadioButtonJanitor";
            this.RadioButtonJanitor.Size = new System.Drawing.Size(80, 28);
            this.RadioButtonJanitor.TabIndex = 20;
            this.RadioButtonJanitor.Text = "Janitor";
            this.RadioButtonJanitor.UncheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonJanitor.UncheckedState.BorderThickness = 1;
            this.RadioButtonJanitor.UncheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonJanitor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioButtonRecep
            // 
            this.RadioButtonRecep.AutoSize = true;
            this.RadioButtonRecep.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioButtonRecep.CheckedState.BorderThickness = 0;
            this.RadioButtonRecep.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioButtonRecep.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonRecep.CheckedState.InnerOffset = -4;
            this.RadioButtonRecep.Font = new System.Drawing.Font("VNbahamas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonRecep.Location = new System.Drawing.Point(20, 32);
            this.RadioButtonRecep.Name = "RadioButtonRecep";
            this.RadioButtonRecep.Size = new System.Drawing.Size(122, 28);
            this.RadioButtonRecep.TabIndex = 19;
            this.RadioButtonRecep.Text = "Receptionist";
            this.RadioButtonRecep.UncheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonRecep.UncheckedState.BorderThickness = 1;
            this.RadioButtonRecep.UncheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonRecep.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::GUI.Properties.Resources.icons8_arrow_50__1_;
            this.BtnSearch.Location = new System.Drawing.Point(969, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(52, 48);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.TabStop = false;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Animated = true;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TextBoxSearch.IconLeft = global::GUI.Properties.Resources.icons8_search_64__1_;
            this.TextBoxSearch.Location = new System.Drawing.Point(628, 21);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Search here";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(335, 48);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmployees.ColumnHeadersHeight = 30;
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fullname,
            this.CCCD,
            this.Time,
            this.Salary});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.Location = new System.Drawing.Point(26, 112);
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.ReadOnly = true;
            this.dgvListEmployees.RowHeadersVisible = false;
            this.dgvListEmployees.RowHeadersWidth = 51;
            this.dgvListEmployees.RowTemplate.Height = 24;
            this.dgvListEmployees.Size = new System.Drawing.Size(442, 494);
            this.dgvListEmployees.TabIndex = 8;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListEmployees.ThemeStyle.ReadOnly = true;
            this.dgvListEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployees.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.MinimumWidth = 6;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // panelTotalTime
            // 
            this.panelTotalTime.BorderRadius = 30;
            this.panelTotalTime.Controls.Add(this.labelTotalTime);
            this.panelTotalTime.FillColor = System.Drawing.Color.PaleTurquoise;
            this.panelTotalTime.FillColor2 = System.Drawing.Color.LightCyan;
            this.panelTotalTime.FillColor3 = System.Drawing.Color.PaleTurquoise;
            this.panelTotalTime.FillColor4 = System.Drawing.Color.CornflowerBlue;
            this.panelTotalTime.Location = new System.Drawing.Point(483, 161);
            this.panelTotalTime.Name = "panelTotalTime";
            this.panelTotalTime.Size = new System.Drawing.Size(286, 157);
            this.panelTotalTime.TabIndex = 9;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTotalTime.IsDerivedStyle = true;
            this.labelTotalTime.Location = new System.Drawing.Point(89, 64);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(100, 23);
            this.labelTotalTime.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.labelTotalTime.StyleManager = null;
            this.labelTotalTime.TabIndex = 0;
            this.labelTotalTime.Text = "Total Time:";
            this.labelTotalTime.ThemeAuthor = "Taiizor";
            this.labelTotalTime.ThemeName = "MetroLight";
            // 
            // panelTotalSalary
            // 
            this.panelTotalSalary.BorderRadius = 30;
            this.panelTotalSalary.Controls.Add(this.labelTotalSalary);
            this.panelTotalSalary.FillColor = System.Drawing.Color.Moccasin;
            this.panelTotalSalary.FillColor2 = System.Drawing.Color.OldLace;
            this.panelTotalSalary.FillColor3 = System.Drawing.Color.Moccasin;
            this.panelTotalSalary.FillColor4 = System.Drawing.Color.DarkGoldenrod;
            this.panelTotalSalary.Location = new System.Drawing.Point(790, 161);
            this.panelTotalSalary.Name = "panelTotalSalary";
            this.panelTotalSalary.Size = new System.Drawing.Size(286, 157);
            this.panelTotalSalary.TabIndex = 10;
            // 
            // labelTotalSalary
            // 
            this.labelTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTotalSalary.IsDerivedStyle = true;
            this.labelTotalSalary.Location = new System.Drawing.Point(93, 67);
            this.labelTotalSalary.Name = "labelTotalSalary";
            this.labelTotalSalary.Size = new System.Drawing.Size(106, 23);
            this.labelTotalSalary.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.labelTotalSalary.StyleManager = null;
            this.labelTotalSalary.TabIndex = 1;
            this.labelTotalSalary.Text = "Total Salary:";
            this.labelTotalSalary.ThemeAuthor = "Taiizor";
            this.labelTotalSalary.ThemeName = "MetroLight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_point_48;
            this.pictureBox1.Location = new System.Drawing.Point(753, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 18;
            this.btnRefresh.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefresh.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(619, 438);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 46);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            // 
            // btnCheckTime
            // 
            this.btnCheckTime.BorderRadius = 18;
            this.btnCheckTime.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCheckTime.BorderThickness = 1;
            this.btnCheckTime.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckTime.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckTime.DisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckTime.FillColor = System.Drawing.Color.White;
            this.btnCheckTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckTime.ForeColor = System.Drawing.Color.DimGray;
            this.btnCheckTime.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckTime.Location = new System.Drawing.Point(809, 438);
            this.btnCheckTime.Name = "btnCheckTime";
            this.btnCheckTime.Size = new System.Drawing.Size(128, 46);
            this.btnCheckTime.TabIndex = 13;
            this.btnCheckTime.Text = "Check Time";
            this.btnCheckTime.Click += new System.EventHandler(this.btnCheckTime_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 18;
            this.btnPrint.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.DimGray;
            this.btnPrint.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.Location = new System.Drawing.Point(711, 386);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 46);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSaticData
            // 
            this.btnSaticData.BorderRadius = 18;
            this.btnSaticData.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSaticData.BorderThickness = 1;
            this.btnSaticData.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaticData.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSaticData.DisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaticData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaticData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaticData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaticData.FillColor = System.Drawing.Color.White;
            this.btnSaticData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaticData.ForeColor = System.Drawing.Color.DimGray;
            this.btnSaticData.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaticData.Location = new System.Drawing.Point(711, 490);
            this.btnSaticData.Name = "btnSaticData";
            this.btnSaticData.Size = new System.Drawing.Size(128, 46);
            this.btnSaticData.TabIndex = 15;
            this.btnSaticData.Text = "Static Data";
            // 
            // UC_ReportES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnSaticData);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCheckTime);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTotalSalary);
            this.Controls.Add(this.panelTotalTime);
            this.Controls.Add(this.dgvListEmployees);
            this.Controls.Add(this.parrotGroupBox1);
            this.Name = "UC_ReportES";
            this.Size = new System.Drawing.Size(1097, 621);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.panelTotalTime.ResumeLayout(false);
            this.panelTotalSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        public Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private System.Windows.Forms.PictureBox BtnSearch;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButtonJanitor;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButtonRecep;
        private Guna.UI2.WinForms.Guna2RadioButton RadioBtnAll;
        private ReaLTaiizor.Controls.PoisonDateTime DatePicker;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTotalTime;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTotalSalary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnCheckTime;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnSaticData;
        private ReaLTaiizor.Controls.MetroLabel labelTotalTime;
        private ReaLTaiizor.Controls.MetroLabel labelTotalSalary;
    }
}
