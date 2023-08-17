using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0017_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!");

            int x, n, s = 1, k = 1, l = 1, i = 1;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap x: ");
            s = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                k = (k * i);
                l *= k; // l = l * k;
                s = s + (l / k);
                i++;
            }

            Console.WriteLine($"S(n) = {s}");
        }

    }
}
