namespace Bank
{
    partial class LoginForm
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
            this.UX_PasswordBox = new System.Windows.Forms.TextBox();
            this.UX_UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UX_Button = new System.Windows.Forms.Button();
            this.UX_LabelUserName = new System.Windows.Forms.Label();
            this.UX_LabelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UX_PasswordBox
            // 
            this.UX_PasswordBox.Location = new System.Drawing.Point(86, 77);
            this.UX_PasswordBox.Name = "UX_PasswordBox";
            this.UX_PasswordBox.Size = new System.Drawing.Size(356, 20);
            this.UX_PasswordBox.TabIndex = 1;
            // 
            // UX_UserNameTextBox
            // 
            this.UX_UserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UX_UserNameTextBox.Location = new System.Drawing.Point(86, 28);
            this.UX_UserNameTextBox.Name = "UX_UserNameTextBox";
            this.UX_UserNameTextBox.Size = new System.Drawing.Size(356, 20);
            this.UX_UserNameTextBox.TabIndex = 2;
            // 
            // UX_Button
            // 
            this.UX_Button.Location = new System.Drawing.Point(86, 116);
            this.UX_Button.Name = "UX_Button";
            this.UX_Button.Size = new System.Drawing.Size(111, 23);
            this.UX_Button.TabIndex = 3;
            this.UX_Button.Text = "Enter";
            this.UX_Button.UseVisualStyleBackColor = true;
            this.UX_Button.Click += new System.EventHandler(this.UX_Button_Click);
            // 
            // UX_LabelUserName
            // 
            this.UX_LabelUserName.AutoSize = true;
            this.UX_LabelUserName.Location = new System.Drawing.Point(12, 31);
            this.UX_LabelUserName.Name = "UX_LabelUserName";
            this.UX_LabelUserName.Size = new System.Drawing.Size(60, 13);
            this.UX_LabelUserName.TabIndex = 4;
            this.UX_LabelUserName.Text = "User Name";
            // 
            // UX_LabelPassword
            // 
            this.UX_LabelPassword.AutoSize = true;
            this.UX_LabelPassword.Location = new System.Drawing.Point(12, 80);
            this.UX_LabelPassword.Name = "UX_LabelPassword";
            this.UX_LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.UX_LabelPassword.TabIndex = 5;
            this.UX_LabelPassword.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 151);
            this.Controls.Add(this.UX_LabelPassword);
            this.Controls.Add(this.UX_LabelUserName);
            this.Controls.Add(this.UX_Button);
            this.Controls.Add(this.UX_UserNameTextBox);
            this.Controls.Add(this.UX_PasswordBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UX_PasswordBox;
        private System.Windows.Forms.TextBox UX_UserNameTextBox;
        private System.Windows.Forms.Button UX_Button;
        private System.Windows.Forms.Label UX_LabelUserName;
        private System.Windows.Forms.Label UX_LabelPassword;
    }
}

