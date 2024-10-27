using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0003_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 3: Tinh S(n) = 1 + 1/2 + 1/3 + … + 1/n");
            double i = 1, s = 1, n;
            Console.Write("Nhap n: ");

            n = double.Parse(Console.ReadLine());

            while (i <= n)
            {

                s = s + 1 /i;

                i++;
            }

            Console.WriteLine($"Tong S({n}) = {s}");
        }
    }
}
