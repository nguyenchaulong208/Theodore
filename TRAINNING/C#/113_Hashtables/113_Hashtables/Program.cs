using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113_Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTables = new Hashtable();
            HashtableData stud1 = new HashtableData(1, "Maria", 98);
            HashtableData stud2 = new HashtableData(2, "Jason", 76);
            HashtableData stud3 = new HashtableData(3, "Clara", 43);
            HashtableData stud4 = new HashtableData(4, "Stve", 55);
            studentTables.Add(stud1.ID, stud1);
            studentTables.Add(stud2.ID, stud2);
            studentTables.Add(stud3.ID, stud3);
            studentTables.Add(stud4.ID, stud4);
            //Lay gia tri tu mot ID biet truoc
            Console.WriteLine("Lay gia tri tu mot ID biet truoc");
            Console.WriteLine("Voi ID la 1 thi gia tri trong Hashtable la: ");
            HashtableData storedStudent = (HashtableData)studentTables[1];
            //Hoac viet nhu the nay
            //HashtableData storedStudent = (HashtableData)studentTables[stud1.ID];
            Console.WriteLine($"{storedStudent.ID} {storedStudent.Name} {storedStudent.GPA}");
            //Lay tat ca gia tri cua Hashtabel
            Console.WriteLine("Lay tat ca gia tri cua Hashtabel");
            foreach(DictionaryEntry entry in studentTables)
            {
                HashtableData temp = (HashtableData)entry.Value;
                Console.Write($"ID: {temp.ID} ");
                Console.Write($"Name: {temp.Name} ");
                Console.Write($"Name: {temp.GPA} ");
                Console.WriteLine();

            }
            Console.WriteLine("<------------------------>");
            //Mot cach viet khac
            Console.WriteLine("Mot cach viet khac:");
            foreach (HashtableData values in studentTables.Values)
            {
                
                Console.Write($"ID: {values.ID} ");
                Console.Write($"Name: {values.Name} ");
                Console.Write($"Name: {values.GPA} ");
                Console.WriteLine();

            }
            Console.WriteLine("<------------------------>");
            //Kiem tra sinh vien da duoc them vao bang chua bang ID, neu trung ID thi bao loi, neu khong trung thi them sinh vien
            Console.WriteLine("Hashtable Challenge");
            Hashtable table = new Hashtable ();
            HashtableData[] students = new HashtableData [4];
            students [0] = new HashtableData(1, "Maria", 98);
            students[1] = new HashtableData(2, "Jason", 76);
            students[2] = new HashtableData(3, "Clara", 43);
            students[3] = new HashtableData(4, "Stve", 55);
            foreach (HashtableData s in students)
            {
                if (!table.ContainsKey(s.ID))
                {
                    table.Add(s.ID, s);
                    Console.WriteLine($"Student with ID {s.ID} was added!");
                }
                else
                {
                    Console.WriteLine($"Sorry, A Student with ID {s.ID} already exists");
                }
            }

        }
    }
}
