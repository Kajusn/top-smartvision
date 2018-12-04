using LostAndFound.Models;
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
	public partial class FoundPage : ContentPage
	{
        public static FoundPage instance;

        public FoundPage ()
		{
			InitializeComponent ();
            instance = this;
            IFoundFormPresenter presenter = new FoundFormPresenter(new FoundModel());
            BindingContext = presenter;
        }
	}
}