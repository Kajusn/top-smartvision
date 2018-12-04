using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    class FoundFormPresenter: IFoundFormPresenter
    {
        //private IUserModel _model;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Command PickPicCommand { get; }
        public Command CancelCommand { get; }
        private RegisterPage instance;


        public FoundFormPresenter()
        {
            instance = RegisterPage.instance;
            PickPicCommand = new Command(() => PickPic());
            CancelCommand = new Command(() => LoginOpen());
            //_model = new User();
        }

        public void LoginOpen()
        {
            FormController.OpenLogin(instance);
        }

        public void PickPic()
        {
            // Calls method to write registration info to file
            LoginController.Register(Name, LastName, Username, Email, Password, instance);
        }
    }
}
