using ONTAP.DAL;
using ONTAP.Entities;
namespace ONTAP.BLL
{
	public class Xuly
	{
		
		public static string Check()
		{
			string thongbao = string.Empty;
			Boolean check = false;
			string[] dulieuB = LuuTru.DocdulieuB();
            string[] dulieuA = LuuTru.Docdulieu();
			for (int i = 0; i < dulieuB.Length; i++)
			{
				check = false;
				for(int j = 0; j < dulieuA.Length; j++)
				{
                    if (dulieuB[i] == dulieuA[i])
                    {
                        check = true;
                        break;
                    }
                }
				if(check == false)
				{
					thongbao = "Khong la tap con";
					break;
				}
				else
				{
					thongbao = "La tap con";
				}
			}
			return thongbao;
        
        }
		public static string ThemSanpham(string masp,string tensp, int gia,string hansudung,string nhanhang)
		{
			string thongbao = string.Empty;
			if(string.IsNullOrEmpty(masp) || string.IsNullOrEmpty(tensp) || gia <= 0 || string.IsNullOrEmpty(hansudung) || string.IsNullOrEmpty(nhanhang))
			{
				thongbao = "Dữ liệu không hợp lệ!!!";
			}
			else
			{
				Data DL;
				DL.MaSp = masp;
				DL.TenSP = tensp;
				DL.GiaSP = gia;
				DL.HanSD = hansudung;
				DL.Nhanhang = nhanhang;
				LuuTru.LuuTrudulieu(DL);
                thongbao = "Lưu thành công";
            }
			return thongbao;
		}
		public static string XuLySonguyen(int songuyen)
		{
			string thongbao = string.Empty;
			int kq = 0;
			if(songuyen < 0)
			{
				thongbao = "Dữ liệu không hợp lệ";
			}
			else
			{
				for(int i = 0; i < songuyen; i++)
				{
					if(i % 2 == 0)
					{
						kq = kq + i;
					}
				}
				thongbao = $"Tong cac so nguyen duong nho hon N la: {kq}";
			}
			return thongbao;
		}
    }
}
