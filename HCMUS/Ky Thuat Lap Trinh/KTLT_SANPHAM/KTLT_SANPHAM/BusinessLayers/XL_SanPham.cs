using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using KTLT_SANPHAM.DAL;
using KTLT_SANPHAM.Entities;




namespace KTLT_SANPHAM.BusinessLayers
{
    public class XL_SanPham
    {
        public static  SanPham[] TimKiem(string Keyword)
        {
            SanPham[] danhsachSP = LT_SanPham.DocSanPham();
            int soluong = 0;
            //Dem so luong san pham
            foreach (SanPham SP in danhsachSP)
            {
                if (SP.tensp.Contains(Keyword))
                {
                    soluong++;
                }

            }
            SanPham[] KetquaSP = null;
            if (soluong > 0)
            {
                KetquaSP = new SanPham[soluong];
                int n = 0;
                foreach(SanPham SP in danhsachSP)
                {
                    if (SP.tensp.Contains(Keyword))
                    {
                        n++;
                        KetquaSP[n - 1] = SP;
                    }
                }
                
            }
            return KetquaSP;
        }



       public static string ThemSanPham(string ma, string ten, int gia)
        {
            string kq = string.Empty;
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten)|| gia < 0)
            {
                kq = "Dữ liệu khong hợp lệ, vui lòng thử lại";
            }
            else
            {
                SanPham sp;
                sp.masp = ma;
                sp.tensp = ten;
                sp.gia = gia;
                LT_SanPham.LuuSanPham(sp);
                kq = "Lưu thành công";
            }
            return kq;

        }
    }
}
