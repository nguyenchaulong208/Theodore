using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _130_Virtual_and_Override_Keywords
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }
        //Contructor
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            //in our case all our animal are hungry by defaut
            IsHungry = true;
        }
        //Tao 1 phuong thuc ao rong voi tu khoa virtual de cac lop khac ghi de boi cac class ke thua lop animal
        public virtual void MakeSound()
        {

        }
        //Tao 1 phuong thuc ao co ten la Eat de cac lop khac ghi de boi cac class ke thua lop animal
        public virtual void Eat()
        {
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }
        //Tao them 1 phuong thuc ao
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
