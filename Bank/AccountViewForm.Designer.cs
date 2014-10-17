namespace Bank
{
    partial class AccountViewForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UX_depositButton = new System.Windows.Forms.Button();
            this.ux_withrawButton = new System.Windows.Forms.Button();
            this.UX_transferButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UX_BalanceLabel = new System.Windows.Forms.Label();
            this.UX_transactionList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UX_DepositText = new System.Windows.Forms.TextBox();
            this.UX_WithdrawText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(575, 287);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.UX_transferButton, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 287);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // UX_depositButton
            // 
            this.UX_depositButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UX_depositButton.Location = new System.Drawing.Point(54, 55);
            this.UX_depositButton.Name = "UX_depositButton";
            this.UX_depositButton.Size = new System.Drawing.Size(75, 23);
            this.UX_depositButton.TabIndex = 0;
            this.UX_depositButton.Text = "Deposit";
            this.UX_depositButton.UseVisualStyleBackColor = true;
            this.UX_depositButton.Click += new System.EventHandler(this.UX_depositButton_Click);
            // 
            // ux_withrawButton
            // 
            this.ux_withrawButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ux_withrawButton.Location = new System.Drawing.Point(54, 55);
            this.ux_withrawButton.Name = "ux_withrawButton";
            this.ux_withrawButton.Size = new System.Drawing.Size(75, 23);
            this.ux_withrawButton.TabIndex = 1;
            this.ux_withrawButton.Text = "Withdraw";
            this.ux_withrawButton.UseVisualStyleBackColor = true;
            this.ux_withrawButton.Click += new System.EventHandler(this.ux_withrawButton_Click);
            // 
            // UX_transferButton
            // 
            this.UX_transferButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UX_transferButton.Location = new System.Drawing.Point(57, 227);
            this.UX_transferButton.Name = "UX_transferButton";
            this.UX_transferButton.Size = new System.Drawing.Size(75, 23);
            this.UX_transferButton.TabIndex = 2;
            this.UX_transferButton.Text = "Transfer";
            this.UX_transferButton.UseVisualStyleBackColor = true;
            this.UX_transferButton.Click += new System.EventHandler(this.UX_transferButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UX_BalanceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UX_transactionList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UX_BalanceLabel
            // 
            this.UX_BalanceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UX_BalanceLabel.AutoSize = true;
            this.UX_BalanceLabel.Location = new System.Drawing.Point(166, 22);
            this.UX_BalanceLabel.Name = "UX_BalanceLabel";
            this.UX_BalanceLabel.Size = new System.Drawing.Size(49, 13);
            this.UX_BalanceLabel.TabIndex = 0;
            this.UX_BalanceLabel.Text = "Balance:";
            // 
            // UX_transactionList
            // 
            this.UX_transactionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UX_transactionList.FormattingEnabled = true;
            this.UX_transactionList.Location = new System.Drawing.Point(3, 60);
            this.UX_transactionList.Name = "UX_transactionList";
            this.UX_transactionList.Size = new System.Drawing.Size(375, 224);
            this.UX_transactionList.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.UX_depositButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.UX_DepositText, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(184, 89);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ux_withrawButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.UX_WithdrawText, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 98);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(184, 89);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // UX_DepositText
            // 
            this.UX_DepositText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UX_DepositText.Location = new System.Drawing.Point(42, 12);
            this.UX_DepositText.Name = "UX_DepositText";
            this.UX_DepositText.Size = new System.Drawing.Size(100, 20);
            this.UX_DepositText.TabIndex = 1;
            // 
            // UX_WithdrawText
            // 
            this.UX_WithdrawText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UX_WithdrawText.Location = new System.Drawing.Point(42, 12);
            this.UX_WithdrawText.Name = "UX_WithdrawText";
            this.UX_WithdrawText.Size = new System.Drawing.Size(100, 20);
            this.UX_WithdrawText.TabIndex = 2;
            // 
            // AccountViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 287);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AccountViewForm";
            this.Text = "AccountViewForm";
            this.Load += new System.EventHandler(this.AccountViewForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button UX_depositButton;
        private System.Windows.Forms.Button ux_withrawButton;
        private System.Windows.Forms.Button UX_transferButton;
        private System.Windows.Forms.Label UX_BalanceLabel;
        private System.Windows.Forms.ListBox UX_transactionList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox UX_DepositText;
        private System.Windows.Forms.TextBox UX_WithdrawText;

    }
}