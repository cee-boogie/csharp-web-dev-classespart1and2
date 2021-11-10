using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }


        public override string ToString()
        {
            return $"Student Name: {Name} \n" +
                $"Student ID: {StudentId} \n" +
                $"Credits: {NumberOfCredits} \n" +
                $"GPA: {Gpa} \n";
        }

        // Update the appropriate fields: NumberOfCredits, Gpa
        public void AddGrade (int courseCredits, double grade)
        {
            double currentTotalQualityScore = Gpa * NumberOfCredits;
            double addThisToTotalQualityScore = grade * courseCredits;
            double TotalQualityScore = currentTotalQualityScore + addThisToTotalQualityScore;
            NumberOfCredits += courseCredits;
            Gpa = TotalQualityScore / NumberOfCredits;
        }

        // Determine the grade level of the student based on NumberOfCredits
        public string GetGradeLevel()
        {
            if (NumberOfCredits >= 90)
            {
                return "Senior (90+ credits";
            }
            else if (NumberOfCredits >= 60)
            {
                return "Junior (60-89 credits)";
            }
            else if (NumberOfCredits >= 30)
            {
                return "Sophomore (30-59 credits)";
            }
            else if (NumberOfCredits >= 0)
            {
                return "Freshman (0-29 credits)";
            }
            else
            {
                return "Error - unable to compute student's grade level.";
            }

        }
    }
}
