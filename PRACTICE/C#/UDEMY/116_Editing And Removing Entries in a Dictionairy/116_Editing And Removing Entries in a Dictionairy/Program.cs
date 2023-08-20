using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116_Editing_And_Removing_Entries_in_a_Dictionairy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentData =
            {
                new Student(1, "Maria", 98),
                new Student(2, "Jason", 76),
                new Student(3, "Clara", 43),
                new Student(4, "Stve", 55),
            };
            
            //Them data bang Dictionary
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            //Duyet HashTable Student va them data
            foreach(Student stud in studentData)
            {
                if (!students.ContainsKey(stud.ID))
                {
                    students.Add(stud.ID, stud);
                    Console.WriteLine($"hoc sinh co ID: {stud.ID} da duoc them vao danh sach!");

                }
                else
                {
                    Console.WriteLine($" ID: {stud.ID} da ton tai trong danh sach!");
                }
                
            }
            //Update data
            int key = 2;
            if(students.ContainsKey(key))
            {
                students[key] = new Student(2, "Mike", 50);
                Console.WriteLine($"ID: {key} da duoc cap nhat!");
            }
            int keyRemove = 3;
            if (students.Remove(keyRemove))
            {
                students[key] = new Student(2, "Mike", 50);
                Console.WriteLine($"ID: {keyRemove} da bi xoa!");
            }
            //Remove

            //Xuat du lieu cua bang students.
            //students va studentData la 2 bang du lieu doc lap khong anh huong nhau.
            for (int i = 0; i < students.Count; i++)
            {
                KeyValuePair<int, Student> keyValuePair = students.ElementAt(i);
                Console.WriteLine($"Key: {keyValuePair.Key}, {i}");
                Student studentValue = keyValuePair.Value;
                Console.WriteLine($"ID: {studentValue.ID}, Name: {studentValue.Name}, GPA: {studentValue.GPA} ");
            }
        }
    }
}
