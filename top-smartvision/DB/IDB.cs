using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision.DB
{
    public interface IDB
    {
        /// <summary>
        /// Takes image from local storage
        /// </summary>
        /// <returns>image string</returns>
        string PullImage();

        /// <summary>
        /// Saves image from local storage to default directory
        /// </summary>
        void PushImage();

        /// <summary>
        /// Save displayed image to default directory
        /// </summary>
        /// <param name="image"></param>
        void PushImage(string image);

        /// <summary>
        /// Writes registering information to file
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="pass"></param>
       void Register(string name, string lastname, string username, string email, string pass/*, string gender*/);

        /// <summary>
        /// Checks if username or email is already taken
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
       bool CheckUsernameEmail(string username, string email);

        /// <summary>
        /// Checks Username and password and logs in user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string username, string password);

        /// <summary>
        /// Hashes the password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        String Hashing(string password);
    }
}
