namespace top_smartvision
{
    partial class LostForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.FilterListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(434, 34);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Lost IDs";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.65854F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.2439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.68293F));
            this.tableLayoutPanel1.Controls.Add(this.FilterBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SortBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 36);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SearchBox
            // 
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Location = new System.Drawing.Point(67, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(279, 20);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "Search IDs";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterBtn.Location = new System.Drawing.Point(3, 3);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(58, 23);
            this.FilterBtn.TabIndex = 1;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortBtn.Location = new System.Drawing.Point(352, 3);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(55, 23);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Sort by";
            this.SortBtn.UseVisualStyleBackColor = true;
            // 
            // FilterListBox
            // 
            this.FilterListBox.Enabled = false;
            this.FilterListBox.FormattingEnabled = true;
            this.FilterListBox.Items.AddRange(new object[] {
            "LSP",
            "Credit Cards",
            "Debit Cards",
            "Personal ID",
            "Driver\'s Licence"});
            this.FilterListBox.Location = new System.Drawing.Point(15, 66);
            this.FilterListBox.Name = "FilterListBox";
            this.FilterListBox.Size = new System.Drawing.Size(100, 64);
            this.FilterListBox.TabIndex = 3;
            this.FilterListBox.Visible = false;
            // 
            // LostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 552);
            this.Controls.Add(this.FilterListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "LostForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost&Found";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LostForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.CheckedListBox FilterListBox;
    }
}