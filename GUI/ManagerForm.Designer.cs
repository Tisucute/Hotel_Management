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
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.MenuSideBarButton = new System.Windows.Forms.PictureBox();
            this.PictureBoxManager = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonEmployeeManagement = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonTimeAndSalary = new System.Windows.Forms.Button();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuSideBar2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxManager)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(253, 727);
            this.SideBar.MinimumSize = new System.Drawing.Size(0, 727);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(253, 727);
            this.SideBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Controls.Add(this.MenuSideBarButton);
            this.panel1.Controls.Add(this.PictureBoxManager);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 251);
            this.panel1.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(97, 214);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(44, 16);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // MenuSideBarButton
            // 
            this.MenuSideBarButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuSideBarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuSideBarButton.Image = global::GUI.Properties.Resources.icons8_menu_64;
            this.MenuSideBarButton.Location = new System.Drawing.Point(3, 3);
            this.MenuSideBarButton.Name = "MenuSideBarButton";
            this.MenuSideBarButton.Size = new System.Drawing.Size(50, 46);
            this.MenuSideBarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuSideBarButton.TabIndex = 0;
            this.MenuSideBarButton.TabStop = false;
            this.MenuSideBarButton.Click += new System.EventHandler(this.MenuSideBarButton_Click);
            // 
            // PictureBoxManager
            // 
            this.PictureBoxManager.ImageRotate = 0F;
            this.PictureBoxManager.Location = new System.Drawing.Point(40, 38);
            this.PictureBoxManager.Name = "PictureBoxManager";
            this.PictureBoxManager.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxManager.Size = new System.Drawing.Size(162, 158);
            this.PictureBoxManager.TabIndex = 1;
            this.PictureBoxManager.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonEmployeeManagement);
            this.panel2.Location = new System.Drawing.Point(3, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 65);
            this.panel2.TabIndex = 1;
            // 
            // ButtonEmployeeManagement
            // 
            this.ButtonEmployeeManagement.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEmployeeManagement.Font = new System.Drawing.Font("VNbahamas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEmployeeManagement.Image = global::GUI.Properties.Resources.icons8_identification_documents_50;
            this.ButtonEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEmployeeManagement.Location = new System.Drawing.Point(3, 5);
            this.ButtonEmployeeManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEmployeeManagement.Name = "ButtonEmployeeManagement";
            this.ButtonEmployeeManagement.Size = new System.Drawing.Size(239, 60);
            this.ButtonEmployeeManagement.TabIndex = 0;
            this.ButtonEmployeeManagement.Text = "              Employee Management";
            this.ButtonEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonTimeAndSalary);
            this.panel3.Location = new System.Drawing.Point(3, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 65);
            this.panel3.TabIndex = 2;
            // 
            // ButtonTimeAndSalary
            // 
            this.ButtonTimeAndSalary.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonTimeAndSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTimeAndSalary.Font = new System.Drawing.Font("VNbahamas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTimeAndSalary.Image = global::GUI.Properties.Resources.icons8_time_is_money_48;
            this.ButtonTimeAndSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTimeAndSalary.Location = new System.Drawing.Point(3, 0);
            this.ButtonTimeAndSalary.Name = "ButtonTimeAndSalary";
            this.ButtonTimeAndSalary.Size = new System.Drawing.Size(240, 60);
            this.ButtonTimeAndSalary.TabIndex = 4;
            this.ButtonTimeAndSalary.Text = "              Working Time and Salary";
            this.ButtonTimeAndSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTimeAndSalary.UseVisualStyleBackColor = true;
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // MenuSideBar2
            // 
            this.MenuSideBar2.BackColor = System.Drawing.Color.Transparent;
            this.MenuSideBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuSideBar2.Image = global::GUI.Properties.Resources.icons8_menu_64__1_;
            this.MenuSideBar2.Location = new System.Drawing.Point(3, 0);
            this.MenuSideBar2.Name = "MenuSideBar2";
            this.MenuSideBar2.Size = new System.Drawing.Size(50, 46);
            this.MenuSideBar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuSideBar2.TabIndex = 4;
            this.MenuSideBar2.TabStop = false;
            this.MenuSideBar2.Click += new System.EventHandler(this.MenuSideBar2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.MenuSideBar2);
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1185, 49);
            this.panel6.TabIndex = 5;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1186, 727);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.SideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxManager)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonEmployeeManagement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonTimeAndSalary;
        private System.Windows.Forms.PictureBox MenuSideBarButton;
        private System.Windows.Forms.Timer SideBarTimer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxManager;
        private System.Windows.Forms.PictureBox MenuSideBar2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelName;
    }
}