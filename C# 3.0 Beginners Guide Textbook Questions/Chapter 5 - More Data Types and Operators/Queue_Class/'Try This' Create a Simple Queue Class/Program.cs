/*
 * Try This Create a Simple Queue Class
 * Try this question from C# 3.0 A Beginners Guide Textbook
 * Beginning location 3454 in eTextbook
 * 24 Aug 2019
 * Created by Kane Argentaro
 * 
 * Desc:
 *      A stack is a list in which elements can be accessed in first-in, last-out (FILO) order only.
 *      eg. stack of dinner plates in the order it is used
 *      A queue is a list in which elements can be accesed in first-in, first-out (FIFO) order only.
 *      eg. line in a bank in which first come first serve
 *      both are data engines
 */
using System;

namespace _Try_This__Create_a_Simple_Queue_Class
{
    class SimpleQueue
    {
        public char[] q; //array that holds the queue
        public int putloc, getloc; //the put and get indicies

        public SimpleQueue(int size)
        {
            q = new char[size + 1]; //allocate memory for a queue
            putloc = getloc = 0;
        }

        //put a charater into the queue
        public void Put(char ch)
        {
            if (putloc == q.Length - 1)
            {
                Console.WriteLine(" -- Queue is full.");
                return;
            }
            putloc++;
            q[putloc] = ch;
        }

        //get character from the queue
        public char Get()
        {
            if (getloc == putloc)
            {
                Console.WriteLine(" -- Queue is empty.");
                return (char)0;
            }
            getloc++;
            return q[getloc];
        }
    }

    class intQueue
    {
        public int[] q; //array that holds the queue
        public int putloc, getloc; //the put and get indicies

        public intQueue(int size)
        {
            q = new int[size + 1]; //allocate memory for a queue
            putloc = getloc = 0;
        }

        //put a charater into the queue
        public void Put(int z)
        {
            if (putloc == q.Length - 1)
            {
                Console.WriteLine(" -- Queue is full.");
                return;
            }
            putloc++;
            q[putloc] = z;
        }

        //get character from the queue
        public int Get()
        {
            if (getloc == putloc)
            {
                Console.WriteLine(" -- Queue is empty.");
                return (int)'b';
            }
            getloc++;
            return q[getloc];
        }
    }
    class Program
    {
        static void charQueue()
        {
            SimpleQueue bigQ = new SimpleQueue(100);
            SimpleQueue smallQ = new SimpleQueue(4);
            char ch;
            int i;

            Console.WriteLine("Using bigQ to store the alphabet.");
            //put some numbers into bigQ
            for (i = 0; i < 26; i++)
            {
                bigQ.Put((char)('A' + i));
            }

            //retrieve and display elements from bigQ
            Console.WriteLine("Contents of bigQ: ");
            for (i = 0; i < 26; i++)
            {
                ch = bigQ.Get();
                if (ch != (char)0)
                {
                    Console.Write(ch);
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Using smallQ to generate errors.");

            //now use smallq to generate some errors
            for (i = 0; i < 5; i++)
            {
                Console.Write("Attempting to store " + (char)('Z' - i));

                smallQ.Put((char)('Z' - i));
                Console.WriteLine();
            }
            Console.WriteLine();

            //More errors on smallQ
            Console.Write("Contents of smallQ: ");
            for (i = 0; i < 5; i++)
            {
                ch = smallQ.Get();
                if (ch != (char)0)
                {
                    Console.Write(ch);
                }
            }

            Console.WriteLine("\n");
        }

        static void intQueue()
        {
            intQueue bigQ = new intQueue(20);
            intQueue smallQ = new intQueue(4);
            int z;
            int i;

            Console.WriteLine("Using bigQ to store the numbers from 1-20.");
            //put some numbers into bigQ
            for (i = 0; i < 20; i++)
            {
                bigQ.Put((int)(i+1));
            }

            //retrieve and display elements from bigQ
            Console.WriteLine("Contents of bigQ: ");
            for (i = 0; i < 20; i++)
            {
                z = bigQ.Get();
                if (z != (int)'b')
                {
                    Console.Write(z + " ");
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Using smallQ to generate errors.");

            //now use smallq to generate some errors
            for (i = 0; i < 5; i++)
            {
                Console.Write("Attempting to store " + (int)(i));

                smallQ.Put((int)(i));
                Console.WriteLine();
            }
            Console.WriteLine();

            //More errors on smallQ
            Console.Write("Contents of smallQ: ");
            for (i = 0; i < 5; i++)
            {
                z = smallQ.Get();
                if (z != (int)'b')
                {
                    Console.Write(z);
                }
            }

            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            charQueue();
            intQueue();
        }
    }
}


