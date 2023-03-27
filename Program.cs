using HelloWorld;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int total = 0;
        int sum = 0;
        int number = 0; 
        int counter = 0;
        while (true)
        {
            
            string loop = Console.ReadLine();

            if (loop == "end")
            {
                break;
            }
            int getal = Convert.ToInt32(loop);

                sum = getal * getal * getal;
                Console.WriteLine(sum);

            counter++;
        }

    }
}