using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    public interface ILoginFormPresenter
    {
        string Username { get; set; }
        string Password { get; set; }
        Command LoginCommand { get; }
        Command RegOpenCommand { get; }
    }
}
