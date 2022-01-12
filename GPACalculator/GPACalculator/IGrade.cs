using System.Collections.Generic;

namespace GPACalculator
{
    interface IGrade
    {
        char GradeType { get; set; }
        byte GradeUnit { get; set; }
        int TotalGradeUnit { get; set; }
        int TotalQualityPoint { get; set; }

        void AccumulatedGradeUnit(List<Course> courses);
        byte AddGradeUnit(char gradeType);
        char GradeSystem(int CourseScore);
        int QualityPoint(byte courseUnit, byte gradeUnit);
        void QualityPoint(List<Course> courses);
    }
}