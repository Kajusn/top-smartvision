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
    public partial class MainPage : ContentPage
    {
        public static MainPage instance;
        public MainPage()
        {
            InitializeComponent();
            //LoginUserModel model = new LoginUserModel();
            instance = this;
            BindingContext = new LoginFormPresenter(); // CIA GERIAU PER INTERFACE O NE PER PATI PRESENTERI
        }

        #region Setters; Getters

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
    }
}
