using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0010_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Bài 10: Tinh T(x, n) = x^n");
			int i = 1,x ,n ,s = 1;
			Console.Write(" Nhap x: ");
			x = int.Parse(Console.ReadLine());

			Console.Write(" Nhap n: ");
			n = int.Parse(Console.ReadLine());

			while (i <= n)
            {
				s = s * x;
				i++;
				

            }			
			Console.WriteLine($"S(n) = {s}");
			
		}
	}
    }

