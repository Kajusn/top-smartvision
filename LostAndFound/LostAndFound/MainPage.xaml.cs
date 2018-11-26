using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using top_smartvision;

namespace LostAndFound
{
    public partial class MainPage : ContentPage //, ILoginForm
    {

        public MainPage()
        {
            InitializeComponent();
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


        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            // this.Hide();
            _RegButtonClicked();
        }
    }
}
