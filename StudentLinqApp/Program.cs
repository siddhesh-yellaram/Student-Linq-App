using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLinqApp.Model;

namespace StudentLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>(
                    new Student[]
                    {
                        new Student{Name = "Sid", CGPA = 8.95, Location = "Mumbai"},
                        new Student{Name = "Bruce", CGPA = 9.21, Location = "NYC"},
                        new Student{Name = "Rahul", CGPA = 8.64, Location = "Pune"},
                        new Student{Name = "Clark", CGPA = 8.91, Location = "NYC"},
                        new Student{Name = "Tina", CGPA = 8.45, Location = "Pune"},
                        new Student{Name = "Ram", CGPA = 8.5, Location = "Mumbai"},
                        new Student{Name = "Pankaj", CGPA = 8.54, Location = "Mumbai"},
                        new Student{Name = "Anirudh", CGPA = 8.14, Location = "Mumbai"},
                        new Student{Name = "Dev", CGPA = 8.24, Location = "Mumbai"},
                    }
                );

            //Display top 5 students with highest cgpa.
            var first5Students = stud.Where(s => s.CGPA > 8.5).Take(5);
            Console.Write("Top 5 student with highest CGPA: ");
            foreach(var n in first5Students)
            {
                Console.Write(n.Name+" ");
            }
            Console.WriteLine();

            //Display All Student with location Mumbai.
            var studentLoc = stud.Where(s => s.Location == "Mumbai");
            Console.Write("Students with Location Mumbai: ");
            foreach (var n in studentLoc)
            {
                Console.Write(n.Name+" ");
            }
            Console.WriteLine();

            //Display All Student with location Mumbai in ascending order.
            var studAscen = stud.Where(s => s.Location == "Mumbai").OrderBy(s => s.Name);
            Console.Write("Students with Location Mumbai in Ascending order: ");
            foreach (var n in studAscen)
            {
                Console.Write(n.Name + " ");
            }
            Console.WriteLine();

            //Display All Student Name and CGPA Only.
            var studDet = stud.Select(s => $"Name: {s.Name} CGPA: {s.CGPA}");
            Console.WriteLine("All Students with Name & CGPA: ");
            foreach (var n in studDet)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
