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
using Tesseract;

namespace top_smartvision.recognition
{
    public class Recognition
    {
        /// <summary>
        /// Enum for one method fits all EmguCV Option
        /// </summary>
        [Flags]
        public enum Option { Skeletonize = 1, CropFace = 2, Other = 4};

        // Point struct for Skeletonize method
        PointStruct point = new PointStruct(-1, -1);

        /// <summary>
        /// 'One method fits all' for EmguCV rendering. Controls which methods to be called.
        /// </summary>
        /// <param name="bit"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public Bitmap Recognizer(Bitmap bit, Option option)
        {
            switch (option)
            {
                case Option.Skeletonize:
                    return Skeletonize(bit, point);

                case Option.CropFace:
                    return CropFace(bit);

                case Option.Other:
                    return Other(bit);

                case (Option.Skeletonize | Option.Other):
                    Bitmap bitty = Other(bit);
                    return Skeletonize(bitty, point);

                default:
                    return null;
            }
        }

        private Bitmap Other(Bitmap image)
        {
            Image<Hsv, byte> bitmap = new Image<Hsv, byte>(image);

            Hsv lowerLimit = new Hsv(0, 0, 200);
            Hsv upperLimit = new Hsv(5, 255, 255);

            var imageHSVDest = bitmap.InRange(lowerLimit, upperLimit);

            return imageHSVDest.Bitmap;
        }

        /// <summary>
        /// Finds text in a picture
        /// </summary>
        /// <param name="imageName"></param>
        /// <returns></returns>
        public string OCR(Bitmap image)
        {
                // Creates a tesseract object
                var ocr = new TesseractEngine("./tessdata", "lit", EngineMode.Default);
                
                // Processes bitmap image
                var page = ocr.Process(image, Tesseract.PageSegMode.Auto);

                // Returns text from processed image
                return page.GetText();
        }



        /// <summary>
        /// Converts image to white contours in a black background
        /// </summary>
        /// <param name="image">Bitmap</param>
        /// <returns>Bitmap</returns>
        private Bitmap Skeletonize(Bitmap image, PointStruct point)
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
            var element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(point.x, point.y));

            // Check if done in while loop
            bool done = false;

            while (!done)
            {
                // Erodes the img2 image
                CvInvoke.Erode(img2, eroded, element, new Point(point.x, point.y), 1, BorderType.Reflect, default(MCvScalar));

                // Dilates the eroded image
                CvInvoke.Dilate(eroded, temp, element, new Point(point.x, point.y), 1, BorderType.Reflect, default(MCvScalar));

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

        /// <summary>
        /// Crops face from image
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Bitmap CropFace(Bitmap image)
        {
            // Creates CascadeClassifier from trained file for face detection
            CascadeClassifier _cascadeClassifier = new CascadeClassifier("./haarcascades/haarcascade_frontalface_alt.xml");

            // Concerts Bitmap to Image<Bgr, Byte>
            Image<Bgr, Byte> grayframe = new Image<Bgr, Byte>(image);

            // Here comes the face detection processing
            var faces = _cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);

            Bitmap BmpInput = grayframe.ToBitmap();
            Bitmap ExtractedFace;
            Graphics FaceCanvas;
            Bitmap[] ExtFaces = new Bitmap[faces.Length];

            foreach (var face in faces)
            {
                // the detected face is highlighted here using a box that is drawn around it
                grayframe.Draw(face, new Bgr(Color.BurlyWood), 3);

                // Creates extracted face blank Bitmap of face size
                ExtractedFace = new Bitmap(face.Width, face.Height);

                // Draws face to the extracted face bitmap
                FaceCanvas = Graphics.FromImage(ExtractedFace);
                FaceCanvas.DrawImage(BmpInput, 0, 0, face, GraphicsUnit.Pixel);

                ExtFaces[0] = ExtractedFace;
            }
        
            return ExtFaces[0];
        }

        /// <summary>
        /// Point struct for default point value
        /// </summary>
        public struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
