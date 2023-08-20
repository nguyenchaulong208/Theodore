using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_Nested_For_Loops_And_2D_Arrays__Two_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                {1, 2, 3},
                {4, 5, 6},
                {6, 7, 8},
                {10, 11, 12},

            };
            Console.WriteLine($"Day la ma tran gom [{array.GetLength(0)}] dong va [{array.GetLength(1)}] cot:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //if(i==j)
                    
                    Console.WriteLine($"Gia tri tai i[{i}] va j[{j}] la: {array[i, j]}");
                }

            }
        }
    }
}
