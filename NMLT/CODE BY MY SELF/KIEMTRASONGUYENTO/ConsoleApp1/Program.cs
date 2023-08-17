using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_31_02
{
    internal class Program
    {
        public static bool KiemTraNguyenTo(int n)
        {

            if (n <= 1)
            {
                return false;
            }
        public static void Main(String[] agrs)
            {
                int i = 2;
                while (i <= n / 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                    i++;
                }
                return true;
            }
            
            

        }
    }
}
