using System;
using System.IO;


namespace Book_Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Open(@"books.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] book = new string[4];
            Console.WriteLine("File Contents:");
            for (int i = 0; i < book.Length; i++)
            {
                book[i] = sr.ReadLine();
            }
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine(book[i]);
            }
            sr.Close();
        }
    }
}
