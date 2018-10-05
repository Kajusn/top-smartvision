using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_smartvision.DB
{
    interface IDB
    {
        string PullImage();
        void PushImage();
    }
}
