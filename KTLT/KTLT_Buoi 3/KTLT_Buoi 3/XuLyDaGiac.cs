using Newtonsoft.Json;

namespace KTLT_Buoi_3
{
    public struct DaGiac
    {
        public Diem[] DanhSachDinh; 
    }
    public class XuLyDaGiac
    {
       public static DaGiac KhoiTaoDaGiac (string chuoiDaGiac)
        {
            DaGiac kq;
            string[] m = chuoiDaGiac.Split("|", StringSplitOptions.RemoveEmptyEntries);
            kq.DanhSachDinh = new Diem[m.Length];
            for (int i=0; i<m.Length; i++)
            {
                kq.DanhSachDinh[i] = XuLyDiem.KhoiTaoDiem(m[i]); 
            }
            return kq;
        }
        public static double TinhChuVi (DaGiac dg)
        {
            double kq = 0;
            for (int i=0; i< dg.DanhSachDinh.Length-1;i++) 
            {
                kq = kq + XuLyDiem.TinhKhoangCach(dg.DanhSachDinh[i], dg.DanhSachDinh[i +1]);
            }
            kq = kq + XuLyDiem.TinhKhoangCach(dg.DanhSachDinh[0 ], dg.DanhSachDinh[dg.DanhSachDinh.Length-1]);

            return kq;
        }
        public static void LuuDaGiac_JSON(DaGiac dg)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\lephu\\source\\repos\\KTLT_Buoi 3\\dagiac.json");

            string json = JsonConvert.SerializeObject(dg);
            file.Write(json);
            file.Close();
        }

        public static DaGiac DocDaGiac (string filePath)
        {
            DaGiac kq;
            StreamReader file = new StreamReader(filePath);

            string s = file.ReadToEnd();
            int n = int.Parse(s);

            kq.DanhSachDinh = new Diem[n];

            for (int i=0; i< n; i++)
            {
                s = file.ReadToEnd();
                kq.DanhSachDinh[i] = XuLyDiem.KhoiTaoDiem(s);
            }
            file.Close();

            return kq;
        }


    }
}
