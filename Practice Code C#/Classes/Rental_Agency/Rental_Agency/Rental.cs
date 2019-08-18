using System;


namespace Rental_Agency
{
    class Rental
    {
        public Rental()
            { 
            }

        public void PrintRentals()
        { 
                Console.WriteLine("{0}, {1}");
                Console.WriteLine("\tRental for {0}  - {1:c}");
        }
    }
}
