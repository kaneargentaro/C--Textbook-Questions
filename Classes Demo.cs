using System;

namespace Classes_Demo
{
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
