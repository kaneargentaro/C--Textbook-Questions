/* Jaggered Array Demo + Notes
 * Notes from C# 3.0 A Beginners Guide Textbook
 * Beginning location 3363+ in eTextbook
 * 24 Aug 2019
 * Created by Kane Argentaro
 */
using System;

namespace Jaggered_Arrays_Demo
{
    class Program
    {
        static void Main()
        {
            /*
            //Declare Jag array
            //allocates first dimension when its declared, and then declare second manually
            int[][] jaggered = new int[3][];
            jaggered[0] = new int[2];
            jaggered[1] = new int[3];
            jaggered[2] = new int[4];
            //array now looks like this
            //  X   X
            //  X   X   X
            //  X   X   X   X

            jaggered[2][1] = 10;
            */

            //create a program that shows airport shuttle buses run time:
            //runs 10 times on week days, and 2 times on weekends
            int[][] riders = new int[7][];
            riders[0] = new int[10];
            riders[1] = new int[10];
            riders[2] = new int[10];
            riders[3] = new int[10];
            riders[4] = new int[10];
            riders[5] = new int[2];
            riders[6] = new int[2];

            int i, j;

            //fabricate some data
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    riders[i][j] = i + j + 10;
                }
            }
            for (i = 5; i < 7; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    riders[i][j] = i + j + 10;
                }
            }

            Console.WriteLine("Riders per trip during the week:");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine(riders[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Riders per trip on the weekend:");
            for (i = 5; i < 7; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(riders[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
