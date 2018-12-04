using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFound.Models
{
    class FoundModel : IFoundModel
    {
        public string TypeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersCode { get; set; }

        public FoundModel() { }

        public FoundModel(string TypeID, string FirstName, string LastName, string PersCode)
        {
            this.TypeID = TypeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PersCode = PersCode;

        }
    }
}
