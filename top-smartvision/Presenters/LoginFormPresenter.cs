using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using top_smartvision.DB;

namespace top_smartvision
{
    class LoginFormPresenter
    {
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\References\Images\";

        public ILoginForm _view;
        private IModel _model;

        public LoginFormPresenter(IModel model)
        {
            this._model = model;
            _view = new LoginForm();
            _view.OnPropertyChanged += log;
            _view.RegButtonClicked += reg;
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
        /// Logs the user in if the username and password are entered correctly and opens up the main menu form
        /// </summary>
        public void log()
        {
            if (!Login(_view.username, _view.password)) MessageBox.Show("The Username or Password is incorrect");
            else
            {
                LostOrFound fm = new LostOrFound();
                fm.Show();
                fm.WelcomeMessage(_view.username);
                UpdateData();
                //Presenter sasdasd = new Presenter(_model)
            }
        }

        #region Helpers (Update data and Start)

        /// <summary>
        /// Starts the application
        /// </summary>
        public void Start()
        {
            Application.Run((Form)_view);
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

            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";
            

            if (Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\") == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\");
            }
            // Creates file if it doesn't exist
            if (File.Exists(appPath) == false)
            {
                //File.Create(appPath);
            }

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
        public void reg()
        {
            RegisterForm.GetInstance.Show();

            
        }


       /* public void Register(string name, string lastname, string username, string email, string pass /*string gender*/  //)
       // {
          /*  appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\users.txt";

            // Creates file if it doesn't exist
            if (File.Exists(appPath) == false)
            {
                File.Create(appPath);
            }

            // calls method to check is username of email is not used
            if (!CheckUsernameEmail(username, email)) return;

            // Hashing the password
            pass = Hashing(pass);

            //Creating a line of all user info
            string line = $"{name },{lastname},{username},{email},{pass}\r\n";

            //Writes the info into file
            File.AppendAllText(appPath, line);

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
            if (Usernames.Count() > 0)
            {
                MessageBox.Show("The username is already taken");
                return false;
            }

            // Same with Email
            AllUsers = AllUsers.Where(x => x.email == email).ToList();
            if (AllUsers.Count() > 0)
            {
                MessageBox.Show("The email is already taken");
                return false;
            }
            return true;
        }*/
    }
}
