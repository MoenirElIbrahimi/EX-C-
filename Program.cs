using HelloWorld;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        string[] guestList = File.ReadAllLines("C:\\Users\\moeni\\OneDrive\\Bureaublad\\school\\C#\\HelloWorld\\guestlist.txt");

        Console.WriteLine("Enter names, an empty line quits.");
        while (true)
        {
            string name = Console.ReadLine();
            if (name == "")
            {
                break;
            }

            if (Array.IndexOf(guestList, name) >= 0)
            {
                Console.WriteLine("The name is on the list.");
            }
            else
            {
                Console.WriteLine("The name is not on the list.");
            }
        }
    }
}