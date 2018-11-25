using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using top_smartvision.DB;
using top_smartvision.Views;

namespace top_smartvision
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        //private static RegisterForm instance;
        private User _newUser;

        public User newUser
        {
            get
            {
                _newUser.name = FirstNameText.Text;
                _newUser.lastName = LastNameText.Text;
                _newUser.username = UsernameText.Text;
                _newUser.email = EmailText.Text;
                _newUser.password = PasswordText.Text;

                return _newUser;
            }

            set
            {
                _newUser = value;

                FirstNameText.Text = _newUser.name;
                LastNameText.Text = _newUser.name;
                UsernameText.Text = _newUser.name;
                EmailText.Text = _newUser.email;
                PasswordText.Text = _newUser.password;
            }
        }

        private Action _onRegFormClosed;
        public Action OnRegFormClosed
        {
            get
            {
                return _onRegFormClosed;
            }
            set
            {
                _onRegFormClosed = value;
            }
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Singleton Instance of form
        /// </summary>
        /*public static RegisterForm GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new RegisterForm();
                }
                return instance;
            }
        }*/

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
            EmailText.BackColor = SystemColors.Window;
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
            EmailValidation(EmailText.Text);
        }

        #endregion

        #region Helpers

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

        /// <summary>
        /// Checks if all fields have been filled out, message box if false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool FieldsFilledOut(string username, string firstname, string lastname, string password, string password2, string email)
        {
            // Checks if all fields have been filled out, message box if false
            if (username == "Username" || firstname == "First Name" || lastname == "Last Name" || password == "Password" || password2 == "Re-enter Password" || email == "Email")
            {
                MessageBox.Show("Please fill out all fields");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validates email address using regular expressions
        /// </summary>
        /// <returns></returns>
        public bool EmailValidation(String email)
        {
            // Regular expressions email pattern
            String EmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                  + "@"
                                  + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            // If email doesn't match pattern, background color of text box is changed to red
            if (!Regex.IsMatch(email, EmailPattern))
            {
                EmailText.BackColor = Color.LightCoral;
                return false;
            }

            // If email matches pattern, background color is set to default
            else EmailText.BackColor = SystemColors.Window;
            return true;
        }

        #endregion

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Makes sure all fields are filled out
            FieldsFilledOut(UsernameText.Text, FirstNameText.Text, LastNameText.Text, PasswordText.Text, PasswordText2.Text, EmailText.Text);

            // Will return if Email is invalid
            if (!EmailValidation(EmailText.Text)) return;

            User newUser = new User(FirstNameText.Text, LastNameText.Text, EmailText.Text, UsernameText.Text, PasswordText.Text);

            FileIO file = new FileIO();

            // Calls method to write registration info to file
            file.Register(newUser.name, newUser.lastName, newUser.username, newUser.email, newUser.password);

            this.Close();
           // LoginForm.GetInstance.Show();

            
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _onRegFormClosed();
        }
    }

}
