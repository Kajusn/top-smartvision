using LostAndFound.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            BindingContext = new RegisterFormPresenter();
        }
	}
}