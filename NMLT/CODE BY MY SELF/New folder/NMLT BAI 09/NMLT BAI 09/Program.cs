using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_BAI_09
{
    internal class Program
    {
        public static int TinhGiaiThua (int a)
        {
            int  kq = 1 ;
            for (int i = 1; i <= a; i++)
            {
               kq = kq * i;
            }
               
            return kq;

        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Nhap x ");
             x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập y ");
            //y = int.Parse(Console.ReadLine());

            int kq = TinhGiaiThua(x);
            Console.WriteLine(kq);
        }
    }
}
