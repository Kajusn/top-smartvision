namespace top_smartvision
{
    partial class Form1
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
            this.UploadImgButton = new System.Windows.Forms.Button();
            this.UploadImgToCompareButton = new System.Windows.Forms.Button();
            this.CompareButton = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.UploadImgLabel = new System.Windows.Forms.Label();
            this.ImageNameLabel = new System.Windows.Forms.Label();
            this.ImgBox2 = new System.Windows.Forms.PictureBox();
            this.ImageNameLabel2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizedText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(108, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(390, 34);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Smart Vision";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.UploadImgButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UploadImgToCompareButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CompareButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 396);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 53);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UploadImgButton
            // 
            this.UploadImgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploadImgButton.Location = new System.Drawing.Point(199, 3);
            this.UploadImgButton.Name = "UploadImgButton";
            this.UploadImgButton.Size = new System.Drawing.Size(190, 47);
            this.UploadImgButton.TabIndex = 2;
            this.UploadImgButton.Text = "Upload image";
            this.UploadImgButton.UseVisualStyleBackColor = true;
            this.UploadImgButton.Click += new System.EventHandler(this.UploadImgButton_Click);
            // 
            // UploadImgToCompareButton
            // 
            this.UploadImgToCompareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploadImgToCompareButton.Location = new System.Drawing.Point(395, 3);
            this.UploadImgToCompareButton.Name = "UploadImgToCompareButton";
            this.UploadImgToCompareButton.Size = new System.Drawing.Size(191, 47);
            this.UploadImgToCompareButton.TabIndex = 3;
            this.UploadImgToCompareButton.Text = "Upload image to compare";
            this.UploadImgToCompareButton.UseVisualStyleBackColor = true;
            this.UploadImgToCompareButton.Click += new System.EventHandler(this.UploadImgToCompareButton_Click);
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(3, 3);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(190, 47);
            this.CompareButton.TabIndex = 4;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImgBox.Location = new System.Drawing.Point(12, 46);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(270, 316);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox.TabIndex = 2;
            this.ImgBox.TabStop = false;
            this.ImgBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ImgBox_LoadCompleted);
            // 
            // UploadImgLabel
            // 
            this.UploadImgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadImgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImgLabel.Location = new System.Drawing.Point(17, 214);
            this.UploadImgLabel.Name = "UploadImgLabel";
            this.UploadImgLabel.Size = new System.Drawing.Size(581, 23);
            this.UploadImgLabel.TabIndex = 3;
            this.UploadImgLabel.Text = "Upload image to begin...\r\n\r\n";
            this.UploadImgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageNameLabel
            // 
            this.ImageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImageNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ImageNameLabel.Location = new System.Drawing.Point(9, 369);
            this.ImageNameLabel.MaximumSize = new System.Drawing.Size(380, 24);
            this.ImageNameLabel.Name = "ImageNameLabel";
            this.ImageNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ImageNameLabel.Size = new System.Drawing.Size(273, 24);
            this.ImageNameLabel.TabIndex = 4;
            this.ImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgBox2
            // 
            this.ImgBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBox2.Location = new System.Drawing.Point(389, 46);
            this.ImgBox2.Name = "ImgBox2";
            this.ImgBox2.Size = new System.Drawing.Size(140, 140);
            this.ImgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox2.TabIndex = 5;
            this.ImgBox2.TabStop = false;
            // 
            // ImageNameLabel2
            // 
            this.ImageNameLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImageNameLabel2.Location = new System.Drawing.Point(328, 369);
            this.ImageNameLabel2.Name = "ImageNameLabel2";
            this.ImageNameLabel2.Size = new System.Drawing.Size(273, 24);
            this.ImageNameLabel2.TabIndex = 6;
            this.ImageNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.updatesToolStripMenuItem.Text = "Updates";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // recognizedText
            // 
            this.recognizedText.Location = new System.Drawing.Point(334, 202);
            this.recognizedText.Multiline = true;
            this.recognizedText.Name = "recognizedText";
            this.recognizedText.Size = new System.Drawing.Size(263, 159);
            this.recognizedText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 461);
            this.Controls.Add(this.recognizedText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UploadImgLabel);
            this.Controls.Add(this.ImageNameLabel2);
            this.Controls.Add(this.ImgBox2);
            this.Controls.Add(this.ImageNameLabel);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Vision";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UploadImgButton;
        private System.Windows.Forms.Button UploadImgToCompareButton;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Label UploadImgLabel;
        private System.Windows.Forms.Label ImageNameLabel;
        private System.Windows.Forms.PictureBox ImgBox2;
        private System.Windows.Forms.Label ImageNameLabel2;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.TextBox recognizedText;
    }
}

