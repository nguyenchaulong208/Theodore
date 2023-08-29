using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1: Calculate S(n) = 1 + 2 + 3 + … + n
            Console.WriteLine("1: Calculate S(n) = 1 + 2 + 3 + … + n");
            Console.WriteLine("-----");
            int n = 0, result = 0;
            Console.Write("Please input n: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                result = result + i;
            }  
            Console.WriteLine($"S = {result}");
        }
    }
}
