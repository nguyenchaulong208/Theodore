using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    public class Theodore
    {
        private string _ngayhd;
        private int _sohd;
        private string _msp;
        private string _tensp;
        private double _soluong;
        private double _dongia;
        private double _thanhtien;
        //Constructor
        public string NgayHD
        {
            get
            {
                return this._ngayhd;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ngay hoa don khong hop le");
                }
                else
                {
                    this._ngayhd = value;
                }

            }
            
        }
        public int Sohd
        {
            get
            {
                return this._sohd;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("SO hoa don khong hop le");
                }
                else
                {
                    this._sohd = value;
                }
            }
        }

        public string Masp
        {
            get
            {
                return this._msp;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ma san pham khong hop le");
                }
                else
                {
                    this._msp = value;
                }

            }

        }
        public string TenSP
        {
            get
            {
                return this._tensp;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ten san pham khong hop le");
                }
                else
                {
                    this._tensp = value;
                }

            }

        }
        public double Soluong
        {
            get
            {
                return this._soluong;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("So luong khong hop le");
                }
                else
                {
                    this._soluong = value;
                }
            }
        }
        public double Dongia
        {
            get
            {
                return this._dongia;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Don gia khong hop le");
                }
                else
                {
                    this._dongia = value;
                }

            }
        }
        public double Thanhtien
        {
            get
            {
                return this._thanhtien;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Thanh tien khong hop le");
                }
                else
                {
                    this._thanhtien = value;
                }

            }

        }
    }
    
    
}
