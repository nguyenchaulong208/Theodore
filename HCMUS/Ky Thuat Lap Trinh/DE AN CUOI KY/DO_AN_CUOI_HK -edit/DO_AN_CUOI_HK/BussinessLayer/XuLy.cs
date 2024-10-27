using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.IO;
using DO_AN_CUOI_HK.DAL;
using DO_AN_CUOI_HK.Entities;

namespace DO_AN_CUOI_HK.BussinessLayer
{
    public class XuLy
    {
        #region //Nhap hang       
        //Them san pham
        public static string ThemHangHoa(int XLsohoadon, string XLngayhoadon, string XLngaysanxuat, string XLmahang, string XLtenhang, int XLsoluong, int XLdongia, int XLthanhtien, string XLloaihang, string XLnhasanxuat, string XLhansudung)
        {

            string thongbao = string.Empty;
            if (XLsohoadon < 0 || string.IsNullOrEmpty(XLngayhoadon) || string.IsNullOrEmpty(XLngaysanxuat) || string.IsNullOrEmpty(XLmahang) || string.IsNullOrEmpty(XLtenhang) || XLsoluong < 0 || XLdongia < 0 || XLthanhtien < 0 || string.IsNullOrEmpty(XLloaihang) || string.IsNullOrEmpty(XLnhasanxuat) || string.IsNullOrEmpty(XLhansudung))
            {
                thongbao = "Dữ liệu khong hợp lệ, vui lòng thử lại";

            }
            else
            {
                QL_CuaHang DulieuCuaHang = new QL_CuaHang();

                DulieuCuaHang.sohoadon = XLsohoadon;
                DulieuCuaHang.ngayhoadon = XLngayhoadon;
                DulieuCuaHang.ngaysanxuat = XLngaysanxuat;
                DulieuCuaHang.mahang = XLmahang;
                DulieuCuaHang.tenhang = XLtenhang;
                DulieuCuaHang.soluong = XLsoluong;
                DulieuCuaHang.dongia = XLdongia;
                DulieuCuaHang.thanhtien = XLthanhtien;
                DulieuCuaHang.loaihang = XLloaihang;
                DulieuCuaHang.nhasanxuat = XLnhasanxuat;
                DulieuCuaHang.hansudung = XLhansudung;
                LuuTru.LuuDuLieu(DulieuCuaHang);
                thongbao = "Lưu thành công";

            }

            return thongbao;

        }
        #endregion
        //Hien thi du lieu nhap hang len bang ke

        public static QL_CuaHang[] Danhsach()
        {
            QL_CuaHang[] newDanhsach;
            newDanhsach = LuuTru.DocDuLieu();
            return newDanhsach;
        }

        //Tim ma hang trong du lieu nhap hang da luu
        public static QL_CuaHang? DocDulieu(string maHang)
        {
            QL_CuaHang[] newDocdulieu = LuuTru.DocDuLieu();
            //Dem so phan tu thoa dieu kien
            foreach (QL_CuaHang newDoc in newDocdulieu)
            {
                if (newDoc.mahang == maHang)
                {
                    return newDoc;
                }
            }
            return null;

        }
        public static void XoaDulieu(string maHang)
        {
            LuuTru.XoaDuLieu(maHang);
        }
        public static string SuaDulieu(QL_CuaHang DL)
        {
            string thongbao = string.Empty;
            if (DL.sohoadon <= 0 || string.IsNullOrEmpty(DL.ngayhoadon) || string.IsNullOrEmpty(DL.mahang))
            {
                thongbao = "Dữ liệu khong hợp lệ, vui lòng thử lại";

            }
            else
            {
                LuuTru.SuaDuLieu(DL);
                thongbao = "Lưu thành công";

            }
            return thongbao;
        }
        //-------------------------------------

        //Xuat hang
        #region//Xuat hang
        public static string XuatHanghoa(int XLsohoadon, string XLngayhoadon, string XLngaysanxuat, string XLmahang, string XLtenhang, int XLsoluongXuat, int XLdongia, int XLthanhtien, string XLloaihang, string XLnhasanxuat, string XLhansudung)
        {

            string thongbao = string.Empty;
            if (XLsohoadon < 0 || string.IsNullOrEmpty(XLngayhoadon) || string.IsNullOrEmpty(XLngaysanxuat) || string.IsNullOrEmpty(XLmahang) || string.IsNullOrEmpty(XLtenhang) || XLsoluongXuat < 0 || XLdongia < 0 || XLthanhtien < 0 || string.IsNullOrEmpty(XLloaihang) || string.IsNullOrEmpty(XLnhasanxuat) || string.IsNullOrEmpty(XLhansudung))
            {
                thongbao = "Dữ liệu khong hợp lệ, vui lòng thử lại";

            }
            else
            {
                QL_CuaHang DulieuCuaHang = new QL_CuaHang();

                DulieuCuaHang.sohoadon = XLsohoadon;
                DulieuCuaHang.ngayhoadon = XLngayhoadon;
                DulieuCuaHang.ngaysanxuat = XLngaysanxuat;
                DulieuCuaHang.mahang = XLmahang;
                DulieuCuaHang.tenhang = XLtenhang;
                DulieuCuaHang.soluongXuat = XLsoluongXuat;
                DulieuCuaHang.dongia = XLdongia;
                DulieuCuaHang.thanhtien = XLthanhtien;
                DulieuCuaHang.loaihang = XLloaihang;
                DulieuCuaHang.nhasanxuat = XLnhasanxuat;
                DulieuCuaHang.hansudung = XLhansudung;

                LuuTru.LuuDuLieuXuathang(DulieuCuaHang);
                thongbao = "Lưu thành công";

            }

            return thongbao;


        }

        //Hien thi du lieu len bang ke xuat hang
        public static QL_CuaHang[] DanhsachXuathang()
        {
            QL_CuaHang[] newDanhsach;
            newDanhsach = LuuTru.DocDuLieuXuathang();
            return newDanhsach;
        }

        public static QL_CuaHang? DocDulieuXH(string _maHang)
        {
            QL_CuaHang[] _newDocdulieu = LuuTru.DocDuLieuXuathang();
            //Dem so phan tu thoa dieu kien
            foreach (QL_CuaHang newDoc in _newDocdulieu)
            {
                if (newDoc.mahang == _maHang)
                {
                    return newDoc;

                }
            }
            return null;

        }

        public static void XoaDulieuXH(string maHang)
        {
            LuuTru.XoaDuLieuXuathang(maHang);
        }
        public static string SuaDulieuXH(QL_CuaHang DL)
        {
            string thongbao = string.Empty;
            if (DL.sohoadon <= 0 || string.IsNullOrEmpty(DL.ngayhoadon) || string.IsNullOrEmpty(DL.mahang))
            {
                thongbao = "Dữ liệu khong hợp lệ, vui lòng thử lại";

            }
            else
            {
                LuuTru.SuaHangxuat(DL);
                thongbao = "Lưu thành công";

            }
            return thongbao;
            #endregion
            //--------------
            //Hang ton kho



        }
        public static void LuuDuLieuHTK(QL_CuaHang DuLieu)
        {
            LuuTru.LuuDuLieuHTK(DuLieu);
        }

        //Tim Kiem
        public static QL_CuaHang[] TimKiem(string keyword)
        {
            QL_CuaHang[] ds;
           

            ds = LuuTru.DocDuLieuHTK();


            int soLuong = 0;

            //dem so phan tu thoa dieu kien
            foreach (QL_CuaHang sp in ds)
            {
                if (sp.mahang.Contains(keyword))
                {
                    soLuong++;
                }
            }
            QL_CuaHang[] kq = null;
            if (soLuong > 0)
            {
                kq = new QL_CuaHang[soLuong];
                int n = 0;
                foreach (QL_CuaHang sp in ds)
                {
                    if (sp.mahang.Contains(keyword))
                    {
                        n++;
                        kq[n - 1] = sp;
                    }
                }
            }
            return kq;


        }
        public static string Dangnhap(string user, string password)
        {
            string a = string.Empty;
             
            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                a = "Dữ liệu không hợp lệ. Vui lòng thử lại";
            }
            else
            {
                if(user == "admin" & password == "22880089")
                {
                    a = "True";
                }
                else
                {
                    a = "Sai tài khoản hoặc mật khẩu";
                }
            }
            return a;
        }


        
    }
}
