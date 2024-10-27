namespace example_OOP
{
    public class DaGiac
    {
        public Diem[] DanhSachDinh;
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap so dinh cua da giac: ");
            int n = int.Parse(Console.ReadLine());
            DanhSachDinh = new Diem[n];
            for (int i = 0; i <DanhSachDinh.Length; i++)
            {
                DanhSachDinh[i] = new Diem();
                DanhSachDinh[i].Nhap("Nhap Dinh " + i + ":");
            }
        }
        public double TinhChuVi()
        {
            double kq = 0;
            for (int i = 0; i < DanhSachDinh.Length-1
            ; i++)
            {
                kq = kq + DanhSachDinh[i].TinhKhoangCach(DanhSachDinh[i + 1]);
            }
            kq = DanhSachDinh[0].TinhKhoangCach(DanhSachDinh[DanhSachDinh.Length - 1]);
            return kq;
        }
    }
}