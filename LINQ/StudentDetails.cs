using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class StudentDetails
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
                new Student(1, "Raze", 20, "Mysore"),
                new Student(2, "Omen", 30, "Banglore"),
                new Student(3, "Jett", 22, "Chennai"),
                new Student(4, "Reyna", 31, "Hydrabad"),
                new Student(5, "Breach", 40, "Mysore"),
                new Student(6, "Brimstone", 43, "Mysore"),
                new Student(7, "Cypher", 24, "Manglore"),
                new Student(8, "Skye", 26, "Banglore"),
                new Student(9, "Sage", 270, "Mysore"),
                new Student(10, "Sova", 29, "Mumbai")
            };

            Console.WriteLine("List of students are:");
            print(students);
            
            var selectByCityName = from student in students
                                   where (student.City.Contains("a") || student.City.Contains("m")) && student.Id % 2 != 0
                                   orderby student.Name descending
                                   select student;

            Console.WriteLine("\r\nList of students whose names contain 'a' and 'm' are:");
            print(selectByCityName.ToList());
            
        }

        public static void print(List<Student> students)
        {
            foreach (var student in students)
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.City);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Student(int id, string name, int age, string city)
        {
            Id = id;
            Age = age;
            Name = name;
            City = city;
        }
    }
}
