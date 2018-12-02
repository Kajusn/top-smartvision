using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Xamarin.Forms;

namespace LostAndFound
{
    static class LoginController
    {
        /// <summary>
        /// User Login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Login(string username, string password)
        {
            //hashes the password
            password = Hashing(password);

            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "users.txt");

            if (backingFile == null || !File.Exists(backingFile))
            {
                File.Create(backingFile);
            }

            //string appPath = @"C:\Users\Dovydas\Documents\GitHub\top-smartvision\top-smartvision\bin\Debug\Users\users.txt";


            //Creates a list of users
            List<User> AllUsers = new List<User>();

            //Creates a list of all lines in the text file
            List<string> Lines = File.ReadAllLines(backingFile).ToList();

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
        /// Registers the user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        public static void Register(string name, string lastname, string username, string email, string pass, ContentPage instance /*string gender*/)
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "users.txt");

            if (backingFile == null || !File.Exists(backingFile))
            {
                File.Create(backingFile);
            }

            // calls method to check is username of email is not used
            if (!CheckUsernameEmail(username, email, instance)) return;

            // Hashing the password
            pass = Hashing(pass);

            //Creating a line of all user info
            string line = $"{name },{lastname},{username},{email},{pass}\r\n";

            //Writes the info into file
            File.AppendAllText(backingFile, line);

        }

        /// <summary>
        /// Checks to see if the given Username or Email is already taken
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool CheckUsernameEmail(string username, string email, ContentPage instance)
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "users.txt");

            //Creates a list of users
            List<User> AllUsers = new List<User>();

            //Creates a list of all lines in the text file
            List<string> Lines = File.ReadAllLines(backingFile).ToList();

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
            if (Usernames.Count() > 0)
            {
                instance.DisplayAlert("", "The username is already taken", "OK");
                return false;
            }

            // Same with Email
            AllUsers = AllUsers.Where(x => x.email == email).ToList();
            if (AllUsers.Count() > 0)
            {
                instance.DisplayAlert("", "The email is already taken", "OK");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Changes password into array of 16 bytes
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static String Hashing(string password)
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
