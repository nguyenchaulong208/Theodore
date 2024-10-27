using System;

namespace example_OOP
{
    public class TamGiac
    {
        //Thành phần dữ liệu
        public Diem A;
        public Diem B;
        public Diem C;

        //Thành phần xử lý
        public void Nhap(string ghiChu)
        {
            Console.Write(ghiChu);
            A = new Diem();
            A.Nhap("Nhap diem A:");
            B = new Diem();
            B.Nhap("Nhap diem B:");
            C = new Diem();
            C.Nhap("Nhap diem C:");
        }
        public double TinhChuVi()
        {
            double a, b, c;
            a = A.TinhKhoangCach(C);
            b = A.TinhKhoangCach(B);
            c = B.TinhKhoangCach(C);
            return a + b + c;

        }
    }
}