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
            Tesseract _ocr;
            _ocr = new Tesseract(@"C:\Emgu\emgucv-windows-universal 3.0.0.2157\Emgu.CV.OCR\tessdata", "eng", OcrEngineMode.TesseractLstmCombined);//first Parameter set your path ..complete path like i did
            _ocr.SetVariable("tessedit_char_whitelist", "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopkrstuvwxyz");
            
        }

        /*public List<Rectangle> detectLetters(Image<Bgr, Byte> img)
        {
            List<Rectangle> rects = new List<Rectangle>();
            Image<Gray, Single> img_sobel;
            Image<Gray, Byte> img_gray, img_threshold;
            img_gray = img.Convert<Gray, Byte>();
            img_sobel = img_gray.Sobel(1, 0, 3);
            img_threshold = new Image<Gray, byte>(img_sobel.Size);
            CvInvoke.Threshold(img_sobel.Convert<Gray, Byte>(), img_threshold, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3,17), new Point(1, 6));
            //StructuringElementEx element = new StructuringElementEx(3, 17, 1, 6, Emgu.CV.CvEnum.ElementShape.Rectangle);
            //CvInvoke.MorphologyEx(img_threshold, img_threshold, IntPtr.Zero, element, BorderType.Isolated, 1);

            for (Contour<System.Drawing.Point> contours = img_threshold.FindContours(); contours != null; contours = contours.HNext)
            {
                if (contours.Area > 100)
                {
                    Contour<System.Drawing.Point> contours_poly = contours.ApproxPoly(3);
                    rects.Add(new Rectangle(contours_poly.BoundingRectangle.X, contours_poly.BoundingRectangle.Y, contours_poly.BoundingRectangle.Width, contours_poly.BoundingRectangle.Height));
                }
            }
            return rects;
        }*/
        /*
        private CascadeClassifier _cascadeClassifier = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalface_alt_tree.xml");
        using (var imageFrame = _capture.QueryFrame().ToImage())
        {
            if (imageFrame != null)
            {
                var grayframe = imageFrame.Convert();
                var faces = _cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10, Size.Empty); //the actual face detection happens here
                foreach (var face in faces)
                {
                    imageFrame.Draw(face, new Bgr(Color.BurlyWood), 3); //the detected face(s) is highlighted here using a box that is drawn around it/them

                }
            }
            imgCamUser.Image = imageFrame;                    
        }*/

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
