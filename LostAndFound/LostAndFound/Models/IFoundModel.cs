using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFound.Models
{
    interface IFoundModel
    {
        string TypeID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PersCode { get; set; }
    }
}
