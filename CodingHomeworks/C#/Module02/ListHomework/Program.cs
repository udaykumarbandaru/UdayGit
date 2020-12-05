using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomework
{
    public class student
    {
        public string name { get; set; }
        public int id { get; set; }

        public string details()
        {
            return $"Name and ID of student is {this.name} and {this.id}";
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            students.Add(new student() { name = "uday", id = 1001 });
            students.Add(new student() { name = "venky", id = 1002 });
            students.Add(new student() { name = "srikanth", id = 1003 });
            students.Add(new student() { name = "mani", id = 1004 });

            Console.WriteLine($"Number of students in class are: {students.Count} ");

            foreach(student aStudent in students)
            {
                Console.WriteLine(aStudent.details());
                Console.WriteLine($"contains: {students.Contains(aStudent)}");
            }

            Console.WriteLine($"contains: {students.Contains(new student { name = "uday", id = 1001 })}");

            students.Insert(4,new student() { name = "Anusha", id = 1005 });
            students.Remove(students[2]);
            students.RemoveAt(1);

            foreach (student aStudent in students)
            {
                Console.WriteLine(aStudent.details());
            }

            Console.ReadLine();
        }
    }
}
