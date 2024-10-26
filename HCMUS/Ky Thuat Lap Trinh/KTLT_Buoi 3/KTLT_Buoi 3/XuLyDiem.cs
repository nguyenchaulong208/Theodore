namespace KTLT_Buoi_3
{
	public struct Diem
	{
		public int X;
		public int Y;
	}
	public class XuLyDiem
	{
		public static double TinhKhoangCach (Diem a, Diem b)
		{
		  return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));

		}

		//chuoiDiem = "(3,2)"
		public static Diem KhoiTaoDiem (string chuoiDiem)
		{
			chuoiDiem= chuoiDiem.Substring(1, chuoiDiem.Length - 2);
			//chuoiDiem= "3,2";
			string[] m = chuoiDiem.Split(",");
			Diem kq;
			kq.X= int.Parse(m[0]);
			kq.Y= int.Parse(m[1]);
			return kq;

		}
	}
}
