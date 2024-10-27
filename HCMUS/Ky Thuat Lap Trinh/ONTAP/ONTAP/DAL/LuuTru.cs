using ONTAP.BLL;
using ONTAP.Entities;

namespace ONTAP.DAL
{
    public class LuuTru
    {
        public static string[] Docdulieu()
        {
            var path1 = "DuLieu/A.txt";
            var path = Path.GetFullPath(path1);
            StreamReader FileReader = new StreamReader(path);
            int n = int.Parse(FileReader.ReadLine());
            string[] newMangA = new string[n];

            for (int i = 0; i < newMangA.Length; i++)
            {
                string s = FileReader.ReadLine();
                newMangA[i] = s;
            }

            FileReader.Close();
            return newMangA;
        }

    
    public static string[] DocdulieuB()
        {
            var path1 = "DuLieu/B.txt";
            var path = Path.GetFullPath(path1);
            string[] newMangB;
            //string DL = new string();
            StreamReader FileReader = new StreamReader(path);
            int n = int.Parse(FileReader.ReadLine());
            newMangB = new string[n];
            for (int i = 0; i < newMangB.Length; i++)
            {

                string s = FileReader.ReadLine();

				newMangB[i] = s;
            }
            FileReader.Close();
            return newMangB;
        }
        
        public static Data[] DocDulieuSP()
        {
            var path = "DuLieu/DulieuSanPham.txt";
            var fullpath = Path.GetFullPath(path);
            Data[] newMang;
            StreamReader FileReader = new StreamReader(fullpath);
            int count = int.Parse(FileReader.ReadLine());
            newMang = new Data[count];
            for(int i = 0; i < newMang.Length; i++) 
            { 
                string ReadFile = FileReader.ReadLine();
                Data newData = new Data();
                string[] chuoi = ReadFile.Split("|");
                newData.MaSp = chuoi[0];
                newData.TenSP = chuoi[1];
                newData.GiaSP = int.Parse(chuoi[2]);
                newData.HanSD = chuoi[3];
                newData.Nhanhang = chuoi[4];
                newMang[i] = newData;
            }
            FileReader.Close();
            return newMang;
        }
        public static void Ghidulieu(Data[] dulieu)
        {
            var path = "DuLieu/DulieuSanPham.txt";
            string fullpath = Path.GetFullPath(path);
            
            StreamWriter FileWriter = new StreamWriter(fullpath);
            FileWriter.WriteLine(dulieu.Length);
            for(int i = 0; i < dulieu.Length; i++)
            {
                FileWriter.WriteLine($"{dulieu[i].MaSp}|{dulieu[i].TenSP}|{dulieu[i].GiaSP}|{dulieu[i].HanSD}|{dulieu[i].Nhanhang}");
            }
            FileWriter.Close();
        }

        public static void LuuTrudulieu(Data dulieuSP)
        {
            Data[] newData = DocDulieuSP();
            Data[] newData2 = new Data[newData.Length + 1];
            for(int i = 0; i < newData.Length; i++)
            {
                newData2[i] = newData[i];
            }
            newData2[newData2.Length-1] = dulieuSP;
            Ghidulieu(newData2);
        }
	}
}
