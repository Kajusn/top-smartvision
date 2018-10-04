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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Username/Password text

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

        #endregion

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // TO-DO:
            // Login button takes you to homescreen/main menu

            NamePassNotEmpty();
        }
        
        /// <summary>
        /// Makes sure Username and Password fields are not empty
        /// </summary>
        private void NamePassNotEmpty()
        {
            // Message box if Username and Password are not entered
            if ((UsernameText.Text == "" && PasswordText.Text == "") || (UsernameText.Text == "Username" && PasswordText.Text == "Password"))
                MessageBox.Show("Please enter your username and password");

            // Message box if Username is not entered
            else if (UsernameText.Text == "" || UsernameText.Text == "Username")
                MessageBox.Show("Please enter your username");

            // Message box if Password is not entered
            else if (PasswordText.Text == "" || PasswordText.Text == "Password")
                MessageBox.Show("Please enter your password");

            else return;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
            this.Hide();
        }
    }
}
