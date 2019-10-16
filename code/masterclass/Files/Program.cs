using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            // reading text
            string filePath = @"D:\temp\myfile.txt";

            string text = File.ReadAllText(filePath);
            Console.WriteLine("text fille contains : {0}", text);

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("contetn:");

            foreach( string line in lines)
            {
                Console.WriteLine("\t"+ line);
            }
            string[] morelines =
            {
                "first line",
                "second line",
                "third line"
            };

            File.WriteAllLines(filePath, morelines);

            Console.WriteLine("Please enter a file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("enter content");
            string input = Console.ReadLine();

            File.WriteAllText(fileName, input);

            // method with Stream Writer
            string streamwriterfile = @"D:\temp\stremReaderFile.txt";
            using (StreamWriter file = new StreamWriter(streamwriterfile))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(fileName, true))
            {
                file.WriteLine("Additional line");
            }

            Console.ReadKey();
        }
    }
}
