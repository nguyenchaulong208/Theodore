using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class CongTy
    {
        private string _ten;
        private LopNhanVien[] DSVanPhong;
        private LopNhanPhienPX[] DsPhanXuong;
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap ten cong ty: ");
            _ten = Console.ReadLine();
            Console.Write("Nhap tso luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            DSVanPhong = new LopNhanVien[n];
            for (int i = 0; i < DSVanPhong.Length; i++)
            {
                DSVanPhong[i] = new LopNhanVien(string.Empty);
                DSVanPhong[i].Nhap($"Nhap thong tin nhan vien thu {i}: ");
            }
            int c = int.Parse(Console.ReadLine());
            DsPhanXuong = new LopNhanPhienPX[c];
            for (int i = 0; i < DSVanPhong.Length; i++)
            {
                DsPhanXuong[i] = new LopNhanPhienPX(string.Empty);
                DsPhanXuong[i].Nhap($"Nhap thong tin nhan vien thu {i}: ");
            }
        }

        public double TinhTongLuong()
        {
            double s = 0;
            for (int i = 0;i < DsPhanXuong.Length;i++)
            {
                s = s + DsPhanXuong[i].TinhLuong();
            }
            for (int i = 0; i < DsPhanXuong.Length; i++)
            {
                s = s + DsPhanXuong[i].TinhLuong();
            }
            return s;
        }
    }
}
