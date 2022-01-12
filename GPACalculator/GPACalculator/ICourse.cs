namespace GPACalculator
{
    public interface ICourse
    {
        string CourseCode { get; set; }
        byte CourseUnit { get; set; }
        char GradeType { get; set; }
        byte GradeUnit { get; set; }
        int QualityPoint { get; set; }
    }
}