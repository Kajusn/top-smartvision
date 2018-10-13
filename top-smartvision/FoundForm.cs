using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using top_smartvision.recognition;
using Emgu.CV;
using Emgu.CV.Structure;
using top_smartvision.DB;

namespace top_smartvision
{
    public partial class FoundForm : Form
    {
        Recognition test = new Recognition();

        public FoundForm()
        {
            InitializeComponent();
            //test.Recognizer();
        }

        #region Buttons

        /// <summary>
        /// "Takes a picture" when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadImgButton_Click(object sender, EventArgs e)
        {
            Take_Picture();
        }


        #endregion

        #region Helpers

        /// <summary>
        /// Browse system to upload an image (should be able to take a picture eventually)
        /// </summary>
        private void Take_Picture()
        {
            // Creates new file handling object
            IDB file = new FileIO();

            // Takes image from local storage
            string img = file.PullImage();

            // Quits method if no image was opened
            if (img == null)
                return;

            // Creates new bitmap object
            Bitmap Image = new Bitmap(img);
            Bitmap rec = test.Skeletonize(Image);

            // Loads and displays image
            ImgBox.Image = rec;

            // Changes image box maximum size to uploaded image size
            ImgBox.MaximumSize = Image.Size;

            // Displays image path
            ImageNameLabel.Text = img;
        }

        #endregion

        private void CompareButton_Click(object sender, EventArgs e)
        {
            // TO-DO: Runs Recognizer with opened image


           /* if ()
                MessageBox.Show ("Images are similar ");
             else
                MessageBox.Show ("Images are not similar");*/
                
        }

        /// <summary>
        /// exits application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Opens up the main menu when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoundForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Opens up the main menu
            LostOrFound fm = new LostOrFound();
            fm.Show();
        }
    }
}
