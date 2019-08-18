using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringresult = new List<string>();
            int listnumber = 0;
            string add = "";
            string input = "";

            while (input != "end")
            {
                Console.Write("Please enter a term or type 'end' to exit: ");
                input = Console.ReadLine();

                if (input == "")
                {
                    Console.WriteLine("Invalid, please insert something!");
                }
                else
                {
                    input = input.ToLower();

                    if (listnumber != 0)
                    {
                        foreach (string s in stringresult)
                        {
                            int result = input.CompareTo(s);

                            if (result == 1 || result == -1)
                            {
                                add = "yes";
                            }
                            if (result == 0)
                            {
                                add = "no";
                                break;
                            }
                        }
                    }
                    else if (listnumber == 0)
                    {
                        stringresult.Insert(listnumber, input);
                        listnumber += 1;
                    }

                    if (add == "yes")
                    {
                        stringresult.Insert(listnumber, input);
                        listnumber += 1;
                    }

                    stringresult.Sort();

                    Console.WriteLine("\nList of terms entered:");
                    {
                        foreach (string c in stringresult)
                            Console.WriteLine("{0}", c);
                    }
                    Console.WriteLine("");
                }

            }
        }
    }
}
