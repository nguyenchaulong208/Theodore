using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0004_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 4: Tinh S(n) = ½ + ¼ + … + 1/2n");

            double i = 1, s = 0, n;
            Console.Write("Nhap n: ");

            n = double.Parse(Console.ReadLine());

            while (i <= n)
            {

                s = s + (1 / 2) + (1 / (2 * i));

                i++;
            }

            Console.WriteLine($"Tong S({n * 2}) = {s}");







            
        }
    }
}
