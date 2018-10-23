using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using top_smartvision.recognition;

namespace UnitTestProject
{
    [TestClass]
    public class RecognitionTest
    {
        private readonly Recognition<string> _recognition;

        public RecognitionTest()
        {
            _recognition = new Recognition<string>();
        }

        [TestMethod]
        public void SkeletonizeNotNull()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs Skeletonize
            var result = _recognition.Recognizer(bitmap, Recognition<string>.Option.Skeletonize);

            // Check if Skeletonize returns not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SkeletonizeReturnsBitmap()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs Skeletonize
            var result = _recognition.Recognizer(bitmap, Recognition<string>.Option.Skeletonize);

            // Check if Skeletonize returns Bitmap type
            Assert.IsInstanceOfType(result, typeof(Bitmap));
        }

        [TestMethod]
        public void CropFaceNotNull()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs Skeletonize
            var result = _recognition.Recognizer(bitmap, Recognition<string>.Option.CropFace);

            // Check if returns not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CropFaceReturnsBitmap()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs CropFace
            var result = _recognition.Recognizer(bitmap, Recognition<string>.Option.CropFace);

            // Check if returns Bitmap type
            Assert.IsInstanceOfType(result, typeof(Bitmap));
        }

        [TestMethod]
        public void SkeletonizeAndOtherNotNull()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs CropFace
            var result = _recognition.Recognizer(bitmap);

            // Check if returns not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SkeletonizeAndOtherReturnsBitmap()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs Skeletonize And Other
            var result = _recognition.Recognizer(bitmap);

            // Check if returns Bitmap type
            Assert.IsInstanceOfType(result, typeof(Bitmap));
        }

        [TestMethod]
        public void OCRNotNull()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs OCR
            var result = _recognition.OCR(bitmap);

            // Check if returns not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void OCRReturnsString()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs OCR
            var result = _recognition.OCR(bitmap);

            // Check if returns Bitmap type
            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
