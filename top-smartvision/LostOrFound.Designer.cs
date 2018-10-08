namespace top_smartvision
{
    partial class LostOrFound
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
            this.Found_Button = new System.Windows.Forms.Button();
            this.Lost_Button = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Found_Button
            // 
            this.Found_Button.Location = new System.Drawing.Point(12, 359);
            this.Found_Button.Name = "Found_Button";
            this.Found_Button.Size = new System.Drawing.Size(255, 79);
            this.Found_Button.TabIndex = 0;
            this.Found_Button.Text = "I found something";
            this.Found_Button.UseVisualStyleBackColor = true;
            this.Found_Button.Click += new System.EventHandler(this.Found_Button_Click);
            // 
            // Lost_Button
            // 
            this.Lost_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Lost_Button.Location = new System.Drawing.Point(12, 265);
            this.Lost_Button.Name = "Lost_Button";
            this.Lost_Button.Size = new System.Drawing.Size(255, 79);
            this.Lost_Button.TabIndex = 1;
            this.Lost_Button.Text = "I lost something";
            this.Lost_Button.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(254, 55);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Lost && Found";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(78, 119);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(128, 40);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LostOrFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Lost_Button);
            this.Controls.Add(this.Found_Button);
            this.Name = "LostOrFound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Vision";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Found_Button;
        private System.Windows.Forms.Button Lost_Button;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}