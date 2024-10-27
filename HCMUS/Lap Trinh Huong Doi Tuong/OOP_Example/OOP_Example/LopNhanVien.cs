using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class LopNhanVien
    {
        private double _heSoLuong;
        private double _phuCap;
        public string _hoTen;
        public string _diaChi;
        public string _CCCD;

        public double HeSoLuong
        {
            get
            {
                return _heSoLuong;
            }
            set
            {
                if(value >=1 && value <= 10)
                {
                    _heSoLuong = value;
                }
            }
        }

        public double PhuCap
        {
            get
            {
                return _phuCap;
            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _phuCap = value;
                }
            }
        }
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
                if (value is not null)
                {
                    _hoTen = value;
                }
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }
            set
            {
                if (value is not null)
                {
                    _diaChi = value;
                }
            }
        }
        public string CCCD
        {
            get
            {
                return _CCCD;
            }
            set
            {
                if (value is not null)
                {
                    _CCCD = value;
                }
            }
        }
        public LopNhanVien(string hoTen)
        {
            HoTen = hoTen;
            HeSoLuong = 1;
            PhuCap = 0;
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
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            PhuCap = double.Parse(Console.ReadLine());

        }

        public double TinhLuong()
        {
            return HeSoLuong * 1000 + PhuCap;
        }
    }
}
