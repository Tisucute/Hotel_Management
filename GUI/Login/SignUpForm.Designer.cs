namespace GUI
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AutoRoundedCorners = true;
            this.TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUsername.BorderRadius = 17;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TextBoxUsername.DefaultText = "";
            this.TextBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.FillColor = System.Drawing.Color.Gainsboro;
            this.TextBoxUsername.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.TextBoxUsername.HideSelection = false;
            this.TextBoxUsername.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBoxUsername.IconLeft")));
            this.TextBoxUsername.Location = new System.Drawing.Point(69, 272);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.PlaceholderText = "Username";
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.ShadowDecoration.BorderRadius = 17;
            this.TextBoxUsername.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.TextBoxUsername.ShadowDecoration.Depth = 20;
            this.TextBoxUsername.ShadowDecoration.Enabled = true;
            this.TextBoxUsername.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.TextBoxUsername.Size = new System.Drawing.Size(255, 37);
            this.TextBoxUsername.TabIndex = 2;
            this.TextBoxUsername.UseWaitCursor = true;
            this.TextBoxUsername.WordWrap = false;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Camranh", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.LabelLogin.Location = new System.Drawing.Point(62, 57);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(276, 111);
            this.LabelLogin.TabIndex = 3;
            this.LabelLogin.Text = "Login";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 609);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TextBoxUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelLogin;
    }
}