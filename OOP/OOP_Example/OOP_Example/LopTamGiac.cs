using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class LopTamGiac
    {
        //trong toa do khong gian thi dung diem de tinh dinh cua tam giac
        public Diem A;
        public Diem B;
        public Diem C;
        public void NhapTamGiac(string ghiChu)
        {
            Console.Write("Nhap tam giac: ");
            //Cap phat vung nho de luu tru diem
            A = new Diem();
            B = new Diem();
            C = new Diem();
            //Nhap cac dinh tam giac
            A.Nhap("Nhap dinh A: ");
            B.Nhap("Nhap dinh B: ");
            C.Nhap("Nhap dinh C: ");
        }
        public double TinhChuVi()
        {
            double a, b, c;
            a = B.TinhKhoangCach(C);
            b = A.TinhKhoangCach(C);
            c = A.TinhKhoangCach(B);
            return a + b + c;
        }
    }
}
