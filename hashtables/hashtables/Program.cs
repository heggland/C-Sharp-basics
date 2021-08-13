using System;
using System.Collections;

namespace hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 16);
            Student stud2 = new Student(2, "Ola", 86);
            Student stud3 = new Student(3, "Jim", 66);
            Student stud4 = new Student(4, "Leif", 12);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];
            
            Console.WriteLine(storedStudent1.Id + storedStudent1.Name + storedStudent1.GPA);

            // retrive all values from a hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine(temp.Id);
                Console.WriteLine(temp.Name);
                Console.WriteLine(temp.GPA);
            }

            // another way to retrive all values from a hashtable
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine(value.Id);
                Console.WriteLine(value.Name);
                Console.WriteLine(value.GPA);
            }
            */

            Challange();

        }

        static void Challange()
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Dennis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luice", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();

            foreach (var item in students)
            {
                if (!studentsTable.ContainsKey(item.Id))
                {
                    Student stud = new Student(item.Id, item.Name, item.GPA);

                    studentsTable.Add(stud.Id, stud);

                    Console.WriteLine($"Student with ID {stud.Id} added.");
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same ID already exsists ID: " +
                        $"{item.Id} - {item.Name}\n");
                }
            }

            Console.WriteLine("\nStudentstable:");

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"ID: {value.Id} " +
                    $"Name: {value.Name} " +
                    $"GPA: {value.GPA}");
            }
        }

    }
}
