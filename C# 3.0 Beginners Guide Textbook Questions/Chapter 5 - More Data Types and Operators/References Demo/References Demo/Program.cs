/*
 * How to reference arrays in C# demo
 * Notes from C# 3.0 A Beginners Guide Textbook
 * Beginning location 3400+ in eTextbook
 * 24 Aug 2019
 * Created by Kane Argentaro
 */

using System;

namespace References_Demo
{
    class Program
    {
        static void Main()
        {
            int i;
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            //give nums1 and nums2 some values
            for (i = 0; i < 10; i++)
            {
                nums1[i] = i;
                nums2[i] = -i;
            }

            Console.WriteLine("Here is nums1: ");
            foreach (int a in nums1)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Here is nums2: ");
            foreach (int a in nums2)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Now nums2 refers to nums1
            nums2 = nums1;

            Console.WriteLine("Here is nums2 after assignment: ");
            foreach (int a in nums2)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //operate on nums1 array through nums2
            nums2[3] = 99;

            Console.WriteLine("Here is nums1 after chance through nums2: ");
            foreach (int a in nums1)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Use length property with arrays
            //not going to do a demo on this since I've used it lots in previous demos
            //arrayname.Length
            //eg. nums1.Length
            //will get the length of the array nums1 (10)
        }
    }
}
