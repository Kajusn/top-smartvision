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
    public partial class LostOrFound : Form
    {
        public LostOrFound()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method should open form to look for lost item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lost_Button_Click(object sender, EventArgs e)
        {
            LostForm fm = new LostForm();
            fm.Show();

            this.Dispose();
        }

        /// <summary>
        /// Opens form to upload found ID pictures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Found_Button_Click(object sender, EventArgs e)
        {
            FoundForm fm = new FoundForm();
            fm.Show();

            this.Dispose();
        }

    }
}
