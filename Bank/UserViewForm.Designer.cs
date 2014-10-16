namespace Bank
{
    partial class UserViewForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UX_RemoveAccountButton = new System.Windows.Forms.Button();
            this.UX_SettingsButton = new System.Windows.Forms.Button();
            this.UX_AddAccountButton = new System.Windows.Forms.Button();
            this.UX_AccountsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.UX_AccountsList);
            this.splitContainer1.Size = new System.Drawing.Size(647, 290);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UX_RemoveAccountButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UX_SettingsButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UX_AddAccountButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UX_RemoveAccountButton
            // 
            this.UX_RemoveAccountButton.Location = new System.Drawing.Point(3, 99);
            this.UX_RemoveAccountButton.Name = "UX_RemoveAccountButton";
            this.UX_RemoveAccountButton.Size = new System.Drawing.Size(162, 23);
            this.UX_RemoveAccountButton.TabIndex = 1;
            this.UX_RemoveAccountButton.Text = "Close Account";
            this.UX_RemoveAccountButton.UseVisualStyleBackColor = true;
            this.UX_RemoveAccountButton.Click += new System.EventHandler(this.UX_RemoveAccountButton_Click);
            // 
            // UX_SettingsButton
            // 
            this.UX_SettingsButton.Location = new System.Drawing.Point(3, 195);
            this.UX_SettingsButton.Name = "UX_SettingsButton";
            this.UX_SettingsButton.Size = new System.Drawing.Size(162, 23);
            this.UX_SettingsButton.TabIndex = 2;
            this.UX_SettingsButton.Text = "Account Settings";
            this.UX_SettingsButton.UseVisualStyleBackColor = true;
            // 
            // UX_AddAccountButton
            // 
            this.UX_AddAccountButton.Location = new System.Drawing.Point(3, 3);
            this.UX_AddAccountButton.Name = "UX_AddAccountButton";
            this.UX_AddAccountButton.Size = new System.Drawing.Size(162, 23);
            this.UX_AddAccountButton.TabIndex = 0;
            this.UX_AddAccountButton.Text = "Add Account";
            this.UX_AddAccountButton.UseVisualStyleBackColor = true;
            this.UX_AddAccountButton.Click += new System.EventHandler(this.UX_AddAccountButton_Click);
            // 
            // UX_AccountsList
            // 
            this.UX_AccountsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UX_AccountsList.FormattingEnabled = true;
            this.UX_AccountsList.Location = new System.Drawing.Point(0, 0);
            this.UX_AccountsList.Name = "UX_AccountsList";
            this.UX_AccountsList.Size = new System.Drawing.Size(475, 290);
            this.UX_AccountsList.TabIndex = 0;
            this.UX_AccountsList.DoubleClick += new System.EventHandler(this.UX_AccountsList_DoubleClick);
            this.UX_AccountsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UX_AccountsList_MouseDoubleClick);
            // 
            // UserViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 290);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserViewForm";
            this.Text = "UserViewForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox UX_AccountsList;
        private System.Windows.Forms.Button UX_RemoveAccountButton;
        private System.Windows.Forms.Button UX_SettingsButton;
        private System.Windows.Forms.Button UX_AddAccountButton;
    }
}