using Newtonsoft.Json;

namespace KTLT_Buoi_3
{
    public struct TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;
    }
    public class XuLyTamGiac
    {
        public static double TinhChuVi (TamGiac tg)
        {
            double a, b, c;
            a = XuLyDiem.TinhKhoangCach(tg.B, tg.C);
            b = XuLyDiem.TinhKhoangCach(tg.A, tg.C);
            c = XuLyDiem.TinhKhoangCach(tg.A, tg.B);
            return a + b + c;
        }
        public static void LuuTamGiac (TamGiac tg)
        {
            StreamWriter file = new ("E:\\OneDrive\\LEARNING\\My Code\\KTLT\\KTLT_Buoi 3tamgiac.txt");
            file.WriteLine($"{tg.A.X},{tg.A.Y}");
            file.WriteLine($"{tg.B.X},{tg.B.Y}");
            file.WriteLine($"{tg.C.X},{tg.C.Y}");
            file.Close();
        }
        public static void LuuTamGiac_JSON(TamGiac tg)
        {
            StreamWriter file = new StreamWriter("E:\\OneDrive\\LEARNING\\My Code\\KTLT\\KTLT_Buoi 3tamgiac.json");

            string json = JsonConvert.SerializeObject(tg);
            file.Write(json);
            file.Close();
        }
        public static TamGiac DocTamGiac (string filePath)
        {
            TamGiac kq;

            StreamReader file = new StreamReader(filePath);
            
            string s = file.ReadToEnd();
            kq.A = XuLyDiem.KhoiTaoDiem (s);

            s = file.ReadToEnd();
            kq.B = XuLyDiem.KhoiTaoDiem(s);

            s = file.ReadToEnd();
            kq.C = XuLyDiem.KhoiTaoDiem(s);

            file.Close();

            return kq;
        }
        public static TamGiac DocTamGiac_JSON(string filePath)
        {
            TamGiac kq;

            StreamReader file = new StreamReader(filePath);

            //doc toan bo tap tin
            string json = file.ReadToEnd();

            //bien chuoi tam giac thanh json
            kq = JsonConvert.DeserializeObject<TamGiac>(json);


            file.Close();

            return kq;
        }

    }
}
