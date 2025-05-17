using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface ILuuTruSanPham
    {
        List<SanPham> DocDanhSachSanPham();
        string FilePath(string filePath);

        List<SanPham> LuuDanhSachSanPham(List<SanPham> SanPham);
        void ThemSanPham(SanPham sanPham);
    }
}
