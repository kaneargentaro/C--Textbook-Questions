using System;

/*
 * C# 3.0: A BEGINNER'S GUIDE EBOOK
 * LOCATION 1800 of 11536
 * CHAPTER 2 QUESTION
 * "Try this display a truth table for the logical operators"
 */


namespace LogicalOpTable
{
    class Program
    {
        static int Conv(bool p)
        {
            int temp = 2;
            if (p == true)
            {
                temp = 1;
            }
            else if (p == false)
            {
                temp = 0;
            }
            return temp;
        }

        static void Main(string[] args)
        {
            bool p, q;
            Console.WriteLine("P\tQ\tAND\tOR\tXOR\tNOT\t");

            p = true;
            q = true;

            Console.Write(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p) + "\n");

            p = true;
            q = false;

            Console.Write(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p) + "\n");

            p = false;
            q = true;

            Console.Write(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p) + "\n");

            p = false;
            q = false;

            Console.Write(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p) + "\n");

            Console.WriteLine("\nTrue = 1, false = 0");
            Console.WriteLine("P\tQ\tAND\tOR\tXOR\tNOT\t");

            p = true;
            q = true;
            
            Console.Write(Conv(p) + "\t" + Conv(q) + "\t" + Conv(p & q) + "\t" + Conv(p | q) + "\t" + Conv(p ^ q) + "\t" + Conv(!p) + "\n");

            p = true;
            q = false;

            Console.Write(Conv(p) + "\t" + Conv(q) + "\t" + Conv(p & q) + "\t" + Conv(p | q) + "\t" + Conv(p ^ q) + "\t" + Conv(!p) + "\n");

            p = false;
            q = true;

            Console.Write(Conv(p) + "\t" + Conv(q) + "\t" + Conv(p & q) + "\t" + Conv(p | q) + "\t" + Conv(p ^ q) + "\t" + Conv(!p) + "\n");

            p = false;
            q = false;

            Console.Write(Conv(p) + "\t" + Conv(q) + "\t" + Conv(p & q) + "\t" + Conv(p | q) + "\t" + Conv(p ^ q) + "\t" + Conv(!p) + "\n");
        }
    }
}
