using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.
            int ii = int.Parse(Console.ReadLine());
            double dd = double.Parse(Console.ReadLine());
            string ss = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + ii);
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + dd).ToString("F1"));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + ss);
            // The 's' variable above should be printed first.
        }
    }
}
