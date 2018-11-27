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
        private MainPage instance;

        public LoginFormPresenter(IModel model)
        {
            this._model = model;
            _view = new MainPage();

            LoginCommand = new Command(() => log());

            //_view.OnLoginBtnClicked += log;
            //_view.RegButtonClicked += reg;

            
        }

        public LoginFormPresenter()
        {
            instance = MainPage.instance;
            //this._model = model;
            //_view = new MainPage();

            LoginCommand = new Command(() => log());

            //_view.OnLoginBtnClicked += log;
            //_view.RegButtonClicked += reg;


        }

        /*public void Registr()
        {
            string name = _view.user.name;
            string lastname = _view.user.lastName;
            string username = _view.user.username;
            string email = _view.user.email;
            string pass = _view.user.password;

            _model.Register(name, lastname, username, email, pass);
        }*/

        /// <summary>
        /// Opens Register form
        /// </summary>
        public void reg()
        {
           // RegisterFormPresenter regPresenter = new RegisterFormPresenter(_view);
        }

        /// <summary>
        /// Logs the user in if the username and password are entered correctly and opens up the main menu form
        /// </summary>
        public void log()
        {
            if (!Login(instance.username, instance.password)) instance.DisplayAlert("Alert", "The Username or Password is incorrect", "okayblet");
            else
            {
                /* LostOrFound fm = new LostOrFound();
                 fm.Show();
                 fm.WelcomeMessage(_view.username);
                 UpdateData();*/
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

        public bool Login(string username, string password)
        {
            //hashes the password
            password = Hashing(password);

            string appPath = @"C:\Users\Dovydas\Documents\GitHub\top-smartvision\top-smartvision\bin\Debug\Users\users.txt";
          

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
