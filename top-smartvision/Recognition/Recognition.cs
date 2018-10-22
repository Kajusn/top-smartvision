using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.OCR;
using System.Windows.Forms;

namespace top_smartvision.recognition
{
    public class Recognition
    {
        public void Recognizer()
        {
            Image<Hsv, byte> bitmap = new Image<Hsv, byte>(@"C:\Users\Deividas\source\plate.bmp");

            Hsv lowerLimit = new Hsv(0, 0, 200);
            Hsv upperLimit = new Hsv(5, 255, 255);

            var imageHSVDest = bitmap.InRange(lowerLimit, upperLimit);

            CvInvoke.Imshow("imageHSVDest", imageHSVDest);
            CvInvoke.WaitKey(1000);
        }

        /// <summary>
        /// Not yet realized. Finds text in a picture
        /// </summary>
        public void OCR()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFile.FileName);
                var ocr = new TesseractEngine("./tessdata", "lit", EngineMode.Default);
                var page = ocr.Process(img, PageSegMode.Auto);

                textBox1.Text = page.GetText();


            }
        }



        /// <summary>
        /// Converts image to white contours in a black background
        /// </summary>
        /// <param name="image">Bitmap</param>
        /// <returns>Bitmap</returns>
        public Bitmap Skeletonize(Bitmap image)
        {
            // Makes bunch of image objects for futher execution
            Image<Gray, byte> imgOld = new Image<Gray, byte>(image);
            Image<Gray, byte> img2 = (new Image<Gray, byte>(imgOld.Width, imgOld.Height, new Gray(255))).Sub(imgOld);
            Image<Gray, byte> eroded = new Image<Gray, byte>(img2.Size);
            Image<Gray, byte> temp = new Image<Gray, byte>(img2.Size);
            Image<Gray, byte> skel = new Image<Gray, byte>(img2.Size);

            // Sets skel image value to 0
            skel.SetValue(0);

            // Makes img2 from grayscale to binary
            CvInvoke.Threshold(img2, img2, 127, 256, 0);

            // Makes structuring element for morphological operations
            var element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));

            // Check if done in while loop
            bool done = false;

            while (!done)
            {
                // Erodes the img2 image
                CvInvoke.Erode(img2, eroded, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));

                // Dilates the eroded image
                CvInvoke.Dilate(eroded, temp, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));

                // Subtracts proccessed temp image from binary img2 image
                CvInvoke.Subtract(img2, temp, temp);

                // Calcs bit disjunction between images
                CvInvoke.BitwiseOr(skel, temp, skel);

                // Copies eroded to img2 for while loop
                eroded.CopyTo(img2);

                // Checks whether all img2 was proccessed
                if (CvInvoke.CountNonZero(img2) == 0) done = true;
            }
            return skel.Bitmap;
        }
    }
}
