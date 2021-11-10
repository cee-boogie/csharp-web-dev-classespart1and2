using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

           Student christine = new Student
            {
                Name = "Christine",
                StudentId = 2,
                NumberOfCredits = 1,
                Gpa = 4.0
            };

            Student allison = new Student
            {
                Name = "Allison",
                StudentId = 4,
                NumberOfCredits = 1,
                Gpa = 4.0
            };

            Student joe = new Student
            {
                Name = "Joe",
                StudentId = 3,
                NumberOfCredits = 1,
                Gpa = 3.5
            };

            Teacher missDavid = new Teacher
            {
                FirstName = "Miss",
                LastName = "David",
                Subject = "GT",
                YearsTeaching = 20
            };

            Course gt = new Course
            {
                Name = "GT",
                Teacher = "Miss David",
                StudentsById =
                {
                    {christine.StudentId, christine.Name },
                    {allison.StudentId, allison.Name },
                    {joe.StudentId, joe.Name }
                }

            };



            Console.WriteLine(allison.ToString());

            Console.WriteLine(christine.ToString());

            Console.WriteLine($"Christine's grade level is: {christine.GetGradeLevel()} \n");

            christine.AddGrade(4, 2);

            Console.WriteLine(christine.ToString());

            Console.WriteLine(joe.ToString());

            Console.WriteLine(gt.ToString());

            Console.WriteLine(missDavid.ToString());

            

        }
    }
}