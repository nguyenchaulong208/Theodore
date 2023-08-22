using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_Simple_Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phuong thuc SwitchOn/SwitchOff khong co trong 2 class Radio va TV, tuy nhien do 2 class nay duoc ke thua tu class ElectricalDevices
            //nen su dung duoc 2 phuong thuc nay tu class ElectricalDevices
            Radio myRadio = new Radio(true, "LG");
            //myRadio.SwitchOff();
            myRadio.ListenRadio();
            TV myTV = new TV(false, "Samsung");
           //myTV.SwitchOn();
            myTV.WatchTV();
            
        }
    }
}
