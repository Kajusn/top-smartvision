using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace top_smartvision
{
   public  class LoginUserModel : IModel
    {

        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\References\Images\";

        public string username { get; set; }

        public string password { get; set; }

    

    }
}


    

