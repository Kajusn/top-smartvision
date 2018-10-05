using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top_smartvision.DB
{
    class FileIO : IDB
    {
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\References\Images\";

        public string PullImage()
        {
            // Open file dialog
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = appPath,
                // Filters the types of files that can be opened
                Filter = "*.jpg; *.jpeg; *.bmp; *.png|*.jpg; *.jpeg; *.bmp; *.png"
            };
            if (open.ShowDialog() != DialogResult.OK)
                return null;
            
            return open.FileName;
        }

        public void PushImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"..\Resources\Images\";
            open.Filter = " *.jpg; *.jpeg; *.bmp; *.png|*.jpg; *.jpeg; *.bmp; *.png";

            
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = open.SafeFileName;
                    string filepath = open.FileName;
                    File.Copy(filepath, appPath + iName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                open.Dispose();
            }
        }

        public void PushImage(string image)
        {
            

            Bitmap b = new Bitmap(image);
            string startupPath = Environment.CurrentDirectory;
            b.Save(@"..\Resources\Images\img.jpg");
        }
    }
}
