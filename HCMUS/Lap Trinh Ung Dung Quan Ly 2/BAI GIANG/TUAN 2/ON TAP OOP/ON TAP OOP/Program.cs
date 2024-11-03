using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ON_TAP_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee alice; // Declare a variable of type Employee
            alice = new Employee(); // Create an object of type Employee
            // Assign values to the object's fields
            alice.FirstName = "Alice";
            alice.LastName = "Maive";
            alice.Tel = "0909111245";
            // Display the object's fields
            Console.WriteLine("First Name: " + alice.FirstName);
            Console.WriteLine("Last Name: " + alice.LastName);
            Console.WriteLine("Tel: " + alice.Tel);
            Console.WriteLine();
            //Rut gon code
            Employee bob = new Employee()
            {
                FirstName = "Bob",
                LastName = "Baker",
                Tel = "0909111245"
            };
            Console.WriteLine("First Name: " + bob.FirstName);
            Console.ReadKey();
        }
    }
}
