using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LinkedList
{
    //Tao 1 class NODE , vì là kiểu tham chiếu nên sử dụng class, struct là kiểu tham trị
   
   
    public class Program
    {
        public class NODE
        {
            public int data; 
            public NODE pNext; 
        }
        //Hàm tạo NODE
        static NODE createNODE(int k)
        {
            NODE p = new NODE(); //tạo 1 con trỏ p, lúc này p sẽ trỏ đến 1 vị trí ô nhớ có giá trị rác
            p.data = k; //Con trỏ p sẽ trỏ đến data với giá trị là k
            p.pNext = null; //con trỏ sẽ trỏ đến pNext với giá trị là null
            return p;
        }
        //Tạo hàm in kết quả
        public static void printNode(NODE pHead)
        { 
            for(NODE p = pHead; p != null; p = p.pNext)
            {
                Console.WriteLine(p.data);
            }
        }
        //Hàm thêm giá trị vào đầu NODE
        public static void insertHeadNode(ref NODE pHead, int k)// truyen tham chieu
        {
            NODE pNew = createNODE(k); //Tạo 1 con trỏ pNew với giá trị truyền vào là k
            if (pHead == null)
            {
               
                pHead = pNew;
            }
            else
            {
                pNew.pNext = pHead; //con trỏ pNew sẽ trỏ đến vị trí của pNext và gán vào pHead
                pHead = pNew; //Gán pHead = pNew
            }
        }

        public static NODE findLastNODE(NODE pHead)
        {
            NODE p1 = new NODE();

            for(NODE p = pHead; p != null;p = p.pNext)
            {
                if(p.pNext != null)
                {
                    p1 = p.pNext;
                }
                
            }
            return p1;
        }
        public static void insertTail(ref NODE pHead, int k)
        {
            NODE pNew = createNODE(k); 
            if (pHead == null)
            {

                pHead = pNew;
            }
            else
            {
               NODE p = findLastNODE(pHead); 
                p.pNext = pNew;
            }
        }
        static void Main(string[] args)
        {
            NODE pHead = null; //Tạo 1 danh sách pHead với giá trị đầu tiên là null
            insertHeadNode(ref pHead, 5);//Thêm giá trị vào pHead
            insertHeadNode(ref pHead, 7);//Thêm giá trị vào pHead
            insertHeadNode(ref pHead, 9);//Thêm giá trị vào đầu pHead
            insertTail(ref pHead, 10);
            insertTail(ref pHead, 11);
            printNode(pHead);
        }
    }
}
