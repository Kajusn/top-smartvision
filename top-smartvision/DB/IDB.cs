﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision.DB
{
    interface IDB
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
    }
}