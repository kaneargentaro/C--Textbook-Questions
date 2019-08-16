using System;
/*
 * Future Updates:
 * - starts with
 * - ends with
 * - index of
 * - substring
 * - contains
 * (get secondary input and compare the above
 * 
 */
namespace Manipulate_Strings
{
    class Program
    {
        static bool Validation(string x)
        {
            bool xValidated = false;

            if (String.IsNullOrEmpty(x))
            {
                Console.WriteLine("No string stored. Please enter a string first via (1) in the menu. \n");
                xValidated = false;
            }

            else
            {
                xValidated = true;
            }

            return xValidated;
        }
        static string InputString(ref string x)
        {
            Console.Write("Please enter a string: ");
            x = Console.ReadLine();
            Console.WriteLine("You have entered the string '" + x + "' \n");
            return x;
        }

        static void ExitMessage()
        {
            Console.WriteLine("You have chosen to exit the program.");
            Console.WriteLine("Thank you for using this program. The program will now close.");
        }

        static string StringToUpper(ref string x)
        {
            if (Validation(x) == true)
            {
                x = x.ToUpper();
            Console.WriteLine("The string has been changed to: '" + x + "' \n");
            }

            return x;
        }

        static string StringToLower(ref string x)
        {
            if (Validation(x) == true)
            {
                x = x.ToLower();
                Console.WriteLine("The string has been changed to: '" + x + "' \n");
            }
            return x;
        }

        static void DisplayString(string x)
        {
            if (Validation(x) == true)
            {
                Console.WriteLine("The string is: '" + x + "' \n");
            }
        }

        static string SortString(ref string x)
        {
            if (Validation(x) == true)
            {
                //split current string by white spaces into an array
                string[] arr = x.Split();

                Console.WriteLine();
                //sort array
                Array.Sort(arr);

                //store sorted array back to string x
                x = string.Join(" ", arr);

                Console.WriteLine("The string has been changed to: '" + x + "' \n");
            }
            return x;
        }
        static void Main(string[] args)
        {
            //input
            string menu;
            string userString = "";

            //induction message
            Console.WriteLine("Welcome to the string manipulation program");

            //infinite loop
            for (; ; )
            {
                Console.WriteLine("(1) to Add a String (Must add a string before beginning!)");
                Console.WriteLine("(2) Convert String to UpperCase");
                Console.WriteLine("(3) Convert String to LowerCase");
                Console.WriteLine("(4) Display Current String");
                Console.WriteLine("(5) Sort Current String");
                Console.WriteLine("(x) to Exit");
                //get users choice
                Console.Write("Users Choice: ");
                menu = Console.ReadLine();
                Console.WriteLine();
                //convert users choice to lower case
                menu = menu.ToLower();

                if (menu == "1")
                {
                    InputString(ref userString);
                }
                
                else if (menu == "2")
                {
                    StringToUpper(ref userString);
                }

                else if (menu == "3")
                {
                   StringToLower(ref userString);
                }

                else if (menu == "4")
                {
                    DisplayString(userString);
                }

                else if (menu == "5")
                {
                    SortString(ref userString);
                }

                else if (menu == "x")
                {
                    ExitMessage();
                    break;
                }

            } 
           
        }
    }
}
