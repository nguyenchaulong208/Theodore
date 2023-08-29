using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhap mang");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("KQ");
            for(int i = 0; i < n; i++)
            { 
                int check = a[i];
                int kq = 0;
                for (int j = 0; j < n; j++)
                {
                    
                    kq = check + a[j];
                    if(kq == 17)
                    {
                        
                        Console.WriteLine($"A[i = {i}] = {a[i]} va A[j = {i}] = {a[j]} ");
                        Console.WriteLine(kq);
                    }
                    
                }
               
                
            }
        }
    }
}
    
