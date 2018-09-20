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
            test.Recognizer();
        }
    }
}
