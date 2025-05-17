namespace Entities
{
    public class SanPham
    {
        public string soHoaDon {  get; set; }
        public int maSP {  get; set; }
        public string tenSP { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
        public int thanhTien { get; set; }
        public DateOnly hanSuDung { get; set; }
        public string loaiHang { get; set; }
        public string congTySanXuat {  get; set; }
        public string namSanXuat { get; set; }

        //Constructor
        public SanPham(string SoHoaDon, int MaSP, string TenSP,int DGia, int SoLuong,int ThanhTien,string ctySX, string nam, string LoaiHang, DateOnly HanSuDung)
        {
            soHoaDon = SoHoaDon;
            maSP = MaSP;
            tenSP = TenSP;
            donGia = DGia;
            soLuong = SoLuong;
            thanhTien = ThanhTien;
            hanSuDung = HanSuDung;
            loaiHang = LoaiHang;
            congTySanXuat = ctySX;
            namSanXuat = nam;
        }
        public SanPham(string s)
        {
            string[] arr = s.Split(',');
            soHoaDon = arr[0];
            maSP = int.Parse(arr[1]);
            tenSP = arr[2];
            donGia = int.Parse(arr[3]);
            soLuong = int.Parse(arr[4]);
            thanhTien = int.Parse(arr[5]);
            hanSuDung = DateOnly.Parse(arr[6]);
            loaiHang = arr[7];
            congTySanXuat = arr[8];
            namSanXuat= arr[9];

        }
        


    }
    

    
}
