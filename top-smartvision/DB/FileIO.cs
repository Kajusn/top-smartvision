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

        /// <summary>
        /// Takes image from local storage
        /// </summary>
        /// <returns>image string</returns>
        public string PullImage()
        {
            // Open file dialog
            OpenFileDialog open = new OpenFileDialog
            {
                // Opens default directory for images
                InitialDirectory = appPath,

                // Filters the types of files that can be opened
                Filter = "*.jpg; *.jpeg; *.bmp; *.png|*.jpg; *.jpeg; *.bmp; *.png"
            };

            // returns null if no image was opened
            if (open.ShowDialog() != DialogResult.OK)
                return null;
            
            return open.FileName;
        }

        /// <summary>
        /// Saves image from local storage to default directory
        /// </summary>
        public void PushImage()
        {
            // Open file dialog
            OpenFileDialog open = new OpenFileDialog
            {
                // Opens default directory for images
                InitialDirectory = appPath,

                // Filters the types of files that can be opened
                Filter = "*.jpg; *.jpeg; *.bmp; *.png|*.jpg; *.jpeg; *.bmp; *.png"
            };

            // Creates directory if not present
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Gets the filename and extension
                    string iName = open.SafeFileName;

                    // Gets current file path
                    string filepath = open.FileName;

                    // Copies image to default directory
                    File.Copy(filepath, appPath + iName);
                }
                catch (Exception exp)
                {
                    // Catches errors if failed
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                // Disposes OpenFileDialog object
                open.Dispose();
            }
        }

        /// <summary>
        /// Save displayed image to default directory
        /// </summary>
        /// <param name="image"></param>
        public void PushImage(string image)
        {
            // Not yet implemented
        }
        public void WriteToFile(string name, string lastname, string username, string email, string pass /*string gender*/)
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\";

            /* if (Directory.Exists(appPath)==false || File.Exists(appPath)==false)
             {
                 Directory.CreateDirectory(appPath);
                 appPath = appPath + @"users.txt";
                 File.Create(appPath);

             }
             */
            appPath = appPath + @"users.txt";
            string line = $"{name },{lastname},{username},{email},{pass}\r\n";
           
            File.AppendAllText (appPath, line);
   
        }
        public void ReadFromFile(string a, string b)
        {

        }
    }
}
