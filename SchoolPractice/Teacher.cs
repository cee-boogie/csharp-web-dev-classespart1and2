using System;
namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public override string ToString()
        {
            return $"Teacher Name: {FirstName + " " + LastName} \n" +
                $"Subject: {Subject} \n" +
                $"Years Teaching: {YearsTeaching}";
        }
    }
}
