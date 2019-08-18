using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            //positive integar N
            int N = 1041;

            //Convert Integar to Binary value
            string binaryValue = Convert.ToString(N, 2);

            //split up the binary value and find the longest segement then assign it to the variable Z
            int Z = binaryValue.Trim('0').Split(new[] { '1' }).Max(x => x.Length);

            Console.WriteLine("The Binary Value of " + N + " is " + binaryValue + ", and the largest binary gap consists of " + Z + " zeroes");

            //pause
            Console.ReadLine();
        }
    }
}
