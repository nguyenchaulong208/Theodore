using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0018_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!");

            int x, n, s = 0, k = 1, j = 1, i = 1;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                k = 2 * k * i;
                j = 2 * j * i;
                s = s  + (k / j);
                i++;
            
            }
            
            Console.WriteLine($"S(n) = {s}");



        }
    }
}
