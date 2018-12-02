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
            if (!LoginController.Login(instance.username, instance.password)) instance.DisplayAlert("Alert", "The Username or Password is incorrect", "OK");
            else
            {
                instance.DisplayAlert("", "Login complete", "OK");
            }
        }

    }
}
