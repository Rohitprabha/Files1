using System;
using System.IO;

namespace String_Reader
{
    class String_Reader
    {
        static void Main(string[] args)
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();
            StringReader reader = new StringReader(str.ToString());       // Creating StringReader instance and passing StringWriter  
            while (reader.Peek() > -1)                                    // Reading data 
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
