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

    }
}
