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

            CvInvoke.cvShowImage("imageHSVDest", imageHSVDest);
            CvInvoke.cvWaitKey(1000);
        }
    }
}
