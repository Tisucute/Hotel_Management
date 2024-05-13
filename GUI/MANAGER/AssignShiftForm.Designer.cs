namespace GUI
{
    partial class AssignShiftForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ButtonAssign = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvListEmployeeAssign = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvListEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.LabelListEmployee = new System.Windows.Forms.Label();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 52);
            this.panel1.TabIndex = 18;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.LabelHeader.Location = new System.Drawing.Point(621, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(246, 28);
            this.LabelHeader.TabIndex = 26;
            this.LabelHeader.Text = "Employee Assignment";
            // 
            // ButtonAssign
            // 
            this.ButtonAssign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAssign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAssign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAssign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAssign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAssign.ForeColor = System.Drawing.Color.White;
            this.ButtonAssign.Location = new System.Drawing.Point(957, 77);
            this.ButtonAssign.Name = "ButtonAssign";
            this.ButtonAssign.Size = new System.Drawing.Size(108, 36);
            this.ButtonAssign.TabIndex = 20;
            this.ButtonAssign.Text = "Assign";
            this.ButtonAssign.Click += new System.EventHandler(this.ButtonAssign_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(575, 616);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 45);
            this.ButtonSave.TabIndex = 22;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(626, 307);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(61, 45);
            this.ButtonAdd.TabIndex = 23;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
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
            this.comboBox.Location = new System.Drawing.Point(706, 147);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(213, 36);
            this.comboBox.TabIndex = 24;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(27, 189);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1335, 19);
            this.guna2Separator1.TabIndex = 26;
            // 
            // dgvListEmployeeAssign
            // 
            this.dgvListEmployeeAssign.AllowUserToAddRows = false;
            this.dgvListEmployeeAssign.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployeeAssign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmployeeAssign.ColumnHeadersHeight = 18;
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
            this.dgvListEmployeeAssign.Location = new System.Drawing.Point(706, 214);
            this.dgvListEmployeeAssign.Name = "dgvListEmployeeAssign";
            this.dgvListEmployeeAssign.ReadOnly = true;
            this.dgvListEmployeeAssign.RowHeadersVisible = false;
            this.dgvListEmployeeAssign.RowHeadersWidth = 80;
            this.dgvListEmployeeAssign.RowTemplate.Height = 24;
            this.dgvListEmployeeAssign.Size = new System.Drawing.Size(656, 366);
            this.dgvListEmployeeAssign.TabIndex = 27;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployeeAssign.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployeeAssign.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvListEmployeeAssign.ThemeStyle.ReadOnly = true;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeAssign.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvListEmployee
            // 
            this.dgvListEmployee.AllowUserToAddRows = false;
            this.dgvListEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvListEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListEmployee.ColumnHeadersHeight = 18;
            this.dgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployee.Location = new System.Drawing.Point(37, 214);
            this.dgvListEmployee.Name = "dgvListEmployee";
            this.dgvListEmployee.ReadOnly = true;
            this.dgvListEmployee.RowHeadersVisible = false;
            this.dgvListEmployee.RowHeadersWidth = 80;
            this.dgvListEmployee.RowTemplate.Height = 24;
            this.dgvListEmployee.Size = new System.Drawing.Size(575, 366);
            this.dgvListEmployee.TabIndex = 28;
            this.dgvListEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployee.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvListEmployee.ThemeStyle.ReadOnly = true;
            this.dgvListEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Location = new System.Drawing.Point(626, 420);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(61, 47);
            this.ButtonRemove.TabIndex = 29;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // LabelListEmployee
            // 
            this.LabelListEmployee.AutoSize = true;
            this.LabelListEmployee.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelListEmployee.Location = new System.Drawing.Point(33, 160);
            this.LabelListEmployee.Name = "LabelListEmployee";
            this.LabelListEmployee.Size = new System.Drawing.Size(125, 23);
            this.LabelListEmployee.TabIndex = 121;
            this.LabelListEmployee.Text = "List Employee";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Animated = true;
            this.dateTimePicker.AutoRoundedCorners = true;
            this.dateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.BorderRadius = 17;
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.FillColor = System.Drawing.Color.FloralWhite;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(690, 77);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(229, 36);
            this.dateTimePicker.TabIndex = 122;
            this.dateTimePicker.UseTransparentBackground = true;
            this.dateTimePicker.Value = new System.DateTime(2024, 4, 27, 21, 40, 53, 875);
            // 
            // AssignShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1400, 701);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.LabelListEmployee);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.dgvListEmployee);
            this.Controls.Add(this.dgvListEmployeeAssign);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonAssign);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignShiftForm";
            this.Text = "AssignShiftForm";
            this.Load += new System.EventHandler(this.AssignShiftForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelHeader;
        private Guna.UI2.WinForms.Guna2Button ButtonAssign;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployeeAssign;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployee;
        private Guna.UI2.WinForms.Guna2Button ButtonRemove;
        private System.Windows.Forms.Label LabelListEmployee;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
    }
}