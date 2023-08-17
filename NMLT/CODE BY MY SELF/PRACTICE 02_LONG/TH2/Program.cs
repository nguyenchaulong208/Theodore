using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuc_hanh_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Code  
            int a, b;
            Console.WriteLine("Cho a va b la cac so nguyen");
            Console.Write("trong do: \na = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

                    int c = a + b;
                Console.WriteLine("Tong cua a va b = " + c);

                    int d = a * b;
                Console.WriteLine("Tich cua a va b = " + d);

                    int e = a / b, f = a % b;
                Console.WriteLine("Thuong cua a va b= " + e + "  \n phan du cua phep chia a va b = " + f);

            #endregion

            #region //Note
            /*
             * Câu lệnh "Console.Readline();" mặc định nhập vào bất kỳ số gì cũng sẽ cho ra kết quả là dạng chuỗi
             *     => Để thực hiện một phép tính ta cần chuyển từ dạng chuỗi sang dạng số
             *     => để chuyển từ chuỗi sang số ta cần dùng câu lệnh:
             *        string s = Console.ReadLine(); trong đó "s" là 1 biến bất kỳ không trùng với các biens trước đó đã khai báo
             *                                                  vd: string x = Console.ReadLine();
             *                                                      string y = Console.ReadLine();
             *                                                      string z = Console.ReadLine();
             *                                                      ......
             * ==>    <tên biến> = int.Parse(s);
             *  câu lệnh "<tên biến> = int.Parse(s);" tương đương với câu lệnh "<tên biến> = Convert.ToInt32(s);"
             */
            //     Ví dụ:
            //int g;
            //Console.WriteLine("Nhap gia tri g: ");
            //string s = Console.ReadLine();
            //g = int.Parse(s);

            /* 
             
             * Tuy nhiên câu lệnh: "string s = Console.ReadLine();" tương đương "Console.Readline();"
             *     => có thể thay thế: <tên biến>  = int.Parse(Console.ReadLine());
             */
            #endregion


        }
    }
}
