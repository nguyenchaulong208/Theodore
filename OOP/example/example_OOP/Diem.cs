using System;

namespace example_OOP
{
    public class Diem
    {

            public int X;
            public int Y;
            public void Nhap(string ghiChu)
            {
                Console.WriteLine(ghiChu);
                Console.Write("Nhap x: ");
                X = int.Parse(Console.ReadLine());
                Console.Write("Nhap y: ");
                Y = int.Parse(Console.ReadLine());
            }
            public double TinhKhoangCach(Diem b){
                return Math.Sqrt((X-b.X)*(X-b.X)+(Y-b.Y)*(Y-b.Y));
            }
        

        
    }
}