using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_Simple_Inheritance_Example
{
    public class ElectricalDevices
    {
        //boolean to determin the state of the Electrical Devices
        public bool IsOn { get; set; }
        //string for the branch name of the Electrical Device
        public string Brand { get; set; }
        //Contructor
        public ElectricalDevices(bool power, string brandName)
        {
            this.IsOn = power;
            this.Brand = brandName;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
