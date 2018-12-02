using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace LostAndFound
{
    static class LoginController
    {
        #region Login

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

        #endregion 
    }
}
