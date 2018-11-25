using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision
{
    public interface ILoginForm
    {
        //LoginUserModel user { get; set; }
        Action OnPropertyChanged { get; set; }
        Action RegButtonClicked { get; set; }
        string username { get; set; }
        string password { get; set; }
    }
}
