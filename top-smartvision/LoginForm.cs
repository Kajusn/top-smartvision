using System;
using System.Drawing;
using System.Windows.Forms;

namespace top_smartvision
{
    public partial class LoginForm : Form , ILoginForm
    {
        private Action _onLoginBtnClicked;
        private Action _RegButtonClicked;

        #region Action setters/getters

        public Action OnLoginBtnClicked
        {
            get
            {
                return _onLoginBtnClicked;
            }
            set
            {
                _onLoginBtnClicked = value;
            }
        }

        public Action RegButtonClicked
        {
            get
            {
                return _RegButtonClicked;
            }
            set
            {
                _RegButtonClicked = value;
            }
        }

        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        public string username
        {
            get
            {
                return UsernameText.Text;
            }
            set
            {
                UsernameText.Text = value;
            }
        }

        public string password
        {
            get
            {
                return PasswordText.Text;
            }
            set
            {
                PasswordText.Text = value;
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
        private bool NamePassNotEmpty()
        {
            // Message box if Username and Password are not entered
            if ((UsernameText.Text == "" && PasswordText.Text == "") || (UsernameText.Text == "Username" && PasswordText.Text == "Password"))
            {
                MessageBox.Show("Please enter your username and password");
                return false;
            }

            // Message box if Username is not entered
            else if (UsernameText.Text == "" || UsernameText.Text == "Username")
            {
                MessageBox.Show("Please enter your username");
                return false;
            }

            // Message box if Password is not entered
            else if (PasswordText.Text == "" || PasswordText.Text == "Password")
          
            {
                MessageBox.Show("Please enter your password");
                return false;
            }

            else return true;

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
            while (NamePassNotEmpty() == false) return;
            _onLoginBtnClicked();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            //RegisterForm.GetInstance.Show();
            this.Hide();
            _RegButtonClicked();
        }
    }
}
