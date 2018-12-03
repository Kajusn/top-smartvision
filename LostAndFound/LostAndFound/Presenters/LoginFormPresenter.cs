using Xamarin.Forms;
using LostAndFound.Views;

namespace LostAndFound.Presenters
{
    public class LoginFormPresenter : ILoginFormPresenter
    {
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
            RegOpenCommand = new Command(() => openReg());
        }

        /// <summary>
        /// Opens Register form
        /// </summary>
        public void openReg()
        {
            FormController.OpenRegister(instance);
        }

        /// <summary>
        /// Logs the user in if the username and password are entered correctly and opens up the main menu form
        /// </summary>
        public void log()
        {
            if (!LoginController.Login(instance.username, instance.password)) FormController.OpenMenu(instance); //instance.DisplayAlert("", "The Username or Password is incorrect", "OK");
            else
            {
                instance.DisplayAlert("", "Login complete", "OK");
            }
        }

    }
}
