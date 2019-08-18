using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Book_Input_Output_V2
{
    class Program
    {
        private static Book DeserializeBook()
        {
            Book result;
            FileStream fs = File.Open(@"books.soap", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            result = (Book)sf.Deserialize(fs);
            fs.Close();
            fs.Dispose();
            return result;
        }
        private static void SerializeBook(Book book)
        {
            FileStream fs = File.Open(@"books.soap", FileMode.Create, FileAccess.Write);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, book);
            fs.Close();

        }
        static void Main()
        {
            Book book = DeserializeBook();

            Console.WriteLine("File Contents:");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(book);
            }

            SerializeBook(book);
        }
    }
}
