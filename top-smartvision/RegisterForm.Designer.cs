namespace top_smartvision
{
    partial class RegisterForm
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
            this.CreateAccLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordText2 = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.MaleLabel = new System.Windows.Forms.Label();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.FemaleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateAccLabel
            // 
            this.CreateAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateAccLabel.Location = new System.Drawing.Point(12, 22);
            this.CreateAccLabel.Name = "CreateAccLabel";
            this.CreateAccLabel.Size = new System.Drawing.Size(260, 28);
            this.CreateAccLabel.TabIndex = 3;
            this.CreateAccLabel.Text = "Create a new account";
            this.CreateAccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FirstNameText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastNameText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UsernameText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordText2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EmailText, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 252);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FirstNameText.Location = new System.Drawing.Point(13, 9);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(144, 22);
            this.FirstNameText.TabIndex = 1;
            this.FirstNameText.Text = "First Name";
            this.FirstNameText.Enter += new System.EventHandler(this.FirstNameText_Enter);
            this.FirstNameText.Leave += new System.EventHandler(this.FirstNameText_Leave);
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LastNameText.Location = new System.Drawing.Point(13, 50);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(144, 22);
            this.LastNameText.TabIndex = 2;
            this.LastNameText.Text = "Last Name";
            this.LastNameText.Enter += new System.EventHandler(this.LastNameText_Enter);
            this.LastNameText.Leave += new System.EventHandler(this.LastNameText_Leave);
            // 
            // UsernameText
            // 
            this.UsernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UsernameText.Location = new System.Drawing.Point(13, 91);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(144, 22);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Username";
            this.UsernameText.Enter += new System.EventHandler(this.UsernameText_Enter);
            this.UsernameText.Leave += new System.EventHandler(this.UsernameText_Leave);
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordText.Location = new System.Drawing.Point(13, 132);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(144, 22);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "Password";
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.PasswordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // PasswordText2
            // 
            this.PasswordText2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordText2.Location = new System.Drawing.Point(13, 173);
            this.PasswordText2.Name = "PasswordText2";
            this.PasswordText2.Size = new System.Drawing.Size(144, 22);
            this.PasswordText2.TabIndex = 5;
            this.PasswordText2.Text = "Re-enter Password";
            this.PasswordText2.Enter += new System.EventHandler(this.PasswordText2_Enter);
            this.PasswordText2.Leave += new System.EventHandler(this.PasswordText2_Leave);
            // 
            // EmailText
            // 
            this.EmailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailText.Location = new System.Drawing.Point(13, 217);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(144, 22);
            this.EmailText.TabIndex = 6;
            this.EmailText.Text = "Email";
            this.EmailText.Enter += new System.EventHandler(this.EmailText_Enter);
            this.EmailText.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // MaleLabel
            // 
            this.MaleLabel.AutoSize = true;
            this.MaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleLabel.Location = new System.Drawing.Point(69, 329);
            this.MaleLabel.Name = "MaleLabel";
            this.MaleLabel.Size = new System.Drawing.Size(38, 16);
            this.MaleLabel.TabIndex = 7;
            this.MaleLabel.Text = "Male";
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Location = new System.Drawing.Point(174, 329);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(14, 13);
            this.MaleRadioBtn.TabIndex = 8;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(174, 350);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(14, 13);
            this.FemaleRadioBtn.TabIndex = 9;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleLabel
            // 
            this.FemaleLabel.AutoSize = true;
            this.FemaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleLabel.Location = new System.Drawing.Point(69, 348);
            this.FemaleLabel.Name = "FemaleLabel";
            this.FemaleLabel.Size = new System.Drawing.Size(54, 16);
            this.FemaleLabel.TabIndex = 10;
            this.FemaleLabel.Text = "Female";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 421);
            this.Controls.Add(this.FemaleLabel);
            this.Controls.Add(this.FemaleRadioBtn);
            this.Controls.Add(this.MaleRadioBtn);
            this.Controls.Add(this.MaleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CreateAccLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CreateAccLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox PasswordText2;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label MaleLabel;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
        private System.Windows.Forms.Label FemaleLabel;
    }
}