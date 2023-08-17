using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0005_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
				
			
				Console.WriteLine("Bai 5: Tinh S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1)");
				
				double i = 1, s = 1, n;
				Console.Write(" Nhap n: ");
				n = double.Parse(Console.ReadLine());

				while (i <= n)
				{

					s = s + (1 / (2 * i + 1));
					i++;

				}

				Console.WriteLine($"Tong S({2 * n + 1}) = {s}");


				


			

		}
	}
    
}
