using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class PhanSo
    {
        public int TuSo;
        public int MauSo;
        public void NhapPhanSo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());

            Console.Write("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
    }
    
}
