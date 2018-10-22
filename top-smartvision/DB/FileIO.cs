using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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

        /// <summary>
        /// Writes registration info to file
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        public void Register(string name, string lastname, string username, string email, string pass /*string gender*/)
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";

            // Creates file if it doesn't exist
             if ( File.Exists(appPath)==false)
             {             
                 File.Create(appPath);
             }
             
             // calls method to check is username of email is not used
           if (!CheckUsernameEmail(username,email)) return;

            // Hashing the password
            pass = Hashing(pass);

            //Creating a line of all user info
            string line = $"{name },{lastname},{username},{email},{pass}\r\n";
           
            //Writes the info into file
            File.AppendAllText (appPath, line);
   
        }
        public bool CheckUsernameEmail(string username, string email)
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";

            //Creates a list of users
            List<User> AllUsers = new List<User>();

            //Creates a list of all lines in the text file
            List<string> Lines = File.ReadAllLines(appPath).ToList();

            foreach (var line in Lines)
            {
                // splits every word - name , lastname , username , email , password
                string[] info = line.Split(',');
              
                //creates user object and fils the information
                User newUser = new User();

                newUser.name = info[0];
                newUser.lastName = info[1];
                newUser.username = info[2];
                newUser.email = info[3];
                newUser.password = info[4];

                //adds the object to list
                AllUsers.Add(newUser);
            }

            //new list for filtration
            List<User> Usernames = new List<User>();

            //leaves the objects where username is the same as username of registering person
            Usernames = AllUsers.Where(x => x.username == username).ToList();

            //if there at least one object in the list the username is taken
            if (Usernames.Count() >0)
            {
                MessageBox.Show("The username is already taken");
                return false;
            }

            // Same with Email
            AllUsers = AllUsers.Where(x => x.email == email).ToList();
            if (AllUsers.Count()>0)
            {
                MessageBox.Show("The email is already taken");
                return false;
            }
            return true;
        }

       public  bool Login(string username, string password)
        {
            //hashes the password
            password = Hashing(password);

            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";

            //Creates a list of users
            List<User> AllUsers = new List<User>();

            //Creates a list of all lines in the text file
            List<string> Lines = File.ReadAllLines(appPath).ToList();

            foreach (var line in Lines)
            {
                // splits every word - name , lastname , username , email , password
                string[] info = line.Split(',');

                //creates user object and fils the information
                User newUser = new User();

                newUser.name = info[0];
                newUser.lastName = info[1];
                newUser.username = info[2];
                newUser.email = info[3];
                newUser.password = info[4];

                AllUsers.Add(newUser);
            }

            // checks if there is an account with written username and password
            AllUsers = AllUsers.Where(x => x.username == username && x.password == password).ToList();
            
            // if there is such an account user can login
            if (AllUsers.Count() == 1) return true;

            return false;
        }

        /// <summary>
        /// Changes password into array of 16 bytes
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
       public  String Hashing(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }
    }
}
