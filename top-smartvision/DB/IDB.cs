﻿using System;
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
       void WriteToFile(string name, string lastname, string username, string email, string pass/*, string gender*/);
       bool ReadFromFile(string username, string email);
    }
}
