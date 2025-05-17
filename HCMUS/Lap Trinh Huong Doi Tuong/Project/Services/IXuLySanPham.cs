using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IXuLySanPham
    {
        //Hàm trả về danh sách sản phẩm
        List<SanPham> DocDanhSachSanPham(string tuKhoa = "");
        List<SanPham> TimKiemTongHop(string tuKhoa = "");
        List<SanPham> HanSuDung(DateOnly date);
        //Ham them san pham
        void ThemSanPham(SanPham sanPham, int MaSP);
        void SuaSanPham(SanPham SanPham);
        void loadFile();
        void loadFileOut();
        List<SanPham>TongHopSanPham();
        void XoaSanPham(int MaSP);


    }
    
}
