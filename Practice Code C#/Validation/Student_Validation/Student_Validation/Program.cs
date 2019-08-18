using System;

namespace Student_Validation
{
    class StudentValidator
    {
        private static bool ValidStudentID(string input)
        {
            bool result = true;
            foreach (char c in input)
            {
                {
                    if (char.IsDigit(c))
                        result = true; // do something, it is a digit
                    else
                        result = false; // do something else, it isn’t a digit
                }
                {
                    if (input.Length <= 7)
                        result = false;
                    else if (input.Length >= 9)
                        result = true;
                }
            }

            return result;
        }

        private static bool ValidBirthYear(string input)
        {
            bool result = true;

            int d = DateTime.Now.Year;
            int d100 = d - 100;
            int d17 = d - 17;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    result = true; // do something, it is a digit
                else
                    result = false; // do something else, it isn’t a digit
            }
            foreach (char c in input)
            {
                if (input.Length != 4)
                    result = false;
                else if (input.Length == 4)
                    result = true;
            }
            foreach (char c in input)
            {

                if (int.Parse(input) <= d17 && int.Parse(input) >= d100)
                    result = true;
                else
                    result = false;
            }

            return result;
        }

        private static bool ValidBirthMonth(string input)
        {
            bool result = true;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    result = true; // do something, it is a digit
                else
                    result = false; // do something else, it isn’t a digit
            }
            foreach (char c in input)
            {

                if (int.Parse(input) <= 12 && int.Parse(input) >= 1)
                    result = true;
                else
                    result = false;
            }

            return result;

        }

        private static bool ValidBirthDay(string input, string month)
        {
            bool result = true;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    result = true; // do something, it is a digit
                else
                    result = false; // do something else, it isn’t a digit
            }
            {
                if (int.Parse(input) <= 0 || int.Parse(input) >= 32)
                    result = false;
                else
                    result = true;
            }
            return result;


        }

        static void Main(string[] args)
        {
            string studentID;
            Console.Write("Please enter the student ID: ");
            studentID = Console.ReadLine();
            while (ValidStudentID(studentID) == false)
            {
                Console.WriteLine("You have entered an invalid student ID, please try again.");
                Console.Write("Please enter the student ID: ");
                studentID = Console.ReadLine();
            }

            string birthYear;
            Console.Write("Please enter the birth year: ");
            birthYear = Console.ReadLine();
            while (ValidBirthYear(birthYear) == false)
            {
                Console.WriteLine("You have entered an invalid birth year, please try again.");
                Console.Write("Please enter the birth year: ");
                birthYear = Console.ReadLine();
            }

            string birthMonth;
            Console.Write("Please enter the birth month: ");
            birthMonth = Console.ReadLine();
            while (ValidBirthMonth(birthMonth) == false)
            {
                Console.WriteLine("You have entered an invalid birth month, please try again.");
                Console.Write("Please enter the birth month: ");
                birthMonth = Console.ReadLine();
            }

            string birthDay;
            Console.Write("Please enter the birth day: ");
            birthDay = Console.ReadLine();
            while (ValidBirthDay(birthDay, birthMonth) == false)
            {
                Console.WriteLine("You have entered an invalid birth month, please try again.");
                Console.Write("Please enter the birth day: ");
                birthDay = Console.ReadLine();
            }

            Console.WriteLine("Validated data:");
            Console.WriteLine("\tStudent ID: {0}", studentID);
            Console.WriteLine("\tBirth date: {0}/{1}/{2}", birthDay, birthMonth, birthYear);
        }
    }
}
