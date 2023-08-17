using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_MANG
{
    public class Xulymang
    {
        public static int bt122(int[] a)
        {

            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s = Math.Max(s, a[i]);


            }
            return s;
        }
        //public static int bt127(int[] a)
        //{
        //    int c;
        //    //dùng 2 vòng lặp để so sánh và lấy số tăng dần
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        // dùng j tìm a[j] nhỏ nhất từ i+1 tới n
        //        //     lên a[1] thì tìm giá trị nhỏ nhất từ a[2] tới a[nư
        //        //      nếu như số nhập sau bé hơn số nhập trước thì lúc này c (số cần viết ra) sẽ là số b [j]
        //        for (int j = i + 1; j < a.Length; j++)

        //            if (a[j] < a[i])
        //            {
        //                c = a[i];
        //                a[i] = a[j];
        //                a[j] = c;
        //            }
        //        return a[i];
        //    }

        //    return int.getvalue.a;


        //}

        //Bài 169 (*): Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số chẵn nhỏ nhất lớn hơn mọi giá trị có trong mảng

       
        //+ tìm số chẵn
        //+ Tìm số lớn nhất

        public static int bt169(int[] a)
        {
            int j, k, max = a[0];
            //tìm số lớn nhất

            for (int i = 0; i < a.Length; i++)
            {
                k = a[i] % 2;
                
                    if ( a[i] > max && k ==0 )
                    {
                        max = a[i] + 2;
                         
                    }
                    else
                    {
                    max = a[i] + 1;
                    }    
              

                
                
            }
            return max;
        }
        //Bài 170: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số nguyên tố nhỏ nhất lớn hơn mọi giá trị có trong mảng
        //( ý tưởng: Tìm số lớn nhất = A. A tăng lên 1 cho đến khi tìm được số nguyên tố)
        //public static int bt170(int[] a)
        //{
        //    int k, l;
        //    int max = a[0];
        //    //tìm số lớn nhất
        //    for(int i = 0; i < a.Length; i++)
        //    {
        //        if ( a[i] > max )
        //        {
        //            max = a[i]++;
        //        }

        //        //tìm số nguyên tố đầu tiên
                
        //        for (int j = 0; j < a.Length; j++)
        //        {
        //            max ++;
        //            if (l % 2 > 0 && l % l == 0)
        //            {
        //                max = l;
        //            }
        //        }
        //        return l;
        //    }  
        //    return max;
        //}

        //Bài 141: Hãy tìm vị trí giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về  -1

        public static int bt141(int[] a)
        {
            int min = -1;
            for(int i = 0; i < a.Length; i++)
            { 
                if(a[i] > 0);
                {
                    min = i;
                    break;
                }
            
            } 
            if (min >= 0)
            {
                for(int i = min + 1; i < a.Length; i++)
                {
                    if (a[i] > 0 && a[i] < a[min])
                    {
                        min = i;
                    }    
                }
                
            }
            return min;
        }
    }

}

