using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_MANG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            int[] a = NhapMang.NM();
            //int kq122 = Xulymang.bt122(a);
            int kq = Xulymang.bt141(a);
            //Console.WriteLine($"ket qua la: {kq122}");
            Console.WriteLine($"ket qua la: {kq}");
            //Xulymang.bt122(a);
            Xulymang.bt141(a);





            //}
            ////for (int i = 1; i < b.Length; i++)
            ////{
            ////Console.WriteLine(b[]);
            ////}    
            ////xuat mang
            //for(int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine($"So thu tu tang dan: {b[i]}");
            //}






        }



    }
}
