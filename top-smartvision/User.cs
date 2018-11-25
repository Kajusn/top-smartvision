using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using top_smartvision.Models;

namespace top_smartvision
{
    /// <summary>
    /// User information for future database
    /// </summary>
    public class User : IUserModel
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        // private string gender;

        public User(){}
        
        public User(string Name, string LastName, string Email, string User, string Pass/* string gender*/)
        {
            this.name = Name;
            this.lastName = LastName;
            this.email = Email;
            this.username = User;
            this.password = Pass;
           // this.gender = gender;
        }
    }
}
