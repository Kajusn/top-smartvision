using LostAndFound.Models;
using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    public class RegisterFormPresenter : IRegisterFormPresenter
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
            // Calls method to write registration info to file
            LoginController.Register(Name, LastName, Username, Email, Password, instance);
            LoginOpen();
        }
        
    }
}
