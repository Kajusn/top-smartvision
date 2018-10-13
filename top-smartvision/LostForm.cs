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
    public partial class LostForm : Form
    {
        public LostForm()
        {
            InitializeComponent();
        }



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
            }

            // Creates watermark for text box
            else if (sender.TextLength == 0)
            {
                // Sets watermark
                sender.Text = text;

                // Sets watermark color
                sender.ForeColor = SystemColors.GrayText;
            }
        }

        #endregion


        /// <summary>
        /// Opens up the main menu when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Opens up the main menu
            LostOrFound fm = new LostOrFound();
            fm.Show();
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            WatermarkHelper(SearchBox, "Search IDs");
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            WatermarkHelper(SearchBox, "Search IDs");
        }

        /// <summary>
        /// Opens/closes filter selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (FilterListBox.Visible)
            {
                FilterListBox.Enabled = false;
                FilterListBox.Visible = false;
                return;
            }
            FilterListBox.Enabled = true;
            FilterListBox.Visible = true;
        }

    }
}
