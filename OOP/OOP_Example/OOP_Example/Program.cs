// See https://aka.ms/new-console-template for more information

using OOP_Example;

////PHAN SO
//LopPhanSo p1 = new LopPhanSo();
//LopPhanSo p2 = new LopPhanSo();
//p1.NhapPhanSo("Nhap phan so 1: ");
//p2.NhapPhanSo("Nhap phan so p2");
//LopPhanSo kqPS;
//kqPS = p1.CongPhanSo(p2);
//string chuoiPS = $"Ket qua la {kqPS.XuatKetQua()}";
//Console.WriteLine(chuoiPS);
//Console.WriteLine("Cach 2: ");
//kqPS.CongPS(p1, p2);
//Console.WriteLine(chuoiPS);



////Da Giac
//DaGiac dg = new DaGiac();
//dg.Nhap("Nhập đa giác: ");
//double kq = dg.TinhChuVi();
//string chuoi = $"ket qua la: {kq}";
//Console.WriteLine(chuoi);

////Tam Giac

//LopTamGiac TamGiac = new LopTamGiac();
//TamGiac.NhapTamGiac("Nhap dinh Tam giac: ");
//double KQ = TamGiac.TinhChuVi();
//string kqTG = $"Ket qua la: {KQ}";
//Console.WriteLine(kqTG);

//NHAN VIEN

//LopNhanVien lopNhanVien = new LopNhanVien();
//lopNhanVien.Nhap("Nhap thong tin nhan vien");
//double kq = lopNhanVien.TinhLuong();
//Console.WriteLine($"tien luong la: {kq}");

CongTy congTy = new CongTy();
congTy.Nhap("nhap thong tin");
Console.WriteLine(congTy.TinhTongLuong());

