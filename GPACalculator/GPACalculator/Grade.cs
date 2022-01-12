using System;
using System.Collections.Generic;
using System.Text;

namespace GPACalculator
{
    class Grade : IGrade
    {
        public char GradeType { get; set; }

        public byte GradeUnit { get; set; }

        public int TotalQualityPoint { get; set; }

        public int TotalGradeUnit { get; set; }

        readonly IInput newInput = Factory.CreateUserInput();

        public char GradeSystem(int CourseScore)
        {
            int score = CourseScore;
            if (score <= 100 && score >= 70)
            {
                GradeType = Grades.A.ToString()[0];
            }
            else if (score < 69 && score >= 60)
            {
                GradeType = Grades.B.ToString()[0];
            }
            else if (score < 59 && score >= 50)
            {
                GradeType = Grades.C.ToString()[0];
            }
            else if (score < 49 && score >= 45)
            {
                GradeType = Grades.D.ToString()[0];
            }
            else if (score < 44 && score >= 40)
            {
                GradeType = Grades.E.ToString()[0];
            }
            else
            {
                GradeType = Grades.F.ToString()[0];
            }
            return GradeType;
        }

        public byte AddGradeUnit(char gradeType)
        {
            byte gradeUnit = 0;
            if (gradeType.ToString() == nameof(Grades.A)) gradeUnit = (byte)Grades.A;
            else if (gradeType.ToString() == nameof(Grades.B)) gradeUnit = (byte)Grades.B;
            else if (gradeType.ToString() == nameof(Grades.C)) gradeUnit = (byte)Grades.C;
            else if (gradeType.ToString() == nameof(Grades.D)) gradeUnit = (byte)Grades.D;
            else if (gradeType.ToString() == nameof(Grades.E)) gradeUnit = (byte)Grades.E;
            else gradeUnit = (byte)Grades.F;

            return gradeUnit;
        }

        public int QualityPoint(byte courseUnit, byte gradeUnit)
        {
            int qualityPoint = courseUnit * gradeUnit;
            return qualityPoint;
        }

        public void QualityPoint(List<Course> courses)
        {
            TotalQualityPoint = 0;

            foreach (var course in courses)
            {
                TotalQualityPoint += course.QualityPoint;
            }
        }

        public void AccumulatedGradeUnit(List<Course> courses)
        {
            //int unitPassed = TotalGradeUnit;

            foreach (var course in courses)
            {
                //if (course.GradeType == 'F')
                //{
                //    unitPassed -= course.CourseUnit;
                //}
                TotalGradeUnit += course.CourseUnit;
            }
        }

    }
}
