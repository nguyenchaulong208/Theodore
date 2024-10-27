using System;


namespace example_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           //Tạo lập đôi tượng tam giác:
        //    TamGiac tg;
        //    tg = new TamGiac();
        //    //Yêu cầu nhập tam giác
        //    tg.Nhap("Nhap tam giac:");
        //    //Tính chu vi tam giác
        //    double kq = tg.TinhChuVi();
        //    string chuoi = "ket qua la: " + kq;
        //    Console.WriteLine(chuoi);
           //Tạo lập đôi tượng đa giác
              DaGiac dg;
            dg = new DaGiac();
            //Yêu cầu nhập đa giác
            dg.Nhap("Nhap da giac:");
            //Tính chu vi đa giác
           double kqDg = dg.TinhChuVi();
           string chuoiDg = "ket qua la: " + kqDg;
            Console.WriteLine(chuoiDg);
        }
    }
}