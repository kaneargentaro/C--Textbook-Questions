using System;

namespace OddOccurencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int result = 0;
            foreach (var x in A)
            {
                result ^= x;
                Console.WriteLine(result + ", " + x);
            }
            Console.WriteLine(result);
        }
    }
}
