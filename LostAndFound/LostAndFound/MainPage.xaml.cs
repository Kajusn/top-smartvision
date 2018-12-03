using Xamarin.Forms;
using LostAndFound.Presenters;

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
            ILoginFormPresenter presenter = new LoginFormPresenter();
            BindingContext = presenter;
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
