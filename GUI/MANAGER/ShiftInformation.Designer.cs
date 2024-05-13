namespace GUI
{
    partial class ShiftInformation
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
            this.LabelTotalSalary = new ReaLTaiizor.Controls.MetroLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dgvListCheck = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotalSalary
            // 
            this.LabelTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSalary.IsDerivedStyle = true;
            this.LabelTotalSalary.Location = new System.Drawing.Point(12, 511);
            this.LabelTotalSalary.Name = "LabelTotalSalary";
            this.LabelTotalSalary.Size = new System.Drawing.Size(162, 23);
            this.LabelTotalSalary.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.LabelTotalSalary.StyleManager = null;
            this.LabelTotalSalary.TabIndex = 26;
            this.LabelTotalSalary.Text = "Total Salary:";
            this.LabelTotalSalary.ThemeAuthor = "Taiizor";
            this.LabelTotalSalary.ThemeName = "MetroLight";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.groupBox.Controls.Add(this.dungeonHeaderLabel3);
            this.groupBox.Controls.Add(this.dgvListCheck);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F);
            this.groupBox.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox.Location = new System.Drawing.Point(12, 23);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(808, 467);
            this.groupBox.TabIndex = 25;
            this.groupBox.TabStop = false;
            // 
            // dungeonHeaderLabel3
            // 
            this.dungeonHeaderLabel3.AutoSize = true;
            this.dungeonHeaderLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.dungeonHeaderLabel3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonHeaderLabel3.ForeColor = System.Drawing.Color.LightCoral;
            this.dungeonHeaderLabel3.Location = new System.Drawing.Point(6, 0);
            this.dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            this.dungeonHeaderLabel3.Size = new System.Drawing.Size(79, 31);
            this.dungeonHeaderLabel3.TabIndex = 10;
            this.dungeonHeaderLabel3.Text = "Check";
            // 
            // dgvListCheck
            // 
            this.dgvListCheck.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCheck.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCheck.ColumnHeadersHeight = 30;
            this.dgvListCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCheck.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCheck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListCheck.Location = new System.Drawing.Point(12, 34);
            this.dgvListCheck.Name = "dgvListCheck";
            this.dgvListCheck.ReadOnly = true;
            this.dgvListCheck.RowHeadersVisible = false;
            this.dgvListCheck.RowHeadersWidth = 51;
            this.dgvListCheck.RowTemplate.Height = 24;
            this.dgvListCheck.Size = new System.Drawing.Size(785, 416);
            this.dgvListCheck.TabIndex = 9;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListCheck.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListCheck.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListCheck.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListCheck.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListCheck.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListCheck.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListCheck.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListCheck.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListCheck.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListCheck.ThemeStyle.ReadOnly = true;
            this.dgvListCheck.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListCheck.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListCheck.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListCheck.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListCheck.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListCheck.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListCheck.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ShiftInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(861, 634);
            this.Controls.Add(this.LabelTotalSalary);
            this.Controls.Add(this.groupBox);
            this.Name = "ShiftInformation";
            this.Text = "ShiftInformation";
            this.Load += new System.EventHandler(this.ShiftInformation_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MetroLabel LabelTotalSalary;
        private System.Windows.Forms.GroupBox groupBox;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        public Guna.UI2.WinForms.Guna2DataGridView dgvListCheck;
    }
}