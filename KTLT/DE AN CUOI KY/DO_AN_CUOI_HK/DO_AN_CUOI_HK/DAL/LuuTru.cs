using DO_AN_CUOI_HK.Entities;
namespace DO_AN_CUOI_HK.DAL
{
    public class LuuTru
    {
        //khởi tạo 1 file với mảng rỗng
        //Đọc file
        public static QL_CuaHang[] DocDuLieu()
        {
            QL_CuaHang[] Dulieu;
            StreamReader readFile = new StreamReader("g:\\TEST\\default.txt");
            int n = int.Parse(readFile.ReadLine());
            Dulieu = new QL_CuaHang[n];
            
                for (int i = 0; i < Dulieu.Length; i++)
                {

                    string s = readFile.ReadLine();
                    QL_CuaHang DL = new QL_CuaHang();
                    string[] chuoi = s.Split(","); // tách chuỗi tại ký tự ,
                    DL.sohoadon = int.Parse(chuoi[0]); // gán vị trí chuỗi
                    DL.ngayhoadon = chuoi[1];// gán vị trí chuỗi
                    DL.ngaysanxuat = chuoi[2];// gán vị trí chuỗi
                    DL.mahang = chuoi[3];
                    DL.tenhang = chuoi[4];
                    DL.soluong = int.Parse(chuoi[5]);
                    DL.dongia = int.Parse(chuoi[6]);
                    DL.thanhtien = int.Parse(chuoi[7]);
                    DL.loaihang = chuoi[8];
                    DL.nhasanxuat = chuoi[9];
                    DL.hansudung = chuoi[10];
                    Dulieu[i] = DL;



                }
                readFile.Close();
            
                
            return Dulieu;
        }
        //luu danh sach hang hoa
        public static void LuuTruDanhSach(QL_CuaHang[] DanhSach)
        {
            StreamWriter writeFile = new StreamWriter("g:\\TEST\\default.txt");
            writeFile.WriteLine(DanhSach.Length);
            for(int i = 0; i < DanhSach.Length; i++)
            {
                writeFile.WriteLine($"{DanhSach[i].sohoadon},{DanhSach[i].ngayhoadon},{DanhSach[i].ngaysanxuat},{DanhSach[i].mahang},{DanhSach[i].tenhang},{DanhSach[i].soluong},{DanhSach[i].dongia},{DanhSach[i].thanhtien},{DanhSach[i].loaihang},{DanhSach[i].nhasanxuat},{DanhSach[i].hansudung}");
            }
            writeFile.Close();
        }
        //luu san pham
        public static void LuuDuLieu(QL_CuaHang DuLieu)
        {
            QL_CuaHang[] _dulieu = DocDuLieu();
            QL_CuaHang[] newDulieu = new QL_CuaHang[_dulieu.Length+1]; //khoi tao mang voi kich thuoc lon hon 1 don vi so voi mang ban dau
            for(int i = 0; i < _dulieu.Length; i++)
            {
                newDulieu[i] = _dulieu[i];
            }
            newDulieu[newDulieu.Length-1] = DuLieu;
            LuuTruDanhSach(newDulieu);
        }

        public static void XoaDuLieu(string maHang)
        {
            QL_CuaHang[] XoaDL = DocDuLieu();
            QL_CuaHang[] newXoaDL = new QL_CuaHang[XoaDL.Length - 1];
            int n = 0;
            for( int i = 0; i < XoaDL.Length; i++ )
            {
                if (XoaDL[i].mahang != maHang)
                {
                    n++;
                    newXoaDL[n -1] = XoaDL[i];
                    
                }

               
            }
            LuuTruDanhSach(newXoaDL);
        }
        public static void SuaDuLieu(QL_CuaHang suaDL)
        {
            QL_CuaHang[] SuaDL = DocDuLieu();

            for (int j = 0; j < SuaDL.Length; j++)
            {
                if (SuaDL[j].mahang == suaDL.mahang)
                {
                    SuaDL[j] = suaDL;
                }
            }
             
        }

        //Xuat Hang
        public static QL_CuaHang[] DocDuLieuBR()
        {
            QL_CuaHang[] Dulieu;
            StreamReader readFile = new StreamReader("g:\\TEST\\Out.txt");
            int n = int.Parse(readFile.ReadLine());
            Dulieu = new QL_CuaHang[n];

            for (int i = 0; i < Dulieu.Length; i++)
            {

                string s = readFile.ReadLine();
                QL_CuaHang DL = new QL_CuaHang();
                string[] chuoi = s.Split(","); // tách chuỗi tại ký tự ,
                DL.sohoadon = int.Parse(chuoi[0]); // gán vị trí chuỗi
                DL.ngayhoadon = chuoi[1];// gán vị trí chuỗi
                DL.mahang = chuoi[2];
                DL.tenhang = chuoi[3];
                DL.soluong = int.Parse(chuoi[4]);
                DL.dongia = int.Parse(chuoi[5]);
                DL.thanhtien = int.Parse(chuoi[6]);
               
                Dulieu[i] = DL;



            }
            readFile.Close();


            return Dulieu;
        }
        //luu danh sach hang hoa
        public static void LuuTruDanhSachBR(QL_CuaHang[] DanhSach)
        {
            StreamWriter writeFile = new StreamWriter("g:\\TEST\\Out.txt");
            writeFile.WriteLine(DanhSach.Length);
            for (int i = 0; i < DanhSach.Length; i++)
            {
                writeFile.WriteLine($"{DanhSach[i].sohoadon},{DanhSach[i].ngayhoadon},{DanhSach[i].ngaysanxuat},{DanhSach[i].mahang},{DanhSach[i].tenhang},{DanhSach[i].soluong},{DanhSach[i].dongia},{DanhSach[i].thanhtien},{DanhSach[i].loaihang},{DanhSach[i].nhasanxuat},{DanhSach[i].hansudung}");
            }
            writeFile.Close();
        }
        //luu san pham
        public static void LuuDuLieuBR(QL_CuaHang DuLieu)
        {
            QL_CuaHang[] _dulieu = DocDuLieuBR();
            QL_CuaHang[] newDulieu = new QL_CuaHang[_dulieu.Length + 1]; //khoi tao mang voi kich thuoc lon hon 1 don vi so voi mang ban dau
            for (int i = 0; i < _dulieu.Length; i++)
            {
                newDulieu[i] = _dulieu[i];
            }
            newDulieu[newDulieu.Length - 1] = DuLieu;
            LuuTruDanhSachBR(newDulieu);
        }


        //Kiểm tra dữ liệu

       
    }
}

