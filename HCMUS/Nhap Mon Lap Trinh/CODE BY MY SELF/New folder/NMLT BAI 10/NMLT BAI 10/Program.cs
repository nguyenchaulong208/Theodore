using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_BAI_10
{
    internal class Program
    {
        /* vd 2^n
         * S(1) = 2
         * S(2) = 2 x 2
         * S(3) = 2 x 2 x 2
         *      = S(2) x 2
         *   => với A^n
         *   <=> S(n) = S(n-1) x A
         */
        public static int Luythua(int a, int b)
        { int kq = 1;
            for (int i = 1; i <= b; i++)
            {
                kq *= a;
               
            }    
            return kq;
        }
        public static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Nhap x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y");
            y = int.Parse(Console.ReadLine());

            int kq = Luythua(x, y);
            Console.WriteLine(kq);
        }
    }
}
