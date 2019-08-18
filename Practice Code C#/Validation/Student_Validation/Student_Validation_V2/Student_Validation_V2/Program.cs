using System;

namespace Student_Validation_V2
{
    class StudentValidator
    {
        #region Helper Methods
        private static bool AllDigits(string input)
        {
            bool result = true;

            foreach (char c in input)
            {
                if (char.IsDigit(c) == false)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static bool InRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
        #endregion

        private static bool ValidStudentID(string input)
        {
            bool result = true;

            if (input.Length < 8 || input.Length > 9 || AllDigits(input) == false)
                result = false;

            return result;
        }

        private static bool ValidStudentGrade(int input)
        {
            bool result = true;

            if (input < 0 || input > 100)
                result = false;

            return result;
        }

        private static bool ValidStudentName(string input)
        {
            bool result = true;

            if (input.Length < 1 || input.Length > 15 || AllDigits(input) == true)
                result = false;

            return result;
        }

        private static bool Valid_Number(string input)
        {
            bool result = true;

            if (input.Length < 9 || input.Length > 11 || AllDigits(input) == false)
                result = false;

            return result;
        }

        private static bool ValidBirthYear(string input)
        {
            bool result = true;

            int minYear = DateTime.Now.Year - 100;
            int maxYear = DateTime.Now.Year - 17;
            if (AllDigits(input) == false || InRange(Convert.ToInt32(input), minYear, maxYear) == false)
                result = false;

            return result;
        }

        private static bool ValidBirthMonth(string input)
        {
            bool result = true;

            if (AllDigits(input) == false || InRange(Convert.ToInt32(input), 1, 12) == false)
                result = false;

            return result;
        }

        private static bool ValidBirthDay(string input, string month)
        {
            bool result = true;
            byte[] daysInMonth = new byte[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int monthNum = Convert.ToInt32(month);

            if (AllDigits(input) == false || InRange(Convert.ToInt32(input), 1, daysInMonth[monthNum - 1]) == false)
                result = false;

            return result;

        }

        static void Main(string[] args)
        {

            string _ID;
            Console.Write("Please enter the student ID: ");
            _ID = Console.ReadLine();
            while (ValidStudentID(_ID) == false)
            {
                Console.WriteLine("You have entered an invalid student ID, please try again. Student ID must contain 8 digits.");
                Console.Write("Please enter the student ID: ");
                _ID = Console.ReadLine();
            }

            string _Name;
            Console.Write("Please enter the students Name: ");
            _Name = Console.ReadLine();
            while (ValidStudentName(_Name) == false)
            {
                Console.WriteLine("You have entered an invalid student Name, please try again.");
                Console.Write("Please enter the students given name: ");
                _Name = Console.ReadLine();
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

            string _Number;
            Console.Write("Please enter the students phone number: ");
            _Number = Console.ReadLine();
            while (Valid_Number(_Number) == false)
            {
                Console.WriteLine("You have entered an invalid student phone number, please try again. Phone number must be 10 digits. (eg. 0421346573)");
                Console.Write("Please enter the students phone number: ");
                _Number = Console.ReadLine();
            }


            int _Grade1 = 0;
            bool ok = false;
            do
            {
                try
                {
                    Console.Write("Please enter the students grade for class 1: ");
                    _Grade1 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                    ok = false;
                }
            } while (ok == false);


            int _Grade2 = 0;
            ok = false;
            do
            {
                try
                {
                    Console.Write("Please enter the students grade for class 2: ");
                    _Grade2 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                    ok = false;
                }
            } while (ok == false);

            int _Grade3 = 0;
            ok = false;
            do
            {
                try
                {
                    Console.Write("Please enter the students grade for class 3: ");
                    _Grade3 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                    ok = false;
                }
            } while (ok == false);

            int _Grade4 = 0;
            ok = false;
            do
            {
                try
                {
                    Console.Write("Please enter the students grade for class 4: ");
                    _Grade4 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                    ok = false;
                }
            } while (ok == false);

            Student student1 = new Student(_ID, _Name, _Number, _Grade1, _Grade2, _Grade3, _Grade4, birthDay + "/" + birthMonth + "/" + birthYear);
            Console.WriteLine(student1);    
        }
    }
}