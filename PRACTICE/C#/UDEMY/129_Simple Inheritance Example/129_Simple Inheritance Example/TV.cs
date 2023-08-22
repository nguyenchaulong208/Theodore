using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_Simple_Inheritance_Example
{
    //Tao class ke thua, class nay se thua huong cac thuoc tinh cua lop ElectricalDevices.
    public class TV: ElectricalDevices
    {
        //Constructor ke thua tu lop co so ElectricalDevices
        public TV(bool IsOn, string Brand): base(IsOn, Brand)
        {

        }
        public void WatchTV()
        {
            //Kiem tra radio co dang mo khong
            if (IsOn)
            {
                //Nghe radio
                Console.WriteLine("Watching  the TV!");
            }
            else
            {// bao loi
                Console.WriteLine("TV switched off, switch it on first!");
            }
        }
    }
}
