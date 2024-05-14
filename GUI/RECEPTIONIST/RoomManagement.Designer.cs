namespace GUI
{
    partial class RoomManagementForm
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.ucRooms4 = new GUI.RECEPTIONIST.ucRooms();
            this.ucRooms3 = new GUI.RECEPTIONIST.ucRooms();
            this.ucRooms2 = new GUI.RECEPTIONIST.ucRooms();
            this.ucRooms1 = new GUI.RECEPTIONIST.ucRooms();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucRooms5 = new GUI.RECEPTIONIST.ucRooms();
            this.ucRooms6 = new GUI.RECEPTIONIST.ucRooms();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 896);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1529, 46);
            this.guna2Panel3.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.guna2Panel4.Controls.Add(this.guna2Panel1);
            this.guna2Panel4.Controls.Add(this.guna2Button3);
            this.guna2Panel4.Controls.Add(this.guna2Button2);
            this.guna2Panel4.Controls.Add(this.guna2Button1);
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1529, 71);
            this.guna2Panel4.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1529, 97);
            this.guna2Panel1.TabIndex = 12;
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.Animated = true;
            this.BtnAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddRoom.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddRoom.BorderRadius = 20;
            this.BtnAddRoom.BorderThickness = 1;
            this.BtnAddRoom.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.BtnAddRoom.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddRoom.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoom.Location = new System.Drawing.Point(453, 80);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Size = new System.Drawing.Size(171, 48);
            this.BtnAddRoom.TabIndex = 9;
            this.BtnAddRoom.Text = "Add Room";
            this.BtnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "ROOMS OF HOTEL";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(649, 12);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(156, 116);
            this.guna2Button3.TabIndex = 11;
            this.guna2Button3.Text = "guna2Button3";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(468, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(156, 116);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(288, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(156, 116);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "ROOMS OF HOTEL";
            // 
            // panelRoom
            // 
            this.panelRoom.AutoScroll = true;
            this.panelRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoom.Controls.Add(this.ucRooms4);
            this.panelRoom.Controls.Add(this.ucRooms3);
            this.panelRoom.Controls.Add(this.ucRooms2);
            this.panelRoom.Controls.Add(this.ucRooms1);
            this.panelRoom.Controls.Add(this.ucRooms5);
            this.panelRoom.Controls.Add(this.ucRooms6);
            this.panelRoom.Location = new System.Drawing.Point(17, 144);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(1348, 679);
            this.panelRoom.TabIndex = 3;
            // 
            // ucRooms4
            // 
            this.ucRooms4.Location = new System.Drawing.Point(3, 3);
            this.ucRooms4.Name = "ucRooms4";
            this.ucRooms4.person = 0;
            this.ucRooms4.Ppicture = null;
            this.ucRooms4.Pprice = null;
            this.ucRooms4.room_id = 0;
            this.ucRooms4.room_name = "Room\'s Name";
            this.ucRooms4.Size = new System.Drawing.Size(215, 237);
            this.ucRooms4.status = "Status";
            this.ucRooms4.TabIndex = 3;
            this.ucRooms4.type = "";
            // 
            // ucRooms3
            // 
            this.ucRooms3.Location = new System.Drawing.Point(224, 3);
            this.ucRooms3.Name = "ucRooms3";
            this.ucRooms3.person = 0;
            this.ucRooms3.Ppicture = null;
            this.ucRooms3.Pprice = null;
            this.ucRooms3.room_id = 0;
            this.ucRooms3.room_name = "Room\'s Name";
            this.ucRooms3.Size = new System.Drawing.Size(215, 237);
            this.ucRooms3.status = "Status";
            this.ucRooms3.TabIndex = 2;
            this.ucRooms3.type = "";
            // 
            // ucRooms2
            // 
            this.ucRooms2.Location = new System.Drawing.Point(445, 3);
            this.ucRooms2.Name = "ucRooms2";
            this.ucRooms2.person = 0;
            this.ucRooms2.Ppicture = null;
            this.ucRooms2.Pprice = null;
            this.ucRooms2.room_id = 0;
            this.ucRooms2.room_name = "Room\'s Name";
            this.ucRooms2.Size = new System.Drawing.Size(215, 237);
            this.ucRooms2.status = "Status";
            this.ucRooms2.TabIndex = 1;
            this.ucRooms2.type = "";
            // 
            // ucRooms1
            // 
            this.ucRooms1.Location = new System.Drawing.Point(666, 3);
            this.ucRooms1.Name = "ucRooms1";
            this.ucRooms1.person = 0;
            this.ucRooms1.Ppicture = null;
            this.ucRooms1.Pprice = null;
            this.ucRooms1.room_id = 0;
            this.ucRooms1.room_name = "Room\'s Name";
            this.ucRooms1.Size = new System.Drawing.Size(215, 237);
            this.ucRooms1.status = "Status";
            this.ucRooms1.TabIndex = 0;
            this.ucRooms1.type = "";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(207)))));
            this.TextBoxSearch.IconLeft = global::GUI.Properties.Resources.icons8_find_50;
            this.TextBoxSearch.Location = new System.Drawing.Point(94, 80);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Search here";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(335, 48);
            this.TextBoxSearch.TabIndex = 4;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ucRooms5
            // 
            this.ucRooms5.Location = new System.Drawing.Point(887, 3);
            this.ucRooms5.Name = "ucRooms5";
            this.ucRooms5.person = 0;
            this.ucRooms5.Ppicture = null;
            this.ucRooms5.Pprice = null;
            this.ucRooms5.room_id = 0;
            this.ucRooms5.room_name = "Room\'s Name";
            this.ucRooms5.Size = new System.Drawing.Size(215, 237);
            this.ucRooms5.status = "Status";
            this.ucRooms5.TabIndex = 4;
            this.ucRooms5.type = "";
            // 
            // ucRooms6
            // 
            this.ucRooms6.Location = new System.Drawing.Point(1108, 3);
            this.ucRooms6.Name = "ucRooms6";
            this.ucRooms6.person = 0;
            this.ucRooms6.Ppicture = null;
            this.ucRooms6.Pprice = null;
            this.ucRooms6.room_id = 0;
            this.ucRooms6.room_name = "Room\'s Name";
            this.ucRooms6.Size = new System.Drawing.Size(215, 237);
            this.ucRooms6.status = "Status";
            this.ucRooms6.TabIndex = 5;
            this.ucRooms6.type = "";
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 942);
            this.Controls.Add(this.BtnAddRoom);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.panelRoom);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomManagementForm";
            this.Text = "RoomManagement";
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnAddRoom;
        public Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private RECEPTIONIST.ucRooms ucRooms1;
        private RECEPTIONIST.ucRooms ucRooms2;
        private RECEPTIONIST.ucRooms ucRooms3;
        private RECEPTIONIST.ucRooms ucRooms4;
        public System.Windows.Forms.FlowLayoutPanel panelRoom;
        private RECEPTIONIST.ucRooms ucRooms5;
        private RECEPTIONIST.ucRooms ucRooms6;
    }
}