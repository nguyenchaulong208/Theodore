using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_008_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Bai 8: Tinh S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");
			double i = 1, s = 0, n;
			Console.Write(" Nhap n: ");
			n = double.Parse(Console.ReadLine());

			while (i <= n)
			{

				s = s + (1 / (1 * 2)) + ((2 * i + 1) / (i * (i + 1)));
				i++;

			}

			Console.WriteLine($"Tong S ({n}) = {s}");
		}
    }
}
