using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class GuestRequest
    {
        public int GuestRequestKey { get;}
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Status { get; set; }
        public DateTime Registration { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Area { get; set; }
        public string SubArea { get; set; }
        public string TypeOfUnit { get; set; }
        public int NumAdult { get; set; }
        public int NumChildren { get; set; }
        public string Pool { get; set; }
        public string Jacuzzi { get; set; }
        public string Garden { get; set; }
        public string ChildrenAttractions { get; set; }
        //tostring
    }
}
