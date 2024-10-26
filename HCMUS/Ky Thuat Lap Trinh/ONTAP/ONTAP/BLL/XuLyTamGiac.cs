using ONTAP;
namespace ONTAP.BLL
{
  
    public class XuLyTamGiac
	{
		
		public static int TinhChuVi(TamGiac tg)
		{
			int kq = 0;
			
			kq = (tg.B.Y - tg.A.Y) + (tg.B.Y - tg.C.Y) + (tg.C.Y - tg.A.Y);
			
			return kq;
		}
	}
}
