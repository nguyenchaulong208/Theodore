using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace KTLT_Buoi_3
{
    public struct PhanSo
    {
        public int TuSo;
        public int MauSo;

    }
    public class XuLyPhanSo
    {
       public static PhanSo Cong2PS (PhanSo a, PhanSo b)
       {
            PhanSo kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
       
        public static void LuuPhanSo (PhanSo a)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\lephu\\source\\repos\\KTLT_Buoi 3\\phanso.txt");
            file.Write($"{a.TuSo}/{a.MauSo}");
            file.Close();
        }
        public static void LuuPhanSo_JSON(PhanSo a)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\lephu\\source\\repos\\KTLT_Buoi 3\\phanso.json");

            //bien phan so a thanh chuoi dang JSON
            string json = JsonConvert.SerializeObject(a);
            file.Write(json);
            file.Close();
        }
        //doc phan so tu file json
        public static PhanSo DocPhanSo_JSON(string filePath)
        {
            StreamReader file = new StreamReader(filePath);

            
            //ReadToEnd: doc toan bo tap tin
            string json = file.ReadToEnd();

            //bien chuoi json thanh phan so a
            PhanSo kq = JsonConvert.DeserializeObject<PhanSo>(json);


            file.Close();

            return kq;
        }
        //doc phan so tu file text
        public static PhanSo DocPhanSo (string filePath)
        {
            StreamReader file = new StreamReader(filePath);

           //cach doc 1: readline
           //string s = file.ReadLine(); //"4,7"

           //cach doc 2: readtoend
           string s = file.ReadToEnd();

            PhanSo kq = KhoiTaoPhanSo(s);  

            file.Close();

            return kq;
        }
        private static PhanSo KhoiTaoPhanSo (string s)
        {
         
            string[] m = s.Split('/');
            PhanSo kq;
            kq.TuSo = int.Parse(m[0]);
            kq.MauSo= int.Parse(m[1]);

            return kq;
        }
        
        
    }
}
