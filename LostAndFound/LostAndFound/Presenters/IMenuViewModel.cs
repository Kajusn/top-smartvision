using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    public interface IMenuViewModel
    {
        Command openFoundCommand { get; }
        Command openLostCommand { get; }
        string Username { get; set; }
        string Name { get; set; }
        Command userProfileCommand { get; }
    }
}