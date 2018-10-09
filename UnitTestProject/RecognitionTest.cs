using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using top_smartvision.recognition;

namespace UnitTestProject
{
    [TestClass]
    public class RecognitionTest
    {
        private readonly Recognition _recognition;

        public RecognitionTest()
        {
            _recognition = new Recognition();
        }

        [TestMethod]
        public void Skeletonize()
        {
            // open image to Bitmap
            Bitmap bitmap = new Bitmap(@"C:/Users/Deividas/Pictures/Camera Roll/Annotation.png");

            // Runs Skeletonize
            var result = _recognition.Skeletonize(bitmap);

            // Check if Skeletonize returns not null
            Assert.IsNotNull(result);

            // Check if Skeletonize returns Bitmap type
            Assert.IsInstanceOfType(result, typeof(Bitmap));
        }
    }
}
