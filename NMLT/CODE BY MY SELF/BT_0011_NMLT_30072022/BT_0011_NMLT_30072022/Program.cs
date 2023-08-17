using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0011_NMLT_30072022
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 11: Tinh S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N");

            int s = 0, i = 1, k = 1, n;

          Console.Write("Nhap n: ");
          n = int.Parse(Console.ReadLine());

            while (i <= n)
           {
               k = k * i;
               s = s + k;
               i++;

            }
         Console.WriteLine($"S(n) = {s}");
        }
    }
}
