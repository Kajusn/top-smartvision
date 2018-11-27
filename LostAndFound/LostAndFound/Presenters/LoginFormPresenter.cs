using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LostAndFound;
using Xamarin.Forms;
using LostAndFound.Views;
using LostAndFound.Presenters;
using System.Windows.Input;

namespace LostAndFound.Presenters
{
    public class LoginFormPresenter
    {
       // private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\References\Images\";

        public ILoginForm _view;
        private IModel _model;
        public string Username { get; set; }
        public string Password { get; set; }
        public Command LoginCommand { get; }
        public Command RegOpenCommand { get; }
        private MainPage instance;

        /*public LoginFormPresenter(IModel model)
        {
            this._model = model;
            _view = new MainPage();
            LoginCommand = new Command(() => log());
        }*/

        public LoginFormPresenter()
        {
            instance = MainPage.instance;
            LoginCommand = new Command(() => log());
            RegOpenCommand = new Command(() => reg());
        }

        /// <summary>
        /// Opens Register form
        /// </summary>
        public void reg()
        {
            instance.Navigation.PushModalAsync(new RegisterPage(), true); // TURETU BUT KAZKOKS MASTER CONTROLLERIS KURIS KURIA FORMAS, O NE IS FORMOS I FORMA
        }

        /// <summary>
        /// Logs the user in if the username and password are entered correctly and opens up the main menu form
        /// </summary>
        public void log()
        {
            if (!Login(instance.username, instance.password)) instance.DisplayAlert("Alert", "The Username or Password is incorrect", "OK");
            else
            {
                instance.DisplayAlert("", "Login complete", "OK");
            }
        }

        #region Helpers (Update data and Start)

        /// <summary>
        /// Starts the application
        /// </summary>
        public void Start()
        {
            //Application.Run((Form)_view);
        }

        /// <summary>
        /// Updates data in model
        /// </summary>
        public void UpdateData()
        {
            _model.username = _view.username;
            _model.password = _view.password;
        }

        #endregion

        #region Login

        public bool Login(string username, string password) // CIA BUTU GERIAU PERKELTI LOGIN I PVZ LOGIN KLASE AR KAZKA PANASAUS
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
