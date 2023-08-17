using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //Du lieu 1
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Du lieu 2
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 18, City = "HO CHI MINH"},
                new Student { Name = "Bob", Age = 22, City = "CAN THO"},
                new Student { Name = "Charlie", Age = 19, City ="NHA TRANG"},
                new Student { Name = "David", Age = 25, City = "HO CHI MINH" },
                new Student { Name = "Eva", Age = 20, City = "HO CHI MINH"},
                new Student { Name = "Adam", Age = 16, City = "HA NOI"}
            };

            Console.WriteLine("1. Bai 1: Cho 1 mang so nguyen, viet 1 bieu thuc lambda de tinh tong cac so chan");
            Console.WriteLine("2. Bai 2: Loc danh sach sinh vien");
            Console.WriteLine("3. Bai 3: Loc danh sach sinh vien theo thu tu tu A -> Z (Dung du lieu bai 2)");
            Console.WriteLine("4. Bai 4: Tinh tong binh phuong cac so (dung du lieu bai 1)");
            Console.WriteLine("5. Bai 5: Loc danh sach sinh vien co tuoi lon hon 19 va que HO CHI MINH (Dung du lieu bai 2)");
            Console.WriteLine("6. Bai 6: Viet 1 bieu thuc lambda de chuyen doi nhiet do tu do C sang do F\n cho truoc cong thuc chuyen doi: F = C *  9/5 + 32");
            Console.WriteLine("7. Bai 7: Su dung Func và Action \nSu dung Func de viet 1 phuong thuc tinh tong 2 so, dung Action de in 1 chuoi ra man hinh.");
 
             Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Chon bai can lam");
            int BT = int.Parse(Console.ReadLine());
            switch(BT)
            {
                case 1:
                    Console.WriteLine("\n-------------------");

                    int[] find = numbers.Where(number => number % 2 == 0).ToArray();
                    Console.WriteLine("------\nCac so chan la");
                    foreach (int s in find)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                 case 2:

                    Console.WriteLine("\n-------------------");

                    var filterStudent = students.Where(st => st.Age > 20).ToList();
                    foreach (Student student in filterStudent)
                    {
                        Console.WriteLine(student.Name);
                    }
                    break;
                case 3:

                    Console.WriteLine("\n-------------------");
                    var sortStudent = students.OrderBy(student => student.Name).ToList();
                    Console.WriteLine("Sinh vien sau sap xep:");
                    foreach (var student in sortStudent)
                    {
                        Console.WriteLine(student.Name);
                    }
                    
                    
                    break;
                case 4:
                    Console.WriteLine("\n-------------------");
                    var sum = numbers.Sum(s => Math.Pow(s, 2));
                    Console.WriteLine(sum);
                    break;
                case 5:
                    Console.WriteLine("\n-------------------");
                    var filterStudents = students.Where(student => student.Age > 19 && student.City == "HO CHI MINH").ToList();
                    foreach (var student in filterStudents)
                    {
                        Console.WriteLine($"{student.Name} - {student.City}");
                    }
                    break;
                case 6:
                    Console.WriteLine("\n-------------------");
                    Console.WriteLine("Nhap vao nhiet do C: ");
                    float a = int.Parse(Console.ReadLine());
                    //Dùng Func<T in, T out>
                    Func<float, float> F = s => s * (9 / 5) + 32;
                    //Gan so a vao cong thuc F
                    float fahrenheit = F(a);
                    Console.WriteLine(fahrenheit);

                    Console.WriteLine("\n-------------------");
                    break;
            }
                
            
            



        }


    }
}
