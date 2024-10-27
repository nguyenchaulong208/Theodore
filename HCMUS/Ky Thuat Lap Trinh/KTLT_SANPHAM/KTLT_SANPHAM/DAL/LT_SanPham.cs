using  KTLT_SANPHAM.Entities;
namespace KTLT_SANPHAM.DAL
{
    public class LT_SanPham
    {
        public static SanPham[] DocSanPham ()
        {
            
            //Doc san pham va tach schuoi
            SanPham[] danhsach;
            StreamReader _file = new StreamReader("g:\\dataASP\\Newdssp1.txt");
            int n  = int.Parse(_file.ReadLine()); //Đọc dòng đầu tiên cho biết số lượng sản phẩm trong file.
            danhsach = new SanPham[n];
            for (int i = 0; i < danhsach.Length; i++)
            {
                string s = _file.ReadLine();
                SanPham SP;
                string[] chuoi = s.Split(","); // tách chuỗi tại ký tự ,
                SP.masp = chuoi[0]; // gán vị trí chuỗi
                SP.tensp = chuoi[1];// gán vị trí chuỗi
                SP.gia = int.Parse(chuoi[2]);// gán vị trí chuỗi
                danhsach[i] = SP;

            }
            _file.Close();
            return danhsach;



        }

        public static void LuuDanhSach(SanPham[] danhsach)
        {
            StreamWriter file = new StreamWriter("g:\\dataASP\\Newdssp1.txt");
            for (int i = 0; i < danhsach.Length; i++)
            {
                file.WriteLine($"{danhsach[i].masp}, {danhsach[i].tensp}, {danhsach[i].gia}");
            }
            file.Close();

        }

        public static void LuuSanPham (SanPham sanpham)
        {
            SanPham[] _sanpham = DocSanPham();
            //them san pham vao cuoi danh sach
            SanPham[] dsMoi = new SanPham[_sanpham.Length+1];
            for(int i = 0; i < _sanpham.Length; i++)
            {
                dsMoi[i] = _sanpham[i];
            }
            dsMoi[dsMoi.Length - 1] = sanpham;
            LuuDanhSach(dsMoi);
        }






    }
}
