using System;
using System.Collections.Generic;

namespace GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************** Grade Point Average (GPA) Calculator **********************");
            Console.WriteLine("\n********************** GuideLines **********************\n");
            Console.WriteLine("1. Enter Number of Courses ");
            Console.WriteLine("2. Enter The Course Code. The Course Code should contain three(3) Uppercase letters and three(3) numbers with no whitespace.");
            Console.WriteLine("3. Enter The Course Unit. The Course Unit should be a number between 1 and 6");
            Console.WriteLine("4. Enter The Course Score. The Course Score should be a number between 0 and 100\n");

            ICompute compute = Factory.CreateComputation();

            compute.AddCourse();
            compute.GetCourses();
            compute.CalculateGPA();

            Console.WriteLine("&copy; Bolanle Ayodeji Oladapo");
        }
    }
}
