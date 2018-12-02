using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    public interface IRegisterFormPresenter
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        Command RegisterCommand { get; }
        Command CancelCommand { get; }
    }
}
