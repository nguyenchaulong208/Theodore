using System;

namespace BT_02_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Bai 2: Tinh S(n) = 1^2 + 2^2 + … + n^2");

            int i = 0, n, s = 0;
            Console.Write("Nhap n: ");

            n = int.Parse(Console.ReadLine());


            while (i <= n)
            {
                s = s + i * i;
                i++;
            }


            Console.WriteLine($"Tong S({n}) = {s}");




        }
    }
}