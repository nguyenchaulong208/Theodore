using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class Diem
    {
        public int X;
        public int Y;

        public void Nhap(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.Write("Nhap X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y: ");
            Y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(Diem b)
        {
            // (X1 - x2)^2 +(Y1 - Y2)^2
            return Math.Sqrt((X-b.X)*(X-b.X)+(Y-b.Y)*(Y-b.Y));
        }
    }
}
