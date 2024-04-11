namespace GUI
{
    partial class EmployeeManagementForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.LabelHeader);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1198, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 572);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1198, 52);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.Location = new System.Drawing.Point(785, 72);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(67, 22);
            this.LabelSearch.TabIndex = 3;
            this.LabelSearch.Text = "Search";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(14, 153);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1170, 19);
            this.guna2Separator1.TabIndex = 5;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.Location = new System.Drawing.Point(12, 25);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(259, 28);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Employee Management";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonAdd.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.ButtonAdd.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.ButtonAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonAdd.ImageRotate = 0F;
            this.ButtonAdd.ImageSize = new System.Drawing.Size(55, 55);
            this.ButtonAdd.IndicateFocus = true;
            this.ButtonAdd.Location = new System.Drawing.Point(26, 92);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.ButtonAdd.Size = new System.Drawing.Size(64, 54);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.IconLeft = global::GUI.Properties.Resources.icons8_search_64;
            this.TextBoxSearch.Location = new System.Drawing.Point(789, 98);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Search here";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(335, 48);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 624);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagementForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label LabelSearch;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label LabelHeader;
        public Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        public Guna.UI2.WinForms.Guna2ImageButton ButtonAdd;
    }
}