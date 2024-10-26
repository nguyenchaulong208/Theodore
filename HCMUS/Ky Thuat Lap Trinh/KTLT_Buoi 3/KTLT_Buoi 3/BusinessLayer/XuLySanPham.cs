using KTLT_Buoi_3.DAL;
using KTLT_Buoi_3.Entities;

namespace KTLT_Buoi_3.BusinessLayer
{
   
    public class XuLySanPham
    {
        public static SanPham[] TimKiem (string keyword)
        {
            SanPham[] ds = LuuTruSanPham.DocDanhSach();
            int soLuong = 0;
            
            //dem so phan tu thoa dieu kien
            foreach ( SanPham sp in ds )
            {
                if (sp.TenSp.Contains(keyword))
                {
                    soLuong++;
                }
            }
            SanPham[] kq = null;
            if (soLuong > 0)
            {
                kq = new SanPham [soLuong];
                int n = 0;
                foreach (SanPham sp in ds )
                {
                    if (sp.TenSp.Contains(keyword))
                    {
                        n++;
                        kq[ n - 1 ] = sp;   
                    }
                }
            }
            return kq;

        }
        public static string ThemSanPham (string ma, string ten, int gia)
        {
            string kq = string.Empty;
            //kiem tra tinh hop le cua du lieu va luu tru
            if (string.IsNullOrEmpty(ma)
                || string.IsNullOrEmpty(ten)
                || gia <= 0)
            {
                kq = "Du lieu khong hop le";
            }
            else
            {
                //tien hanh luu tru 1 san pham
                //LuuTruSanPham.Luu1SanPham(ma, ten, gia);
                //kq = "Da luu thanh cong";

                //tien hanh luu tru danh sach san pham
                SanPham sp;
                sp.MaSp = ma;
                sp.TenSp = ten;
                sp.Gia = gia;
                
                LuuTruSanPham.LuuSanPham(sp);
                kq = "Da luu thanh cong";

            }
            return kq;

        }
    }
}
