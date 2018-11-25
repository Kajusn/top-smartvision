using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using top_smartvision.DB;
using top_smartvision.Models;
using top_smartvision.Views;

namespace top_smartvision.Presenters
{
    class RegisterFormPresenter
    {
        Thread th;
        public IRegisterForm _view;
        private IUserModel _model;
        private LoginForm login;

        public RegisterFormPresenter(object obj)
        {
            _model = new User();
            RegisterForm form = new RegisterForm();
            form.Show();
            _view = form;
            login = (LoginForm)obj;
            _view.OnRegFormClosed += LoginOpen;
            _view.OnRegisterClicked += Register;
        }

        public void LoginOpen()
        {
            login.Show();
        }

        public void Register()
        {
            _model = _view.newUser;

            FileIO file = new FileIO();

            // Calls method to write registration info to file
            file.Register(_model.name, _model.lastName, _model.username, _model.email, _model.password);
            LoginOpen();
        }

    }
}
