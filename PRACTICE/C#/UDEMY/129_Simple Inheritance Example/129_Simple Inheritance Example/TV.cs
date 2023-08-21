using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_Simple_Inheritance_Example
{
    //Tao class ke thua
    public class TV: ElectricalDevices
    {
        //Ham tao ke thua tu lop co so ElectricalDevices
        public TV(bool IsOn, string Brand): base(IsOn, Brand)
        {

        }
    }
}
