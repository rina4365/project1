using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class GuestRequest
    {
        //static number
        public string name { get; set; }
        public string LastNmae { get; set; }
        public string mail { get; set; }
        public string status { get; set; }
        public DateTime Registration { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string area { get; set; }
        public string SubArea { get; set; }
        public string TypeOfUnit { get; set; }
        public int NumAdult { get; set; }
        public int NumChildren { get; set; }
        public string pool { get; set; }
        public string jacuzzi { get; set; }
        public string garden { get; set; }
        public string ChildrenAttractions { get; set; }
        //tostring
    }
}
