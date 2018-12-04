using Xamarin.Forms;

namespace LostAndFound
{
    public static class FormController
    {

        public static void OpenRegister(ContentPage page)
        {
            page.Navigation.PushModalAsync(new RegisterPage(), true);
        }

        public static void OpenLogin(ContentPage page)
        {
            page.Navigation.PushModalAsync(new MainPage(), true);
        }

        public static void OpenFound(ContentPage page)
        {
            page.Navigation.PushModalAsync(new FoundPage(), true);
        }

        public static void OpenMenu(ContentPage page)
        {
            page.Navigation.PushModalAsync(new MenuPage(), true);
        }

        public static void OpenLostItems(ContentPage page)
        {
            page.Navigation.PushModalAsync(new LostItemsPage(), true);
        }

    }
}
