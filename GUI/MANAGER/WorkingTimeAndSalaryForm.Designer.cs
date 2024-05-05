namespace GUI
{
    partial class WorkingTimeAndSalaryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dgvListEmployeeAssign = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dgvListCheck = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelTotalSalary = new ReaLTaiizor.Controls.MetroLabel();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            this.comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeAssign)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheck)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.labelTitle.Location = new System.Drawing.Point(432, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "List Shift";
            // 
            // dgvListEmployeeAssign
            // 
            this.dgvListEmployeeAssign.AllowUserToAddRows = false;
            this.dgvListEmployeeAssign.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvListEmployeeAssign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployeeAssign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvListEmployeeAssign.ColumnHeadersHeight = 30;
            this.dgvListEmployeeAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployeeAssign.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvListEmployeeAssign.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.Location = new System.Drawing.Point(438, 140);
            this.dgvListEmployeeAssign.Name = "dgvListEmployeeAssign";
            this.dgvListEmployeeAssign.ReadOnly = true;
            this.dgvListEmployeeAssign.RowHeadersVisible = false;
            this.dgvListEmployeeAssign.RowHeadersWidth = 51;
            this.dgvListEmployeeAssign.RowTemplate.Height = 24;
            this.dgvListEmployeeAssign.Size = new System.Drawing.Size(1027, 406);
            this.dgvListEmployeeAssign.TabIndex = 8;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListEmployeeAssign.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListEmployeeAssign.ThemeStyle.ReadOnly = true;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Animated = true;
            this.DateTimePicker.AutoRoundedCorners = true;
            this.DateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePicker.BorderRadius = 17;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.FloralWhite;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(98, 98);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(229, 36);
            this.DateTimePicker.TabIndex = 13;
            this.DateTimePicker.UseTransparentBackground = true;
            this.DateTimePicker.Value = new System.DateTime(2024, 4, 27, 21, 40, 53, 875);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.groupBox.Controls.Add(this.dungeonHeaderLabel3);
            this.groupBox.Controls.Add(this.dgvListCheck);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F);
            this.groupBox.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox.Location = new System.Drawing.Point(37, 159);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(358, 387);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // dungeonHeaderLabel3
            // 
            this.dungeonHeaderLabel3.AutoSize = true;
            this.dungeonHeaderLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.dungeonHeaderLabel3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonHeaderLabel3.ForeColor = System.Drawing.Color.LightCoral;
            this.dungeonHeaderLabel3.Location = new System.Drawing.Point(6, 0);
            this.dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            this.dungeonHeaderLabel3.Size = new System.Drawing.Size(79, 31);
            this.dungeonHeaderLabel3.TabIndex = 10;
            this.dungeonHeaderLabel3.Text = "Check";
            // 
            // dgvListCheck
            // 
            this.dgvListCheck.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvListCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvListCheck.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListCheck.ColumnHeadersHeight = 30;
            this.dgvListCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Checkin,
            this.Checkout,
            this.Time});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCheck.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListCheck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListCheck.Location = new System.Drawing.Point(6, 38);
            this.dgvListCheck.Name = "dgvListCheck";
            this.dgvListCheck.ReadOnly = true;
            this.dgvListCheck.RowHeadersVisible = false;
            this.dgvListCheck.RowHeadersWidth = 51;
            this.dgvListCheck.RowTemplate.Height = 24;
            this.dgvListCheck.Size = new System.Drawing.Size(346, 338);
            this.dgvListCheck.TabIndex = 9;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListCheck.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListCheck.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListCheck.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListCheck.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListCheck.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListCheck.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListCheck.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListCheck.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListCheck.ThemeStyle.ReadOnly = true;
            this.dgvListCheck.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListCheck.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListCheck.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListCheck.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListCheck.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListCheck.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListCheck.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Fullname";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.HeaderText = "Checkin";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.HeaderText = "Checkout";
            this.Checkout.MinimumWidth = 6;
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 52);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.LabelHeader.Location = new System.Drawing.Point(621, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(259, 28);
            this.LabelHeader.TabIndex = 26;
            this.LabelHeader.Text = "Employee Management";
            // 
            // LabelTotalSalary
            // 
            this.LabelTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSalary.IsDerivedStyle = true;
            this.LabelTotalSalary.Location = new System.Drawing.Point(37, 573);
            this.LabelTotalSalary.Name = "LabelTotalSalary";
            this.LabelTotalSalary.Size = new System.Drawing.Size(162, 23);
            this.LabelTotalSalary.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.LabelTotalSalary.StyleManager = null;
            this.LabelTotalSalary.TabIndex = 22;
            this.LabelTotalSalary.Text = "Total Salary:";
            this.LabelTotalSalary.ThemeAuthor = "Taiizor";
            this.LabelTotalSalary.ThemeName = "MetroLight";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::GUI.Properties.Resources.icons8_refresh_48;
            this.BtnRefresh.Location = new System.Drawing.Point(166, 624);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(71, 63);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnRefresh.TabIndex = 24;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Transparent;
            this.comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox.ItemHeight = 30;
            this.comboBox.Items.AddRange(new object[] {
            "Ca 7h-11h",
            "Ca 11h-15h",
            "Ca 15h-19h",
            "Ca 19h-23h",
            "Ca 23h-3h",
            "Ca 3h-7h"});
            this.comboBox.Location = new System.Drawing.Point(438, 98);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(154, 36);
            this.comboBox.TabIndex = 25;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1275, 573);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(79, 29);
            this.labelTotal.TabIndex = 26;
            this.labelTotal.Text = "label1";
            // 
            // WorkingTimeAndSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1477, 718);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.LabelTotalSalary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.dgvListEmployeeAssign);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkingTimeAndSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkingTimeAndSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeAssign)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheck)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployeeAssign;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private System.Windows.Forms.GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListCheck;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MetroLabel LabelTotalSalary;
        private System.Windows.Forms.PictureBox BtnRefresh;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
        private System.Windows.Forms.Label labelTotal;
    }
}