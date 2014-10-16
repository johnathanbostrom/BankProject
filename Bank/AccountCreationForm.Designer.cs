namespace Bank
{
    partial class AccountCreationForm
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
            this.UX_Select = new System.Windows.Forms.ComboBox();
            this.UX_OKButton = new System.Windows.Forms.Button();
            this.UX_CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UX_Select
            // 
            this.UX_Select.FormattingEnabled = true;
            this.UX_Select.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.UX_Select.Location = new System.Drawing.Point(12, 12);
            this.UX_Select.Name = "UX_Select";
            this.UX_Select.Size = new System.Drawing.Size(248, 21);
            this.UX_Select.TabIndex = 0;
            this.UX_Select.SelectedIndexChanged += new System.EventHandler(this.UX_Select_SelectedIndexChanged);
            // 
            // UX_OKButton
            // 
            this.UX_OKButton.Location = new System.Drawing.Point(143, 39);
            this.UX_OKButton.Name = "UX_OKButton";
            this.UX_OKButton.Size = new System.Drawing.Size(75, 23);
            this.UX_OKButton.TabIndex = 1;
            this.UX_OKButton.Text = "OK";
            this.UX_OKButton.UseVisualStyleBackColor = true;
            this.UX_OKButton.Click += new System.EventHandler(this.UX_OKButton_Click);
            // 
            // UX_CancelButton
            // 
            this.UX_CancelButton.Location = new System.Drawing.Point(45, 39);
            this.UX_CancelButton.Name = "UX_CancelButton";
            this.UX_CancelButton.Size = new System.Drawing.Size(75, 23);
            this.UX_CancelButton.TabIndex = 2;
            this.UX_CancelButton.Text = "Cancel";
            this.UX_CancelButton.UseVisualStyleBackColor = true;
            this.UX_CancelButton.Click += new System.EventHandler(this.UX_CancelButton_Click);
            // 
            // AccountCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 84);
            this.Controls.Add(this.UX_CancelButton);
            this.Controls.Add(this.UX_OKButton);
            this.Controls.Add(this.UX_Select);
            this.Name = "AccountCreationForm";
            this.Text = "AccountCreationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox UX_Select;
        private System.Windows.Forms.Button UX_OKButton;
        private System.Windows.Forms.Button UX_CancelButton;
    }
}