using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_0020_NMLT_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n");

            int i = 1, s = 0, n, a ;

            
            Console.Write(" Nhap n: ");
            n = int.Parse(Console.ReadLine());

                while ( i < n)
                {
                    a = n % i; // sử dụng phép thử chia lấy phần dư


                        if (a == 0) // phần dư = 0 => n chia hết cho số i (với i chạy từ 1 đến n) => i là ước số của n

                        {
                        Console.WriteLine(i);
                
                
                        }
                        
                     i++;

                }
                

            

          

        }
    }
}
