using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using top_smartvision.DB;
using top_smartvision.Models;
using top_smartvision.Views;
using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    class RegisterFormPresenter
    {
        //public IRegisterForm _view;
        private IUserModel _model;
        //private LoginForm login;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Command RegisterCommand { get; }
        public Command CancelCommand { get; }
        private RegisterPage instance;

        public RegisterFormPresenter(object obj)
        {
            /*_model = new User();
            RegisterForm form = new RegisterForm();
            form.Show();
            _view = form;
            login = (LoginForm)obj;
            _view.OnRegFormClosed += LoginOpen;
            _view.OnRegisterClicked += Register;*/
        }

        public RegisterFormPresenter()
        {
            instance = RegisterPage.instance;
            RegisterCommand = new Command(() => Reg());
            CancelCommand = new Command(() => LoginOpen());
            _model = new User();
        }

        public void LoginOpen()
        {
            instance.Navigation.PushModalAsync(new MainPage(), true);
        }

        public void Reg()
        {
            //_model = _view.newUser;

            // Calls method to write registration info to file
            Register(Name, LastName, Username, Email, Password);
            LoginOpen();
        }

        public void Register(string name, string lastname, string username, string email, string pass /*string gender*/)
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "users.txt");

            if (backingFile == null || !File.Exists(backingFile))
            {
                File.Create(backingFile);
            }

            // calls method to check is username of email is not used
            if (!CheckUsernameEmail(username, email)) return;

            // Hashing the password
            pass = Hashing(pass);

            //Creating a line of all user info
            string line = $"{name },{lastname},{username},{email},{pass}\r\n";

            //Writes the info into file
            File.AppendAllText(backingFile, line);

        }

        #region Helpers

        public bool CheckUsernameEmail(string username, string email)
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
                instance.DisplayAlert("","The username is already taken", "OK");
                return false;
            }

            // Same with Email
            AllUsers = AllUsers.Where(x => x.email == email).ToList();
            if (AllUsers.Count() > 0)
            {
                instance.DisplayAlert("","The email is already taken","OK");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Changes password into array of 16 bytes
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public String Hashing(string password)
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
