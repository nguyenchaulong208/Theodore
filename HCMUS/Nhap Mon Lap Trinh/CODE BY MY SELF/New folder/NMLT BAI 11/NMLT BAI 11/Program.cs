using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_BAI_11
{
    /*Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N
     * ---
     * S(1) = 1
     * S(2) = 1 + 1 x 2
     * S(3) = 1 + 1 x 2 + 1 x 2 x 3
     *      <=> S(2) + 1 x 2 x 3
     *      <=> S(2) + 3!
     *  => S(n) = S(n-1) + n!
     *  => mượn biến phụ đê tính n!
     */
    internal class Program
    {
        public static int S(int a)
        {
            int kq = 0, k = 1;
            for (int i = 1; i <= a;i ++)
            {
                k = k * i; //tính n!
                kq = kq + k; //S(n) = S(n-1) + n!
            }

            return kq;
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Nhap x");
            x =int.Parse(Console.ReadLine());

            int kq = S(x);
            Console.WriteLine($"S({x}) = {kq}");
        }
    }
}
