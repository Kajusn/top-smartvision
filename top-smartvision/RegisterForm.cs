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
            if (FirstNameText.Text == "First Name")
            {
                // Removes watermark
                FirstNameText.Text = "";

                // Sets text color to default
                FirstNameText.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Creates "First Name" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameText_Leave(object sender, EventArgs e)
        {
            if (FirstNameText.TextLength == 0)
            {
                // Sets watermark
                FirstNameText.Text = "First Name";

                // Sets watermark color
                FirstNameText.ForeColor = SystemColors.GrayText;
            }
        }

        /// <summary>
        /// Removes "Last Name" watermark when entering username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameText_Enter(object sender, EventArgs e)
        {
            if (LastNameText.Text == "Last Name")
            {
                // Removes watermark
                LastNameText.Text = "";

                // Sets text color to default
                LastNameText.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Creates "Last Name" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameText_Leave(object sender, EventArgs e)
        {
            if (LastNameText.TextLength == 0)
            {
                // Sets watermark
                LastNameText.Text = "Last Name";

                // Sets watermark color
                LastNameText.ForeColor = SystemColors.GrayText;
            }
        }

        /// <summary>
        /// Removes "Username" watermark when entering username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Username")
            {
                // Removes watermark
                UsernameText.Text = "";

                // Sets text color to default
                UsernameText.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Creates "Username" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.TextLength == 0)
            {
                // Sets watermark
                UsernameText.Text = "Username";

                // Sets watermark color
                UsernameText.ForeColor = SystemColors.GrayText;
            }
        }

        /// <summary>
        /// Removes "Password" watermark and masks the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                // Removes watermark
                PasswordText.Text = "";

                // Sets text color to default
                PasswordText.ForeColor = SystemColors.WindowText;

                // Masks the password
                PasswordText.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Creates "Password" watermark when leaving textbox and unmasks it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.TextLength == 0)
            {
                // Unmasks the password
                PasswordText.PasswordChar = (Char)0;

                // Sets watermark
                PasswordText.Text = "Password";

                // Sets watermark color
                PasswordText.ForeColor = SystemColors.GrayText;

            }

        }

        /// <summary>
        /// Removes "Re-enter Password" watermark and masks the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText2_Enter(object sender, EventArgs e)
        {
            if (PasswordText2.Text == "Re-enter Password")
            {
                // Removes watermark
                PasswordText2.Text = "";

                // Sets text color to default
                PasswordText2.ForeColor = SystemColors.WindowText;

                // Masks the password
                PasswordText2.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Creates "Re-enter Password" watermark when leaving textbox and unmasks it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordText2_Leave(object sender, EventArgs e)
        {
            if (PasswordText2.TextLength == 0)
            {
                // Unmasks the password
                PasswordText2.PasswordChar = (Char)0;

                // Sets watermark
                PasswordText2.Text = "Re-enter Password";

                // Sets watermark color
                PasswordText2.ForeColor = SystemColors.GrayText;

            }

        }

        /// <summary>
        /// Removes "Email" watermark when entering email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (EmailText.Text == "Email")
            {
                // Removes watermark
                EmailText.Text = "";

                // Sets text color to default
                EmailText.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Creates "Email" watermark when leaving the textbox if it's empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (EmailText.TextLength == 0)
            {
                // Sets watermark
                EmailText.Text = "Email";

                // Sets watermark color
                EmailText.ForeColor = SystemColors.GrayText;
            }
        }

        #endregion
    }

}
