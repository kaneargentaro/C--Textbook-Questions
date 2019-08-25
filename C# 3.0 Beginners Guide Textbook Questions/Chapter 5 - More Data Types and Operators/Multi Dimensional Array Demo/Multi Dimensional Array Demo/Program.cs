/*
 * Multi Dimensional Array Demo + Notes
 * Notes from C# 3.0 A Beginners Guide Textbook
 * Beginning location 3311+ in eTextbook
 * 24 Aug 2019
 * Created by Kane Argentaro
 */
 using System;

namespace Multi_Dimensional_Array_Demo
{
    class Program
    {
        static void Main()
        {
            int i, j;
            //Create a two dimensional array
            //3 rows, 4 columns, a total of 12 values
            int[,] table = new int[3, 4];
            
            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 4; j++)
                {
                    table[i, j] = (i * 4) + j + i;
                    Console.Write(table[i, j] + "");
                }
                Console.WriteLine();
            }

            //create a multi dimensional array
            int[,,] multitable = new int[4, 10, 3];
            //assign multi dimen array value
            multitable[3, 1, 1] = 10;


            //Squares example
            int[,] sqrs = {
                    {1, 1},
                    {2, 4},
                    {3, 9},
                    {4, 16},
                    {5, 25},
                    };

            Console.WriteLine("SQUARED ARRAY: ");
            //int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(sqrs[i,j] + " " ); ;
                }
                Console.WriteLine();
            }


        }
    }
}
