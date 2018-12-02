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
	}
}