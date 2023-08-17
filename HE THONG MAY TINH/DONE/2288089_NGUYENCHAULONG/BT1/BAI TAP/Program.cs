using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Chon he muon chuyen doi");
            Console.WriteLine("1.Thap phan sang nhi phan");
            Console.WriteLine("2.Thap phan sang thap luc phan");
            Console.WriteLine("3.Nhi phan sang he thap phan");
            Console.WriteLine("4.Thap luc phan sang thap phan");
            Console.WriteLine("5.Nhi phan sang thap luc phan");
            Console.WriteLine("___________");
            Console.Write("Chon: ");

            int select = int.Parse(Console.ReadLine());

            
            //if(select == 1)
            //{
            //    int kq = xuly.binary(a);
            //    Console.WriteLine($"Binary: {kq}");
            //}    

            switch(select)
            {
                case 1:
                    
                    Console.WriteLine("Chuyen doi so thap phan sang nhi phan \n___________");
                    Console.Write("Nhap so can chuyen doi: ");
                    int a = int.Parse(Console.ReadLine());
                    int kqB = xuly.binary(a);
                    Console.WriteLine($"Binary: 0{kqB}");
                    Console.WriteLine();
                break;

                case 2:

                    Console.WriteLine("Chuyen doi so thap phan sang thap luc phan \n___________");
                    Console.Write("Nhap so can chuyen doi: ");
                    int b = int.Parse(Console.ReadLine());
                   string kqH = xuly.hexadecimal(b);
                    Console.WriteLine($"Hexadecimal: {kqH}");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Chuyen doi so nhi phan sang he thap phan \n___________");
                    Console.Write("Nhap so can chuyen doi: ");
                    string c = Console.ReadLine();
                    string kq = xuly._decimal(c);
                    Console.WriteLine($"Decimal: {kq}");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Chuyen doi so thap luc phan sang thap phan \n___________");
                    Console.Write("Nhap so can chuyen doi: ");
                    string e = Console.ReadLine();
                    string _kqHtd = xuly.htd(e);
                    Console.WriteLine($"Decimal: {_kqHtd}");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Chuyen doi so nhi phan sang thap luc phan \n___________");
                    Console.Write("Nhap so can chuyen doi: ");
                    string f = Console.ReadLine();
                    string _kqbtn = xuly.bth(f);
                    Console.WriteLine($"Decimal: {_kqbtn}");
                    Console.WriteLine();
                    break;

            }    
            
        }
    }

}

