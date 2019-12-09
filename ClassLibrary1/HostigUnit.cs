using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class HostigUnit
    {
        public int HostingUnitKey { get; }
        public Host Owner { get; set; }
        public string HostingUnitName { get; set; }
        public bool[,] diary { get; set; }//diary from question 2
        //tostring
        HostigUnit(string name, Host h1)
        {
            HostingUnitKey = Configuration.HostingKey++;
            HostingUnitName = name;
            Owner = h1;//operator =
            diary = new bool[12, 31];
        }
    }
}
