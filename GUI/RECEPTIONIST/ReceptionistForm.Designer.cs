namespace GUI
{
    partial class ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistForm));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureBoxRecep = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panelWorkingTime = new System.Windows.Forms.Panel();
            this.BtnCheckTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnService = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            this.LabelManager = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MenuSideBar2 = new System.Windows.Forms.PictureBox();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelHienThi = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRecep)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelWorkingTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 100;
            // 
            // SideBar
            // 
            this.SideBar.AutoScroll = true;
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.SideBar.Controls.Add(this.panelAvatar);
            this.SideBar.Controls.Add(this.panelHome);
            this.SideBar.Controls.Add(this.panelWorkingTime);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.panel4);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 62);
            this.SideBar.MaximumSize = new System.Drawing.Size(253, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(253, 799);
            this.SideBar.TabIndex = 12;
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.panelAvatar.Controls.Add(this.BtnLogOut);
            this.panelAvatar.Controls.Add(this.LabelName);
            this.panelAvatar.Controls.Add(this.PictureBoxRecep);
            this.panelAvatar.Location = new System.Drawing.Point(3, 3);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(246, 232);
            this.panelAvatar.TabIndex = 0;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.Image = global::GUI.Properties.Resources.icons8_arrow_50__2_1;
            this.BtnLogOut.Location = new System.Drawing.Point(207, 196);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(36, 33);
            this.BtnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogOut.TabIndex = 7;
            this.BtnLogOut.TabStop = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // LabelName
            // 
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelName.Location = new System.Drawing.Point(37, 183);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(164, 46);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Name";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxRecep
            // 
            this.PictureBoxRecep.ImageRotate = 0F;
            this.PictureBoxRecep.Location = new System.Drawing.Point(40, 26);
            this.PictureBoxRecep.Name = "PictureBoxRecep";
            this.PictureBoxRecep.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxRecep.Size = new System.Drawing.Size(156, 154);
            this.PictureBoxRecep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxRecep.TabIndex = 3;
            this.PictureBoxRecep.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.BtnHome);
            this.panelHome.Location = new System.Drawing.Point(3, 241);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(246, 65);
            this.panelHome.TabIndex = 1;
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnHome.Image = global::GUI.Properties.Resources.icons8_home_50__1_;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(4, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(240, 60);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "               Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelWorkingTime
            // 
            this.panelWorkingTime.Controls.Add(this.BtnCheckTime);
            this.panelWorkingTime.Location = new System.Drawing.Point(3, 312);
            this.panelWorkingTime.Name = "panelWorkingTime";
            this.panelWorkingTime.Size = new System.Drawing.Size(246, 65);
            this.panelWorkingTime.TabIndex = 6;
            // 
            // BtnCheckTime
            // 
            this.BtnCheckTime.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCheckTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCheckTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCheckTime.Image = global::GUI.Properties.Resources.icons8_calendar_50;
            this.BtnCheckTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckTime.Location = new System.Drawing.Point(4, 3);
            this.BtnCheckTime.Name = "BtnCheckTime";
            this.BtnCheckTime.Size = new System.Drawing.Size(240, 60);
            this.BtnCheckTime.TabIndex = 4;
            this.BtnCheckTime.Text = "              Check Time Work";
            this.BtnCheckTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckTime.UseVisualStyleBackColor = true;
            this.BtnCheckTime.Click += new System.EventHandler(this.BtnCheckTime_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRoom);
            this.panel1.Location = new System.Drawing.Point(3, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 65);
            this.panel1.TabIndex = 7;
            // 
            // BtnRoom
            // 
            this.BtnRoom.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRoom.Image = global::GUI.Properties.Resources.icons8_bed_50;
            this.BtnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRoom.Location = new System.Drawing.Point(3, 2);
            this.BtnRoom.Name = "BtnRoom";
            this.BtnRoom.Size = new System.Drawing.Size(240, 60);
            this.BtnRoom.TabIndex = 5;
            this.BtnRoom.Text = "               Room Management";
            this.BtnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRoom.UseVisualStyleBackColor = true;
            this.BtnRoom.Click += new System.EventHandler(this.BtnRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCustomer);
            this.panel2.Location = new System.Drawing.Point(3, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 65);
            this.panel2.TabIndex = 8;
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCustomer.Image = global::GUI.Properties.Resources.icons8_tourist_50;
            this.BtnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomer.Location = new System.Drawing.Point(3, 2);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(240, 60);
            this.BtnCustomer.TabIndex = 6;
            this.BtnCustomer.Text = "               Customers";
            this.BtnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomer.UseVisualStyleBackColor = true;
            this.BtnCustomer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnService);
            this.panel3.Location = new System.Drawing.Point(3, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 65);
            this.panel3.TabIndex = 9;
            // 
            // btnService
            // 
            this.btnService.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnService.Image = global::GUI.Properties.Resources.icons8_service_50;
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(3, 2);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(240, 60);
            this.btnService.TabIndex = 7;
            this.btnService.Text = "               Services";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRevenueReport);
            this.panel4.Location = new System.Drawing.Point(3, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 65);
            this.panel4.TabIndex = 10;
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRevenueReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRevenueReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRevenueReport.Image = global::GUI.Properties.Resources.icons8_report_50__1_;
            this.btnRevenueReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenueReport.Location = new System.Drawing.Point(4, 3);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(240, 60);
            this.btnRevenueReport.TabIndex = 8;
            this.btnRevenueReport.Text = "               Revenue Reports";
            this.btnRevenueReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenueReport.UseVisualStyleBackColor = true;
            this.btnRevenueReport.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // LabelManager
            // 
            this.LabelManager.AutoSize = true;
            this.LabelManager.BackColor = System.Drawing.Color.Transparent;
            this.LabelManager.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManager.Location = new System.Drawing.Point(51, 18);
            this.LabelManager.Name = "LabelManager";
            this.LabelManager.Size = new System.Drawing.Size(397, 28);
            this.LabelManager.TabIndex = 5;
            this.LabelManager.Text = "Hotel_Management | RECEPTIONIST";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitle.Controls.Add(this.guna2ControlBox1);
            this.panelTitle.Controls.Add(this.MenuSideBar2);
            this.panelTitle.Controls.Add(this.LabelManager);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1490, 62);
            this.panelTitle.TabIndex = 11;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1433, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // MenuSideBar2
            // 
            this.MenuSideBar2.BackColor = System.Drawing.Color.Transparent;
            this.MenuSideBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuSideBar2.Image = global::GUI.Properties.Resources.icons8_menu_64__1_;
            this.MenuSideBar2.Location = new System.Drawing.Point(10, 12);
            this.MenuSideBar2.Name = "MenuSideBar2";
            this.MenuSideBar2.Size = new System.Drawing.Size(41, 44);
            this.MenuSideBar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuSideBar2.TabIndex = 4;
            this.MenuSideBar2.TabStop = false;
            this.MenuSideBar2.Click += new System.EventHandler(this.MenuSideBar2_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // PanelHienThi
            // 
            this.PanelHienThi.BackgroundImage = global::GUI.Properties.Resources.velassaru_maldives_resort_vacation_wallpaper_thumb__1_;
            this.PanelHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHienThi.Location = new System.Drawing.Point(253, 62);
            this.PanelHienThi.Name = "PanelHienThi";
            this.PanelHienThi.Size = new System.Drawing.Size(1237, 799);
            this.PanelHienThi.TabIndex = 13;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.velassaru_maldives_resort_vacation_wallpaper_thumb__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1490, 861);
            this.Controls.Add(this.PanelHienThi);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceptionistForm_FormClosing);
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.SideBar.ResumeLayout(false);
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRecep)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelWorkingTime.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHienThi;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelWorkingTime;
        private System.Windows.Forms.Button BtnCheckTime;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox MenuSideBar2;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Label LabelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxRecep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRoom;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnRevenueReport;
        private System.Windows.Forms.PictureBox BtnLogOut;
        public System.Windows.Forms.Label LabelManager;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}