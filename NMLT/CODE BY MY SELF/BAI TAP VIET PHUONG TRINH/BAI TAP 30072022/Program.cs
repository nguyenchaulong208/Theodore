using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_30072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Bai 1: Tinh S(n) = 1 + 2 + 3 + … +n

            int n;
            
            n = int.Parse(Console.ReadLine());
            
            while (n < 20)
            {
               Console.WriteLine($"Tong S(n) = {n++}");

            }    
            #endregion
        }
    }
}
