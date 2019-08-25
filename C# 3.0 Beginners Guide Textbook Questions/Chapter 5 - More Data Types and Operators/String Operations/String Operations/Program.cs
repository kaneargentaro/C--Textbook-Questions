using System;

namespace String_Operations
{
    class Program
    { 
        static void Main()
        {
            string str1 = "When it comes to .Net programming, C# is #1";
            string str2 = string.Copy(str1);
            string str3 = "C# strings are powerful.";
            int result, idx;

            Console.WriteLine("Length of str1: " + str1.Length + "\n");

            //Display str1, one char at a time
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
            }
            Console.WriteLine("\n");

            if (str1 == str2)
            {
                Console.WriteLine("str1 == str2");
            }
            else
            {
                Console.WriteLine("str1 != str2");

            }
            Console.WriteLine("\n");

            if (str1 == str3)
            {
                Console.WriteLine("str1 == str3");
            }
            else
            {
                Console.WriteLine("str1 != str3");
            }
            Console.WriteLine("\n");

            result = str1.CompareTo(str3);
            if (result == 0)
            {
                Console.WriteLine("str1 and str3 are equal");
            }
            else if (result < 0)
            {
                Console.WriteLine("str1 is less than str3");
            }
            else
            {
                Console.WriteLine("str1 is greater then str3");
            }
            Console.WriteLine("\n");

            str2 = "one two three one";
            idx = str2.IndexOf("one");
            Console.Write("Index of first occurrence of One: " + idx + "\n");
            idx = str2.LastIndexOf("one");
            Console.Write("Index of last occurrence of One: " + idx + "\n");

            //use of substrings, etc.
            string orgstr = "C# makes strings easy";
            //construct a substring
            string substr = orgstr.Substring(5, 12);

            Console.WriteLine("orgstr: " + orgstr);
            Console.WriteLine("substr: " + substr);
        }
    }
}
