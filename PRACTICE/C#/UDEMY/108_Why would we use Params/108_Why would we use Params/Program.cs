using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_Why_would_we_use_Params
{
    
    public class Program
    {
        public static double Sum(params int[] numbers)
        {
            int count = 0;
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
                count++;
            }
            return (double) total/count;
        }
    
        static void Main(string[] args)
        {
            //khoi tao cac bien va goi ham Sum voi cac parameter khong xac dinh duoc so luong cu the.
            double sum1 = Sum(1,2,3);
            double sum2 = Sum(2,3,4,5);
            double sum3 = Sum();
            Console.WriteLine($"Ket qua cua sum1: {sum1}");
            Console.WriteLine($"Ket qua cua sum1: {sum2}");
            Console.WriteLine($"Ket qua cua sum1: {sum3}");
            
            
        }
    }
}
