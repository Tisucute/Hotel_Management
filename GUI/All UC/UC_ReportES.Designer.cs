namespace GUI
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
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckTime = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotalTime = new ReaLTaiizor.Controls.MetroLabel();
            this.DatePicker = new ReaLTaiizor.Controls.PoisonDateTime();
            this.panelTotalTime = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.RadioBtnAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButtonJanitor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButtonRecep = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BtnSearch = new System.Windows.Forms.PictureBox();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelTotalTime.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.SuspendLayout();
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
            this.btnPrint.Location = new System.Drawing.Point(821, 178);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(203, 68);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnCheckTime.Location = new System.Drawing.Point(821, 300);
            this.btnCheckTime.Name = "btnCheckTime";
            this.btnCheckTime.Size = new System.Drawing.Size(203, 66);
            this.btnCheckTime.TabIndex = 22;
            this.btnCheckTime.Text = "Check Time";
            this.btnCheckTime.Click += new System.EventHandler(this.btnCheckTime_Click);
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTotalTime.IsDerivedStyle = true;
            this.labelTotalTime.Location = new System.Drawing.Point(-2, 0);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(230, 58);
            this.labelTotalTime.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.labelTotalTime.StyleManager = null;
            this.labelTotalTime.TabIndex = 0;
            this.labelTotalTime.Text = "Total Time:";
            this.labelTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotalTime.ThemeAuthor = "Taiizor";
            this.labelTotalTime.ThemeName = "MetroLight";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(316, 32);
            this.DatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(243, 30);
            this.DatePicker.TabIndex = 22;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // panelTotalTime
            // 
            this.panelTotalTime.BorderRadius = 30;
            this.panelTotalTime.Controls.Add(this.labelTotalTime);
            this.panelTotalTime.FillColor = System.Drawing.Color.PaleTurquoise;
            this.panelTotalTime.FillColor2 = System.Drawing.Color.LightCyan;
            this.panelTotalTime.FillColor3 = System.Drawing.Color.PaleTurquoise;
            this.panelTotalTime.FillColor4 = System.Drawing.Color.CornflowerBlue;
            this.panelTotalTime.Location = new System.Drawing.Point(65, 475);
            this.panelTotalTime.Name = "panelTotalTime";
            this.panelTotalTime.Size = new System.Drawing.Size(223, 59);
            this.panelTotalTime.TabIndex = 18;
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
            this.parrotGroupBox1.Location = new System.Drawing.Point(23, 19);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.ShowText = true;
            this.parrotGroupBox1.Size = new System.Drawing.Size(1028, 82);
            this.parrotGroupBox1.TabIndex = 17;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "Search Box";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // RadioBtnAll
            // 
            this.RadioBtnAll.AutoSize = true;
            this.RadioBtnAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioBtnAll.CheckedState.BorderThickness = 0;
            this.RadioBtnAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.RadioBtnAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioBtnAll.CheckedState.InnerOffset = -4;
            this.RadioBtnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.RadioBtnAll.Location = new System.Drawing.Point(250, 32);
            this.RadioBtnAll.Name = "RadioBtnAll";
            this.RadioBtnAll.Size = new System.Drawing.Size(49, 24);
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
            this.RadioButtonJanitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonJanitor.Location = new System.Drawing.Point(155, 32);
            this.RadioButtonJanitor.Name = "RadioButtonJanitor";
            this.RadioButtonJanitor.Size = new System.Drawing.Size(81, 24);
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
            this.RadioButtonRecep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonRecep.Location = new System.Drawing.Point(20, 32);
            this.RadioButtonRecep.Name = "RadioButtonRecep";
            this.RadioButtonRecep.Size = new System.Drawing.Size(123, 24);
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
            this.BtnSearch.Location = new System.Drawing.Point(949, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(52, 48);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.TextBoxSearch.Location = new System.Drawing.Point(591, 21);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Search here";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(335, 48);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.AllowUserToAddRows = false;
            this.dgvListEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmployees.ColumnHeadersHeight = 18;
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.Location = new System.Drawing.Point(43, 122);
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.ReadOnly = true;
            this.dgvListEmployees.RowHeadersVisible = false;
            this.dgvListEmployees.RowHeadersWidth = 51;
            this.dgvListEmployees.RowTemplate.Height = 24;
            this.dgvListEmployees.Size = new System.Drawing.Size(673, 347);
            this.dgvListEmployees.TabIndex = 26;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvListEmployees.ThemeStyle.ReadOnly = true;
            this.dgvListEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployees.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_ReportES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvListEmployees);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCheckTime);
            this.Controls.Add(this.panelTotalTime);
            this.Controls.Add(this.parrotGroupBox1);
            this.Name = "UC_ReportES";
            this.Size = new System.Drawing.Size(1062, 621);
            this.Load += new System.EventHandler(this.UC_ReportES_Load);
            this.panelTotalTime.ResumeLayout(false);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnCheckTime;
        private ReaLTaiizor.Controls.MetroLabel labelTotalTime;
        private ReaLTaiizor.Controls.PoisonDateTime DatePicker;
        private System.Windows.Forms.PictureBox BtnSearch;
        public Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTotalTime;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployees;
        private Guna.UI2.WinForms.Guna2RadioButton RadioBtnAll;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButtonJanitor;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButtonRecep;
    }
}
