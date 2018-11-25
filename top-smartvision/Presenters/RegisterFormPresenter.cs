using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        public void LoginOpen()
        {
            login.Show();
        }

    }
}
