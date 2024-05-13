namespace GUI
{
    partial class WorkingTimeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dgvListEmployeeAssign = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeAssign)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.labelTitle.Location = new System.Drawing.Point(664, 73);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(166, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "List Shift";
            // 
            // dgvListEmployeeAssign
            // 
            this.dgvListEmployeeAssign.AllowUserToAddRows = false;
            this.dgvListEmployeeAssign.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListEmployeeAssign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployeeAssign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmployeeAssign.ColumnHeadersHeight = 30;
            this.dgvListEmployeeAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployeeAssign.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListEmployeeAssign.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.Location = new System.Drawing.Point(12, 239);
            this.dgvListEmployeeAssign.Name = "dgvListEmployeeAssign";
            this.dgvListEmployeeAssign.ReadOnly = true;
            this.dgvListEmployeeAssign.RowHeadersVisible = false;
            this.dgvListEmployeeAssign.RowHeadersWidth = 51;
            this.dgvListEmployeeAssign.RowTemplate.Height = 24;
            this.dgvListEmployeeAssign.Size = new System.Drawing.Size(1072, 406);
            this.dgvListEmployeeAssign.TabIndex = 8;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListEmployeeAssign.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListEmployeeAssign.ThemeStyle.ReadOnly = true;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Animated = true;
            this.DateTimePicker.AutoRoundedCorners = true;
            this.DateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePicker.BorderRadius = 17;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.FloralWhite;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(40, 128);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(229, 36);
            this.DateTimePicker.TabIndex = 13;
            this.DateTimePicker.UseTransparentBackground = true;
            this.DateTimePicker.Value = new System.DateTime(2024, 4, 27, 21, 40, 53, 875);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 52);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.LabelHeader.Location = new System.Drawing.Point(621, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(259, 28);
            this.LabelHeader.TabIndex = 26;
            this.LabelHeader.Text = "Employee Management";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Transparent;
            this.comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox.ItemHeight = 30;
            this.comboBox.Items.AddRange(new object[] {
            "Ca 7h-11h",
            "Ca 11h-15h",
            "Ca 15h-19h",
            "Ca 19h-23h",
            "Ca 23h-3h",
            "Ca 3h-7h"});
            this.comboBox.Location = new System.Drawing.Point(40, 186);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(154, 36);
            this.comboBox.TabIndex = 25;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(960, 675);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 29);
            this.labelTotal.TabIndex = 26;
            // 
            // WorkingTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1109, 718);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.dgvListEmployeeAssign);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkingTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkingTimeAndSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeAssign)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployeeAssign;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelHeader;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
        private System.Windows.Forms.Label labelTotal;
    }
}