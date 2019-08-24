/*
 * Sort an array
 * C# 3.0: A Beginner's Guide
 * Chapter 5 'Try This' Question
 * Location 3274 in ebook
 * Kane Argentaro
 * 24 Aug 2019
 */

using System;

namespace Bubble
{
    class Program
    {
        static void Main()
        {
            int[] nums = {99, -10, 100123, 18, -978, 5623, 463, -9, 287, 49 };
            int a, b, t, size;

            //set the number of elements to sort
            size = nums.Length;

            //display original array
            Console.WriteLine("Original array is:");
            foreach(int i in nums)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            //bubble sort
            for (a = 1; a < size; a++)
            {
                for (b = size-1; b>=a; b--)
                {
                    if(nums[b-1] > nums[b])
                    {
                        //exchange out of order elements;
                        t = nums[b - 1];
                        nums[b - 1] = nums[b];
                        nums[b] = t;
                    }
                }
            }
            
            //This array method works the same way, but is one line
            //Array.Sort(nums);

            //displaty sorted array
            Console.WriteLine("Sorted array is:");
            foreach (int i in nums)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
