using System;
using System.Text;
using System.IO;
namespace String_Writer
{
    class String_Writer
    {
        static void Main(string[] args)
        {
            string text = "Hello. This is Line 1 \n Hello.This is Line 2. \n Hello This is Line 3";
            StringBuilder sb = new StringBuilder();                             // Creating StringBuilder instance   
            StringWriter writer = new StringWriter(sb);                         // Passing StringBuilder instance into StringWriter 
            writer.WriteLine(text);                                             // Writing data using StringWriter 
            writer.Flush();  
            writer.Close();                                                     // Closing writer connection  
            StringReader reader = new StringReader(sb.ToString());              // Creating StringReader instance and passing StringBuilder
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
