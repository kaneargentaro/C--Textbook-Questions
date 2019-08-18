using System;
using System.Collections.Generic;


namespace Stock_Books
{
    class Program
    {
        static void ProduceReport()
        {
            string[] quantity = { "5", "50", "500" };
            string[] description = { "Visual C#: How to Program", "Database Systems", "HTML & XHTML: The Complete Reference" };
            double[] price = { 134.95, 119.95, 72 };
            string asterisks = new string('#', 68);

            Console.WriteLine(asterisks);
            Console.WriteLine("# {0,3} # {1,9}{2,49}", "Qty", "Description", "#     Cost     #");
            Console.WriteLine(asterisks);
            for (int counter = 0; counter <3; ++counter)
            {
                Console.WriteLine("# {0,-3} # {1,-44}{2, -5}{3,-10:c}{4,-5}", quantity[counter], description[counter], "#", price[counter], "#");
            }
            Console.WriteLine(asterisks);

        }
        static void Main(string[] args)
        {
            Program.ProduceReport();
        }
    }
}
