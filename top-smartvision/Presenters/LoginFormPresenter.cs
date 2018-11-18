using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top_smartvision
{
    class LoginFormPresenter
    {
        public ILoginForm _view;
        private IModel _model;

        public LoginFormPresenter(IModel model)
        {
            this._model = model;
            _view = new LoginForm();
            _view.OnPropertyChanged += log;
        }

        public void Start()
        {
            Application.Run((Form)_view);
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

        public void log()
        {
            string username = _view.user.username;
            string pass = _view.user.password;
            if (!_model.Login(username,pass)) MessageBox.Show("The Username or Password is incorrect");
            else
            {
                LostOrFound fm = new LostOrFound();
                fm.Show();
                fm.WelcomeMessage(username);
            }

            

           // _model.Login(username, pass);
        }
    }
}
