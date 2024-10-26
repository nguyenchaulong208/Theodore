using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContainer
{
    public class Student: INotifyPropertyChanged
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public int Credits { get; set; }
        public string Avatar { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
