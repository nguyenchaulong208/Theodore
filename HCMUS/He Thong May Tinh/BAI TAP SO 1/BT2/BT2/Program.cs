using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {

        /*
         * Bài 2. Hãy nhập vào 2 số nhị phân 8 bit (số nguyên có dấu dạng bù 2) hãy thực hiện các phép tính theo menu sau:

                1. Tính tổng hai dãy bit

                2. Tính Hiệu hai dãy bit

                3. Tính tích hai dãy bit

                4. TÍnh thương 2 dãy bit
         */
        static void Main(string[] args)
        {
            XuLyNhiPhan data1, data2;
            data1 = new XuLyNhiPhan();
            data2 = new XuLyNhiPhan();
            
            //lua chon phep toan
            int select;
            
            Console.WriteLine("1.Tinh tong");
            Console.WriteLine("2.Tinh hieu");
            Console.WriteLine("3.Tinh tich");
            Console.WriteLine("4.Tinh thuong");
            Console.WriteLine("______");
            Console.WriteLine("Chon phep tinh");
            select = int.Parse(Console.ReadLine());
            Console.WriteLine("______");
            //Nhap so nhi phan
            XuLyNhiPhan kq;
            Console.Write("Nhap so thu nhat: ");
            data1.input();
            Console.WriteLine();
            Console.Write("Nhap so thu nhat: ");
            data2.input();
            Console.WriteLine("______");
            if (select == 1)
            { 
                kq = data1.Cong(data2);
                kq.result();
            }
            if(select == 2)
            {
                kq = data1.Hieu(data2);
                kq.result();
            }
            if(select == 3)
            {
                kq = data1.tich(data2);
                kq.result();
            }

            Console.WriteLine();
        }
    }
}