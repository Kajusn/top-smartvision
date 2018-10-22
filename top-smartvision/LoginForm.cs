using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using top_smartvision.DB;

namespace top_smartvision
{
    public partial class LoginForm : Form
    {
        private static LoginForm instance;
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Singleton Instance of form
        /// </summary>
        public static LoginForm GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }

        #region Username/Password text

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

        #endregion

        #region Helpers

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

            
            return;
        }

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
                if (sender == PasswordText) sender.PasswordChar = '*';
            }

            // Creates watermark for text box
            else if (sender.TextLength == 0)
            {
                // Sets watermark
                sender.Text = text;

                // Sets watermark color
                sender.ForeColor = SystemColors.GrayText;

                // Unmasks the text if it's a password text box
                if (sender == PasswordText) sender.PasswordChar = (Char)0;
            }
        }

        #endregion Helpers

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            

            NamePassNotEmpty();

            FileIO log = new FileIO();

            // checks if the username and pass are written correctly
            if (!log.Login(UsernameText.Text, PasswordText.Text)) MessageBox.Show("The Username or Password is incorrect");

            else
            {
                LostOrFound fm = new LostOrFound();
                fm.Show();

                this.Visible = false;
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegisterForm.GetInstance.Show();
            this.Hide();
        }
    }
}
