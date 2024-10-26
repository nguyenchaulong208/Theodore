using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {//Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực
        static void Main(string[] args)
        {
            ////khai bao mang
            //int[] a;
            ////nhap phan tu mang
            //Console.WriteLine("Nhap phan tu mang: ");
            //int n = int.Parse(Console.ReadLine());
            //a = new int[n];

            ////nhap mang
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"nhap mang A[{i}]:");
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            ////xu ly mang
            //int maxNumber;
            //maxNumber = a[0];
            //    for(int i = 0; i < a.Length; i++)
            //{
            //    if(a[i] > maxNumber)
            //    {
            //        maxNumber = a[i];
            //    }    
            //}
            //Console.WriteLine($"So thuc luong nhat trong mang la {maxNumber}");
            //int j = 0;
            //int[] a; int[] b;
            //Console.WriteLine("Nhap phan tu mang");
            //int n = int.Parse(Console.ReadLine());
            //a = new int [n];

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Nhap mang A[{i}]");
            //    a[i] = int.Parse (Console.ReadLine());
            //}
            ////Bài 307: Tạo mảng b chỉ chứa giá trị lẻ từ mảng a


            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] % 2 > 0)                   
            //    { 
            //        b[j] = a[i];
            //        j++;
            //    }
            //}
            //Console.WriteLine(b[j]);

            //int n, m;
            //int[,] a;

            //Console.WriteLine("Nhap so dong");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap so cot");
            //m = int.Parse(Console.ReadLine());
            //a = new int[n, m];
            ////nhap mang

            //for(int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.WriteLine($"Nhap so dong A[{i}, A[{j}]");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////xuat a tran
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{a[i,j]}");

            //    }
            //    Console.WriteLine();
            //}


            int[,] a;
            Console.WriteLine("Nhap dong");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cot");
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Nhap mang A[{i},{j}");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
                //xu ly
                int max =a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if(a[i,j] > max)
                        {
                            max = a[i,j];
                        }    
                    }
                    
                }
                Console.WriteLine(max);
            



        }

        


    }
}
