using System;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 6, 7, 10};

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(array);

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
