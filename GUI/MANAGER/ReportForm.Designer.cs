namespace GUI
{
    partial class ReportForm
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnEmployeeSalary = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomService = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_ReportES1 = new GUI.All_UC.UC_ReportES();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_ReportRS1 = new GUI.All_UC.UC_ReportRS();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.Location = new System.Drawing.Point(12, 18);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(194, 28);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Report Overview";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.LabelHeader);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1125, 69);
            this.guna2Panel1.TabIndex = 9;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnRoomService);
            this.guna2Panel2.Controls.Add(this.BtnEmployeeSalary);
            this.guna2Panel2.FillColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel2.Location = new System.Drawing.Point(32, 75);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1051, 64);
            this.guna2Panel2.TabIndex = 12;
            // 
            // BtnEmployeeSalary
            // 
            this.BtnEmployeeSalary.Animated = true;
            this.BtnEmployeeSalary.AutoRoundedCorners = true;
            this.BtnEmployeeSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmployeeSalary.BorderRadius = 23;
            this.BtnEmployeeSalary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnEmployeeSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployeeSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployeeSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmployeeSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEmployeeSalary.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnEmployeeSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEmployeeSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnEmployeeSalary.Location = new System.Drawing.Point(224, 8);
            this.BtnEmployeeSalary.Name = "BtnEmployeeSalary";
            this.BtnEmployeeSalary.Size = new System.Drawing.Size(137, 49);
            this.BtnEmployeeSalary.TabIndex = 0;
            this.BtnEmployeeSalary.Text = "Employee Salary";
            this.BtnEmployeeSalary.UseTransparentBackground = true;
            this.BtnEmployeeSalary.Click += new System.EventHandler(this.BtnEmployeeSalary_Click);
            // 
            // btnRoomService
            // 
            this.btnRoomService.Animated = true;
            this.btnRoomService.AutoRoundedCorners = true;
            this.btnRoomService.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomService.BorderRadius = 23;
            this.btnRoomService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoomService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomService.FillColor = System.Drawing.Color.SteelBlue;
            this.btnRoomService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomService.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRoomService.Location = new System.Drawing.Point(637, 8);
            this.btnRoomService.Name = "btnRoomService";
            this.btnRoomService.Size = new System.Drawing.Size(151, 49);
            this.btnRoomService.TabIndex = 1;
            this.btnRoomService.Text = "Room and Service";
            this.btnRoomService.UseTransparentBackground = true;
            this.btnRoomService.Click += new System.EventHandler(this.btnRoomService_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.uC_ReportRS1);
            this.panel1.Controls.Add(this.uC_ReportES1);
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 625);
            this.panel1.TabIndex = 13;
            // 
            // panelMoving
            // 
            this.panelMoving.FillColor = System.Drawing.Color.CornflowerBlue;
            this.panelMoving.Location = new System.Drawing.Point(267, 134);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(116, 10);
            this.panelMoving.TabIndex = 13;
            // 
            // uC_ReportES1
            // 
            this.uC_ReportES1.Location = new System.Drawing.Point(-2, -2);
            this.uC_ReportES1.Name = "uC_ReportES1";
            this.uC_ReportES1.Size = new System.Drawing.Size(1101, 625);
            this.uC_ReportES1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_ReportRS1
            // 
            this.uC_ReportRS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.uC_ReportRS1.Location = new System.Drawing.Point(-3, -2);
            this.uC_ReportRS1.Name = "uC_ReportRS1";
            this.uC_ReportRS1.Size = new System.Drawing.Size(1097, 621);
            this.uC_ReportRS1.TabIndex = 1;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelMoving);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnRoomService;
        private Guna.UI2.WinForms.Guna2Button BtnEmployeeSalary;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel panelMoving;
        private All_UC.UC_ReportES uC_ReportES1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_UC.UC_ReportRS uC_ReportRS1;
    }
}