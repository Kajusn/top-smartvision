using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LostAndFound.Views;
using LostAndFound.Presenters;

//using top_smartvision;

namespace LostAndFound
{
    public partial class MainPage : ContentPage , ILoginForm
    {
        public static MainPage instance;
        public MainPage()
        {
            InitializeComponent();
            //LoginUserModel model = new LoginUserModel();
            instance = this;
            BindingContext = new LoginFormPresenter(); // CIA GERIAU PER INTERFACE O NE PER PATI PRESENTERI
        }

        private Action _onLoginBtnClicked;
        private Action _RegButtonClicked;
        #region setters getters

        public Action OnLoginBtnClicked
        {
            get
            {
                return _onLoginBtnClicked;
            }
            set
            {
                _onLoginBtnClicked = value;
            }
        }

        public Action RegButtonClicked
        {
            get
            {
                return _RegButtonClicked;
            }
            set
            {
                _RegButtonClicked = value;
            }
        }

        public string username
        {
            get
            {
                return Username.Text;
            }
            set
            {
                Username.Text = value;
            }
        }

        public string password
        {
            get
            {
                return Password.Text;
            }
            set
            {
                Password.Text = value;
            }
        }
        #endregion

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;


            //_onLoginBtnClicked();


            await DisplayAlert("clicke", "" + Username.Text, "ok");
        }

       public async void displayblet()
        {
            await DisplayAlert("Alert" ,"The Username or Password is incorrect","okayblet");
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            // this.Hide();
            _RegButtonClicked();
        }
    }
}
