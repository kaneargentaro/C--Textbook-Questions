using System;
using System.Collections.Generic;

namespace Math_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numberlist = new List<string>();
            string input;
            double meannumber = 0;


            Console.Write("Please enter a number or END to finish: ");
            input = Console.ReadLine();

            while (input.ToUpper() != "END")
            {
                numberlist.Add(input);
                meannumber++;
                Console.Write("Please enter a string or END to finish: ");
                input = Console.ReadLine();
            }

            List<double> newnumberlist = numberlist.ConvertAll(item => double.Parse(item));

            newnumberlist.Sort();
            Console.WriteLine("Sorted numbers that have been entered:");
            foreach (double s in newnumberlist)
            {
                Console.WriteLine("\t" + s);
            }

            double sumnumber = 0;
            foreach (double s in newnumberlist)
            {
                sumnumber += s;
            }

            double result1, result2, result3, y = 0, answer1 = 0, answer2 = 0;

            result1 = sumnumber / meannumber;

            List<double> resultlist = new List<double>();
            foreach (double s in newnumberlist)
            {
                result2 = s - result1;
                resultlist.Add(result2);
            }
            List<double> resultlistpowered = new List<double>();
            foreach (double s in resultlist)
            {
                result3 = (s) * (s);
                resultlistpowered.Add(result3);
            }
            foreach (double s in resultlistpowered)
            {
                y += s;
            }

            Console.WriteLine("The sum of all numbers entered are: {0}", y);

            answer1 = Math.Sqrt(y / (meannumber - 1));

            Console.WriteLine("The standard deviation of the numbers entered is: {0}", answer1);
        }
    }
}
