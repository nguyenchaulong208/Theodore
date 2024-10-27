using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0014_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 14: Tính S(n) = x + x^3 + x^5 + … + x^2n + 1");

            int x, n, m = 1, i = 1, s = 1, k = 1, f = 1;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());

            while (i <= n)
            {

                k = 2 * i + 1;

                //while (f <= k)
                //{
                //    m = m * x;
                //    f++;
                //}

                //s = s + m;
                i++;
            }

            Console.WriteLine($"S(n) = {k}");

        }
    }
}
