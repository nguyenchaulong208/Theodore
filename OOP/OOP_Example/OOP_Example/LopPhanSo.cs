using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class LopPhanSo
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
        public LopPhanSo CongPhanSo( LopPhanSo p2)
        {
            LopPhanSo kq = new LopPhanSo();
            kq.TuSo = TuSo * p2.MauSo + MauSo * p2.TuSo;
            kq.MauSo =MauSo* p2.MauSo;
            return kq;
        }

        public LopPhanSo CongPS(LopPhanSo p1, LopPhanSo p2)
        {
            LopPhanSo kq = new LopPhanSo();
            kq.TuSo = p1.TuSo * p2.MauSo + p2.TuSo * p1.MauSo;
            kq.MauSo = p1.MauSo* p2.MauSo;
            return kq ;
        }
        public string XuatKetQua()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}
