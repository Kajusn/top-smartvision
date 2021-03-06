﻿using LostAndFound.Models;
using System;
using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    public class RegisterFormPresenter : IRegisterFormPresenter
    {
        private IUserModel _model;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Command RegisterCommand { get; }
        public Command CancelCommand { get; }
        private RegisterPage instance;
        Lazy<LoginController> lazy = new Lazy<LoginController>();

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
            FormController.OpenLogin(instance);
        }

        public void Reg()
        {
            if (FieldsEmpty()) return;
            if (!LoginController.EmailValidation(Email)) { instance.InvalidEmail(); return; }
            // Calls method to write registration info to file
            LoginController Logs = lazy.Value;

            Logs.Register(Name, LastName, Username, Email, Password, instance);
            LoginOpen();
        }

        /// <summary>
        /// Checks to make sure none of the fields are empty
        /// </summary>
        /// <returns></returns>
        bool FieldsEmpty()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(Email)) return false;
            instance.FillOutFields();
            return true;
        }

        

    }
}
