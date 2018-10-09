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
            string i = "1";
            Bitmap bitmap = new Bitmap(i);
            var result = _recognition.Skeletonize(bitmap);

            Assert.IsNotNull(result);
        }
    }
}
