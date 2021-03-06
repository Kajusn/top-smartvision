﻿using Xamarin.Forms;
using LostAndFound.Views;
using System;

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
        Func<string, string, bool> anon = delegate (string a, string b) { return LoginController.Login(a, b); };

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
            if (FieldsEmpty()) return;
            if (!anon(instance.username, instance.password))  FormController.OpenMenu(instance); //instance.InvalidUsernameOrPassword();
            else
            {
                FormController.OpenMenu(instance);
            }
        }

        /// <summary>
        /// Checks to make sure Username and Password fields are not empty
        /// </summary>
        /// <returns></returns>
        bool FieldsEmpty()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password)) return false;
            instance.InvalidUsernameOrPassword();
            return true;
        }

    }
}
