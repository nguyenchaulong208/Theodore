using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable named 'inputString' to hold our input.
            string note = "Hello, World.";
            string inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine(note);
            Console.WriteLine(inputString);

        }
    }
}
