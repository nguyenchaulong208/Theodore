using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BT_0012_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n");
            int s = 0, i = 1, k = 1, n, x, d = 1;

            Console.Write("Nhap x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                d = d * x;
                s = s + d;
                Console.WriteLine($"{x} {s}");
                i++;

            }

            Console.WriteLine($"S(n) = {s}");

        }
    }
}

     
