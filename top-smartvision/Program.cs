using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top_smartvision
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginUserModel model = new LoginUserModel();
            LoginForm view = new LoginForm(model);
            Application.Run(view);
            //Application.Run(LoginForm.GetInstance);
        }
    }
}
