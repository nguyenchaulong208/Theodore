using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class XuLyNhiPhan
    {
        public string dulieu;
        
        public void input()
        {
            //Console.WriteLine("Chuoi du lieu: ");
            dulieu = Console.ReadLine();
        }
        public XuLyNhiPhan Cong(XuLyNhiPhan n)
        { 
            XuLyNhiPhan kq = new XuLyNhiPhan();
            int i,a, b, c = 0, kqTong;
            for (i = dulieu.Length - 1;   i >= 0; i--)
            {
                string t = Convert.ToString(dulieu[i]);
                a = Convert.ToInt32(t);
                t = Convert.ToString(n.dulieu[i]);
                b = Convert.ToInt32(t);
                kqTong = a + b + c;
                if (kqTong == 2)
                {
                    c = 1;
                }    
                
                else
                {
                    c = 0;
                }  
                if(kqTong == 2)
                {
                    kq.dulieu = "0" + kq.dulieu ;

                }
                else if(kqTong == 3)
                {
                    kq.dulieu = "1" + kq.dulieu;
                }
                else
                {
                    kq.dulieu =   Convert.ToString(kqTong) + kq.dulieu;
                }    
            }    
            return kq;
        }

        public XuLyNhiPhan Hieu(XuLyNhiPhan m)
        {//dap chuoi
            XuLyNhiPhan kqH = new XuLyNhiPhan();
            int i;
            string p, u = "";
            for (i = 0; i < m.dulieu.Length; i++)
            {
                p = Convert.ToString(m.dulieu[i]);
                if (p == "1")
                {
                    u = u + "0";
                }
                if (p == "0")
                {
                    u = u + "1";
                }
            }    
             


            
            int a, b, c = 0, kqHieu;
            for (i = dulieu.Length - 1; i >= 0; i--)
            {
                string t = Convert.ToString(dulieu[i]);
                a = Convert.ToInt32(t);
                t = Convert.ToString(u[i]);
                b = Convert.ToInt32(t);
                kqHieu = a + b + c;
                if (kqHieu == 2)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }

                if (kqHieu == 2)
                {
                    kqH.dulieu = "0" + kqH.dulieu;

                }
                else if
                  (kqHieu == 3)
                {
                    kqH.dulieu = "1" + kqH.dulieu;
                }
                else
                {

                    kqH.dulieu = Convert.ToString(kqHieu) + kqH.dulieu;
                }
            }
            return kqH;
        }

        public XuLyNhiPhan tich(XuLyNhiPhan _tich)
        {
            int i,  a, b, c, bitQ, kqT, _kqT, bitnho = 0, _tong = 0;
            XuLyNhiPhan kqTich = new XuLyNhiPhan();
           
            
            bitQ = _tich.dulieu.Length - 1;
            
            for (i = dulieu.Length - 1; i >= 0; i--)
            {
                string t = Convert.ToString(dulieu[i]);
                a = Convert.ToInt32(t);
                t = Convert.ToString(_tich.dulieu[i]);
                b = Convert.ToInt32(t);
                _kqT = a + b + _tong;
               
                _kqT = Convert.ToInt32(t);
                if (bitQ == 1)
                {
                    _kqT = _tong + _tich.dulieu[i];
                }   
                  
                    
            }
            return kqTich;
        }
        public void result()
        {
            Console.WriteLine(dulieu);
        }
    }
}
