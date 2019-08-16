using System;
/*
 * CHAPTER 4 LEARNING MATERIAL FROM  
 * C# 3.0 : A BEGINNER'S GUIDE
 * 
 * TOPICS INCLUDE CLASSES, METHODS, OBJECTS
 */

namespace ClassesDemo
{
    class ChkNum
    {
        public bool IsEven(int x)
        {
            if ((x % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFactor(int x, int y)
        {
            if ((y % x) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Vehicle
    {
        public int Passengers; //# of passengers
        public int FuelCap; //fuel capacity in gallons
        public int Mpg; //fuel consumption in miles per gallon

        //constructor
        public Vehicle (int p, int f, int m)
        {
            Passengers = p;
            FuelCap = f;
            Mpg = m;
        }

        //deconstructor
        ~ Vehicle()
        {

        }

        //display the range
        public int Range()
        {
            return FuelCap * Mpg;

        }

        //display the fuel needed for a certain number of miles
        public double FuelNeeded(int miles)
        {
            return (double) miles / Mpg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double gallons;
            int dist = 252;

            //create an object called minivan, then assign values to fields in minivan
            Vehicle minivan = new Vehicle(7, 16, 21); 

            //create an object called minivan, then assign values to fields in minivan
            Vehicle sportscar = new Vehicle(2, 14, 12);

            gallons = minivan.FuelNeeded(dist);
            Console.WriteLine("Minivan can carry " + minivan.Passengers + " with a range of " + minivan.Range() + " miles");
            Console.WriteLine("To go " + dist + " miles the minivan needs " + gallons + " gallons of fuel. \n");
            
            gallons = sportscar.FuelNeeded(dist);
            Console.WriteLine("Sportscar can carry " + sportscar.Passengers + " with a range of " + sportscar.Range() + " miles");
            Console.WriteLine("To go " + dist + " miles the sportscar needs " + gallons + " gallons of fuel. \n");

            //check if a number is even or not
            ChkNum e = new ChkNum();

            for (int i = 0; i <= 10; i++)
            {
                if (e.IsEven(i))
                {
                    Console.WriteLine(i + " is even.");
                }
            }
            Console.WriteLine();

            //check if a num is a factor
            if (e.IsFactor(2, 20))
            {
                Console.WriteLine("2 is a factor");
            }
            if (e.IsFactor(2, 20))
            {
                Console.WriteLine("3 is a factor");
            }

        }
    }
}
