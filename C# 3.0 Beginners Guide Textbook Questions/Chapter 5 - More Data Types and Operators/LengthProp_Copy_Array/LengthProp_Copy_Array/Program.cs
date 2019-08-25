/*
 * Use lenght property to copy an array demo
 * Notes from C# 3.0 A Beginners Guide Textbook
 * Beginning location 3431+ in eTextbook
 * 24 Aug 2019
 * Created by Kane Argentaro
 */

using System;

namespace LengthProp_Copy_Array
{
    class Program
    {
        static void Main()
        {
            int i;
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            //asign nums1 values from 1-10
            for (i = 0; i < nums1.Length; i++)
            {
                nums1[i] = i;
            }

            //copy nums1 to nums2
            //confirms that target array in large enough to store source array
            if (nums2.Length >= nums1.Length)
            {
                /*for (i = 0; i <nums2.Length; i++)
                {
                    nums2[i] = nums1[i];
                }*/
                //easier way to copy
                Array.Copy(nums1, nums2, nums1.Length);
                   
                foreach (int a in nums2)
                {
                    Console.Write(a + " ");
                }

            }

        }
    }
}
