using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0009_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Bai 9: Tinh T(n) = 1 x 2 x 3…x N");
			int i = 1, s = 1, n; //s = 0;
			Console.WriteLine(" Nhap n");
			n = int.Parse(Console.ReadLine());

			while (i <= n)
			{

				s = s * i; //s = s + 1 *i;
				i++;

			}

			Console.WriteLine($"T({n}) = {s}");
		}
    }
}
