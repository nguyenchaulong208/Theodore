using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0013_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n");

            int x, n, s = 0, k = 1, m = 1, i = 1, f = 1;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                k = 2*i; // k là lũy thừa của x
                
                while (f <= k)
                {
                    m = m * x;
                    f++;
                                       
                }
                s = s + m;
                i++;
                       

            }
            Console.Write($"S(n) = {s}");
        }
    }
}
