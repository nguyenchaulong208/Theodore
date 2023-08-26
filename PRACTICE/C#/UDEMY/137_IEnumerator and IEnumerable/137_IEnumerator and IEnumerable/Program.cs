using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _137_IEnumerator_and_IEnumerable
{
    internal class Program
    {
        /*Co 2 loai interface
         1. IEnumerable<T> la 1 tap hop chunng (generic collections)
         2. IEnumerable la tap hop khong chung (no generic collections)
         => non generic kem hieu qua hon
        ------
            IEnumerable<T> contains a single method that you must implement when implement this interface;
            GetEnumerable(), which return an IEnumerator<T> object
            The returned IEnumarator<T> provides the ability to iterate through the collection
            by exposing a Current proerty tha points at the object we are currently at the collection
        ---
        
        */
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach(Dog dog in shelter) //Neu duyet mang nhu binh thuong thi se bao loi khong co public instance hoac extension 'GetEnumerable'. => de duyet duoc mang ta can trien IEnumerable<T> or IEnumerable (1)
            {

            }
        }
    }
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }
        //Constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        //this method  will print how many treats the dog received
        public void GiveTreats(int numberOfTreats)
        {
            //print a message contain the number of treats and the name of the dog;
            Console.WriteLine($"Dog: {Name} said wuoff {numberOfTreats} times!.");
        }
    }
    class DogShelter: IEnumerable<Dog> //Trien khai IEnumerable<T> (2)
    {
        //List of type List<Dog>
        public List<Dog> dogs;
        //this constructor will initialize the dog list with some values
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog ("Casper", false),
                new Dog ("Sif",true),
                new Dog ("Oreo",false),
                new Dog ("Pixel",false),
            };

        }
        //(3)
        public IEnumerator<Dog> GetEnumerator() 
        {
            return dogs.GetEnumerator();
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
