namespace GUI
{
    partial class AddUserForm
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
            this.BtnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel6 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbBoxRole = new ReaLTaiizor.Controls.SkyComboBox();
            this.ButtonSelect = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(153, 465);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnAdd.Size = new System.Drawing.Size(117, 48);
            this.BtnAdd.TabIndex = 114;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel2.Location = new System.Drawing.Point(84, 355);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(70, 20);
            this.nightLabel2.TabIndex = 108;
            this.nightLabel2.Text = "Password";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Animated = true;
            this.txtBoxPass.AutoRoundedCorners = true;
            this.txtBoxPass.BorderRadius = 20;
            this.txtBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPass.DefaultText = "";
            this.txtBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPass.Location = new System.Drawing.Point(70, 379);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '\0';
            this.txtBoxPass.PlaceholderText = "";
            this.txtBoxPass.SelectedText = "";
            this.txtBoxPass.Size = new System.Drawing.Size(306, 42);
            this.txtBoxPass.TabIndex = 107;
            // 
            // nightLabel6
            // 
            this.nightLabel6.AutoSize = true;
            this.nightLabel6.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel6.Location = new System.Drawing.Point(84, 193);
            this.nightLabel6.Name = "nightLabel6";
            this.nightLabel6.Size = new System.Drawing.Size(39, 20);
            this.nightLabel6.TabIndex = 106;
            this.nightLabel6.Text = "Role";
            // 
            // nightLabel4
            // 
            this.nightLabel4.AutoSize = true;
            this.nightLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel4.Location = new System.Drawing.Point(84, 268);
            this.nightLabel4.Name = "nightLabel4";
            this.nightLabel4.Size = new System.Drawing.Size(75, 20);
            this.nightLabel4.TabIndex = 105;
            this.nightLabel4.Text = "Username";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Animated = true;
            this.txtBoxUsername.AutoRoundedCorners = true;
            this.txtBoxUsername.BorderRadius = 21;
            this.txtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUsername.DefaultText = "";
            this.txtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Location = new System.Drawing.Point(70, 292);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.PasswordChar = '\0';
            this.txtBoxUsername.PlaceholderText = "";
            this.txtBoxUsername.SelectedText = "";
            this.txtBoxUsername.Size = new System.Drawing.Size(306, 44);
            this.txtBoxUsername.TabIndex = 104;
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(84, 60);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(69, 20);
            this.nightLabel1.TabIndex = 103;
            this.nightLabel1.Text = "Fullname";
            // 
            // txtBoxFullname
            // 
            this.txtBoxFullname.Animated = true;
            this.txtBoxFullname.AutoRoundedCorners = true;
            this.txtBoxFullname.BorderRadius = 21;
            this.txtBoxFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFullname.DefaultText = "";
            this.txtBoxFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullname.Location = new System.Drawing.Point(70, 84);
            this.txtBoxFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxFullname.Name = "txtBoxFullname";
            this.txtBoxFullname.PasswordChar = '\0';
            this.txtBoxFullname.PlaceholderText = "";
            this.txtBoxFullname.SelectedText = "";
            this.txtBoxFullname.Size = new System.Drawing.Size(306, 44);
            this.txtBoxFullname.TabIndex = 102;
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
            this.CmbBoxRole.Location = new System.Drawing.Point(82, 216);
            this.CmbBoxRole.Name = "CmbBoxRole";
            this.CmbBoxRole.Size = new System.Drawing.Size(175, 36);
            this.CmbBoxRole.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.CmbBoxRole.StartIndex = 0;
            this.CmbBoxRole.TabIndex = 97;
            this.CmbBoxRole.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.CmbBoxRole.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.ButtonSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSelect.ForeColor = System.Drawing.Color.White;
            this.ButtonSelect.Location = new System.Drawing.Point(82, 135);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(150, 44);
            this.ButtonSelect.TabIndex = 117;
            this.ButtonSelect.Text = "Select Employee";
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 547);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.nightLabel2);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.nightLabel6);
            this.Controls.Add(this.nightLabel4);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.nightLabel1);
            this.Controls.Add(this.txtBoxFullname);
            this.Controls.Add(this.CmbBoxRole);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton BtnAdd;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPass;
        private ReaLTaiizor.Controls.NightLabel nightLabel6;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUsername;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFullname;
        private ReaLTaiizor.Controls.SkyComboBox CmbBoxRole;
        private Guna.UI2.WinForms.Guna2Button ButtonSelect;
    }
}