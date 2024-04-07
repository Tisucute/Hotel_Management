namespace GUI
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuSideBar2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.LabelManager = new System.Windows.Forms.Label();
            this.ButtonTimeAndSalary = new System.Windows.Forms.Button();
            this.ButtonEmployeeManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureBoxManager = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelHienThi = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxManager)).BeginInit();
            this.SideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 5;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.nightControlBox1);
            this.panel6.Controls.Add(this.LabelManager);
            this.panel6.Controls.Add(this.MenuSideBar2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1339, 62);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint_1);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
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
            this.nightControlBox1.Location = new System.Drawing.Point(1200, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 6;
            // 
            // LabelManager
            // 
            this.LabelManager.AutoSize = true;
            this.LabelManager.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManager.Location = new System.Drawing.Point(51, 18);
            this.LabelManager.Name = "LabelManager";
            this.LabelManager.Size = new System.Drawing.Size(350, 28);
            this.LabelManager.TabIndex = 5;
            this.LabelManager.Text = "Hotel_Management | MANAGER";
            // 
            // ButtonTimeAndSalary
            // 
            this.ButtonTimeAndSalary.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonTimeAndSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTimeAndSalary.Font = new System.Drawing.Font("VNbahamas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTimeAndSalary.Image = global::GUI.Properties.Resources.icons8_time_is_money_48;
            this.ButtonTimeAndSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTimeAndSalary.Location = new System.Drawing.Point(4, 0);
            this.ButtonTimeAndSalary.Name = "ButtonTimeAndSalary";
            this.ButtonTimeAndSalary.Size = new System.Drawing.Size(240, 60);
            this.ButtonTimeAndSalary.TabIndex = 4;
            this.ButtonTimeAndSalary.Text = "              Working Time and Salary";
            this.ButtonTimeAndSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTimeAndSalary.UseVisualStyleBackColor = true;
            this.ButtonTimeAndSalary.Click += new System.EventHandler(this.ButtonTimeAndSalary_Click_1);
            // 
            // ButtonEmployeeManagement
            // 
            this.ButtonEmployeeManagement.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEmployeeManagement.Font = new System.Drawing.Font("VNbahamas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEmployeeManagement.Image = global::GUI.Properties.Resources.icons8_identification_documents_50;
            this.ButtonEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEmployeeManagement.Location = new System.Drawing.Point(4, 4);
            this.ButtonEmployeeManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEmployeeManagement.Name = "ButtonEmployeeManagement";
            this.ButtonEmployeeManagement.Size = new System.Drawing.Size(239, 60);
            this.ButtonEmployeeManagement.TabIndex = 0;
            this.ButtonEmployeeManagement.Text = "              Employee Management";
            this.ButtonEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEmployeeManagement.UseVisualStyleBackColor = true;
            this.ButtonEmployeeManagement.Click += new System.EventHandler(this.ButtonEmployeeManagement_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Controls.Add(this.PictureBoxManager);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 232);
            this.panel1.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(102, 192);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(44, 16);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // PictureBoxManager
            // 
            this.PictureBoxManager.ImageRotate = 0F;
            this.PictureBoxManager.Location = new System.Drawing.Point(53, 37);
            this.PictureBoxManager.Name = "PictureBoxManager";
            this.PictureBoxManager.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxManager.Size = new System.Drawing.Size(141, 136);
            this.PictureBoxManager.TabIndex = 1;
            this.PictureBoxManager.TabStop = false;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.panel4);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 62);
            this.SideBar.MaximumSize = new System.Drawing.Size(253, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(253, 665);
            this.SideBar.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonHome);
            this.panel2.Location = new System.Drawing.Point(3, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 65);
            this.panel2.TabIndex = 1;
            // 
            // ButtonHome
            // 
            this.ButtonHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("VNbahamas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.Image = global::GUI.Properties.Resources.icons8_home_50;
            this.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHome.Location = new System.Drawing.Point(4, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(240, 60);
            this.ButtonHome.TabIndex = 5;
            this.ButtonHome.Text = "               Home";
            this.ButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonEmployeeManagement);
            this.panel3.Location = new System.Drawing.Point(3, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 65);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ButtonTimeAndSalary);
            this.panel4.Location = new System.Drawing.Point(3, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 65);
            this.panel4.TabIndex = 6;
            // 
            // PanelHienThi
            // 
            this.PanelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHienThi.Location = new System.Drawing.Point(253, 62);
            this.PanelHienThi.Name = "PanelHienThi";
            this.PanelHienThi.Size = new System.Drawing.Size(1086, 665);
            this.PanelHienThi.TabIndex = 7;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 100;
            // 
            // ManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::GUI.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1339, 727);
            this.Controls.Add(this.PanelHienThi);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Form";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.Resize += new System.EventHandler(this.ManagerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxManager)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.PictureBox MenuSideBar2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelManager;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Button ButtonTimeAndSalary;
        private System.Windows.Forms.Button ButtonEmployeeManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxManager;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelHienThi;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}