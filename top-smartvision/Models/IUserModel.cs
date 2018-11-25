using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision.Models
{
    interface IUserModel
    {
        string name { get; set; }
        string lastName { get; set; }
        string username { get; set; }
        string email { get; set; }
        string password { get; set; }
    }
}
