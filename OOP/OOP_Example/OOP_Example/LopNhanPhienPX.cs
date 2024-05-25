using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class LopNhanPhienPX
    {
        private double _soSanPham;
        public string HoTen;
        public string DiaChi;
        public string CCCD;

        public double SoSanPham
        {
            get
            {
                return this._soSanPham;
            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    this._soSanPham = value;
                }
            }
        }

      
        //public string HoTen
        //{
        //    get
        //    {
        //        return this._hoTen;
        //    }
        //    set
        //    {
        //        if (value is not null)
        //        {
        //            this._hoTen = value;
        //        }
        //    }
        //}

        //public string DiaChi
        //{
        //    get
        //    {
        //        return this._diaChi;
        //    }
        //    set
        //    {
        //        if (value is not null)
        //        {
        //            this._diaChi = value;
        //        }
        //    }
        //}
        //public string CCCD
        //{
        //    get
        //    {
        //        return this._CCCD;
        //    }
        //    set
        //    {
        //        if (value is not null)
        //        {
        //            this._CCCD = value;
        //        }
        //    }
        //}
        public LopNhanPhienPX(string hoTen)
        {
            HoTen = hoTen;
            SoSanPham = 0;
        }

        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap ho ten NV: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap CCCD: ");
            CCCD = Console.ReadLine();

            Console.Write("Nhap he so luong: ");
            SoSanPham = double.Parse(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            

        }
        public double TinhLuong()
        {
            return 100 * SoSanPham;
        }
    }
}
