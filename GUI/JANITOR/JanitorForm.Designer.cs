namespace GUI
{
    partial class JanitorForm
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.BtnHome = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureBoxJanitor = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelWorkingTime = new System.Windows.Forms.Panel();
            this.BtnCheckTime = new System.Windows.Forms.Button();
            this.LabelManager = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.MenuSideBar2 = new System.Windows.Forms.PictureBox();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelHienThi = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxJanitor)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelWorkingTime.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 100;
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Image = global::GUI.Properties.Resources.icons8_home_50;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(4, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(240, 60);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "               Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = true;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.SideBar.Controls.Add(this.panelAvatar);
            this.SideBar.Controls.Add(this.panelHome);
            this.SideBar.Controls.Add(this.panelWorkingTime);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 62);
            this.SideBar.MaximumSize = new System.Drawing.Size(253, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(253, 602);
            this.SideBar.TabIndex = 9;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.panelAvatar.Controls.Add(this.LabelName);
            this.panelAvatar.Controls.Add(this.PictureBoxJanitor);
            this.panelAvatar.Location = new System.Drawing.Point(3, 3);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(246, 232);
            this.panelAvatar.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.Location = new System.Drawing.Point(0, 192);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(246, 40);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxJanitor
            // 
            this.PictureBoxJanitor.ImageRotate = 0F;
            this.PictureBoxJanitor.Location = new System.Drawing.Point(42, 28);
            this.PictureBoxJanitor.Name = "PictureBoxJanitor";
            this.PictureBoxJanitor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxJanitor.Size = new System.Drawing.Size(167, 161);
            this.PictureBoxJanitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxJanitor.TabIndex = 1;
            this.PictureBoxJanitor.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.BtnHome);
            this.panelHome.Location = new System.Drawing.Point(3, 241);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(246, 65);
            this.panelHome.TabIndex = 1;
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
            this.BtnCheckTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckTime.Image = global::GUI.Properties.Resources.icons8_time_is_money_48;
            this.BtnCheckTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckTime.Location = new System.Drawing.Point(4, 0);
            this.BtnCheckTime.Name = "BtnCheckTime";
            this.BtnCheckTime.Size = new System.Drawing.Size(240, 60);
            this.BtnCheckTime.TabIndex = 4;
            this.BtnCheckTime.Text = "              Check Time Work";
            this.BtnCheckTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckTime.UseVisualStyleBackColor = true;
            this.BtnCheckTime.Click += new System.EventHandler(this.ButtonTimeAndSalary_Click);
            // 
            // LabelManager
            // 
            this.LabelManager.AutoSize = true;
            this.LabelManager.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManager.Location = new System.Drawing.Point(51, 18);
            this.LabelManager.Name = "LabelManager";
            this.LabelManager.Size = new System.Drawing.Size(337, 28);
            this.LabelManager.TabIndex = 5;
            this.LabelManager.Text = "Hotel_Management | JANITOR";
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
            this.nightControlBox1.Location = new System.Drawing.Point(1182, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 6;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitle.Controls.Add(this.nightControlBox1);
            this.panelTitle.Controls.Add(this.LabelManager);
            this.panelTitle.Controls.Add(this.MenuSideBar2);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1321, 62);
            this.panelTitle.TabIndex = 8;
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
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            // 
            // PanelHienThi
            // 
            this.PanelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHienThi.Location = new System.Drawing.Point(0, 0);
            this.PanelHienThi.Name = "PanelHienThi";
            this.PanelHienThi.Size = new System.Drawing.Size(1321, 664);
            this.PanelHienThi.TabIndex = 10;
            // 
            // JanitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 664);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.PanelHienThi);
            this.Name = "JanitorForm";
            this.Text = "Janitor Form";
            this.Load += new System.EventHandler(this.JanitorForm_Load);
            this.SideBar.ResumeLayout(false);
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxJanitor)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelWorkingTime.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Label LabelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxJanitor;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelWorkingTime;
        private System.Windows.Forms.Button BtnCheckTime;
        private System.Windows.Forms.Label LabelManager;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox MenuSideBar2;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Panel PanelHienThi;
    }
}