using System;
using System.Collections.Generic;
using System.Text;

namespace Copy_String
{
    class copystr
    {
        static string CopyStr(string first, ref string second)
        {
            second = String.Copy(first);
            Console.WriteLine(first + ", " + second);
            return second;
        }
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "im good lol";

            Console.WriteLine(str1 + ", " + str2);

            CopyStr(str1, ref str2);

            Console.WriteLine(str1 + ", " + str2);


        }
    }
}
