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
	public partial class MenuPage : ContentPage
	{
        public static MenuPage instance;

        public MenuPage ()
		{
			InitializeComponent ();
            instance = this;
            IMenuViewModel _viewModel = new MenuViewModel();
            BindingContext = _viewModel;
        }
	}
}