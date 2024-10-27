using KTLT_Buoi_3.Entities;

namespace KTLT_Buoi_3.DAL
{
    public class LuuTruSanPham
    {
        
        
        public static SanPham [] DocDanhSach ()
        {
            SanPham[] ds;
            StreamReader file = new StreamReader("C:\\Users\\lephu\\source\\repos\\KTLT_Buoi 3\\dssp.txt");
            int n = int.Parse(file.ReadLine());
            ds = new SanPham[n];
            for (int i=0; i<ds.Length; i++)
            {
                string s = file.ReadLine();//"S01,ABC,102" 
                SanPham sp;
                string[] m = s.Split(",");
                sp.MaSp = m[0];
                sp.TenSp = m[1];
                sp.Gia= int.Parse(m[2]);
                ds[i] = sp;
            }
            file.Close();
            return ds;

        }
        
        

        public static void LuuDanhSach(SanPham[] ds)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\lephu\\source\\repos\\KTLT_Buoi 3\\dssp.txt");
            file.WriteLine(ds.Length);
            for (int i = 0; i < ds.Length; i++)
            {
                file.WriteLine($"{ds[i].MaSp},{ds[i].TenSp},{ds[i].Gia}");
            }
            file.Close();

        }
        //luu danh sach san pham
        
        
        public static void LuuSanPham (SanPham sp)
        {
            SanPham[] ds = DocDanhSach();
            //them sp vao cuoi danh sach
            SanPham[] dsMoi = new SanPham[ds.Length + 1];
            for (int i = 0; i < ds.Length; i++)
            {
                dsMoi[i] = ds[i];
            }
            dsMoi[dsMoi.Length-1] = sp;

            //Luu danh sach moi xuong tap tin
            LuuDanhSach(dsMoi);
        }

        //luu san pham don le
        /*public static void Luu1SanPham (string ma, string ten, int gia)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\lephu\\source\\repos\\KTLT_Buoi 3\\sanpham.txt");

            file.WriteLine(ma);
            file.WriteLine(ten);
            file.WriteLine(gia);
            file.Close();
        }*/


    }
}
