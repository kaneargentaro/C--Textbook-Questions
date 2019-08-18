using System;
using System.Collections.Generic;

namespace Order_Books
{
    
class Program
    {        
        public void DisplayOrder(Order customerOrder)
        {
            
            Console.WriteLine(customerOrder);
            foreach (Order a in customerOrder.Books)
            {
                Console.WriteLine("-- {0}", a);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Book PrescribedTextbook = new Book("Deitel H and Deitel P", "Visual C# 2012: How To Program, Fifth Edition", "Pearson Education", 2013);
            Book RecommenededTextbook = new Book("Schildt H", "C# 4.0: The Complete Reference", "McGraw-Hill", 2010);

            Order Customer = new Order();
            Customer.Add(PrescribedTextbook);

            Order Freddie = new Order("Freddie");
            Freddie.Add(RecommenededTextbook);

            Order Customer1 = new Order(Customer);
            Customer1.Add(RecommenededTextbook);

            Program displayorder = new Program();
            displayorder.DisplayOrder(Customer);
            displayorder.DisplayOrder(Freddie);
            displayorder.DisplayOrder(Customer1);

        }
    }
}
