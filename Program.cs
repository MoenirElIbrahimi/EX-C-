using HelloWorld;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        int counter = 0;
        while (true)
        {
            
            string loop = Console.ReadLine();
            if (loop == "end")
            {
                break;
            }


            counter++;


        }
        Console.WriteLine(counter);
    }
}