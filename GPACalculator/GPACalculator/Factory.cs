using System;
using System.Collections.Generic;
using System.Text;

namespace GPACalculator
{
    class Factory
    {
        /// <summary>
        /// THIS IS A FACTORY CLASS CREATED TO FACILITATE DEPENDENCY INJECTION. 
        /// </summary>
        
        public static IGrade grade;
        public static IInput newInput;
        public static ICompute compute;
        public static ICourse course;
        
        public static IInput CreateUserInput()
        {
            if (newInput == null) newInput = new Input();
            return new Input();
        }

        public static ICompute CreateComputation()
        {
            if (compute == null) compute = new Compute();
            return new Compute();
        }

        public static ICourse CreateCourse(string courseCode, byte courseUnit, char grade)
        {
            if (course == null) course = new Course(courseCode, courseUnit, grade);
            return new Course(courseCode, courseUnit, grade);
        }

        public static IGrade CreateGrade()
        {
            if(grade == null) grade = new Grade();
            return grade;
        }
    }
}
