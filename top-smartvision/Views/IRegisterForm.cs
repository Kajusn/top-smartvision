using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision.Views
{
    interface IRegisterForm
    {
        User newUser { get; set; }
        Action OnRegFormClosed { get; set; }
    }
}
