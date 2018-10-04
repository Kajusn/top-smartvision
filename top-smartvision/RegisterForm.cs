using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top_smartvision
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        #region Text watermarks

        /// <summary>
        /// Removes "First Name" watermark when entering username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameText_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(FirstNameText, "First Name");
        }

        /// <summary>
        /// Creates "First Name" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameText_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(FirstNameText, "First Name");
        }

        /// <summary>
        /// Removes "Last Name" watermark when entering username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameText_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(LastNameText, "Last Name");
        }

        /// <summary>
        /// Creates "Last Name" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameText_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(LastNameText, "Last Name");
        }

        /// <summary>
        /// Removes "Username" watermark when entering username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameText_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(UsernameText, "Username");
        }

        /// <summary>
        /// Creates "Username" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameText_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(UsernameText, "Username");
        }

        /// <summary>
        /// Removes "Password" watermark and masks the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(PasswordText, "Password");
        }

        /// <summary>
        /// Creates "Password" watermark when leaving textbox and unmasks it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(PasswordText, "Password");
        }

        /// <summary>
        /// Removes "Re-enter Password" watermark and masks the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText2_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(PasswordText2, "Re-enter Password");
        }

        /// <summary>
        /// Creates "Re-enter Password" watermark when leaving textbox and unmasks it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText2_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(PasswordText2, "Re-enter Password");
        }

        /// <summary>
        /// Removes "Email" watermark when entering email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(EmailText, "Email");
        }

        /// <summary>
        /// Creates "Email" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(EmailText, "Email");
        }

        #endregion

        /// <summary>
        /// Helps set and remove watermarks for text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="text"></param>
        private void WatermarkHelper(TextBox sender, string text)
        {
            // Removes watermark from text box
            if (sender.Text == text)
            {
                // Removes watermark
                sender.Text = "";

                // Sets text color to default
                sender.ForeColor = SystemColors.WindowText;

                // Masks the text if it's a password text box
                if ((sender == PasswordText) || (sender == PasswordText2)) sender.PasswordChar = '*';
            }

            // Creates watermark for text box
            else if (sender.TextLength == 0)
            {
                // Sets watermark
                sender.Text = text;

                // Sets watermark color
                sender.ForeColor = SystemColors.GrayText;

                // Unmasks the text if it's a password text box
                if ((sender == PasswordText) || (sender == PasswordText2)) sender.PasswordChar = (Char)0;
            }
        }
    }

}
