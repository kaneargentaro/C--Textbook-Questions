using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            Regex regexphone = new Regex(@"\d\d\-\d\d\d\d\-\d\d\d\d");
            Regex regexcur = new Regex(@"\$\d+\.\d\d");
            Regex regexstreet = new Regex(@"\d+ \w+ \w+");
            Regex regexpass = new Regex(@"((?=.*\d)(?=.*[A-Z])(?=.*\W))");

            Console.Write("Please enter information: ");
            input = Console.ReadLine();

            Match matchphone = regexphone.Match(input);
            Match matchcur = regexcur.Match(input);
            Match matchstreet = regexstreet.Match(input);
            Match matchpass = regexpass.Match(input);

            if (matchphone.Success)
            {
                Console.WriteLine("'{0}' is a phone number!", input);
            }
            else if (matchcur.Success)
            {
                Console.WriteLine("'{0}' is currency!", input);
            }
            else if (matchstreet.Success)
            {
                Console.WriteLine("'{0}' is a street address!", input);
            }
            else if (matchpass.Success)
            {
                Console.WriteLine("'{0}' is a password!", input);
            }
        }
    }
}
