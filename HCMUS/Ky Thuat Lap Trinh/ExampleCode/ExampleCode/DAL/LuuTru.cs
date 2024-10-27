using DO_AN_CUOI_HK.Entities;
using System;

namespace DO_AN_CUOI_HK.DAL
{
    public class LuuTru
    {
       
        #region //Nhap hang
        //khởi tạo 1 file với mảng rỗng
        //Đọc file
        public static QL_CuaHang[] DocDuLieu()
        {
            var path1 = "DuLieu/default.txt";
            var path = Path.GetFullPath(path1);
            QL_CuaHang[] Dulieu;
            StreamReader readFile = new StreamReader(path);
            int n = int.Parse(readFile.ReadLine());
            Dulieu = new QL_CuaHang[n];

            for (int i = 0; i < Dulieu.Length; i++)
            {

                string s = readFile.ReadLine();
                QL_CuaHang DL = new QL_CuaHang();
                string[] chuoi = s.Split(","); // tách chuỗi tại ký tự ,
                DL.sohoadon = int.Parse(chuoi[0]); // gán vị trí chuỗi
                DL.ngayhoadon = chuoi[1];// gán vị trí chuỗi
                DL.ngaysanxuat = chuoi[2];// gán vị trí chuỗi
                DL.mahang = chuoi[3];
                DL.tenhang = chuoi[4];
                DL.soluong = int.Parse(chuoi[5]);
                DL.dongia = int.Parse(chuoi[6]);
                DL.thanhtien = int.Parse(chuoi[7]);
                DL.loaihang = chuoi[8];
                DL.nhasanxuat = chuoi[9];
                DL.hansudung =chuoi[10];
                Dulieu[i] = DL;



            }
            readFile.Close();


            return Dulieu;
        }
        //luu danh sach hang hoa
        public static void LuuTruDanhSach(QL_CuaHang[] DanhSach)
        {
            var path1 = "DuLieu/default.txt";
            var path = Path.GetFullPath(path1);
            StreamWriter writeFile = new StreamWriter(path);
            writeFile.WriteLine(DanhSach.Length);
            for (int i = 0; i < DanhSach.Length; i++)
            {
                writeFile.WriteLine($"{DanhSach[i].sohoadon},{DanhSach[i].ngayhoadon},{DanhSach[i].ngaysanxuat},{DanhSach[i].mahang},{DanhSach[i].tenhang},{DanhSach[i].soluong},{DanhSach[i].dongia},{DanhSach[i].thanhtien},{DanhSach[i].loaihang},{DanhSach[i].nhasanxuat},{DanhSach[i].hansudung}");
            }
            writeFile.Close();
        }
        //luu san pham
        public static void LuuDuLieu(QL_CuaHang DuLieu)
        {
            QL_CuaHang[] _dulieu = DocDuLieu();
            QL_CuaHang[] newDulieu = new QL_CuaHang[_dulieu.Length + 1]; //khoi tao mang voi kich thuoc lon hon 1 don vi so voi mang ban dau
            for (int i = 0; i < _dulieu.Length; i++)
            {
                newDulieu[i] = _dulieu[i];
            }
            newDulieu[newDulieu.Length - 1] = DuLieu;
            LuuTruDanhSach(newDulieu);
        }
        

        #region//Chuc nang: Xoa, Sua cua phan Nhap hang
        public static void XoaDuLieu(string maHang)
        {

            {
                QL_CuaHang[] XoaDL = DocDuLieu();
                int count = 0;

                // Đếm số lượng mã hàng khác maHang. Mục đích đếm: khi xóa mã trùng sẽ sinh ra chuỗi rỗng lưu cùng với chuỗii đã gán vào file
                for (int i = 0; i < XoaDL.Length; i++)
                {
                    if (XoaDL[i].mahang != maHang)
                    {
                        count++;
                    }
                }
            // Tạo mảng mới có kích thước count và sao chép dữ liệu không trùng mã hàng
                QL_CuaHang[] newXoaDL = new QL_CuaHang[count];
                int n = 0;
                for (int i = 0; i < XoaDL.Length; i++)
                {
                    if (XoaDL[i].mahang != maHang)
                    {
                        n++;
                        newXoaDL[n-1] = XoaDL[i];
                        
                    }
                }

                // Ghi mảng mới vào file
                LuuTruDanhSach(newXoaDL);
            }
        }
        public static void SuaDuLieu(QL_CuaHang suaDL)
        {
            QL_CuaHang[] newSuaDL = DocDuLieu();

            for (int j = 0; j < newSuaDL.Length; j++)
            {
                if (newSuaDL[j].mahang == suaDL.mahang)
                {
                    newSuaDL[j] = suaDL;

                }
                LuuDuLieu(suaDL);
            }

        }
        #endregion
        #endregion
        /*--------------------------------------------------------*/
        #region //Xuat hang
        public static QL_CuaHang[] DocDuLieuXuathang()
        {
            var path1 = "DuLieu/Xuathang.txt";
            var path = Path.GetFullPath(path1);
            QL_CuaHang[] Dulieu;
            StreamReader readFile = new StreamReader(path);
            int n = int.Parse(readFile.ReadLine());
            Dulieu = new QL_CuaHang[n];

            for (int i = 0; i < Dulieu.Length; i++)
            {

                string s = readFile.ReadLine();
                QL_CuaHang DL = new QL_CuaHang();
                string[] chuoi = s.Split(","); // tách chuỗi tại ký tự ,
                DL.sohoadon = int.Parse(chuoi[0]); // gán vị trí chuỗi
                DL.ngayhoadon = chuoi[1];// gán vị trí chuỗi
                DL.ngaysanxuat = chuoi[2];// gán vị trí chuỗi
                DL.mahang = chuoi[3];
                DL.tenhang = chuoi[4];
                DL.soluongXuat = int.Parse(chuoi[5]);
                DL.dongia = int.Parse(chuoi[6]);
                DL.thanhtien = int.Parse(chuoi[7]);
                DL.loaihang = chuoi[8];
                DL.nhasanxuat = chuoi[9];
                DL.hansudung = chuoi[10];
                Dulieu[i] = DL;



            }
            readFile.Close();


            return Dulieu;

        }
        //ghi du lieu vao file
        public static void GhiDulieuXuathang(QL_CuaHang[] DanhSach)
        {   var path1 = "DuLieu/Xuathang.txt";
            var path = Path.GetFullPath(path1);
            StreamWriter writeFile = new StreamWriter(path);
            writeFile.WriteLine(DanhSach.Length);
            for (int i = 0; i < DanhSach.Length; i++)
            {
                writeFile.WriteLine($"{DanhSach[i].sohoadon},{DanhSach[i].ngayhoadon},{DanhSach[i].ngaysanxuat},{DanhSach[i].mahang},{DanhSach[i].tenhang},{DanhSach[i].soluongXuat},{DanhSach[i].dongia},{DanhSach[i].thanhtien},{DanhSach[i].loaihang},{DanhSach[i].nhasanxuat},{DanhSach[i].hansudung}");
            }
            writeFile.Close();
        }

        //Luu du lieu moi
        public static void LuuDuLieuXuathang(QL_CuaHang DuLieuXH)
        {
            QL_CuaHang[] _dulieu = DocDuLieuXuathang();
            QL_CuaHang[] newDulieu = new QL_CuaHang[_dulieu.Length + 1]; //khoi tao mang voi kich thuoc lon hon 1 don vi so voi mang ban dau
            for (int i = 0; i < _dulieu.Length; i++)
            {
                newDulieu[i] = _dulieu[i];
            }
            newDulieu[newDulieu.Length - 1] = DuLieuXH;
            GhiDulieuXuathang(newDulieu);

        }
        #endregion

        #region //Chuc nang: Xoa, Sua cua phan xuat hang
        //Xoa du lieu hang xuat
        public static void XoaDuLieuXuathang(string maHang)
        {
            QL_CuaHang[] XoaDL = DocDuLieuXuathang();
            int count = 0;

            // Đếm số lượng mã hàng khác maHang. Mục đích đếm: khi xóa mã trùng sẽ sinh ra chuỗi rỗng lưu cùng với chuỗii đã gán vào file
            for (int i = 0; i < XoaDL.Length; i++)
            {
                if (XoaDL[i].mahang != maHang)
                {
                    count++;
                }
            }
            // Tạo mảng mới có kích thước count và sao chép dữ liệu không trùng mã hàng
            QL_CuaHang[] newXoaDL = new QL_CuaHang[count];
            int n = 0;
            for (int i = 0; i < XoaDL.Length; i++)
            {
                if (XoaDL[i].mahang != maHang)
                {
                    n++;
                    newXoaDL[n - 1] = XoaDL[i];

                }
                GhiDulieuXuathang(newXoaDL);
            }

        }
        
        //Sua du lieu hang xuat
        public static void SuaHangxuat(QL_CuaHang suaDL)
        {
            QL_CuaHang[] newSuaDL = DocDuLieuXuathang();

            for (int j = 0; j < newSuaDL.Length; j++)
            {
                if (newSuaDL[j].mahang == suaDL.mahang)
                {
                    newSuaDL[j] = suaDL;

                }
                LuuDuLieuXuathang(suaDL);
            }

        }
        #endregion
        //---------


        #region //Tong hop du lieu hang ton kho
        //LUU TRU HANG TON KHO VA HIEN THI DU LIEU LEN BANG TÔNG HOP
        public static QL_CuaHang[] DocDuLieuHTK()
        {
            var path1 = "DuLieu/HTK.txt";
            var path = Path.GetFullPath(path1);
            QL_CuaHang[] DulieuHTK;
            StreamReader readFile = new StreamReader(path);
            int n = int.Parse(readFile.ReadLine());
            DulieuHTK = new QL_CuaHang[n];

            for (int i = 0; i < DulieuHTK.Length; i++)
            {

                string s = readFile.ReadLine();
                QL_CuaHang DL = new QL_CuaHang();
                string[] chuoi = s.Split(","); // tách chuỗi tại ký tự ,
                DL.sohoadon = int.Parse(chuoi[0]); // gán vị trí chuỗi
                 // gán vị trí chuỗi
                DL.ngayhoadon = chuoi[1];// gán vị trí chuỗi
                DL.ngaysanxuat = chuoi[2];// gán vị trí chuỗi
                DL.mahang = chuoi[3];
                DL.tenhang = chuoi[4];
                DL.soluong = int.Parse(chuoi[5]);
                DL.soluongXuat = int.Parse(chuoi[6]);
                DL.dongia = int.Parse(chuoi[7]);
                DL.thanhtien = int.Parse(chuoi[8]);
                DL.loaihang = chuoi[9];
                DL.nhasanxuat = chuoi[10];
                DL.hansudung = chuoi[11];
                DL.soluongTon = int.Parse(chuoi[12]);
                DulieuHTK[i] = DL;
            }
            readFile.Close();
            return DulieuHTK;

        }
        //ghi du lieu vao file
        public static void GhiDulieuHTK(QL_CuaHang[] DanhSach)
        {
            var path1 = "DuLieu/HTK.txt";
            var path = Path.GetFullPath(path1);
            StreamWriter writeFile = new StreamWriter(path);
            writeFile.WriteLine(DanhSach.Length);
            for (int i = 0; i < DanhSach.Length; i++)
            {
                writeFile.WriteLine($"{DanhSach[i].sohoadon},{DanhSach[i].ngayhoadon},{DanhSach[i].ngaysanxuat},{DanhSach[i].mahang},{DanhSach[i].tenhang},{DanhSach[i].soluong},{DanhSach[i].soluongXuat},{DanhSach[i].dongia},{DanhSach[i].thanhtien},{DanhSach[i].loaihang},{DanhSach[i].nhasanxuat},{DanhSach[i].hansudung},{DanhSach[i].soluongTon}");
            }
            writeFile.Close();
        }

        //Luu du lieu moi
        public static void LuuDuLieuHTK(QL_CuaHang DuLieu)
        {
            int tongsoluong = 0;
            QL_CuaHang[] _dulieu = DocDuLieu();

            QL_CuaHang[] newDulieu = new QL_CuaHang[_dulieu.Length + 1]; //khoi tao mang voi kich thuoc lon hon 1 don vi so voi mang ban dau
            // Tinh toan gop ma
          

            QL_CuaHang[] newDL = DocDuLieuXuathang();
            QL_CuaHang[] newArr = _dulieu.Concat(newDL).ToArray();
            QL_CuaHang[] TH = newArr;
            //Gộp mã hàng
           var result = newArr.GroupBy(d => d.mahang).Select(g => new
            {
                mahang = g.Key,
                thanhtien = g.Sum(s => s.thanhtien),
                tenHH = g.Select(s => s.tenhang).Distinct(),
                soluongM = g.Sum(s => s.soluong),
                soluongB = g.Sum(s => s.soluongXuat),
               


                loaiHang = g.Select(s => s.loaihang).Distinct(),
                nXS = g.Select(s => s.nhasanxuat).Distinct()
            }).ToArray();
            var newArray = result.Select(r => new QL_CuaHang
            {
                mahang = r.mahang,
                thanhtien = r.thanhtien,
                tenhang = r.tenHH.FirstOrDefault(),
                soluong = r.soluongM,
                soluongXuat = r.soluongB,
                soluongTon =r.soluongM-r.soluongB,
                loaihang = r.loaiHang.FirstOrDefault(),
                nhasanxuat = r.nXS.FirstOrDefault()
            }).ToArray();


            GhiDulieuHTK(newArray);
        }
        #endregion
        
    }
}

