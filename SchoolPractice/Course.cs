using System;
using System.Linq;
using System.Collections.Generic;
namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public List<string> Students { get; set; }
        public Dictionary<int, string> StudentsById = new Dictionary<int, string>
        {

        };

        public override string ToString()
        {
            string roster = string.Join(", ", StudentsById);
            return $"Course Name: {Name} \n" +
                $"Teacher: {Teacher} \n" +
                $"Students: {roster} \n";
        }

    }
}
