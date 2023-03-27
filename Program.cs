using HelloWorld;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\moeni\\OneDrive\\Bureaublad\\school\\C#\\HelloWorld\\data.txt";
        StreamReader reader = new StreamReader(filePath);

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }

        reader.Close();

    }
}