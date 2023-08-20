using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _109_MinValueUsingParams
{
   
    public class Program
    {
        public static int MinValue(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            double sum1 = MinValue(0,-11,1, 2754, 3);
            Console.WriteLine($"Ket qua cua sum1: {sum1}");

        }
    }
}
