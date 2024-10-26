using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_006_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 7: Tinh S(n) = ½ + 2/3 + ¾ + …. + n / n + 1");

            double i = 0, s = 0, n;
            
            Console.Write("Nhap n: ");
            n = double.Parse(Console.ReadLine());

            while (i <= n)
            {
                s = s + (1 / 2) + (i / (i + 1));
                i++;
            }

            Console.WriteLine($"Tong S({(n / (n + 1))}) = {s}");
        }
    }
}
