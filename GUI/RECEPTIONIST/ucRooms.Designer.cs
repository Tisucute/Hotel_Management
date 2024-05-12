namespace GUI.RECEPTIONIST
{
    partial class ucRooms
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnReceive = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.RadioBtnStatus = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.labelStatus = new ReaLTaiizor.Controls.NightLabel();
            this.labelName = new ReaLTaiizor.Controls.MetroLabel();
            this.labelKind = new ReaLTaiizor.Controls.NightLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.RadioBtnHire = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.BtnDelete);
            this.guna2ShadowPanel1.Controls.Add(this.btnBook);
            this.guna2ShadowPanel1.Controls.Add(this.RadioBtnStatus);
            this.guna2ShadowPanel1.Controls.Add(this.labelStatus);
            this.guna2ShadowPanel1.Controls.Add(this.labelName);
            this.guna2ShadowPanel1.Controls.Add(this.labelKind);
            this.guna2ShadowPanel1.Controls.Add(this.picBox);
            this.guna2ShadowPanel1.Controls.Add(this.RadioBtnHire);
            this.guna2ShadowPanel1.Controls.Add(this.btnReceive);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(211, 281);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // btnReceive
            // 
            this.btnReceive.Animated = true;
            this.btnReceive.AutoRoundedCorners = true;
            this.btnReceive.BorderRadius = 13;
            this.btnReceive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReceive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReceive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReceive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReceive.FillColor = System.Drawing.Color.Orange;
            this.btnReceive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.White;
            this.btnReceive.Location = new System.Drawing.Point(17, 225);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(85, 29);
            this.btnReceive.TabIndex = 10;
            this.btnReceive.Text = "Receive";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Animated = true;
            this.BtnDelete.AutoRoundedCorners = true;
            this.BtnDelete.BorderRadius = 13;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.SlateGray;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(110, 225);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(87, 29);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBook
            // 
            this.btnBook.Animated = true;
            this.btnBook.AutoRoundedCorners = true;
            this.btnBook.BorderRadius = 13;
            this.btnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBook.FillColor = System.Drawing.Color.Green;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(17, 225);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(85, 29);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // RadioBtnStatus
            // 
            this.RadioBtnStatus.Checked = true;
            this.RadioBtnStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtnStatus.CheckedState.BorderThickness = 0;
            this.RadioBtnStatus.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.RadioBtnStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioBtnStatus.Location = new System.Drawing.Point(17, 188);
            this.RadioBtnStatus.Name = "RadioBtnStatus";
            this.RadioBtnStatus.Size = new System.Drawing.Size(14, 20);
            this.RadioBtnStatus.TabIndex = 6;
            this.RadioBtnStatus.Text = "guna2CustomRadioButton1";
            this.RadioBtnStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtnStatus.UncheckedState.BorderThickness = 0;
            this.RadioBtnStatus.UncheckedState.FillColor = System.Drawing.Color.OrangeRed;
            this.RadioBtnStatus.UncheckedState.InnerColor = System.Drawing.Color.OrangeRed;
            this.RadioBtnStatus.UseTransparentBackground = true;
            this.RadioBtnStatus.CheckedChanged += new System.EventHandler(this.RadioBtnStatus_CheckedChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.labelStatus.Location = new System.Drawing.Point(33, 188);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.IsDerivedStyle = true;
            this.labelName.Location = new System.Drawing.Point(3, 147);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(205, 23);
            this.labelName.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.labelName.StyleManager = null;
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Room\'s Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelName.ThemeAuthor = "Taiizor";
            this.labelName.ThemeName = "MetroLight";
            this.labelName.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // labelKind
            // 
            this.labelKind.AutoSize = true;
            this.labelKind.BackColor = System.Drawing.Color.Transparent;
            this.labelKind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.labelKind.Location = new System.Drawing.Point(149, 188);
            this.labelKind.Name = "labelKind";
            this.labelKind.Size = new System.Drawing.Size(39, 20);
            this.labelKind.TabIndex = 1;
            this.labelKind.Text = "Kind";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Gainsboro;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(17, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(180, 121);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // RadioBtnHire
            // 
            this.RadioBtnHire.Checked = true;
            this.RadioBtnHire.CheckedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.RadioBtnHire.CheckedState.BorderThickness = 0;
            this.RadioBtnHire.CheckedState.FillColor = System.Drawing.Color.OrangeRed;
            this.RadioBtnHire.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioBtnHire.Location = new System.Drawing.Point(17, 188);
            this.RadioBtnHire.Name = "RadioBtnHire";
            this.RadioBtnHire.Size = new System.Drawing.Size(14, 20);
            this.RadioBtnHire.TabIndex = 7;
            this.RadioBtnHire.Text = "guna2CustomRadioButton1";
            this.RadioBtnHire.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtnHire.UncheckedState.BorderThickness = 0;
            this.RadioBtnHire.UncheckedState.FillColor = System.Drawing.Color.OrangeRed;
            this.RadioBtnHire.UncheckedState.InnerColor = System.Drawing.Color.OrangeRed;
            this.RadioBtnHire.UseTransparentBackground = true;
            // 
            // ucRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucRooms";
            this.Size = new System.Drawing.Size(215, 287);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ReaLTaiizor.Controls.NightLabel labelKind;
        private System.Windows.Forms.PictureBox picBox;
        private ReaLTaiizor.Controls.MetroLabel labelName;
        private ReaLTaiizor.Controls.NightLabel labelStatus;
        public Guna.UI2.WinForms.Guna2CustomRadioButton RadioBtnStatus;
        public Guna.UI2.WinForms.Guna2CustomRadioButton RadioBtnHire;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2Button btnReceive;
    }
}
