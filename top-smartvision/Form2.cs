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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Username")
            {
                UsernameText.Text = "";
                UsernameText.ForeColor = SystemColors.WindowText;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.TextLength == 0)
            {
                UsernameText.Text = "Username";
                UsernameText.ForeColor = SystemColors.GrayText;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.ForeColor = SystemColors.WindowText;
                PasswordText.PasswordChar = '*';
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.TextLength == 0)
            {
                PasswordText.Text = "Password";
                PasswordText.ForeColor = SystemColors.GrayText;
                PasswordText.PasswordChar = Convert.ToChar("");
            }

         

            
        }

    }
}
