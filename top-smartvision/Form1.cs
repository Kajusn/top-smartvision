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

namespace top_smartvision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Recognition test = new Recognition();
            //test.Recognizer();
        }

        #region Upload image

        /// <summary>
        /// Browsw system for image to upload and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadImgButton_Click(object sender, EventArgs e)
        {
            // Open file dialog
            OpenFileDialog open = new OpenFileDialog();
            
            // Filters the types of files that can be opened
            open.Filter = "*.jpg; *jpeg; *.bmp; *.png|*.jpg; *jpeg; *.bmp; *.png";
            if (open.ShowDialog() != DialogResult.OK)
                return;
            
            // Loads and displays image
            ImgBox.LoadAsync (open.FileName);

            // Displays image path
            ImageNameLabel.Text = open.FileName;
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

        #endregion

        /// <summary>
        /// Runs image recognizer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            // TO-DO: Runs Recognizer with opened image
        }

        
    }
}
