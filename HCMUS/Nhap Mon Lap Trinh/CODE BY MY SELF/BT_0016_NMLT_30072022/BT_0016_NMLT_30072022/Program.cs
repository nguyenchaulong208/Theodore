using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0016_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N");

            double n, x, k = 0, i = 1, s = 0, f = 1, m = 1,j = 1;
                

            Console.Write("Nhap n: ");
            n = double.Parse(Console.ReadLine());

            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());

            while (i <= n)
            {
                k = k + i;
                m = m * x;
                
                
               
                
                
                
                s = s +  (m / k);

                i++;


            }

            Console.WriteLine($"S = {s}");

        }
    }
}
