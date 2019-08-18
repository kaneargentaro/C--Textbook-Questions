using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;

            for (int x = 1; x < K + 1; x++)
            {
                for (int z = 0; z < A.Length; z++)
                {
                    var temp = A[z];
                    Console.Write(temp + " ");
                    A[z] = A[A.Length - 1];
                    Console.Write(A[z] + " ");
                    A[A.Length - 1] = temp;
                    foreach (int y in A)
                    {
                        Console.Write(y + " ");
                    }
                }
            }
            foreach (int x in A)
            {
                Console.WriteLine(x + " ");
            }
        }
    }
}
