using System;
using System.Collections.Generic;
using System.Text;

namespace GPACalculator
{
    public class Course : ICourse
    {
        public string CourseCode { get; set; }
        public byte CourseUnit { get; set; }
        public char GradeType { get; set; }
        public byte GradeUnit { get; set; }
        public int QualityPoint { get; set; }

        readonly IGrade grade = Factory.CreateGrade();

        public Course(string courseCode, byte courseUnit, char courseGrade)
        {
            CourseCode = courseCode;
            CourseUnit = courseUnit;
            GradeType = courseGrade;
            GradeUnit = grade.AddGradeUnit(GradeType);
            QualityPoint = grade.QualityPoint(CourseUnit, GradeUnit);
        }
    }
}
