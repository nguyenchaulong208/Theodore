using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_Simple_Inheritance_Example
{ //Tao class ke thua, class nay se thua huong cac thuoc tinh cua lop ElectricalDevices.
    public class Radio: ElectricalDevices
    {
        //Constructor ke thua tu lop co so ElectricalDevices
        public Radio(bool isOn, string brand) :base(isOn, brand)
        {

        }
        public void ListenRadio()
        {
            //Kiem tra radio co dang mo khong
            if(IsOn)
            {
                //Nghe radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {// bao loi
                Console.WriteLine("Radio switched off, switch it on first!");
            }
        }
    }
}
