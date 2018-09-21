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
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.UploadImgLabel = new System.Windows.Forms.Label();
            this.ImageNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(380, 34);
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
            this.tableLayoutPanel1.Controls.Add(this.AnalyzeButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 396);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 53);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UploadImgButton
            // 
            this.UploadImgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploadImgButton.Location = new System.Drawing.Point(129, 3);
            this.UploadImgButton.Name = "UploadImgButton";
            this.UploadImgButton.Size = new System.Drawing.Size(120, 47);
            this.UploadImgButton.TabIndex = 2;
            this.UploadImgButton.Text = "Upload Image";
            this.UploadImgButton.UseVisualStyleBackColor = true;
            this.UploadImgButton.Click += new System.EventHandler(this.UploadImgButton_Click);
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalyzeButton.Location = new System.Drawing.Point(255, 3);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(122, 47);
            this.AnalyzeButton.TabIndex = 3;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBox.Location = new System.Drawing.Point(12, 46);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(380, 316);
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
            this.UploadImgLabel.Size = new System.Drawing.Size(372, 23);
            this.UploadImgLabel.TabIndex = 3;
            this.UploadImgLabel.Text = "Upload image to begin...\r\n\r\n";
            this.UploadImgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageNameLabel
            // 
            this.ImageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImageNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ImageNameLabel.Location = new System.Drawing.Point(12, 369);
            this.ImageNameLabel.MaximumSize = new System.Drawing.Size(380, 24);
            this.ImageNameLabel.Name = "ImageNameLabel";
            this.ImageNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ImageNameLabel.Size = new System.Drawing.Size(380, 24);
            this.ImageNameLabel.TabIndex = 4;
            this.ImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.ImageNameLabel);
            this.Controls.Add(this.UploadImgLabel);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TitleLabel);
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UploadImgButton;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Label UploadImgLabel;
        private System.Windows.Forms.Label ImageNameLabel;
    }
}

