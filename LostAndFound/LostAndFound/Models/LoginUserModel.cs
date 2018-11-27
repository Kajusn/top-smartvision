using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace LostAndFound
{
   public  class LoginUserModel : IModel
    {

        //private string appPath = @"C:\Users\Dovydas\Documents\GitHub\top-smartvision\top-smartvision\bin\Debug\Users\users.txt";

        public string username { get; set; }

        public string password { get; set; }

    

    }
}


    

