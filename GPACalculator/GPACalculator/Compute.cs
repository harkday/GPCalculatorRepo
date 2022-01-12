using System;
using System.Collections.Generic;
using System.Linq;

namespace GPACalculator
{
    public class Compute : ICompute
    {
        /// <summary>
        /// THIS CLASS COMPUTES AND VALIDATES USERS' INPUT.
        /// </summary>
        
        public string CourseCode { get; set; }
        public byte CourseUnit { get; set; }
        public char GradeType { get; set; }
        public byte GradeUnit { get; set; }
        public int Count { get; set; }

        public List<Course> courses = new List<Course>();
        readonly IInput newInput = Factory.CreateUserInput();
        readonly IGrade grade = Factory.CreateGrade();

        public void AddCourse()
        {

            Console.Write("Please Enter Total Number of Courses- ");
            int numberOfCourses = Int32.Parse(Console.ReadLine());

            while (Count < numberOfCourses)
            {
                var CourseCode = newInput.AddCourseCode();
                var CourseUnit = newInput.AddCourseUnit();
                var Grade = grade.GradeSystem(newInput.AddCourseScore());

                if (courses.Where(cos => cos.CourseCode == CourseCode).Count() != 0)
                {
                    Console.WriteLine("Course already exist");
                }
                else
                {
                    ICourse newCourse = Factory.CreateCourse(CourseCode, CourseUnit, Grade);
                    courses.Add((Course)newCourse);
                    Count++;
                }
            }

        }

        public void GetCourses()
        {
            foreach (var course in courses) Console.WriteLine($"CourseCode: {course.CourseCode} |" +
                $" CourseUnit: {course.CourseUnit} | Grade: {course.GradeType} | GradeUnit: {course.GradeUnit}");

        }

        public void CalculateGPA()
        {
            grade.QualityPoint(courses);
            grade.AccumulatedGradeUnit(courses);

            double cgpa = (double)grade.TotalQualityPoint / grade.TotalGradeUnit;
            Console.WriteLine($"Your GPA {cgpa}");

        }
    }
}
