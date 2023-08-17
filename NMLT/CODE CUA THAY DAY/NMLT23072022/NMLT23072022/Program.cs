using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT23072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Toan tu
            //int x = 10, y = 5;

            //Console.WriteLine("Nhap x");
            //x = int.Parse(Console.ReadLine());

            //Console.WriteLine("nhap y");
            //y = int.Parse(Console.ReadLine());

            //int z = x++;
            //int z = ++x;
            //int z = 7 % 2;
            //int z = 5;
            //Console.WriteLine($"x = {x} va z = {z}");

            //x += 3;
            //x -= 3;
            //x *= 3;
            //Console.WriteLine(x);

            //Console.WriteLine("x = 10 \n y = 5");
            //Console.WriteLine($"x = y là {x == y}");
            //Console.WriteLine($"x khác y là {x != y}");
            //Console.WriteLine($"x nhỏ y là {x < y}");
            //Console.WriteLine($"x lớn y là {x > y}");
            //Console.WriteLine($"x >= y là {x >= y}");
            //Console.WriteLine($"x <= y là {x <= y}");
            //Console.WriteLine($" x > và x < y là {x > y && x < y}");
            //Console.WriteLine(Math.Max(x, y));
            //Console.WriteLine(Math.Min(x, y));
            //Console.WriteLine(Math.Sqrt(x));
            //Console.WriteLine(Math.Sqrt(y));
            //Console.WriteLine(Math.Abs(x));
            //Console.WriteLine(Math.Abs(y));
            //Console.WriteLine(Math.Round(9.99));

            #endregion


            #region //Cau lenh if

            //int x = 10, y = 20;
            //if (x < y)
            //{
            //    Console.WriteLine(" x > y");

            //}
            //if (x > y)
            //{
            //    Console.WriteLine(" x > y ");
            //}
            //else
            //{
            //    Console.WriteLine("x < y");

            //}
            #endregion

            #region //Giai phuong trinh bac nhat
            //ax + b = 0

            int a, b;

            Console.WriteLine("Nhap a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b");
            b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                
            }
            else
            {
                double x = -1.0 * b / a;
                Console.WriteLine($"Nghiem la {x}");
            }



            #endregion
        }
    }
}
