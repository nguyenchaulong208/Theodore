using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130_Virtual_and_Override_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bee", 2);
            Console.WriteLine($"{dog.Name} is {dog.Age} year old");
            dog.MakeSound();
            dog.Eat();
            dog.Play();
        }
    }
}
