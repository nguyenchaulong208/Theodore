using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0015_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 15: Tính S(n) = 1 + 1/1 + 2 + 1/ 1 + 2 + 3 + ….. + 1/ 1 + 2 + 3 + …. + N");

            double n, k = 0, s = 0, i = 1;

            Console.Write("Nhap n: ");
            n = double.Parse(Console.ReadLine());

            while (i <= n)
            {
                k = k + i;
                s = s + (1/k);
                i++;

            }
            Console.WriteLine($"S = {s}");
        }
    }
}
