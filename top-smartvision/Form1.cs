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
    public partial class Form1 : Form
    {
        Recognition test = new Recognition();

        public Form1()
        {
            InitializeComponent();
            //test.Recognizer();
        }

        #region Upload image

        /// <summary>
        /// Browse system for image to upload and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadImgButton_Click(object sender, EventArgs e)
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
            //ImgBox.LoadAsync (img);
            ImgBox.Image = rec;

            // Changes image box maximum size to uploaded image size
            ImgBox.MaximumSize = Image.Size;

            // Displays image path
            ImageNameLabel.Text = img;
        }

        /// <summary>
        /// Hides upload img prompt when img loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Hides "Upload image" prompt
            UploadImgLabel.Visible = false;
            UploadImgButton.Text = "Upload another image";
        }
          
        /// <summary>
        /// Uploads image 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadImgToCompareButton_Click(object sender, EventArgs e)
        {
            // Creates new file handling object
            IDB file = new FileIO();

            // Takes image from local storage
            string img = file.PullImage();

            // Quits method if no image was opened
            if (img == null)
                return;

            // Loads and displays image
            ImgBox2.LoadAsync(img);

            // Creates new bitmap object
            Bitmap Image = new Bitmap(img);

            // Displays image path
            ImageNameLabel2.Text = img;

            // Changes image box maximum size to uploaded image size
            ImgBox2.MaximumSize = Image.Size;

            UploadImgToCompareButton.Text = "Upload another image";
           
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
    }
}
