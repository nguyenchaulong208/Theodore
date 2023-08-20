using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102._Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Jagged Array
            //mang 1
            //Khoi tao so luong mang con
            int[][] array = new int[3][]; //so luong mang con la 3
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            //Khoi tao gia tri cua mang con
            array[0] = new int[] { 4, 5, 6, 7 };
            array[1] = new int[] { 8, 9, 10, 11, 12 };
            array[2] = new int[] { 13, 14, 15 }; 
            //xuat mang con
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                Console.WriteLine($" {array[i].Length} - i[{i}] va [{j}] la {array[i][j]}");
            }
        }
        
    }
}
