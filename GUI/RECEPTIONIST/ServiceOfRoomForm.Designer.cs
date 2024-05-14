namespace GUI.RECEPTIONIST
{
    partial class ServiceOfRoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skyLabel7 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.cmbService = new ReaLTaiizor.Controls.ComboBoxEdit();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbBookID = new ReaLTaiizor.Controls.ComboBoxEdit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListServices)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Salmon;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1023, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Salmon;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(964, 16);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(410, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "SERVICES IN ROOM";
            // 
            // skyLabel7
            // 
            this.skyLabel7.AutoSize = true;
            this.skyLabel7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel7.ForeColor = System.Drawing.Color.Salmon;
            this.skyLabel7.Location = new System.Drawing.Point(38, 98);
            this.skyLabel7.Name = "skyLabel7";
            this.skyLabel7.Size = new System.Drawing.Size(85, 14);
            this.skyLabel7.TabIndex = 149;
            this.skyLabel7.Text = "Booking_ID";
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel2.ForeColor = System.Drawing.Color.Salmon;
            this.skyLabel2.Location = new System.Drawing.Point(38, 292);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(41, 14);
            this.skyLabel2.TabIndex = 147;
            this.skyLabel2.Text = "Price";
            this.skyLabel2.Click += new System.EventHandler(this.skyLabel2_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.BorderRadius = 14;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.Enabled = false;
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtPrice.Location = new System.Drawing.Point(29, 310);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(202, 31);
            this.txtPrice.TabIndex = 146;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel1.ForeColor = System.Drawing.Color.Salmon;
            this.skyLabel1.Location = new System.Drawing.Point(38, 163);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(86, 14);
            this.skyLabel1.TabIndex = 145;
            this.skyLabel1.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.AutoRoundedCorners = true;
            this.txtRoomName.BorderRadius = 14;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.DefaultText = "";
            this.txtRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.Enabled = false;
            this.txtRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtRoomName.Location = new System.Drawing.Point(29, 181);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PlaceholderText = "";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.Size = new System.Drawing.Size(202, 31);
            this.txtRoomName.TabIndex = 144;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Animated = true;
            this.BtnAdd.AutoRoundedCorners = true;
            this.BtnAdd.BorderRadius = 17;
            this.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd.FillColor = System.Drawing.Color.Salmon;
            this.BtnAdd.FillColor2 = System.Drawing.Color.LightSalmon;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(71, 426);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(126, 36);
            this.BtnAdd.TabIndex = 150;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel3.ForeColor = System.Drawing.Color.Salmon;
            this.skyLabel3.Location = new System.Drawing.Point(38, 357);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(57, 14);
            this.skyLabel3.TabIndex = 152;
            this.skyLabel3.Text = "Amount";
            this.skyLabel3.Click += new System.EventHandler(this.skyLabel3_Click);
            // 
            // cmbService
            // 
            this.cmbService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbService.DropDownHeight = 100;
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cmbService.FormattingEnabled = true;
            this.cmbService.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbService.IntegralHeight = false;
            this.cmbService.ItemHeight = 20;
            this.cmbService.Location = new System.Drawing.Point(29, 248);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(202, 26);
            this.cmbService.StartIndex = 0;
            this.cmbService.TabIndex = 153;
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel4.ForeColor = System.Drawing.Color.Salmon;
            this.skyLabel4.Location = new System.Drawing.Point(38, 231);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(57, 14);
            this.skyLabel4.TabIndex = 154;
            this.skyLabel4.Text = "Service";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoRoundedCorners = true;
            this.txtAmount.BorderRadius = 14;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.txtAmount.Location = new System.Drawing.Point(29, 375);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(202, 31);
            this.txtAmount.TabIndex = 155;
            // 
            // dgvListServices
            // 
            this.dgvListServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvListServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListServices.ColumnHeadersHeight = 30;
            this.dgvListServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListServices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListServices.Location = new System.Drawing.Point(262, 98);
            this.dgvListServices.Name = "dgvListServices";
            this.dgvListServices.RowHeadersVisible = false;
            this.dgvListServices.RowHeadersWidth = 51;
            this.dgvListServices.RowTemplate.Height = 24;
            this.dgvListServices.Size = new System.Drawing.Size(737, 396);
            this.dgvListServices.TabIndex = 156;
            this.dgvListServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListServices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListServices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListServices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListServices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListServices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListServices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListServices.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListServices.ThemeStyle.ReadOnly = false;
            this.dgvListServices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListServices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListServices.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmbBookID
            // 
            this.cmbBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbBookID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBookID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBookID.DropDownHeight = 100;
            this.cmbBookID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cmbBookID.FormattingEnabled = true;
            this.cmbBookID.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbBookID.IntegralHeight = false;
            this.cmbBookID.ItemHeight = 20;
            this.cmbBookID.Location = new System.Drawing.Point(29, 115);
            this.cmbBookID.Name = "cmbBookID";
            this.cmbBookID.Size = new System.Drawing.Size(202, 26);
            this.cmbBookID.StartIndex = 0;
            this.cmbBookID.TabIndex = 157;
            this.cmbBookID.SelectedIndexChanged += new System.EventHandler(this.cmbBookID_SelectedIndexChanged);
            // 
            // ServiceOfRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1023, 543);
            this.Controls.Add(this.cmbBookID);
            this.Controls.Add(this.dgvListServices);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.skyLabel4);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.skyLabel3);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.skyLabel7);
            this.Controls.Add(this.skyLabel2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.skyLabel1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceOfRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceOfRoomForm";
            this.Load += new System.EventHandler(this.ServiceOfRoomForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel7;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAdd;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.ComboBoxEdit cmbService;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListServices;
        private ReaLTaiizor.Controls.ComboBoxEdit cmbBookID;
    }
}