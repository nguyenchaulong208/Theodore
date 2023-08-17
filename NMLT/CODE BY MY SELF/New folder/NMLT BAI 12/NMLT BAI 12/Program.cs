using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_BAI_12
{
    internal class Program
    {
        /* Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n
         * S(1) = x
         * S(2) = x + x . x
         * S(3) = x + x . x . x
         *      = S(2) + x . x . x
         *      = S(2) + x . x . x
         *  => S(n) = S(n-1) + x . x . x
         *  => dùng biến phụ đê tính lũy thừa
         * 
        */


        public static int S(int n, int m)
        {
            int kq = 0;
            int Luythua = 1;
            for (int i = 1; i <= m; i++)
            {
                Luythua = Luythua * n;
                //kq = kq + Luythua;
            }

            return Luythua;
        }

        static void Main(string[] args)

        {
            int x, y;
            Console.WriteLine("Nhap x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y");
            y = int.Parse(Console.ReadLine());

            int kq = S(x, y);
            Console.WriteLine($"S({x}) = {kq}");
        }
    }
}
