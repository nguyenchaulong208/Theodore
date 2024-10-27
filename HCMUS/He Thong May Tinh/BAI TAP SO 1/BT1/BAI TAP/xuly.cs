using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP
{
    internal class xuly
    {
        //1.Thap phan sang nhi phan
        public static int binary(int bnr)
        {
            string result = "";
            int kq = 0;

            while (bnr > 0)
            {
                kq = bnr % 2;
                result = kq + result;
                bnr /= 2;
               
            }
            //result = "0" +result;
            
            return Convert.ToInt32(result);

        }
        //2.Thap phan sang thap luc phan
        public static string hexadecimal(int h)
        {
            string result = "", _result = "", result1 = "";
            int kq = 0;

            while (h > 0)
            {
                kq = h % 16;
                h /= 16;


                _result = "";

                switch (kq)
                {
                    case 10:
                        _result = "A"; break;
                    case 11:
                        _result = "B"; break;
                    case 12:
                        _result = "C"; break;
                    case 13:
                        _result = "D"; break;
                    case 14:
                        _result = "E"; break;
                    case 15:
                        _result = "F"; break;

                }


                if (kq >= 0 && kq <= 9) _result = $"{kq}";

                

                result = _result + result;
                 

            }


            ;
            return Convert.ToString(result);


        }

        //3.Nhi phan sang he thap phan
        public static string _decimal(string d)
        {
            int  i,n;
            string k = "";
            double kqD = 0;


            for (i = d.Length - 1; i>= 0; i--)
            {
                k = Convert.ToString(d[d.Length - i - 1]);

                n = Convert.ToInt32(k);
                    kqD = kqD + n * Math.Pow(2, i);
                
               
               
            }
           
            return Convert.ToString(kqD);
        }
        //4.Thap luc phan sang thap phan
        public static string htd(string _htd)
        {
            int i, n, m = 0;
            double kqHtd = 0;
            string kq = "", k = "";
            for (i = _htd.Length - 1; i >= 0; i--)
            {
                kq = Convert.ToString(_htd[_htd.Length - i - 1]);
                if (kq == "A")
                {
                    kq = "10";
                }
                if (kq == "B")
                {
                    kq = "11";
                }
                if (kq == "C")
                {
                    kq = "12";
                }
                if (kq == "D")
                {
                    kq = "13";
                }
                if (kq == "E")
                {
                    kq = "14";
                }
                if (kq == "F")
                {
                    kq = "15";
                }
                n = Convert.ToInt32(kq);
                kqHtd = kqHtd + n * Math.Pow(16, i);
            }
            kq = Convert.ToString(kqHtd);
            kqHtd = Convert.ToDouble(kq);
            //Console.ReadLine();
            return Convert.ToString(kqHtd);

        }

        //5.Nhi phan sang thap luc phan
        public static string bth(string _btn)
        {
            int i, n;
            string kqbth, k, _kqbth = "";
            n = _btn.Length;
            while (n % 4 != 0)
            {
                _btn = "0" + _btn;
                n = _btn.Length;
            }
            for (i = 1; i <= _btn.Length; i++)
            {
                k = "";
                if (i % 4 == 0)
                {
                    k = Convert.ToString(_btn[i - 4]) + Convert.ToString(_btn[i - 3]) + Convert.ToString(_btn[i - 2]) + Convert.ToString(_btn[i - 1]);
                    kqbth = xuly._decimal(k);
                    switch (kqbth)
                    {
                        case "10":
                            kqbth = "A"; break;
                        case "11":
                            kqbth = "B"; break;
                        case "12":
                            kqbth = "C"; break;
                        case "13":
                            kqbth = "D"; break;
                        case "14":
                            kqbth = "E"; break;
                        case "15":
                            kqbth = "F"; break;

                    }
                    //if (kqbth == "10") kqbth = "A";
                    //if (kqbth == "11") kqbth = "B";
                    //if (kqbth == "12") kqbth = "C";
                    //if (kqbth == "13") kqbth = "D";
                    //if (kqbth == "14") kqbth = "E";
                    //if (kqbth == "15") kqbth = "F";
                    _kqbth = _kqbth + kqbth;

                }

            }

            return _kqbth;
        }

    }
}
