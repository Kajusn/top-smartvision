using System;

namespace LostAndFound.Views
{
    public interface ILoginForm
    {
        Action OnLoginBtnClicked { get; set; }
        Action RegButtonClicked { get; set; }
        string username { get; set; }
        string password { get; set; }
    }
}
