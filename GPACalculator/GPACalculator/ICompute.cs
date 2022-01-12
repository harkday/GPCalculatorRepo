namespace GPACalculator
{
    public interface ICompute
    {
        int Count { get; set; }
        string CourseCode { get; set; }
        byte CourseUnit { get; set; }
        char GradeType { get; set; }
        byte GradeUnit { get; set; }

        void AddCourse();
        void CalculateGPA();
        void GetCourses();
    }
}