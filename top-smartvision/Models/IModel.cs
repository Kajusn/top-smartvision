using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision
{
    interface IModel
    {
        void Register(string name, string lastname, string username, string email, string password);
        bool Login(string uss, string pass);
        bool CheckUsernameEmail(string uss, string email);
        string Hashing(string pass);

        
    }
}
