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
        
        public static QL_CuaHang[] Danhsach()
        {
            QL_CuaHang[] newDanhsach;
            newDanhsach = LuuTru.DocDuLieu();
            return newDanhsach;
        }
        public static QL_CuaHang? DocDulieu(string maHang)
        {
            QL_CuaHang[] newDocdulieu = LuuTru.DocDuLieu();
            //Dem so phan tu thoa dieu kien
            foreach(QL_CuaHang newDoc in newDocdulieu)
            {
                if(newDoc.mahang == maHang)
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
            if (DL.sohoadon <= 0 || string.IsNullOrEmpty(DL.ngayhoadon) || string.IsNullOrEmpty(DL.ngaysanxuat) || string.IsNullOrEmpty(DL.mahang) || string.IsNullOrEmpty(DL.tenhang) || DL.soluong < 0 || DL.dongia < 0 || DL.thanhtien < 0 || string.IsNullOrEmpty(DL.loaihang) || string.IsNullOrEmpty(DL.nhasanxuat) || string.IsNullOrEmpty(DL.hansudung))
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
        public static string CheckDL(string MaHang)
        {
            string thongbao = string.Empty;
            
            
            

            return thongbao;


        }
        public static string XuatHangHoa(int XLsohoadon, string XLngayhoadon, string XLmahang, string XLtenhang, int XLsoluong, int XLdongia, int XLthanhtien)
        {

            string thongbao = string.Empty;
            if (XLsohoadon < 0 || string.IsNullOrEmpty(XLngayhoadon) || string.IsNullOrEmpty(XLmahang) || string.IsNullOrEmpty(XLtenhang) || XLsoluong < 0 || XLdongia < 0 || XLthanhtien < 0)
            {
                thongbao = "Dữ liệu khong hợp lệ, vui lòng thử lại";

            }
            
                else
                {
                    QL_CuaHang DulieuCuaHang = new QL_CuaHang();
                    DulieuCuaHang.sohoadon = XLsohoadon;
                    DulieuCuaHang.ngayhoadon = XLngayhoadon;

                    DulieuCuaHang.mahang = XLmahang;
                    DulieuCuaHang.tenhang = XLtenhang;
                    DulieuCuaHang.soluong = XLsoluong;
                    DulieuCuaHang.dongia = XLdongia;
                    DulieuCuaHang.thanhtien = XLthanhtien;
                    LuuTru.LuuDuLieuBR(DulieuCuaHang);
                    thongbao = "Tạo hóa đơn thành công";
                }
            

            return thongbao;

        }


        //Xuat hang
        public static QL_CuaHang[] DanhsachBanra()
        {
            QL_CuaHang[] newDanhsach;
            newDanhsach = LuuTru.DocDuLieuBR();
            return newDanhsach;
        }


    }
}
