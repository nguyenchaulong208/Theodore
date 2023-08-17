using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BTNMLT
{
    internal class Program
    {

        #region //Bai 1: Tinh S(n) = 1 + 2 + 3 + … +n

        public static int Bai01(int n)
        {

            int S = 0;
            for (int i = 0; i <= n; i++)
            {
                S = S + i;

            }
            return S;
        }
        #endregion

        #region // Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
        //public static int Bai02(int x)
        //{
        //    int KQ = 0;

        //    int LuyThua = 0;
        //    for (int i = 0; i <= x; i++)
        //    {
        //        LuyThua = i * i;
        //        KQ = KQ + LuyThua;
        //    }
        //    return KQ;
        //}
        #endregion

        #region //Bài 50: Hãy tìm số đảo ngược của số nguyên dương n
        //public static int bai50(int n)
        //{
        //    int s = 0;


        //    while (n > 0)
        //    {
        //        s = s * 10 + n % 10;
        //        n = n / 10;

        //    }
        //    return s;

        //}
        #endregion

        #region //Bài 51: Tìm chữ số lớn nhất của số nguyên dương n
        //public static int bai51(int n)
        //{
        //    int Mx = 0;
        //    int s = 0;
        //    while (n > 0)
        //    {
        //        s = n % 10;
        //        n = n / 10;
        //        if (s > Mx)
        //            Mx = s;
        //    }
        //    return Mx;
        //}

        #endregion

        #region //Bài 52: Tìm chữ số nhỏ nhất của số nguyên dương n
        //public static int bai52(int n)
        //{
        //    int Mn = 9;
        //    int s = 0;
        //    while (n > 0)
        //    {
        //        s = n % 10;
        //        n = n / 10;

        //        if (s < Mn)
        //           Mn = s;
        //    }
        //    return Mn;
        //}

        #endregion

        #region //Bài 53: Hãy đếm số lượng chữ số lớn nhất của số nguyên dương n (chua ra ket qua)
        //public static int bai53(int n)
        //{
        //    int count = 0;
        //    int Mx = 0;
        //    int s = 0;
        //    while (n > 0)
        //    {
        //        s = n % 10;
        //        n = n / 10;

        //        if (s > Mx)
        //            Mx = s;



        //    }
        //    int m = n;
        //    while(m > 0)
        //    {
        //     count = m % 10;
        //        m = m / 10;

        //        if (count == s)
        //            count ++;

        //    }    

        //    return count;
        //}

        #endregion

        #region //Bài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không

        //public static int bai56(int n)
        //{
        //    int s = 0;
        //    while (n > 0)
        //    {
        //        s = n % 10;
        //        n = n / 10;


        //    }
        //    return s;
        //}

        #endregion

        #region Bài 57: Hãy kiểm tra số nguyên dương n có toàn chữ số chẵn hay không
        //public static int bai57(int n)
        //{
        //    int s = 0;
        //    while (n > 0)
        //    {
        //        s = n % 10;
        //        n = n / 10;
        //        if (s % 2 == 0)
        //        {
        //            Console.WriteLine("Đúng");
        //            break;
        //        }

        //        else
        //        {
        //            Console.WriteLine("Sai");
        //            break;
        //        }
        //    }
        //    return s;
        //}
        #endregion

        #region Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng hay không (chưa ra kq)
        //public static int bai59(int n)
        //{
        //    int s = 0;
        //    while (n > 0)
        //    {
        //        int i;
        //        s = s * 10 + n % 10;
        //        n = n / 10;
        //        if (n > 0)
        //        {
        //            Console.WriteLine("Đúng");
        //            break;
        //        }

        //        else
        //        {
        //            Console.WriteLine("Sai");
        //            break;
        //            //}
        //            //}
        //            return s;
        //        }
        #endregion

        #region Bài 60: Hãy kiểm tra các chữ số của số nguyên dương n có tăng dần từ trái sang phải hay không
        //public static int bai60(int n)
        //{
        //    int s = 0;
        //    int i = 0;


        //    i = n % 10;
        //    n = n / 10;
        //    while (n > 0)
        //    {
        //        s = n % 10;


        //        if (s <= i)
        //        {
        //            Console.WriteLine("Đúng");
        //            break;
        //        }

        //        else
        //        {
        //            Console.WriteLine("Sai");
        //            break;
        //        }

        //    }
        //    return s;
        //}
        #endregion

        #region Bài 61: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không
        //public static int bai61(int n)
        //{
        //    int s = 0;
        //    int i = 0;


        //    i = n % 10;
        //    n = n / 10;
        //    while (n > 0)
        //    {
        //        s = n % 10;


        //        if (s >= i)
        //        {
        //            Console.WriteLine("Đúng");
        //            break;
        //        }

        //        else
        //        {
        //            Console.WriteLine("Sai");
        //            break;
        //        }

        //    }
        //    return s;
        //}
        #endregion

        #region Bài 62: Cho 2 số nguyên dương a và b. Hãy tìm ước chung lớn nhất của 2 số này.
        //public static int bai62(int a, int  b)
        //{
        //    int s = 0;
        //    int SoNguyen1 = 0;
        //    int SoNguyen2 = 0;
        //   for(int i = 0; i < Math.Max(a, b); i++)
        //    {
        //        SoNguyen1 = a % i;
        //        SoNguyen1 = b % i; 

        //        if (SoNguyen1 == 0 )
        //        {
        //            s = SoNguyen1;
        //        }    


        //    } 



        //    return s;
        //}
        #endregion

        #region: Bài 69: Tính S(x, n) = x – x^3 + x^5 + … + (-1)^n * x^2n+1
        //public static int bai69(int m, int n)
        //{
        //    int x = 0;


        //    int luythua = 1;
        //    int s = 0;
        //    int i = 1;
        //    int h = 1;





        //    if (n % 2 == 0)
        //    {
        //        x = 1;

        //    }
        //    else x = -1;


        //    h = 2 * n + 1;
        //    while (i <= h) 
        //    {

        //        luythua = luythua * m;


        //            i++;
        //    }
        //    luythua=luythua*x;
        //    return luythua;
        //}
        //public static int tinhtong(int m, int n)
        //{
        //    int i = 0, kq=0;
        //    while(i <= n)
        //    {
        //        int a=bai69(m,i);
        //        kq = kq + a;
        //        i++;

        //    }
        //    return kq;    
        //}


        #endregion

        #region Bài 83: Viết chương trình nhập 2 số thực, kiểm tra xem chúng có cùng dấu hay không

        //public static int bai83(int m, int n)
        //{

        //} 

        #endregion
        #region Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n
        //public static int bai03(int n)
        //{
        //    Bài 3: Tính S(n) = 1 + ½ +1 / 3 + … +1 / n

        //    int S = 0;
        //    int chia = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        chia = chia + (1 / i);
        //        S = S + chia;
        //    }
        //    return S;
        //}
        #endregion

        #region Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n
        //public static int bai13(int m, int n)
        //{


        //    int luythua = 1;
        //    int S = 1;
        //    for (int i = 1; i < n; i++)
        //    {
        //        luythua = luythua * 2 * n ;
        //        S = S + luythua;
        //    }
        //    return S;
        //}
        #endregion
        #region Bài 101: Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày
        //public static int bai101(int a, int b)
        //{
        //    switch (a)
        //    {
        //        case 1:
        //            Console.WriteLine("Thang 1 co 31 ngay");
        //            break;
        //        case 2:
        //            if( b % 100 > 0 && b % 4 ==0 || b % 400 == 0)
        //            {
        //                Console.WriteLine("Thang 2 co 29 ngay"); break;
        //            }    
        //            Console.WriteLine("Thang 2 co 28 ngay"); break ;
        //        case 3:
        //            Console.WriteLine(" Thang 3 co 31 ngay"); break ;
        //        case 5:
        //            Console.WriteLine(" Thang 5 co 31 ngay"); break;
        //        case 7:
        //            Console.WriteLine(" Thang 7 co 31 ngay"); break;
        //        case 8:
        //            Console.WriteLine(" Thang 8 co 31 ngay"); break;
        //        case 10:
        //            Console.WriteLine(" Thang 10 co 31 ngay"); break;
        //        case 12:
        //            Console.WriteLine(" Thang 12 co 31 ngay"); break;

        //        default : Console.WriteLine($"Thang {a} co 30 ngay"); break ;

        //    }   

        //    return a;


        //}

        #endregion

        #region Bài 96: Viết chương trình nhập giá trị x sau tính giá trị của hàm số
        //f(x) = 2x^2 + 5x + 9 khi x >= 5, f(x) = -2x^2 + 4x – 9 khi x< 5

        //public static int bai96(int x)
        //{

        //        int phuongtrinh = 0;


        //        if (x >= 5)
        //        {
        //            phuongtrinh = 2 * x*x + 5 * x + 9;
        //        }
        //        else
        //        {
        //            phuongtrinh = -2 * x*x + 4 * x - 9;
        //        }

        //        return phuongtrinh;
        // }

        #endregion

        #region Bài 84: Viết chương trình giải và biện luận phương trình bậc nhất ax + b = 0
        //public static int bai84(int a, int b)
        //{
        //    int phuongtrinh = 0;
        //    int x = 1;
        //    phuongtrinh = a * x + b;
        //    if (a == 0 )
        //    {
        //        if( b == 0 )
        //        {
        //            Console.WriteLine("Phuong trinh co vo so nghiem");
        //        }    
        //        else
        //        {
        //            Console.WriteLine("Phuong trinh vo nghiem");
        //        }
        //    }
        //   else
        //    {
        //        x = -b / a;
        //        Console.WriteLine("Phuong trinh co mot nghiem duy nhat");
        //    }

        //    return x;
        //}

        #endregion

        #region Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không
        //là số tự nhiên có căn bậc hai là một số tự nhiên
        //public static int bai32(int x)
        //{
        //    int i, j;
        //    Boolean check = false;
        //    for (i = 0; i <= Math.Sqrt(x); i++)
        //    {
        //        if (i * i == x) check = true;

        //    }


        //    if (check == true)

        //    {
        //        Console.WriteLine("La so chinh phuong");

        //    }
        //    else
        //    {
        //        Console.WriteLine("khong la so chinh phuong");
        //    }





        //    return 0; 
        //}
        #endregion
        #region Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn
        //public static double bai33(int x)
        //{

        //    double a, b = 0;
        //    b = Math.Sqrt(2);
        //    if (x == 1)
        //    {
        //        return b;
        //    }    
        //    for(int i = 2; i < x; i++)
        //    {
        //        a = Math.Sqrt(2 + b);
        //        b = a;
        //    } 
        //    return b;
        //}


        #endregion

        //public static bool kiemtrasonguyento(int n)
        //{

        //    if (n <= 1)
        //    {
        //        return false;

        //    }

        //    int i = 2;
        //    while (i <= n / 2)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;

        //        }
        //        i++;
                
        //    }
        //    return true;
        //}
            public static void Main(string[] args)
        {


            #region //Bai 1: Tinh S(n) = 1 + 2 + 3 + … +n

            int k;

            Console.Write("Cho k = ");
            k = int.Parse(Console.ReadLine());

            int kq1 = Bai01(k);

            Console.WriteLine($"S({k}) = {kq1}");



            #endregion

            #region // Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
            //int n;
            //Console.Write("nhap n = ");
            //n = int.Parse(Console.ReadLine());


            //int kq2 = Bai02(n);

            //Console.WriteLine($"S = {kq2}");

            #endregion

            #region //Bài 50: Hãy tìm số đảo ngược của số nguyên dương n
            //int k;

            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());

            //int kq1 = Bai50(k);

            //Console.WriteLine($"S({k}) = {kq1}");
            #endregion

            #region //Bài 51: Tìm chữ số lớn nhất của số nguyên dương n
            //int k;

            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());

            //int kq1 = bai51(k);

            //Console.WriteLine($"S({k}) = {kq1}");
            #endregion

            #region //Bài 52: Tìm chữ số nhỏ nhất của số nguyên dương n
            //int k;

            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());
            //int kq1 = bai52(k);

            //Console.WriteLine($"S({k}) = {kq1}");
            #endregion

            #region //Bài 53: Hãy đếm số lượng chữ số lớn nhất của số nguyên dương n
            //int k;
            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());
            //int kq1 = bai53(k);

            //Console.WriteLine($"S({k}) = {kq1}");
            #endregion

            #region //Bài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không (dùng thuật toán)
            //int n;
            //int s = 0;
            //Console.Write("Cho n = ");
            //n = int.Parse(Console.ReadLine());
            //while (n > 0)
            //{
            //    s = n % 10;
            //    n = n / 10;
            //    if (s % 2 > 0)
            //    {
            //        Console.WriteLine("Đúng");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("sai");
            //        break;
            //    }
            //}
            #endregion

            #region Bài 57: Hãy kiểm tra số nguyên dương n có toàn chữ số chẵn hay không
            //int k;

            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());

            //int kq1 = bai57(k);


            //Dùng thuật toán
            //int n;
            //int s = 0;
            // Console.Write("Cho n = ");
            //n = int.Parse(Console.ReadLine());
            //while (n > 0)
            //{
            //    s = n % 10;
            //    n = n / 10;
            //    if (s % 2 == 0)
            //    {
            //        Console.WriteLine("Đúng");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Sai");
            //        break;
            //    }
            //}
            #endregion

            #region Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng hay không (chư ra kq)
            //int k;
            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());
            //int kq1 = bai59(k);

            //Console.WriteLine($"S({k}) = {kq1}");
            #endregion

            #region Bài 60: Hãy kiểm tra các chữ số của số nguyên dương n có tăng dần từ trái sang phải hay không
            //int k;
            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());
            //int kq1 = bai60(k);
            #endregion

            #region Bài 61: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không
            //int k,l;
            //Console.Write("Cho a = ");
            //k = int.Parse(Console.ReadLine());
            //Console.Write("Cho b = ");
            //l = int.Parse(Console.ReadLine());
            //int kq1 = bai62(k,l);
            #endregion

            #region
            //int k,i=0, j,dapso=0;
            //Console.Write("Cho k = ");
            //k = int.Parse(Console.ReadLine());
            //Console.Write("Cho j = ");
            //j = int.Parse(Console.ReadLine());

            ////while (i <= j)
            ////{
            ////    int kq1 = bai69(k, j);
            ////    if (i % 2 == 0)
            ////    {
            ////        dapso = dapso + kq1;

            ////    }
            ////    dapso = dapso - kq1;
            ////    i++;

            ////}
            //int kq1 = tinhtong(k, j);
            //Console.WriteLine(kq1);
            #endregion

            //    int k,  j, kq;
            //Console.Write("Nhap k = ");
            //k = int.Parse(Console.ReadLine());
            ////Console.Write("Nhap nam = ");
            ////j = int.Parse(Console.ReadLine());
            //double kq1 = bai50(k);

            //Console.WriteLine($"x = {kq1}");


            //Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không

            //  int n;
            //  Console.Write("Nhap k = ");
            //  n = int.Parse(Console.ReadLine());
            //bool  kq = kiemtrasonguyento(n);
            //  Console.WriteLine(kq);

        }    
            
               
                
                                           

                    
                
                
                    
                
                
            



        
    }
}
















// số hoàn thiện là số Số hoàn hảo (hay còn gọi là số hoàn chỉnh, số hoàn thiện hoặc số hoàn thành) là một số nguyên dương mà tổng các ước nguyên dương thực sự của nó (các số nguyên dương bị nó chia hết ngoại trừ nó) bằng chính nó.