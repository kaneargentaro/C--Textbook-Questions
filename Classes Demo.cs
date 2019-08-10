using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Demo
{
    class Vehicle
    {
    public int Passengers; // number of passengers
    public int FuelCap; // fuel capacity in gallons
    public int Mpg; // fuel consumption in miles per gallon

    //Constructor
    public Vehicle (int p, int f, int m)
        {
            Passengers = p;
            FuelCap = f;
            Mpg = m;
        }
     ~Vehicle()
        {

        }
    //return the range
    public int Range()
    {
        return FuelCap * Mpg;
    }
    //return fuel needed
    public double FuelNeeded(int miles)
    {
        return (double)miles / Mpg;
    }
        
    class Program
    {
        
        static void Main(string[] args)
        {
            Vehicle minivan = new Vehicle(7, 16, 21);
            double gallons;
            int range;
            int dist = 252;

            range = minivan.Range();

            Console.WriteLine("Minivan can carry {0} passengers with a range of {1}", minivan.Passengers, range);

            gallons = minivan.FuelNeeded(dist);

            Console.WriteLine("To go {0} miles the minivan needs {1} gallons of fuel.", dist, gallons);

        }
    }
}
