/*
 * C# 3.0 : A BEGINNER'S GUIDE
 * EBOOK
 * Location 1418 of 11536
 * "Try This Talk to Mars" Question
 */

using System;

namespace Talk_To_Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            //distance is 34,000,000 miles
            //lightspeed is 186,000 miles per seconds
            double distance = 34000000, lightspeed = 186000, delay, delay_in_min;

            //assign delay (delay in seconds) to the value of distance divided by lightspeed
            delay = distance / lightspeed;
            //show seconds with 3 decimal places
            Console.WriteLine("Time delay when talking to Mars: {0:#.###} seconds.", delay);

            //calculate delay in minutes
            delay_in_min = delay / 60;

            Console.WriteLine("This is {0:#.###} minutes.", delay_in_min);

        }
    }
}
