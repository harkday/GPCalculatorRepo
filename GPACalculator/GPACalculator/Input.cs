using System;
using System.Text.RegularExpressions;

namespace GPACalculator
{
    public class Input : IInput
    {
        public static Boolean isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[A-Z]{3}[0-9]{3}$");
            return rg.IsMatch(strToCheck);
        }

        public string AddCourseCode()
        {
            Console.Write("Please Enter Course Code- ");
            string courseCode = Console.ReadLine();

            if (!isAlphaNumeric(courseCode))
            {
                Console.WriteLine("Please Check The Course Code Again. Course Code should consist of 3 uppercase alphabets and 3 digits with no space between them.");
                AddCourseCode();
            }

            return courseCode;
        }

        public byte AddCourseUnit()
        {
            Console.Write("Please Enter Course Unit- ");
            byte courseUnit;
            bool unit = byte.TryParse(Console.ReadLine(), out courseUnit);

            if (unit == false && courseUnit < 1 || courseUnit > 6)
            {
                Console.WriteLine("Please Check The Course Unit Again. Course Unit should be between 1 and 6.");
                AddCourseUnit();
            }

            return courseUnit;
        }

        public int AddCourseScore()
        {
            Console.Write("Please Enter the Score- ");
            int courseScore;
            bool score = int.TryParse(Console.ReadLine(), out courseScore);

            if (score == false && courseScore < 0 || courseScore > 100)
            {
                Console.WriteLine("Please Check The Course Score Again. Course Score should be between 0 and 100.");
                AddCourseScore();
            }

            return courseScore;
        }

    }
}
