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
}
}
