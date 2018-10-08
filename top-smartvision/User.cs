using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision
{
    class User
    {
        private string name;
        private string lastName;
        private string username;
        private string email;
        private string password;

        public User(string user, string Pass, string Email, string Name, string LastName)
        {
            this.email = Email;
            this.username = user;
            this.password = Pass;
            this.name = Name;
            this.lastName = LastName;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail (string email)
        {
            this.email = email;
        }
        public string getUsername()
        {
            return username;
        }
        public void setUserName(string username)
        {
            this.username = username;
        }

        public string getName()
        {
            return name;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
