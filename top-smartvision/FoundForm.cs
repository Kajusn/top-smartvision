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
using System.IO;

namespace top_smartvision
{
    public partial class FoundForm : Form
    {
        Recognition<string> test = new Recognition<string>();
        

        public FoundForm()
        {
            InitializeComponent();

            // Indexed class array item
            test[1] = "Kam nors panaudotas klases masyvas";
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

        /// <summary>
        /// Calls method to upload the ID and its information to the database/filesystem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadIDbtn_Click(object sender, EventArgs e)
        {
            UploadData();
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Uploads ID data to database/filesystem
        /// </summary>
        private void UploadData()
        {
            // Save IDTypeLbl.Text;
            // Save FirstNameLbl.Text;
            // Save LastNameLbl.Text;
            // Save IDLbl.Text;

        }

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

            // Displays information about the ID
            Show_Info();

            // Creates new bitmap object
            Bitmap Image = new Bitmap(img);

            // Named arguments mixed 
            //ImgBox.Image = test.Recognizer(option: Recognition<string>.Option.CropFace, bit: Image);

            // Makes image easier to recognize; second argument is default
            Bitmap rec = test.Recognizer(Image);

            // Loads and displays image
            ImgBox.Image = rec;

            // Changes image box maximum size to uploaded image size
            ImgBox.MaximumSize = Image.Size;

            // Displays image path
            ImageNameLabel.Text = img;

            //recognizedText.Text = test.OCR(rec);
        }

        /// <summary>
        /// Displays information about the ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Show_Info()
        {
            ID_InfoLbl.Visible = true;

            // TODO: Takes the information from the image and displays it in the appropriate fields
        }

        #endregion

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
