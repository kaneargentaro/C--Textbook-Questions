using System;
/*
 * C# : 3.0 : A BEGINNER'S GUIDE - TEXTBOOK
 * CHAPTER 1 SELF TEST QUESTION 12
 * CREATE A PROGRAM THAT CONVERST INCHES TO METERES 
 * WITH A BLANK LINE EVERY 12 LINES OF OUTPUT.
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable for inches and for meters
            double m;
            int i, f = 0;
            //counter variable
            int count = 0;
            
            //for statement to keep looping until 12 feet reached 
            //start at i=1 so we start at the first inch, instead of starting at 0 inches
            //(1 foot = 12 inches, therefore 12 feet = 144 inches + 1 because we're skipping 0) 
            for (i = 1; i < 145; i++)
            {
                //1 meter = 39.37 inches, therefore 1 inch equals to 25.4cm
                m = i * 0.0254;
                if ((i % 12) != 0)
                {
                    Console.WriteLine(i + " inches equals to " + m + " meters");
                }
                //if f = 0, then the next value will be 1
                //display foot instead of feet 
                else if (f == 0)
                {
                    f = i / 12;
                    Console.WriteLine(i + " inches (" + f + " foot) equals to " + m + " meters");
                }
                //f=0-12 excluding 1
                else
                {
                    f = i / 12;
                    Console.WriteLine(i + " inches (" + f + " feet) equals to " + m + " meters");
                }

                count++;
                if (count == 12)
                {
                    Console.WriteLine();
                    count = 0;
                }
                
            }
        }
    }
}
