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
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";

             if ( File.Exists(appPath)==false)
             {
               
                 File.Create(appPath);

             }
             
           if (!ReadFromFile(username,email)) return;

            string line = $"{name },{lastname},{username},{email},{pass}\r\n";
           
            File.AppendAllText (appPath, line);
   
        }
        public bool ReadFromFile(string username, string email)
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";

            List<User> AllUsers = new List<User>();
            List<string> Lines = File.ReadAllLines(appPath).ToList();

            foreach (var line in Lines)
            {
                string[] info = line.Split(',');
              
                User newUser = new User();

                newUser.name = info[0];
                newUser.lastName = info[1];
                newUser.username = info[2];
                newUser.email = info[3];
                newUser.password = info[4];

                AllUsers.Add(newUser);
            }

            List<User> Usernames = new List<User>();

            Usernames = AllUsers.Where(x => x.username == username).ToList();
            if (Usernames.Count() >0)
            {
                MessageBox.Show("The username is already taken");
                return false;
            }

            AllUsers = AllUsers.Where(x => x.email == email).ToList();
            if (AllUsers.Count()>0)
            {
                MessageBox.Show("The email is already taken");
                return false;
            }
            return true;
        }
    }
}
