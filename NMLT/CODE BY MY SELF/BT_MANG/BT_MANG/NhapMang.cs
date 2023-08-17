using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_MANG
{
    class NhapMang
    {
        public static int[] NM ()
        {
            int[] a;

            Console.WriteLine("Nhap so luong phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            Console.WriteLine($"So luong phan tu mang la: {n}");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap a[{i}] ");
                a[i] = int.Parse(Console.ReadLine());

            }
            return a;
        }
    }
}
