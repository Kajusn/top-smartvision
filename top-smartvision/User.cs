﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using top_smartvision.Models;

namespace top_smartvision
{
    /// <summary>
    /// User information for future database
    /// </summary>
    public class User : IUserModel
    {
        /*public string name;
        public string lastName;
        public string username;
        public string email;
        public string password;*/

        public string name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string lastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public string username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        public string email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        // private string gender;

        public User()
        {
            /*name = null;
            lastName = null;
            username = null;
            email = null;
            password = null;*/
        }

        
        public User(string Name, string LastName, string Email, string User, string Pass/* string gender*/)
        {
            this.name = Name;
            this.lastName = LastName;
            this.email = Email;
            this.username = User;
            this.password = Pass;
           // this.gender = gender;
        }
        /// <summary>
        /// User setters and getters
        /// </summary>
        /// <returns></returns>
        #region get/set

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
      /*  public string getGender()
        {
            return gender;
        }
        public void setGender (string gender)
        {
            this.gender = gender;
        }*/
        #endregion
        
    }
}
