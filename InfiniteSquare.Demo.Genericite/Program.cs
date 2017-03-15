using InfiniteSquare.Demo.Genericite.Models;
using System;
using System.Collections.Generic;

namespace InfiniteSquare.Demo.Genericite
{
    class Program
    {
        static void Main(string[] args)
        {

            // Let's initialize our examples : 
            var schoolYear = InitSchoolYear();
            var classRoom = InitClassRoom();


            // Student and Course both inherit CustomEnumerable
            // We have only one definition of the CustomEnumerator, but it can handle any Enumeration of CustomEnumerable
            // So we can Enumerate through both the schoolYear's courses and the classRoom's students with the same CustomEnumerator

            foreach (Course c in schoolYear)
            {
                Console.WriteLine(c.Name + " " + c.Level);
            }
            foreach (Student s in classRoom)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }
            Console.ReadLine();
        }


        static SchoolYear InitSchoolYear()
        {
            return new SchoolYear()
            {
                Year = 2016,
                Courses = new List<CustomEnumerable>() {
                    new Course() { Name = ".NET Introduction", Level = 2 },
                    new Course() { Name = "ASP.NET", Level = 3 },
                    new Course() { Name = "Windows Phone Dev", Level = 3 }
                }
            };
        }

        static ClassRoom InitClassRoom()
        {
            return new ClassRoom()
            {
                Students = new List<CustomEnumerable>() {
                    new Student() { FirstName = "John", LastName = "Doe" },
                    new Student() { FirstName = "Jack", LastName = "Harkness" },
                    new Student() { FirstName = "Billie", LastName = "Piper" }
                }
            };
        }
    }
}
