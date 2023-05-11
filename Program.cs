using HelloWorld;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        // Create new timer
        HelloWorld.Timer timer = new HelloWorld.Timer(100);
        // Loop until you cancel the loop.
        // You can cancel with the CTRL + C
        while (true)
        {
            Console.WriteLine(timer);
            timer.Advance();
            // Some error proving, we'll talk about this later.
            // Known as try-catch.
            try
            {
                // Wait 100th of a second. 
                // Sleep(1000) waits one second, if you want to test at slower pace.
                System.Threading.Thread.Sleep(10);
            }
            // Other half of try-catch pair. 
            catch (Exception e)
            {
                Console.WriteLine("Error happened: +" + e);
            }


        }
    }
    
}