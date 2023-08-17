using System;


namespace NMLT_09072022_CODE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  //Code 1
            //int x;
            //double y;
            //x = 100;
            //y = 19.9;
            //double z
            //z = x + y;
            //double z = x + y;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            #endregion

            #region  //Code 2
            //char ch = 'A';
            //string s = "Toi di hoc";
            //Console.WriteLine(ch);
            //Console.WriteLine(s);
            #endregion

            #region  //Code 3
            //int x, y;
            //x = 10;
            //y = 5;

            //int z = x + y;

            //Console.WriteLine("Tong cua" + x + " va " + y + " la " + z);
            //Console.WriteLine("Tong cua {0} va {1} la {2}", x, y, z);
            //Console.WriteLine($"Tong cuar {x} va {y} la {z}");
            #endregion

            #region  //Code 4
            //int x, y;
            //Console.WriteLine("Nhap x:");

            //string s = Console.ReadLine(); // = 
            //x = int.Parse(s); //  "câu lệnh x = int.Parse(s);" tương đương với câu lệnh "x = Convert.ToInt32(s);"
            //y = 5;

            //int z = x + y;

            //Console.WriteLine("Tong cua" + x + " va " + y + " la " + z);
            //Console.WriteLine("Tong cua {0} va {1} la {2}", x, y, z);
            //Console.WriteLine($"Tong cuar {x} va {y} la {z}");
            #endregion

            #region  //Code 5
            int x, y;
            Console.WriteLine("Nhap a:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap a:");
            y = int.Parse(Console.ReadLine());

            int z = x + y;

            Console.WriteLine("Tong cua" + x + " va " + y + " la " + z);
            Console.WriteLine("Tong cua {0} va {1} la {2}", x, y, z);
            Console.WriteLine($"Tong cuar {x} va {y} la {z}");




            #endregion

        }
    }
}
