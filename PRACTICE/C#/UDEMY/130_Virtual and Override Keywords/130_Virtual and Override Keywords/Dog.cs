using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130_Virtual_and_Override_Keywords
{
    public class Dog: Animal
    {
        //bool property to check if the dog is happy
        public bool IsHappy { get; set; }
        //Contructor
        public Dog(string name, int age): base(name, age)
        {
            //all dog are happy
            IsHappy = true;
        }
        //ghi de phuong thuc MakeSound
        public override void MakeSound()
        {
            //since every animal will make a totally different sound
            //ech animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!.");
        }
        //simple override of the virtual method Eat
        public override void Eat()
        {
            //To call the eat method from out base class we use the keyword "base"
            base.Eat();
        }
        //override of virtual method Play
        //Check if dog is happy if yes call the play method from base class
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
