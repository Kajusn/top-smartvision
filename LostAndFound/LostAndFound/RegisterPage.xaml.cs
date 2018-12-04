using LostAndFound.Presenters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LostAndFound
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
        public static RegisterPage instance;
		public RegisterPage ()
		{
			InitializeComponent ();
            instance = this;
            IRegisterFormPresenter presenter = new RegisterFormPresenter();
            BindingContext = presenter;
        }

        /// <summary>
        /// Prompts the user to fill out all fields
        /// </summary>
        public void FillOutFields()
        {
            DisplayAlert("", "Please fill out all fields", "OK");
        }

        public void InvalidEmail()
        {
            DisplayAlert("", "Invalid email address", "OK");
        }
    }
}