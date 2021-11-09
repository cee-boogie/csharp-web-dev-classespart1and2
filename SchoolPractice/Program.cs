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



            string roster = string.Join(", ", gt.StudentsById);

            Console.WriteLine($"Student Name: {christine.Name} \n" +
                $"Student ID: {christine.StudentId} \n" +
                $"Credits: {christine.NumberOfCredits} \n" +
                $"GPA: {christine.Gpa} \n");


            Console.WriteLine($"Course Name: {gt.Name} \n" +
                $"Teacher: {gt.Teacher} \n" +
                $"Students: {roster} \n");

            Console.WriteLine($"Teacher Name: {missDavid.FirstName + " " + missDavid.LastName} \n" +
                $"Subject: {missDavid.Subject} \n" +
                $"Years Teaching: {missDavid.YearsTeaching}");

        }
    }
}