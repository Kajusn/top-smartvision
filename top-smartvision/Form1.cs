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
using top_smartvision.Properties;

namespace top_smartvision
{
    public partial class Form1 : Form
    {
        static string resource = Resources.hr1;
        private Capture _capture;
        private CascadeClassifier _cascadeClassifier;

        public Form1()
        {
            InitializeComponent();
            Cascade();
            Recognition test = new Recognition();
            test.Recognizer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                pictureBox1.Image = My_Image.ToBitmap();
            }
        }

        public void Cascade()
        {
            _cascadeClassifier = new CascadeClassifier("C:/Users/Deividas/hr.xml");
            _capture = new Capture();
            ImgCamUser.Image = _capture.QueryFrame();
            using (var imageFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
            {
                if (imageFrame != null)
                {
                    var grayframe = imageFrame.Convert<Bgr, Byte>();
                    var faces = _cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10, Size.Empty); //the actual face detection happens here
                    foreach (var face in faces)
                    {
                        imageFrame.Draw(face, new Bgr(Color.BurlyWood), 3); //the detected face(s) is highlighted here using a box that is drawn around it/them

                    }
                }
                ImgCamUser.Image = imageFrame;
            }

        }
    }
}
